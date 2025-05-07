using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using CulturAppEscritorio.Models;

namespace CulturAppEscritorio
{
    public partial class FormManageRooms : Form
    {
        Rooms _roomEdit = null;
        public FormManageRooms()
        {
            InitializeComponent();
        }

        private void roundedButtonCreate_Click(object sender, EventArgs e)
        {
            FormCreateRoom formCreateRoom = new FormCreateRoom(0, _roomEdit);
            if (formCreateRoom.ShowDialog() == DialogResult.OK)
            {
                bindingSourceRoom.DataSource = RoomsOrm.SelectGlobal();
                customComboBoxOrder.Texts = "Ordenar por";
            }
        }

        private void roundedButtonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewRooms.SelectedRows.Count > 0)
            {
                _roomEdit = (Rooms)dataGridViewRooms.SelectedRows[0].DataBoundItem;
                FormCreateRoom formCreateRoom = new FormCreateRoom(1, _roomEdit);
                if (formCreateRoom.ShowDialog() == DialogResult.OK)
                {
                    bindingSourceRoom.DataSource = UsersOrm.SelectGlobal();
                    customComboBoxOrder.Texts = "Ordenar por";
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una sala para editarla.");
            }
        }

        private void FormManageRooms_Load(object sender, EventArgs e)
        {
            bindingSourceRoom.DataSource = RoomsOrm.SelectGlobal();
        }

        private void customComboBoxOrder_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedOrder = customComboBoxOrder.SelectedItem?.ToString();

            var orderedRooms = OrderEventsBy(selectedOrder);

            bindingSourceRoom.DataSource = orderedRooms;
        }

        private List<Rooms> OrderEventsBy(string selectedOrder)
        {
            var _rooms = RoomsOrm.SelectGlobal();

            switch (selectedOrder)
            {
                case "Id":
                    return _rooms.OrderBy(room => room.id).ToList();

                case "Nombre":
                    return _rooms.OrderBy(room => room.name).ToList();

                case "Tamaño":
                    return _rooms.OrderBy(room => room.size).ToList();

                default:
                    return _rooms;
            }
        }
    }
}

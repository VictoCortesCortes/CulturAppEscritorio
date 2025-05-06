using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CulturAppEscritorio.Models;

namespace CulturAppEscritorio
{
    public partial class FormManageRooms : Form
    {
        public FormManageRooms()
        {
            InitializeComponent();
        }

        private void roundedButtonCreate_Click(object sender, EventArgs e)
        {

        }

        private void roundedButtonEdit_Click(object sender, EventArgs e)
        {

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

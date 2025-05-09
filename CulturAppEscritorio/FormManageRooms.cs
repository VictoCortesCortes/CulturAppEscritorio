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
        private Rooms _roomEdit = null;
        public FormManageRooms()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Evento que se dispara cuando el usuario hace clic en el botón "Crear sala".
        /// Abre el formulario para crear una nueva sala.
        /// </summary>
        /// <param name="sender">El objeto que generó el evento (el botón de crear sala).</param>
        /// <param name="e">Los argumentos del evento.</param>
        private void roundedButtonCreate_Click(object sender, EventArgs e)
        {
            // Crear una nueva sala.
            FormCreateRoom formCreateRoom = new FormCreateRoom(0, _roomEdit);
            if (formCreateRoom.ShowDialog() == DialogResult.OK)
            {
                // Actualizar la lista de salas después de crear una nueva sala.
                bindingSourceRoom.DataSource = RoomsOrm.SelectGlobal();
                customComboBoxOrder.Texts = "Ordenar por"; // Resetear el filtro de ordenación.
            }
        }

        /// <summary>
        /// Evento que se dispara cuando el usuario hace clic en el botón "Editar sala".
        /// Abre el formulario para editar una sala seleccionada.
        /// </summary>
        /// <param name="sender">El objeto que generó el evento (el botón de editar sala).</param>
        /// <param name="e">Los argumentos del evento.</param>
        private void roundedButtonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewRooms.SelectedRows.Count > 0)
            {
                // Obtener la sala seleccionada para editar.
                _roomEdit = (Rooms)dataGridViewRooms.SelectedRows[0].DataBoundItem;
                FormCreateRoom formCreateRoom = new FormCreateRoom(1, _roomEdit);
                if (formCreateRoom.ShowDialog() == DialogResult.OK)
                {
                    // Actualizar la lista de salas después de editar una sala.
                    bindingSourceRoom.DataSource = RoomsOrm.SelectGlobal();
                    customComboBoxOrder.Texts = "Ordenar por"; // Resetear el filtro de ordenación.
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una sala para editarla.");
            }
        }

        /// <summary>
        /// Evento que se dispara cuando el formulario se carga.
        /// Carga todas las salas disponibles en el formulario.
        /// </summary>
        /// <param name="sender">El objeto que generó el evento (el formulario).</param>
        /// <param name="e">Los argumentos del evento.</param>
        private void FormManageRooms_Load(object sender, EventArgs e)
        {
            bindingSourceRoom.DataSource = RoomsOrm.SelectGlobal();
        }

        /// <summary>
        /// Evento que se dispara cuando el usuario cambia la selección en el combo box para ordenar las salas.
        /// Filtra las salas según el criterio seleccionado (por Id, Nombre, Tamaño).
        /// </summary>
        /// <param name="sender">El objeto que generó el evento (el combo box de ordenar).</param>
        /// <param name="e">Los argumentos del evento.</param>
        private void customComboBoxOrder_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedOrder = customComboBoxOrder.SelectedItem?.ToString();

            // Ordenar las salas según el criterio seleccionado.
            var orderedRooms = OrderEventsBy(selectedOrder);

            bindingSourceRoom.DataSource = orderedRooms; // Actualizar la lista de salas con el orden seleccionado.
        }

        /// <summary>
        /// Método que ordena las salas según el criterio seleccionado.
        /// </summary>
        /// <param name="selectedOrder">Criterio de ordenación (Id, Nombre, Tamaño).</param>
        /// <returns>Lista de salas ordenadas según el criterio seleccionado.</returns>
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
                    return _rooms; // Si no se selecciona un criterio, devolver la lista sin cambios.
            }
        }
    }
}

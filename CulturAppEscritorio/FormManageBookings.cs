using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using CulturAppEscritorio.Models;

namespace CulturAppEscritorio
{
    public partial class FormManageBookings : Form
    {
        private BookingComplete _bookingEdit = null;
        public FormManageBookings()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Evento que se dispara cuando el usuario hace clic en el botón "Crear reserva".
        /// Abre el formulario para crear una nueva reserva.
        /// </summary>
        /// <param name="sender">El objeto que generó el evento (el botón de crear reserva).</param>
        /// <param name="e">Los argumentos del evento.</param>
        private void roundedButtonCreate_Click(object sender, EventArgs e)
        {
            FormCreateBooking formCreateBooking = new FormCreateBooking(0, _bookingEdit);
            if (formCreateBooking.ShowDialog() == DialogResult.OK)
            {
                // Actualizar la lista de reservas después de crear una nueva.
                bindingSourceBooking.DataSource = BookingOrm.SelectGlobal();
                customComboBoxOrder.Texts = "Ordenar por"; // Resetear el filtro de ordenación.
            }
        }

        /// <summary>
        /// Evento que se dispara cuando el usuario hace clic en el botón "Editar reserva".
        /// Abre el formulario para editar una reserva seleccionada.
        /// </summary>
        /// <param name="sender">El objeto que generó el evento (el botón de editar reserva).</param>
        /// <param name="e">Los argumentos del evento.</param>
        private void roundedButtonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewBookings.SelectedRows.Count > 0)
            {
                // Obtener la reserva seleccionada para editar.
                _bookingEdit = (BookingComplete)dataGridViewBookings.SelectedRows[0].DataBoundItem;
                FormCreateBooking formCreateBooking = new FormCreateBooking(1, _bookingEdit);
                if (formCreateBooking.ShowDialog() == DialogResult.OK)
                {
                    // Actualizar la lista de reservas después de editar una existente.
                    bindingSourceBooking.DataSource = BookingOrm.SelectGlobal();
                    customComboBoxOrder.Texts = "Ordenar por"; // Resetear el filtro de ordenación.
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una reserva para editarla.");
            }
        }

        /// <summary>
        /// Evento que se dispara cuando el usuario hace clic en el botón "Eliminar reserva".
        /// Elimina la reserva seleccionada después de una confirmación.
        /// </summary>
        /// <param name="sender">El objeto que generó el evento (el botón de eliminar reserva).</param>
        /// <param name="e">Los argumentos del evento.</param>
        private void roundedButtonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewBookings.SelectedRows.Count > 0)
            {
                // Confirmación de eliminación.
                DialogResult result = MessageBox.Show("¿Estás seguro de que quieres eliminar esta reserva?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    // Obtener la reserva seleccionada y eliminarla.
                    BookingComplete selectedBooking = (BookingComplete)dataGridViewBookings.SelectedRows[0].DataBoundItem;
                    BookingOrm.Delete(selectedBooking); // Eliminar la reserva de la base de datos.
                    bindingSourceBooking.DataSource = BookingOrm.SelectGlobal(); // Actualizar la lista de reservas.
                    customComboBoxOrder.Texts = "Ordenar por"; // Resetear el filtro de ordenación.
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una reserva para eliminarla.");
            }
        }

        /// <summary>
        /// Evento que se dispara cuando el formulario se carga.
        /// Carga todas las reservas disponibles en el formulario.
        /// </summary>
        /// <param name="sender">El objeto que generó el evento (el formulario).</param>
        /// <param name="e">Los argumentos del evento.</param>
        private void FormManageTickets_Load(object sender, EventArgs e)
        {
            bindingSourceBooking.DataSource = BookingOrm.SelectGlobal();
        }

        /// <summary>
        /// Evento que se dispara cuando el usuario cambia la selección en el combo box para ordenar las reservas.
        /// Filtra las reservas según el criterio seleccionado (por usuario, evento, o cantidad).
        /// </summary>
        /// <param name="sender">El objeto que generó el evento (el combo box de ordenar).</param>
        /// <param name="e">Los argumentos del evento.</param>
        private void customComboBoxOrder_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedOrder = customComboBoxOrder.SelectedItem?.ToString();

            // Ordenar las reservas según el criterio seleccionado.
            var orderedBooking = OrderUsersBy(selectedOrder);

            bindingSourceBooking.DataSource = orderedBooking; // Actualizar la lista de reservas con el orden seleccionado.
        }

        /// <summary>
        /// Método que ordena las reservas según el criterio seleccionado.
        /// </summary>
        /// <param name="selectedOrder">Criterio de ordenación (Usuario, Evento, Cantidad).</param>
        /// <returns>Lista de reservas ordenadas según el criterio seleccionado.</returns>
        private List<BookingComplete> OrderUsersBy(string selectedOrder)
        {
            var _booking = BookingOrm.SelectGlobal();

            switch (selectedOrder)
            {
                case "Usuario":
                    return _booking.OrderBy(booking => booking.user_name).ToList();
                case "Evento":
                    return _booking.OrderBy(booking => booking.event_title).ToList();
                case "Cantidad":
                    return _booking.OrderBy(booking => booking.quantity).ToList();
                default:
                    return _booking; // Si no se selecciona un criterio, devolver la lista sin cambios.
            }
        }
    }
}

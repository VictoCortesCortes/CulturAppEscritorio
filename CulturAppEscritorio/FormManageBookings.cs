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
        BookingComplete _bookingEdit = null;
        public FormManageBookings()
        {
            InitializeComponent();
        }

        private void roundedButtonCreate_Click(object sender, EventArgs e)
        {
            FormCreateBooking formCreateBooking = new FormCreateBooking(0, _bookingEdit);
            if (formCreateBooking.ShowDialog() == DialogResult.OK)
            {
                bindingSourceBooking.DataSource = BookingOrm.SelectGlobal();
                customComboBoxOrder.Texts = "Ordenar por";
            }
        }

        private void roundedButtonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewBookings.SelectedRows.Count > 0)
            {
                _bookingEdit = (BookingComplete)dataGridViewBookings.SelectedRows[0].DataBoundItem;
                FormCreateBooking formCreateBooking = new FormCreateBooking(1, _bookingEdit);
                if (formCreateBooking.ShowDialog() == DialogResult.OK)
                {
                    bindingSourceBooking.DataSource = BookingOrm.SelectGlobal();
                    customComboBoxOrder.Texts = "Ordenar por";
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una reserva para editarla.");
            }
        }

        private void roundedButtonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewBookings.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("¿Estás seguro de que quieres eliminar esta reserva?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    BookingComplete selectedBooking = (BookingComplete)dataGridViewBookings.SelectedRows[0].DataBoundItem;
                    BookingOrm.Delete(selectedBooking);
                    bindingSourceBooking.DataSource = BookingOrm.SelectGlobal();
                    customComboBoxOrder.Texts = "Ordenar por";
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una reserva para eliminarla.");
            }
        }

        private void FormManageTickets_Load(object sender, EventArgs e)
        {
            bindingSourceBooking.DataSource = BookingOrm.SelectGlobal();
        }

        private void customComboBoxOrder_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedOrder = customComboBoxOrder.SelectedItem?.ToString();

            var orderedBooking = OrderUsersBy(selectedOrder);

            bindingSourceBooking.DataSource = orderedBooking;
        }

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
                    return _booking;
            }
        }
    }
}

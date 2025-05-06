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
    public partial class FormManageTickets : Form
    {
        public FormManageTickets()
        {
            InitializeComponent();
        }

        private void roundedButtonCreate_Click(object sender, EventArgs e)
        {

        }

        private void roundedButtonEdit_Click(object sender, EventArgs e)
        {

        }

        private void roundedButtonDelete_Click(object sender, EventArgs e)
        {

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

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using CulturAppEscritorio.Models;

namespace CulturAppEscritorio
{
    public partial class FormManageEvents : Form
    {
        public FormManageEvents()
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

        private void FormManageEvents_Load(object sender, EventArgs e)
        {
            bindingSourceEvents.DataSource = EventsOrm.SelectGlobal();
        }

        private void customComboBoxOrder_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedOrder = customComboBoxOrder.SelectedItem?.ToString();

            var orderedEvents = OrderEventsBy(selectedOrder);

            bindingSourceEvents.DataSource = orderedEvents;
        }

        private List<EventsComplete> OrderEventsBy(string selectedOrder)
        {
            var _events = EventsOrm.SelectGlobal();

            switch (selectedOrder)
            {
                case "Id":
                    return _events.OrderBy(events => events.event_id).ToList();

                case "Titulo":
                    return _events.OrderBy(events => events.title).ToList();

                case "Fecha inicio":
                    return _events.OrderBy(events => events.start_date).ToList();

                case "Fecha fin":
                    return _events.OrderBy(events => events.end_date).ToList();

                case "Capacidad":
                    return _events.OrderBy(events => events.capacity).ToList();

                case "Precio":
                    return _events.OrderBy(events => events.price).ToList();

                default:
                    return _events;
            }
        }
    }
}

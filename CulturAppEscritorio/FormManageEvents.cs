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
        EventsComplete _eventEdit = null;
        public FormManageEvents()
        {
            InitializeComponent();
        }
        private void FormManageEvents_Load(object sender, EventArgs e)
        {
            bindingSourceEvents.DataSource = EventsOrm.SelectGlobal();
        }

        private void roundedButtonCreate_Click(object sender, EventArgs e)
        {
            FormCreateEvent formCreateEvent = new FormCreateEvent(0, _eventEdit);
            if (formCreateEvent.ShowDialog() == DialogResult.OK)
            {
                bindingSourceEvents.DataSource = EventsOrm.SelectGlobal();
                customComboBoxOrder.Texts = "Ordenar por";
            }
        }

        private void roundedButtonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewEvents.SelectedRows.Count > 0)
            {
                _eventEdit = (EventsComplete)dataGridViewEvents.SelectedRows[0].DataBoundItem;
                FormCreateEvent formCreateEvent = new FormCreateEvent(1, _eventEdit);
                if (formCreateEvent.ShowDialog() == DialogResult.OK)
                {
                    bindingSourceEvents.DataSource = EventsOrm.SelectGlobal();
                    customComboBoxOrder.Texts = "Ordenar por";
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un evento para editarlo.");
            }
        }

        private void roundedButtonDelete_Click(object sender, EventArgs e)
        {
            
            if (dataGridViewEvents.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("¿Estás seguro de que quieres eliminar este evento?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                
                if (result == DialogResult.Yes)
                {
                    EventsComplete selectedEvent = (EventsComplete)dataGridViewEvents.SelectedRows[0].DataBoundItem;
                    EventsOrm.Delete(selectedEvent);
                    bindingSourceEvents.DataSource = EventsOrm.SelectGlobal();
                    customComboBoxOrder.Texts = "Ordenar por";
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un usuario para eliminarlo.");
            }
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

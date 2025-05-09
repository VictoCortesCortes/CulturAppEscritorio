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
        private EventsComplete _eventEdit = null;
        public FormManageEvents()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Evento que se dispara cuando el formulario se carga.
        /// Carga todos los eventos disponibles en el formulario.
        /// </summary>
        /// <param name="sender">El objeto que generó el evento (el formulario).</param>
        /// <param name="e">Los argumentos del evento.</param>
        private void FormManageEvents_Load(object sender, EventArgs e)
        {
            bindingSourceEvents.DataSource = EventsOrm.SelectGlobal();
        }

        /// <summary>
        /// Evento que se dispara cuando el usuario hace clic en el botón "Crear evento".
        /// Abre el formulario para crear un nuevo evento.
        /// </summary>
        /// <param name="sender">El objeto que generó el evento (el botón de crear evento).</param>
        /// <param name="e">Los argumentos del evento.</param>
        private void roundedButtonCreate_Click(object sender, EventArgs e)
        {
            // Crear un nuevo evento.
            FormCreateEvent formCreateEvent = new FormCreateEvent(0, _eventEdit);
            if (formCreateEvent.ShowDialog() == DialogResult.OK)
            {
                // Actualizar la lista de eventos después de crear un nuevo evento.
                bindingSourceEvents.DataSource = EventsOrm.SelectGlobal();
                customComboBoxOrder.Texts = "Ordenar por"; // Resetear el filtro de ordenación.
            }
        }

        /// <summary>
        /// Evento que se dispara cuando el usuario hace clic en el botón "Editar evento".
        /// Abre el formulario para editar un evento seleccionado.
        /// </summary>
        /// <param name="sender">El objeto que generó el evento (el botón de editar evento).</param>
        /// <param name="e">Los argumentos del evento.</param>
        private void roundedButtonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewEvents.SelectedRows.Count > 0)
            {
                // Obtener el evento seleccionado para editar.
                _eventEdit = (EventsComplete)dataGridViewEvents.SelectedRows[0].DataBoundItem;
                FormCreateEvent formCreateEvent = new FormCreateEvent(1, _eventEdit);
                if (formCreateEvent.ShowDialog() == DialogResult.OK)
                {
                    // Actualizar la lista de eventos después de editar un evento.
                    bindingSourceEvents.DataSource = EventsOrm.SelectGlobal();
                    customComboBoxOrder.Texts = "Ordenar por"; // Resetear el filtro de ordenación.
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un evento para editarlo.");
            }
        }

        /// <summary>
        /// Evento que se dispara cuando el usuario hace clic en el botón "Eliminar evento".
        /// Elimina el evento seleccionado después de una confirmación.
        /// </summary>
        /// <param name="sender">El objeto que generó el evento (el botón de eliminar evento).</param>
        /// <param name="e">Los argumentos del evento.</param>
        private void roundedButtonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewEvents.SelectedRows.Count > 0)
            {
                // Confirmación de eliminación.
                DialogResult result = MessageBox.Show("¿Estás seguro de que quieres eliminar este evento?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    // Obtener el evento seleccionado y eliminarlo.
                    EventsComplete selectedEvent = (EventsComplete)dataGridViewEvents.SelectedRows[0].DataBoundItem;
                    EventsOrm.Delete(selectedEvent); // Eliminar el evento de la base de datos.
                    bindingSourceEvents.DataSource = EventsOrm.SelectGlobal(); // Actualizar la lista de eventos.
                    customComboBoxOrder.Texts = "Ordenar por"; // Resetear el filtro de ordenación.
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un evento para eliminarlo.");
            }
        }

        /// <summary>
        /// Evento que se dispara cuando el usuario cambia la selección en el combo box para ordenar los eventos.
        /// Filtra los eventos según el criterio seleccionado (por Id, Título, Fecha, etc.).
        /// </summary>
        /// <param name="sender">El objeto que generó el evento (el combo box de ordenar).</param>
        /// <param name="e">Los argumentos del evento.</param>
        private void customComboBoxOrder_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedOrder = customComboBoxOrder.SelectedItem?.ToString();

            // Ordenar los eventos según el criterio seleccionado.
            var orderedEvents = OrderEventsBy(selectedOrder);

            bindingSourceEvents.DataSource = orderedEvents; // Actualizar la lista de eventos con el orden seleccionado.
        }

        /// <summary>
        /// Método que ordena los eventos según el criterio seleccionado.
        /// </summary>
        /// <param name="selectedOrder">Criterio de ordenación (Id, Título, Fecha inicio, Fecha fin, Capacidad, Precio).</param>
        /// <returns>Lista de eventos ordenados según el criterio seleccionado.</returns>
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
                    return _events; // Si no se selecciona un criterio, devolver la lista sin cambios.
            }
        }
    }
}

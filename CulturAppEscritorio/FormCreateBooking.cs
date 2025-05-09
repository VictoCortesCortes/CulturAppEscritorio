using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CulturAppEscritorio.Models;

namespace CulturAppEscritorio
{
    public partial class FormCreateBooking : Form
    {
        private int _actionMade;
        private BookingComplete _bookingEdit;
        public FormCreateBooking(int action, BookingComplete booking)
        {
            InitializeComponent();
            _actionMade = action;
            _bookingEdit = booking;
            bindingSourceEvent.DataSource = EventsOrm.SelectGlobal(); // Cargar los eventos disponibles.
            bindingSourceUsers.DataSource = UsersOrm.SelectGlobal(); // Cargar los usuarios disponibles.
        }

        /// <summary>
        /// Evento que se dispara cuando se carga el formulario.
        /// Si se está editando una reserva, llena los campos con la información de la reserva seleccionada.
        /// </summary>
        /// <param name="sender">El objeto que generó el evento (el formulario).</param>
        /// <param name="e">Los argumentos del evento.</param>
        private void FormCreateBooking_Load(object sender, EventArgs e)
        {
            if (_actionMade == 1)
            {
                labelTitle.Text = "Editar reserva";
                roundedTextBoxQuantity.Texts = _bookingEdit.quantity.ToString();
                customComboBoxUser.Texts = _bookingEdit.user_name;
                customComboBoxEvent.Texts = _bookingEdit.event_title;
                customComboBoxEvent.Enabled = false;
                customComboBoxUser.Enabled = false;
            }
        }

        /// <summary>
        /// Evento que se dispara cuando el usuario hace clic en el botón de guardar.
        /// Valida los datos y crea o actualiza una reserva dependiendo de la acción.
        /// </summary>
        /// <param name="sender">El objeto que generó el evento (el botón de guardar).</param>
        /// <param name="e">Los argumentos del evento.</param>
        private void roundedButtonSave_Click(object sender, EventArgs e)
        {
            bool isQuantityValid = int.TryParse(roundedTextBoxQuantity.Texts.Trim(), out int quantity);
            Users users = (Users)customComboBoxUser.SelectedItem;
            EventsComplete events = (EventsComplete)customComboBoxEvent.SelectedItem;

            if (_actionMade == 0) // Crear nueva reserva
            {
                if (users == null || events == null || isQuantityValid == false || quantity <= 0)
                {
                    MessageBox.Show("Por favor, completa todos los campos correctamente.");
                }
                else
                {
                    int totalBooking = 0;
                    List<BookingComplete> bookingEvent = BookingOrm.SelectByEvent(events.event_id);
                    foreach (BookingComplete booking in bookingEvent)
                    {
                        totalBooking += booking.quantity;
                    }

                    // Verificar si hay suficiente capacidad para la cantidad solicitada.
                    if (totalBooking + quantity > events.capacity)
                    {
                        MessageBox.Show("El evento seleccionado no tiene suficientes entradas disponibles.");
                    }
                    else
                    {
                        BookingComplete bookingExists = BookingOrm.SelectByUserEvent(users.id, events.event_id);
                        if (bookingExists != null)
                        {
                            MessageBox.Show("Ya existe una reserva para este evento de este usuario.");
                        }
                        else
                        {
                            Booking booking = new Booking
                            {
                                user_id = users.id,
                                event_id = events.event_id,
                                quantity = quantity,
                                active = true
                            };
                            BookingOrm.Insert(booking); // Insertar nueva reserva en la base de datos.
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                    }
                }
            }
            else // Editar reserva existente
            {
                int totalBooking2 = 0;
                List<BookingComplete> bookingEvent = BookingOrm.SelectByEvent(events.event_id);
                foreach (BookingComplete booking in bookingEvent)
                {
                    totalBooking2 += booking.quantity;
                }
                totalBooking2 -= _bookingEdit.quantity; // Restar la cantidad de la reserva original.

                // Verificar si hay suficiente capacidad después de la edición.
                if (totalBooking2 + quantity > EventsOrm.SelectById(_bookingEdit.event_id).capacity)
                {
                    MessageBox.Show("El evento seleccionado no tiene suficientes entradas disponibles.");
                }
                else
                {
                    if (isQuantityValid == false || quantity <= 0)
                    {
                        MessageBox.Show("Por favor, completa todos los campos correctamente.");
                    }
                    else
                    {
                        _bookingEdit.quantity = quantity;
                        BookingOrm.Update(_bookingEdit); // Actualizar la reserva en la base de datos.
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
            }
        }

        /// <summary>
        /// Evento que se dispara cuando el usuario hace clic en el botón de cancelar.
        /// Cierra el formulario sin realizar cambios.
        /// </summary>
        /// <param name="sender">El objeto que generó el evento (el botón de cancelar).</param>
        /// <param name="e">Los argumentos del evento.</param>
        private void roundedButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close(); // Cerrar el formulario.
        }
    }
}

using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CulturAppEscritorio.Models;

namespace CulturAppEscritorio
{
    public partial class FormCreateBooking : Form
    {
        int _actionMade;
        BookingComplete _bookingEdit;
        public FormCreateBooking(int action, BookingComplete booking)
        {
            InitializeComponent();
            _actionMade = action;
            _bookingEdit = booking;
            bindingSourceEvent.DataSource = EventsOrm.SelectGlobal();
            bindingSourceUsers.DataSource = UsersOrm.SelectGlobal();
        }

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

        private void roundedButtonSave_Click(object sender, EventArgs e)
        {
            
            bool isQuantityValid = int.TryParse(roundedTextBoxQuantity.Texts.Trim(), out int quantity);
            Users users = (Users)customComboBoxUser.SelectedItem;
            EventsComplete events = (EventsComplete)customComboBoxEvent.SelectedItem;

            if (_actionMade == 0)
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
                            BookingOrm.Insert(booking);
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                    }
                }
            }
            else
            {
                int totalBooking2 = 0;
                List<BookingComplete> bookingEvent = BookingOrm.SelectByEvent(events.event_id);
                foreach (BookingComplete booking in bookingEvent)
                {
                    totalBooking2 += booking.quantity;
                }
                totalBooking2 -= _bookingEdit.quantity;

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
                        BookingOrm.Update(_bookingEdit);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
                
            }
        }

        private void roundedButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

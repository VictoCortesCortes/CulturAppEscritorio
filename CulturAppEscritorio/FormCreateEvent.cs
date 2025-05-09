using System;
using System.Windows.Forms;
using CulturAppEscritorio.Models;

namespace CulturAppEscritorio
{
    public partial class FormCreateEvent : Form
    {
        int _actionMade;
        EventsComplete _eventEdit;
        public FormCreateEvent(int actionMade, EventsComplete eventEdit)
        {
            InitializeComponent();
            bindingSourceRoom.DataSource = RoomsOrm.SelectGlobal();
            bindingSourceType.DataSource = TypeEventOrm.SelectGlobal();
            _actionMade = actionMade;
            _eventEdit = eventEdit;
        }
        private void FormCreateEvent_Load(object sender, System.EventArgs e)
        {
            if (_actionMade == 1)
            {
                labelTitle.Text = "Editar evento";
                roundedTextBoxTitle.Texts = _eventEdit.title;
                roundedTextBoxDescription.Texts = _eventEdit.description;
                roundedTextBoxPrice.Texts = _eventEdit.price.ToString();
                roundedTextBoxCapacity.Texts = _eventEdit.capacity.ToString();
                dateTimePickerStart.Value = _eventEdit.start_date;
                dateTimePickerEnd.Value = _eventEdit.end_date;
                customComboBoxRoom.SelectedItem = RoomsOrm.SelectByName(_eventEdit.room);
                customComboBoxType.SelectedItem = TypeEventOrm.SelectByName(_eventEdit.type);
                customComboBoxRoom.Texts = _eventEdit.room;
                customComboBoxType.Texts = _eventEdit.type;
            }
        }

        private void roundedTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
            {
                return;
            }

            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void roundedTextBoxCapacity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
            {
                return;
            }

            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void roundedButtonSave_Click(object sender, System.EventArgs e)
        {
            bool isPriceValid = int.TryParse(roundedTextBoxPrice.Texts.Trim(), out int price);
            bool isCapacityValid = int.TryParse(roundedTextBoxCapacity.Texts.Trim(), out int capacity);
            Rooms room = (Rooms)customComboBoxRoom.SelectedItem;
            Type_event type = (Type_event)customComboBoxType.SelectedItem;
            string title = roundedTextBoxTitle.Texts.Trim();
            string description = roundedTextBoxDescription.Texts.Trim();
            DateTime startDate = dateTimePickerStart.Value;
            DateTime endDate = dateTimePickerEnd.Value;

            if (startDate >= endDate)
            {
                MessageBox.Show("La fecha de inicio debe ser anterior a la fecha de fin.");
            }
            else
            {
                if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(description) || room == null || type == null || isPriceValid == false || isCapacityValid == false)
                {
                    MessageBox.Show("Por favor, completa todos los campos correctamente.");
                }
                else
                {
                    if (_actionMade == 0)
                    {
                        Events eventExists = EventsOrm.SelectByName(title);
                        if (eventExists != null)
                        {
                            MessageBox.Show("Ya existe un evento con ese nombre.");
                        }
                        else
                        {
                            Events events = new Events
                            {
                                title = title,
                                description = description,
                                start_datetime = startDate,
                                end_datetime = endDate,
                                capacity = capacity,
                                price = price,
                                type_id = type.id,
                                room_id = room.id,
                                active = true
                            };
                            EventsOrm.Insert(events);
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                    }
                    else
                    {
                        Events eventExists = EventsOrm.SelectByName(title);
                        if (eventExists != null && eventExists.id != _eventEdit.event_id)
                        {
                            MessageBox.Show("Ya existe un evento con ese nombre.");
                        }
                        else
                        {
                            _eventEdit.title = title;
                            _eventEdit.description = description;
                            _eventEdit.start_date = startDate;
                            _eventEdit.end_date = endDate;
                            _eventEdit.capacity = capacity;
                            _eventEdit.price = price;
                            _eventEdit.type_id = type.id;
                            _eventEdit.room_id = room.id;
                            EventsOrm.Update(_eventEdit);
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                    }
                }
            }
        }

        private void roundedButtonCancel_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}

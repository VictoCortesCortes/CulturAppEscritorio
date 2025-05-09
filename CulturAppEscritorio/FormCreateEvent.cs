using System;
using System.Windows.Forms;
using CulturAppEscritorio.Models;

namespace CulturAppEscritorio
{
    public partial class FormCreateEvent : Form
    {
        private int _actionMade;
        private EventsComplete _eventEdit;
        public FormCreateEvent(int actionMade, EventsComplete eventEdit)
        {
            InitializeComponent();
            bindingSourceRoom.DataSource = RoomsOrm.SelectGlobal(); // Cargar las habitaciones disponibles.
            bindingSourceType.DataSource = TypeEventOrm.SelectGlobal(); // Cargar los tipos de evento disponibles.
            _actionMade = actionMade;
            _eventEdit = eventEdit;
        }

        /// <summary>
        /// Evento que se dispara cuando se carga el formulario.
        /// Si se está editando un evento, llena los campos con la información del evento seleccionado.
        /// </summary>
        /// <param name="sender">El objeto que generó el evento (el formulario).</param>
        /// <param name="e">Los argumentos del evento.</param>
        private void FormCreateEvent_Load(object sender, EventArgs e)
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

        /// <summary>
        /// Evento que se dispara cuando el usuario ingresa un carácter en el campo de texto.
        /// Permite solo la entrada de números en los campos relacionados con la capacidad o el precio.
        /// </summary>
        /// <param name="sender">El objeto que generó el evento (el campo de texto).</param>
        /// <param name="e">Los argumentos del evento.</param>
        private void roundedTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
            {
                return; // Permitir controles como Backspace.
            }

            if (!char.IsDigit(e.KeyChar)) // Solo permitir dígitos.
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Evento que se dispara cuando el usuario ingresa un carácter en el campo de texto de capacidad.
        /// Permite solo la entrada de números en el campo de capacidad.
        /// </summary>
        /// <param name="sender">El objeto que generó el evento (el campo de texto de capacidad).</param>
        /// <param name="e">Los argumentos del evento.</param>
        private void roundedTextBoxCapacity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
            {
                return; // Permitir controles como Backspace.
            }

            if (!char.IsDigit(e.KeyChar)) // Solo permitir dígitos.
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Evento que se dispara cuando el usuario hace clic en el botón de guardar.
        /// Valida los datos y crea o actualiza un evento dependiendo de la acción.
        /// </summary>
        /// <param name="sender">El objeto que generó el evento (el botón de guardar).</param>
        /// <param name="e">Los argumentos del evento.</param>
        private void roundedButtonSave_Click(object sender, EventArgs e)
        {
            bool isPriceValid = int.TryParse(roundedTextBoxPrice.Texts.Trim(), out int price);
            bool isCapacityValid = int.TryParse(roundedTextBoxCapacity.Texts.Trim(), out int capacity);
            Rooms room = (Rooms)customComboBoxRoom.SelectedItem;
            Type_event type = (Type_event)customComboBoxType.SelectedItem;
            string title = roundedTextBoxTitle.Texts.Trim();
            string description = roundedTextBoxDescription.Texts.Trim();
            DateTime startDate = dateTimePickerStart.Value;
            DateTime endDate = dateTimePickerEnd.Value;

            if (startDate >= endDate) // Verificar que la fecha de inicio sea antes de la fecha de fin.
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
                    if (_actionMade == 0) // Crear nuevo evento
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
                            EventsOrm.Insert(events); // Insertar el nuevo evento en la base de datos.
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                    }
                    else // Editar evento existente
                    {
                        Events eventExists = EventsOrm.SelectByName(title);
                        if (eventExists != null && eventExists.id != _eventEdit.event_id) // Verificar que no exista un evento con el mismo nombre.
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
                            EventsOrm.Update(_eventEdit); // Actualizar el evento en la base de datos.
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
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

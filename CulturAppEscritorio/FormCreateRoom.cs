using System;
using System.Windows.Forms;
using CulturAppEscritorio.Models;

namespace CulturAppEscritorio
{
    public partial class FormCreateRoom : Form
    {
        private int actionMade;
        private Rooms _roomEdit;
        public FormCreateRoom(int action, Rooms room)
        {
            InitializeComponent();
            actionMade = action;
            _roomEdit = room;
        }

        /// <summary>
        /// Evento que se dispara cuando se carga el formulario.
        /// Si se está editando una sala, llena los campos con la información de la sala seleccionada.
        /// </summary>
        /// <param name="sender">El objeto que generó el evento (el formulario).</param>
        /// <param name="e">Los argumentos del evento.</param>
        private void FormCreateRoom_Load(object sender, EventArgs e)
        {
            if (actionMade == 1) // Editar sala
            {
                labelTitle.Text = "Editar sala";
                roundedTextBoxName.Texts = _roomEdit.name;
                roundedTextBoxDescription.Texts = _roomEdit.description;
                roundedTextBoxSize.Texts = _roomEdit.size.ToString();
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
            this.Close();
        }

        /// <summary>
        /// Evento que se dispara cuando el usuario hace clic en el botón de guardar.
        /// Valida los datos y crea o actualiza una sala dependiendo de la acción.
        /// </summary>
        /// <param name="sender">El objeto que generó el evento (el botón de guardar).</param>
        /// <param name="e">Los argumentos del evento.</param>
        private void roundedButtonSave_Click(object sender, EventArgs e)
        {
            string name = roundedTextBoxName.Texts.Trim();
            string description = roundedTextBoxDescription.Texts.Trim();
            bool isSizeValid = float.TryParse(roundedTextBoxSize.Texts.Trim(), out float size);

            // Validación de campos obligatorios y tamaño de la sala.
            if (string.IsNullOrEmpty(name) ||
                    string.IsNullOrEmpty(description) ||
                    isSizeValid == false ||
                    size <= 0)
            {
                MessageBox.Show("Por favor, completa todos los campos para crear la sala.");
            }
            else
            {
                Rooms _roomExists = RoomsOrm.SelectByName(name); // Verificar si ya existe una sala con el mismo nombre.

                if (actionMade == 0) // Crear nueva sala
                {
                    if (_roomExists != null) // Verificar si la sala ya existe.
                    {
                        MessageBox.Show("Ya existe una sala con ese nombre.");
                    }
                    else
                    {
                        Rooms _room = new Rooms
                        {
                            name = name,
                            description = description,
                            size = size
                        };
                        RoomsOrm.Insert(_room); // Insertar la nueva sala en la base de datos.
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
                else // Editar sala existente
                {
                    // Verificar si no existe una sala con el mismo nombre o si es la misma sala que estamos editando.
                    if (_roomExists == null || _roomExists.id == _roomEdit.id)
                    {
                        _roomEdit.name = name;
                        _roomEdit.description = description;
                        _roomEdit.size = size;
                        RoomsOrm.Update(_roomEdit); // Actualizar la sala en la base de datos.
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Ya existe una sala con ese nombre.");
                    }
                }
            }
        }
    }
}

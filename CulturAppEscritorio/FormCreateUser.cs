using System;
using System.Windows.Forms;
using CulturAppEscritorio.Models;
using GigFinder.Entities;

namespace CulturAppEscritorio
{
    public partial class FormCreateUser : Form
    {
        private int actionMade;
        private Users _userEdit;
        public FormCreateUser(int action, Users user)
        {
            InitializeComponent();
            actionMade = action;
            _userEdit = user;
        }

        /// <summary>
        /// Evento que se dispara cuando se carga el formulario.
        /// Si se está editando un usuario, llena los campos con la información del usuario seleccionado.
        /// </summary>
        /// <param name="sender">El objeto que generó el evento (el formulario).</param>
        /// <param name="e">Los argumentos del evento.</param>
        private void FormCreateUser_Load(object sender, EventArgs e)
        {
            if (actionMade == 1)
            {
                labelTitle.Text = "Editar Usuario";
                roundedTextBoxName.Texts = _userEdit.name;
                roundedTextBoxSurname.Texts = _userEdit.surname;
                roundedTextBoxMail.Texts = _userEdit.email;
                customComboBoxType.SelectedItem = _userEdit.type;
                customComboBoxType.Texts = _userEdit.type.ToString();
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

        /// <summary>
        /// Evento que se dispara cuando el usuario hace clic en el botón de guardar.
        /// Valida los datos y crea o actualiza un usuario dependiendo de la acción.
        /// </summary>
        /// <param name="sender">El objeto que generó el evento (el botón de guardar).</param>
        /// <param name="e">Los argumentos del evento.</param>
        private void roundedButtonSave_Click(object sender, EventArgs e)
        {
            string name = roundedTextBoxName.Texts.Trim();
            string surname = roundedTextBoxSurname.Texts.Trim();
            string email = roundedTextBoxMail.Texts.Trim();
            string pass = roundedTextBoxPass.Texts.Trim();
            string confirmPass = roundedTextBoxConfirmPass.Texts.Trim();
            string type = customComboBoxType.SelectedItem?.ToString();

            // Acción para crear un nuevo usuario
            if (actionMade == 0)
            {
                if (string.IsNullOrEmpty(name) ||
                    string.IsNullOrEmpty(surname) ||
                    string.IsNullOrEmpty(email) ||
                    string.IsNullOrEmpty(pass) ||
                    string.IsNullOrEmpty(confirmPass) ||
                    string.IsNullOrEmpty(type))
                {
                    MessageBox.Show("Por favor, completa todos los campos para crear el usuario.");
                }
                else
                {
                    Users userMail = UsersOrm.SelectWithMail(email); // Verificar si el email ya existe.
                    if (userMail == null) // Si no existe un usuario con ese email
                    {
                        if (pass.Equals(confirmPass)) // Verificar si las contraseñas coinciden
                        {
                            Users _user = new Users
                            {
                                name = name,
                                surname = surname,
                                email = email,
                                password = Encrypt.EncryptSHA256(pass), // Encriptar la contraseña
                                type = type,
                                active = true
                            };
                            UsersOrm.Insert(_user); // Insertar el nuevo usuario
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Las contraseñas no coinciden.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ya existe un usuario con ese email.");
                    }
                }
            }
            else // Acción para editar un usuario existente
            {
                if (string.IsNullOrEmpty(name) ||
                    string.IsNullOrEmpty(surname) ||
                    string.IsNullOrEmpty(email) ||
                    string.IsNullOrEmpty(type))
                {
                    MessageBox.Show("Por favor, completa todos los campos para editar el usuario.");
                }
                else
                {
                    Users userToEdit = UsersOrm.SelectWithMail(email); // Verificar si ya existe un usuario con ese email.
                    if (userToEdit != null && userToEdit.id != _userEdit.id)
                    {
                        MessageBox.Show("Ya existe un usuario con ese email.");
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(pass) && string.IsNullOrEmpty(confirmPass)) // Si no se desea cambiar la contraseña
                        {
                            _userEdit.name = name;
                            _userEdit.surname = surname;
                            _userEdit.email = email;
                            _userEdit.type = type;
                            UsersOrm.UpdateWithoutPass(_userEdit); // Actualizar el usuario sin cambiar la contraseña
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        else
                        {
                            if (pass.Equals(confirmPass)) // Verificar si las contraseñas coinciden
                            {
                                _userEdit.name = name;
                                _userEdit.surname = surname;
                                _userEdit.email = email;
                                _userEdit.password = Encrypt.EncryptSHA256(pass); // Encriptar la nueva contraseña
                                _userEdit.type = type;
                                UsersOrm.Update(_userEdit); // Actualizar el usuario
                                this.DialogResult = DialogResult.OK;
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Las contraseñas no coinciden.");
                            }
                        }
                    }
                }
            }
        }
    }
}

using System;
using System.Windows.Forms;
using CulturAppEscritorio.Models;
using GigFinder.Entities;

namespace CulturAppEscritorio
{
    public partial class FormCreateUser : Form
    {
        int actionMade;
        Users _userEdit;
        public FormCreateUser(int action, Users user)
        {
            InitializeComponent();
            actionMade = action;
            _userEdit = user;
        }

        private void roundedButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void roundedButtonSave_Click(object sender, EventArgs e)
        {
            string name = roundedTextBoxName.Texts.Trim();
            string surname = roundedTextBoxSurname.Texts.Trim();
            string email = roundedTextBoxMail.Texts.Trim();
            string pass = roundedTextBoxPass.Texts.Trim();
            string confirmPass = roundedTextBoxConfirmPass.Texts.Trim();
            string type = customComboBoxType.SelectedItem?.ToString();

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
                    Users userMail = UsersOrm.SelectWithMail(email);
                    if (userMail == null)
                    {
                        if (pass.Equals(confirmPass))
                        {
                            Users _user = new Users
                            {
                                name = name,
                                surname = surname,
                                email = email,
                                password = Encrypt.EncryptSHA256(pass),
                                type = type,
                                active = true
                            };
                            UsersOrm.Insert(_user);
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
            } else
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
                    Users userToEdit = UsersOrm.SelectWithMail(email);
                    if (userToEdit != null && userToEdit.id != _userEdit.id)
                    {
                        MessageBox.Show("Ya existe un usuario con ese email.");
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(pass) && string.IsNullOrEmpty(confirmPass))
                        {
                            _userEdit.name = name;
                            _userEdit.surname = surname;
                            _userEdit.email = email;
                            _userEdit.type = type;

                            UsersOrm.UpdateWithoutPass(_userEdit);
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        else
                        {
                          if (pass.Equals(confirmPass))
                            {
                                _userEdit.name = name;
                                _userEdit.surname = surname;
                                _userEdit.email = email;
                                _userEdit.password = Encrypt.EncryptSHA256(pass);
                                _userEdit.type = type;
                                UsersOrm.Update(_userEdit);
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
    }
}

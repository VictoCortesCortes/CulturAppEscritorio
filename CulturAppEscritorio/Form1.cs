using System;
using System.Windows.Forms;
using CulturAppEscritorio.Models;
using GigFinder.Entities;

namespace CulturAppEscritorio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Maneja el evento de clic en el botón de login.
        /// Valida las credenciales de un usuario (correo y contraseña) y permite acceder a la aplicación si son correctas.
        /// </summary>
        /// <param name="sender">El objeto que generó el evento (el botón de login).</param>
        /// <param name="e">Los argumentos del evento.</param>
        private void roundedButtonLogin_Click(object sender, EventArgs e)
        {
            // Se obtienen los valores de correo y contraseña de los campos de texto.
            string mail = roundedTextBoxMail.Texts.Trim();
            string pass = Encrypt.EncryptSHA256(roundedTextBoxPass.Texts.Trim());

            // Se realiza la consulta para verificar el usuario y la contraseña en la base de datos.
            Users _userLogin = UsersOrm.SelectLogin(mail, pass);

            if (_userLogin != null)
            {
                // Si el tipo de usuario es "basic", se le informa que no tiene permisos para entrar.
                if (_userLogin.type == "basic")
                {
                    roundedTextBoxPass.Texts = "";
                    roundedTextBoxMail.Texts = "";
                    MessageBox.Show("Este usuario no tiene permisos para entrar en esta aplicación.");
                }
                else
                {
                    // Si el usuario es válido, se oculta el formulario de login y se muestra el formulario de menú.
                    this.Hide();
                    roundedTextBoxPass.Texts = "";
                    roundedTextBoxMail.Texts = "";

                    // Se crea el formulario de menú pasando el usuario logueado.
                    FormMenu formMenu = new FormMenu(_userLogin);

                    // Se define qué hacer cuando se cierre el formulario de menú: mostrar nuevamente el formulario de login.
                    formMenu.FormClosed += (s, args) =>
                    {
                        this.Show();
                    };

                    formMenu.Show();
                }
            }
            else
            {
                // Si las credenciales son incorrectas, se borra la contraseña y se muestra un mensaje de error.
                roundedTextBoxPass.Texts = "";
                MessageBox.Show("email y/o contraseña incorrectos.");
            }
        }
    }
}

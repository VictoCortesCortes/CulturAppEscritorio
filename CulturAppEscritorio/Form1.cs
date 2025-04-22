using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CulturAppEscritorio.Models;

namespace CulturAppEscritorio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void roundedButtonLogin_Click(object sender, EventArgs e)
        {
            string mail = roundedTextBoxMail.Texts.Trim();
            string pass = roundedTextBoxPass.Texts.Trim();

            // Encrypt.EncryptSHA256(roundedTextBoxPass.Texts.Trim());

            Users _userLogin = UsersOrm.Selectlogin(mail, pass);
            if (_userLogin != null)
            {
                if (_userLogin.type == "basic")
                {
                    roundedTextBoxPass.Texts = "";
                    roundedTextBoxMail.Texts = "";
                    MessageBox.Show("Este usuario no tiene permisos para entrar en esta aplicación.");
                } 
                else
                {
                    this.Hide();
                    roundedTextBoxPass.Texts = "";
                    roundedTextBoxMail.Texts = "";
                    FormMenu formMenu = new FormMenu(_userLogin);
                    formMenu.FormClosed += (s, args) =>
                    {
                        this.Show();
                    };

                    formMenu.Show();
                }  
            }
            else
            {
                roundedTextBoxPass.Texts = "";
                MessageBox.Show("email y/o contraseña incorrectos.");
            }
        }
    }
}

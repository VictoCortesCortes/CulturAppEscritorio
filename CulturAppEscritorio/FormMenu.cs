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
    public partial class FormMenu : Form
    {
        Users _userLogin;
        public FormMenu(Users user)
        {
            InitializeComponent();
            _userLogin = user;
        }

        private void pictureBoxTikets_Click(object sender, EventArgs e)
        {
            if (_userLogin.type != "super")
            {
                MessageBox.Show("No tienes permisos para acceder a este apartado de la aplicación.");
            }
            else
            {
                FormManageTickets formTickets = new FormManageTickets();
                this.Hide();
                formTickets.ShowDialog();
                this.Show();
            }
        }

        private void customPanelUsers_Click(object sender, EventArgs e)
        {
            if (_userLogin.type != "super")
            {
                MessageBox.Show("No tienes permisos para acceder a este apartado de la aplicación.");
            }
            else
            {
                FormManageUsers formUsers = new FormManageUsers();
                this.Hide();
                formUsers.ShowDialog();
                this.Show();
            } 
        }

        private void pictureBoxUsers_Click(object sender, EventArgs e)
        {
            if (_userLogin.type != "super")
            {
                MessageBox.Show("No tienes permisos para acceder a este apartado de la aplicación.");
            }
            else
            {
                FormManageUsers formUsers = new FormManageUsers();
                this.Hide();
                formUsers.ShowDialog();
                this.Show();
            }
        }

        private void pictureBoxEvents_Click(object sender, EventArgs e)
        {
            FormManageEvents formEvents = new FormManageEvents();
            this.Hide();
            formEvents.ShowDialog();
            this.Show();
        }

        private void pictureBoxRooms_Click(object sender, EventArgs e)
        {
            if (_userLogin.type != "super")
            {
                MessageBox.Show("No tienes permisos para acceder a este apartado de la aplicación.");
            }
            else
            {
                FormManageRooms formRooms = new FormManageRooms();
                this.Hide();
                formRooms.ShowDialog();
                this.Show();
            }
        }

        private void customPanelEvents_Click(object sender, EventArgs e)
        {
            FormManageEvents formEvents = new FormManageEvents();
            this.Hide();
            formEvents.ShowDialog();
            this.Show();
        }

        private void customPanelRooms_Click(object sender, EventArgs e)
        {
            if (_userLogin.type != "super")
            {
                MessageBox.Show("No tienes permisos para acceder a este apartado de la aplicación.");
            }
            else
            {
                FormManageRooms formRooms = new FormManageRooms();
                this.Hide();
                formRooms.ShowDialog();
                this.Show();
            }
            
        }

        private void customPanelTikets_Click(object sender, EventArgs e)
        {
            if (_userLogin.type != "super")
            {
                MessageBox.Show("No tienes permisos para acceder a este apartado de la aplicación.");
            }
            else
            {
                FormManageTickets formTickets = new FormManageTickets();
                this.Hide();
                formTickets.ShowDialog();
                this.Show();
            }
        }
    }
}

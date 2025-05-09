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
        private Users _userLogin;
        public FormMenu(Users user)
        {
            InitializeComponent();
            _userLogin = user;
        }

        /// <summary>
        /// Evento que se dispara cuando el usuario hace clic en el área de "Tickets".
        /// Verifica si el usuario tiene permisos para acceder a la sección de gestión de tickets.
        /// </summary>
        /// <param name="sender">El objeto que generó el evento (el picture box de tickets).</param>
        /// <param name="e">Los argumentos del evento.</param>
        private void pictureBoxTikets_Click(object sender, EventArgs e)
        {
            if (_userLogin.type != "super")
            {
                MessageBox.Show("No tienes permisos para acceder a este apartado de la aplicación.");
            }
            else
            {
                FormManageBookings formTickets = new FormManageBookings();
                this.Hide();
                formTickets.ShowDialog();
                this.Show();
            }
        }

        /// <summary>
        /// Evento que se dispara cuando el usuario hace clic en el panel de "Usuarios".
        /// Verifica si el usuario tiene permisos para acceder a la sección de gestión de usuarios.
        /// </summary>
        /// <param name="sender">El objeto que generó el evento (el panel de usuarios).</param>
        /// <param name="e">Los argumentos del evento.</param>
        private void customPanelUsers_Click(object sender, EventArgs e)
        {
            if (_userLogin.type != "super")
            {
                MessageBox.Show("No tienes permisos para acceder a este apartado de la aplicación.");
            }
            else
            {
                FormManageUsers formUsers = new FormManageUsers(_userLogin);
                this.Hide();
                formUsers.ShowDialog();
                this.Show();
            }
        }

        /// <summary>
        /// Evento que se dispara cuando el usuario hace clic en el icono de "Usuarios".
        /// Verifica si el usuario tiene permisos para acceder a la sección de gestión de usuarios.
        /// </summary>
        /// <param name="sender">El objeto que generó el evento (el picture box de usuarios).</param>
        /// <param name="e">Los argumentos del evento.</param>
        private void pictureBoxUsers_Click(object sender, EventArgs e)
        {
            if (_userLogin.type != "super")
            {
                MessageBox.Show("No tienes permisos para acceder a este apartado de la aplicación.");
            }
            else
            {
                FormManageUsers formUsers = new FormManageUsers(_userLogin);
                this.Hide();
                formUsers.ShowDialog();
                this.Show();
            }
        }

        /// <summary>
        /// Evento que se dispara cuando el usuario hace clic en el icono de "Eventos".
        /// Abre el formulario de gestión de eventos.
        /// </summary>
        /// <param name="sender">El objeto que generó el evento (el picture box de eventos).</param>
        /// <param name="e">Los argumentos del evento.</param>
        private void pictureBoxEvents_Click(object sender, EventArgs e)
        {
            FormManageEvents formEvents = new FormManageEvents();
            this.Hide();
            formEvents.ShowDialog();
            this.Show();
        }

        /// <summary>
        /// Evento que se dispara cuando el usuario hace clic en el icono de "Salas".
        /// Verifica si el usuario tiene permisos para acceder a la sección de gestión de salas.
        /// </summary>
        /// <param name="sender">El objeto que generó el evento (el picture box de salas).</param>
        /// <param name="e">Los argumentos del evento.</param>
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

        /// <summary>
        /// Evento que se dispara cuando el usuario hace clic en el panel de "Eventos".
        /// Abre el formulario de gestión de eventos.
        /// </summary>
        /// <param name="sender">El objeto que generó el evento (el panel de eventos).</param>
        /// <param name="e">Los argumentos del evento.</param>
        private void customPanelEvents_Click(object sender, EventArgs e)
        {
            FormManageEvents formEvents = new FormManageEvents();
            this.Hide();
            formEvents.ShowDialog();
            this.Show();
        }

        /// <summary>
        /// Evento que se dispara cuando el usuario hace clic en el panel de "Salas".
        /// Verifica si el usuario tiene permisos para acceder a la sección de gestión de salas.
        /// </summary>
        /// <param name="sender">El objeto que generó el evento (el panel de salas).</param>
        /// <param name="e">Los argumentos del evento.</param>
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

        /// <summary>
        /// Evento que se dispara cuando el usuario hace clic en el panel de "Tickets".
        /// Verifica si el usuario tiene permisos para acceder a la sección de gestión de tickets.
        /// </summary>
        /// <param name="sender">El objeto que generó el evento (el panel de tickets).</param>
        /// <param name="e">Los argumentos del evento.</param>
        private void customPanelTikets_Click(object sender, EventArgs e)
        {
            if (_userLogin.type != "super")
            {
                MessageBox.Show("No tienes permisos para acceder a este apartado de la aplicación.");
            }
            else
            {
                FormManageBookings formTickets = new FormManageBookings();
                this.Hide();
                formTickets.ShowDialog();
                this.Show();
            }
        }
    }
}

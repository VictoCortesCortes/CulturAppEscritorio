using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CulturAppEscritorio
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void pictureBoxTikets_Click(object sender, EventArgs e)
        {
            FormManageTickets formTickets = new FormManageTickets();
            this.Hide();
            formTickets.ShowDialog();
            this.Show();
        }

        private void customPanelUsers_Click(object sender, EventArgs e)
        {
            FormManageUsers formUsers = new FormManageUsers();
            this.Hide();
            formUsers.ShowDialog();
            this.Show();
        }

        private void pictureBoxUsers_Click(object sender, EventArgs e)
        {
            FormManageUsers formUsers = new FormManageUsers();
            this.Hide();
            formUsers.ShowDialog();
            this.Show();
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
            FormManageRooms formRooms = new FormManageRooms();
            this.Hide();
            formRooms.ShowDialog();
            this.Show();
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
            FormManageRooms formRooms = new FormManageRooms();
            this.Hide();
            formRooms.ShowDialog();
            this.Show();
        }

        private void customPanelTikets_Click(object sender, EventArgs e)
        {
            FormManageTickets formTickets = new FormManageTickets();
            this.Hide();
            formTickets.ShowDialog();
            this.Show();
        }
    }
}

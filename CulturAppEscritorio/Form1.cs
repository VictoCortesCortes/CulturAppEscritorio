﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void roundedButtonLogin_Click(object sender, EventArgs e)
        {
            FormMenu form = new FormMenu();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }
    }
}

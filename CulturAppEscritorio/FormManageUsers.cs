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
    public partial class FormManageUsers : Form
    {
        public FormManageUsers()
        {
            InitializeComponent();
        }

        private void FormManageUsers_Load(object sender, EventArgs e)
        {
            bindingSourceUsers.DataSource = UsersOrm.SelectGlobal();
        }
    }
}

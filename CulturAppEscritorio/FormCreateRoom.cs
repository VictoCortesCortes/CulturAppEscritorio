using System;
using System.Windows.Forms;
using CulturAppEscritorio.Models;

namespace CulturAppEscritorio
{
    public partial class FormCreateRoom : Form
    {
        int actionMade;
        Rooms _roomEdit;
        public FormCreateRoom(int action, Rooms room)
        {
            InitializeComponent();
            actionMade = action;
            _roomEdit = room;
        }

        private void FormCreateRoom_Load(object sender, EventArgs e)
        {
            if (actionMade == 1)
            {
                labelTitle.Text = "Editar sala";
                roundedTextBoxName.Texts = _roomEdit.name;
                roundedTextBoxDescription.Texts = _roomEdit.description;
                roundedTextBoxSize.Texts = _roomEdit.size.ToString();
            }

        }

        private void roundedButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void roundedButtonSave_Click(object sender, EventArgs e)
        {

        }
    }
}

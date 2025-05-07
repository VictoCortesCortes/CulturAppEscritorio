using System;
using System.Windows.Forms;
using CulturAppEscritorio.Models;
using GigFinder.Entities;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

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
            string name = roundedTextBoxName.Texts.Trim();
            string description = roundedTextBoxDescription.Texts.Trim();
            bool isSizeValid = float.TryParse(roundedTextBoxSize.Texts.Trim(), out float size);

            if (string.IsNullOrEmpty(name) ||
                    string.IsNullOrEmpty(description) ||
                    isSizeValid == false ||
                    size <= 0)
            {
                MessageBox.Show("Por favor, completa todos los campos para crear la sala.");
            }
            else
            {
                if (actionMade == 0)
                {
                    Rooms _room = new Rooms
                    {
                        name = name,
                        description = description,
                        size = size
                    };
                    RoomsOrm.Insert(_room);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    _roomEdit.name = name;
                    _roomEdit.description = description;
                    _roomEdit.size = size;
                    RoomsOrm.Update(_roomEdit);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }
    }
}

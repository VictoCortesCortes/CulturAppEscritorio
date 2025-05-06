using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using CulturAppEscritorio.Models;

namespace CulturAppEscritorio
{
    public partial class FormManageUsers : Form
    {
        Users _userLogin;
        Users _userEdit = null;
        public FormManageUsers(Users user)
        {
            InitializeComponent();
            _userLogin = user;
        }

        private void FormManageUsers_Load(object sender, EventArgs e)
        {
            bindingSourceUsers.DataSource = UsersOrm.SelectGlobal();
        }
        private void roundedButtonCreate_Click(object sender, EventArgs e)
        {
            FormCreateUser formCreateUser = new FormCreateUser(0, _userEdit);
            if (formCreateUser.ShowDialog() == DialogResult.OK)
            {
                bindingSourceUsers.DataSource = UsersOrm.SelectGlobal();
                customComboBoxFilter.Texts = "Filtrar por";
                customComboBoxOrder.Texts = "Ordenar por";
            }
        }

        private void roundedButtonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewUsers.SelectedRows.Count > 0)
            {
                _userEdit = (Users)dataGridViewUsers.SelectedRows[0].DataBoundItem;
                FormCreateUser formCreateUser = new FormCreateUser(1, _userEdit);
                if (formCreateUser.ShowDialog() == DialogResult.OK)
                {
                    bindingSourceUsers.DataSource = UsersOrm.SelectGlobal();
                    customComboBoxFilter.Texts = "Filtrar por";
                    customComboBoxOrder.Texts = "Ordenar por";
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un usuario para editarlo.");
            }
        }

        private void roundedButtonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewUsers.SelectedRows.Count > 0)
            {
                if (_userLogin.Equals((Users)dataGridViewUsers.SelectedRows[0].DataBoundItem))
                {
                    MessageBox.Show("No puedes eliminar tu propio usuario.");
                }
                else
                {
                    DialogResult result = MessageBox.Show("¿Estás seguro de que quieres eliminar este usuario?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        Users selectedUser = (Users)dataGridViewUsers.SelectedRows[0].DataBoundItem;
                        UsersOrm.Delete(selectedUser);
                        bindingSourceUsers.DataSource = UsersOrm.SelectGlobal();
                        customComboBoxFilter.Texts = "Filtrar por";
                        customComboBoxOrder.Texts = "Ordenar por";
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un usuario para eliminarlo.");
            }
        }

        private void customComboBoxFilter_OnSelectedIndexChanged_1(object sender, EventArgs e)
        {
            var selectedValue = customComboBoxFilter.SelectedItem?.ToString().ToLower();

            var filteredUsers = FilterUsersByType(selectedValue);

            bindingSourceUsers.DataSource = filteredUsers;
        }

        private void customComboBoxOrder_OnSelectedIndexChanged_1(object sender, EventArgs e)
        {
            var selectedOrder = customComboBoxOrder.SelectedItem?.ToString();

            var orderedUsers = OrderUsersBy(selectedOrder);

            bindingSourceUsers.DataSource = orderedUsers;
        }

        private List<Users> OrderUsersBy(string selectedOrder)
        {
            var _users = UsersOrm.SelectGlobal();

            switch (selectedOrder)
            {
                case "Id":
                    return _users.OrderBy(user => user.id).ToList();

                case "Nombre":
                    return _users.OrderBy(user => user.name).ToList();

                case "Apellido":
                    return _users.OrderBy(user => user.surname).ToList();

                case "Email":
                    return _users.OrderBy(user => user.email).ToList();

                default:
                    return _users;
            }
        }

        private List<Users> FilterUsersByType(string selectedType)
        {
            var _users = UsersOrm.SelectGlobal();

            if (string.IsNullOrEmpty(selectedType) || selectedType == "all")
            {
                return _users;
            }
            else
            {
                return _users.Where(user => user.type == selectedType).ToList();
            }
        }
    }
}

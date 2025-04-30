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
        public FormManageUsers()
        {
            InitializeComponent();
        }

        private void FormManageUsers_Load(object sender, EventArgs e)
        {
            bindingSourceUsers.DataSource = UsersOrm.SelectGlobal();
        }
        private void roundedButtonCreate_Click(object sender, EventArgs e)
        {

        }

        private void roundedButtonEdit_Click(object sender, EventArgs e)
        {

        }

        private void roundedButtonDelete_Click(object sender, EventArgs e)
        {

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

                case "Name":
                    return _users.OrderBy(user => user.name).ToList();

                case "Surname":
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

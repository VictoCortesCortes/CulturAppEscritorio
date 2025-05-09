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
        private Users _userLogin;
        private Users _userEdit = null;
        public FormManageUsers(Users user)
        {
            InitializeComponent();
            _userLogin = user;
        }

        /// <summary>
        /// Evento que se dispara cuando el formulario se carga.
        /// Carga todos los usuarios disponibles en el formulario.
        /// </summary>
        /// <param name="sender">El objeto que generó el evento (el formulario).</param>
        /// <param name="e">Los argumentos del evento.</param>
        private void FormManageUsers_Load(object sender, EventArgs e)
        {
            bindingSourceUsers.DataSource = UsersOrm.SelectGlobal();
        }

        /// <summary>
        /// Evento que se dispara cuando el usuario hace clic en el botón "Crear usuario".
        /// Abre el formulario para crear un nuevo usuario.
        /// </summary>
        /// <param name="sender">El objeto que generó el evento (el botón de crear usuario).</param>
        /// <param name="e">Los argumentos del evento.</param>
        private void roundedButtonCreate_Click(object sender, EventArgs e)
        {
            FormCreateUser formCreateUser = new FormCreateUser(0, _userEdit);
            if (formCreateUser.ShowDialog() == DialogResult.OK)
            {
                // Actualizar la lista de usuarios después de crear uno nuevo.
                bindingSourceUsers.DataSource = UsersOrm.SelectGlobal();
                customComboBoxFilter.Texts = "Filtrar por"; // Resetear filtro de usuarios.
                customComboBoxOrder.Texts = "Ordenar por"; // Resetear el filtro de ordenación.
            }
        }

        /// <summary>
        /// Evento que se dispara cuando el usuario hace clic en el botón "Editar usuario".
        /// Abre el formulario para editar un usuario seleccionado.
        /// </summary>
        /// <param name="sender">El objeto que generó el evento (el botón de editar usuario).</param>
        /// <param name="e">Los argumentos del evento.</param>
        private void roundedButtonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewUsers.SelectedRows.Count > 0)
            {
                // Obtener el usuario seleccionado para editar.
                _userEdit = (Users)dataGridViewUsers.SelectedRows[0].DataBoundItem;
                FormCreateUser formCreateUser = new FormCreateUser(1, _userEdit);
                if (formCreateUser.ShowDialog() == DialogResult.OK)
                {
                    // Actualizar la lista de usuarios después de editar uno.
                    bindingSourceUsers.DataSource = UsersOrm.SelectGlobal();
                    customComboBoxFilter.Texts = "Filtrar por"; // Resetear filtro de usuarios.
                    customComboBoxOrder.Texts = "Ordenar por"; // Resetear filtro de ordenación.
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un usuario para editarlo.");
            }
        }

        /// <summary>
        /// Evento que se dispara cuando el usuario hace clic en el botón "Eliminar usuario".
        /// Elimina el usuario seleccionado, pero no permite eliminar el usuario logueado.
        /// </summary>
        /// <param name="sender">El objeto que generó el evento (el botón de eliminar usuario).</param>
        /// <param name="e">Los argumentos del evento.</param>
        private void roundedButtonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewUsers.SelectedRows.Count > 0)
            {
                // Verificar si el usuario seleccionado es el mismo que el usuario logueado.
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
                        // Actualizar la lista de usuarios después de eliminar uno.
                        bindingSourceUsers.DataSource = UsersOrm.SelectGlobal();
                        customComboBoxFilter.Texts = "Filtrar por"; // Resetear filtro de usuarios.
                        customComboBoxOrder.Texts = "Ordenar por"; // Resetear filtro de ordenación.
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un usuario para eliminarlo.");
            }
        }

        /// <summary>
        /// Evento que se dispara cuando el usuario cambia la selección en el combo box para filtrar los usuarios por tipo.
        /// Filtra los usuarios según el tipo seleccionado (por ejemplo, "admin", "user").
        /// </summary>
        /// <param name="sender">El objeto que generó el evento (el combo box de filtro).</param>
        /// <param name="e">Los argumentos del evento.</param>
        private void customComboBoxFilter_OnSelectedIndexChanged_1(object sender, EventArgs e)
        {
            var selectedValue = customComboBoxFilter.SelectedItem?.ToString().ToLower();

            // Filtrar los usuarios por el tipo seleccionado.
            var filteredUsers = FilterUsersByType(selectedValue);

            bindingSourceUsers.DataSource = filteredUsers; // Actualizar la lista de usuarios filtrados.
        }

        /// <summary>
        /// Evento que se dispara cuando el usuario cambia la selección en el combo box para ordenar los usuarios.
        /// Ordena los usuarios según el criterio seleccionado (por Id, Nombre, Apellido, Email).
        /// </summary>
        /// <param name="sender">El objeto que generó el evento (el combo box de ordenación).</param>
        /// <param name="e">Los argumentos del evento.</param>
        private void customComboBoxOrder_OnSelectedIndexChanged_1(object sender, EventArgs e)
        {
            var selectedOrder = customComboBoxOrder.SelectedItem?.ToString();

            // Ordenar los usuarios según el criterio seleccionado.
            var orderedUsers = OrderUsersBy(selectedOrder);

            bindingSourceUsers.DataSource = orderedUsers; // Actualizar la lista de usuarios ordenados.
        }

        /// <summary>
        /// Método que ordena los usuarios según el criterio seleccionado.
        /// </summary>
        /// <param name="selectedOrder">Criterio de ordenación (Id, Nombre, Apellido, Email).</param>
        /// <returns>Lista de usuarios ordenados según el criterio seleccionado.</returns>
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
                    return _users; // Si no se selecciona un criterio, devolver la lista sin cambios.
            }
        }

        /// <summary>
        /// Método que filtra los usuarios según su tipo (por ejemplo, "admin", "user").
        /// </summary>
        /// <param name="selectedType">Tipo de usuario seleccionado (puede ser "admin", "user", o "all" para todos).</param>
        /// <returns>Lista de usuarios filtrados por el tipo seleccionado.</returns>
        private List<Users> FilterUsersByType(string selectedType)
        {
            var _users = UsersOrm.SelectGlobal();

            if (string.IsNullOrEmpty(selectedType) || selectedType == "all")
            {
                return _users; // Devolver todos los usuarios si no se selecciona un tipo específico.
            }
            else
            {
                return _users.Where(user => user.type == selectedType).ToList(); // Filtrar por el tipo de usuario.
            }
        }
    }
}

namespace CulturAppEscritorio
{
    partial class FormManageRooms
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridView dataGridViewRooms;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourceRoom = new System.Windows.Forms.BindingSource(this.components);
            this.customPanel1 = new GigFinder.Controls.CustomPanel();
            this.customComboBoxOrder = new GigFinder.Controls.CustomComboBox();
            this.roundedButtonDelete = new GigFinder.Controls.RoundedButton();
            this.roundedButtonEdit = new GigFinder.Controls.RoundedButton();
            this.roundedButtonCreate = new GigFinder.Controls.RoundedButton();
            this.labelTitle = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            dataGridViewRooms = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(dataGridViewRooms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceRoom)).BeginInit();
            this.customPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewRooms
            // 
            dataGridViewRooms.AllowUserToAddRows = false;
            dataGridViewRooms.AllowUserToDeleteRows = false;
            dataGridViewRooms.AllowUserToResizeRows = false;
            dataGridViewRooms.AutoGenerateColumns = false;
            dataGridViewRooms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewRooms.BackgroundColor = System.Drawing.Color.White;
            dataGridViewRooms.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewRooms.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewRooms.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Alkatra", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dataGridViewRooms.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewRooms.ColumnHeadersHeight = 35;
            dataGridViewRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewRooms.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.sizeDataGridViewTextBoxColumn});
            dataGridViewRooms.DataSource = this.bindingSourceRoom;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dataGridViewRooms.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewRooms.Dock = System.Windows.Forms.DockStyle.Fill;
            dataGridViewRooms.EnableHeadersVisualStyles = false;
            dataGridViewRooms.GridColor = System.Drawing.Color.White;
            dataGridViewRooms.Location = new System.Drawing.Point(6, 0);
            dataGridViewRooms.MultiSelect = false;
            dataGridViewRooms.Name = "dataGridViewRooms";
            dataGridViewRooms.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(151)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(151)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dataGridViewRooms.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewRooms.RowHeadersVisible = false;
            dataGridViewRooms.RowTemplate.Height = 25;
            dataGridViewRooms.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dataGridViewRooms.Size = new System.Drawing.Size(1136, 446);
            dataGridViewRooms.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Descripción";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sizeDataGridViewTextBoxColumn
            // 
            this.sizeDataGridViewTextBoxColumn.DataPropertyName = "size";
            this.sizeDataGridViewTextBoxColumn.HeaderText = "Tamaño";
            this.sizeDataGridViewTextBoxColumn.Name = "sizeDataGridViewTextBoxColumn";
            this.sizeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bindingSourceRoom
            // 
            this.bindingSourceRoom.DataSource = typeof(CulturAppEscritorio.Models.Rooms);
            // 
            // customPanel1
            // 
            this.customPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.customPanel1.BorderRadius = 8;
            this.customPanel1.Controls.Add(dataGridViewRooms);
            this.customPanel1.Location = new System.Drawing.Point(19, 191);
            this.customPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Padding = new System.Windows.Forms.Padding(6, 0, 6, 8);
            this.customPanel1.Size = new System.Drawing.Size(1148, 454);
            this.customPanel1.TabIndex = 46;
            // 
            // customComboBoxOrder
            // 
            this.customComboBoxOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(242)))), ((int)(((byte)(233)))));
            this.customComboBoxOrder.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(242)))), ((int)(((byte)(233)))));
            this.customComboBoxOrder.BorderSize = 1;
            this.customComboBoxOrder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.customComboBoxOrder.Font = new System.Drawing.Font("Alkatra", 14F, System.Drawing.FontStyle.Bold);
            this.customComboBoxOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.customComboBoxOrder.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.customComboBoxOrder.Items.AddRange(new object[] {
            "Id",
            "Nombre",
            "Tamaño"});
            this.customComboBoxOrder.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(242)))), ((int)(((byte)(233)))));
            this.customComboBoxOrder.ListTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.customComboBoxOrder.Location = new System.Drawing.Point(19, 132);
            this.customComboBoxOrder.MinimumSize = new System.Drawing.Size(100, 30);
            this.customComboBoxOrder.Name = "customComboBoxOrder";
            this.customComboBoxOrder.Padding = new System.Windows.Forms.Padding(1);
            this.customComboBoxOrder.Size = new System.Drawing.Size(162, 42);
            this.customComboBoxOrder.TabIndex = 45;
            this.customComboBoxOrder.Texts = "Ordenar por";
            this.customComboBoxOrder.OnSelectedIndexChanged += new System.EventHandler(this.customComboBoxOrder_OnSelectedIndexChanged);
            // 
            // roundedButtonDelete
            // 
            this.roundedButtonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.roundedButtonDelete.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(208)))), ((int)(((byte)(213)))));
            this.roundedButtonDelete.BorderRadius = 8;
            this.roundedButtonDelete.BorderSize = 0;
            this.roundedButtonDelete.FlatAppearance.BorderSize = 0;
            this.roundedButtonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButtonDelete.Font = new System.Drawing.Font("Alkatra", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedButtonDelete.ForeColor = System.Drawing.Color.White;
            this.roundedButtonDelete.Location = new System.Drawing.Point(1018, 132);
            this.roundedButtonDelete.Name = "roundedButtonDelete";
            this.roundedButtonDelete.Size = new System.Drawing.Size(150, 40);
            this.roundedButtonDelete.TabIndex = 44;
            this.roundedButtonDelete.Text = "Eliminar";
            this.roundedButtonDelete.UseVisualStyleBackColor = false;
            // 
            // roundedButtonEdit
            // 
            this.roundedButtonEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(242)))), ((int)(((byte)(233)))));
            this.roundedButtonEdit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(208)))), ((int)(((byte)(213)))));
            this.roundedButtonEdit.BorderRadius = 8;
            this.roundedButtonEdit.BorderSize = 0;
            this.roundedButtonEdit.FlatAppearance.BorderSize = 0;
            this.roundedButtonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButtonEdit.Font = new System.Drawing.Font("Alkatra", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedButtonEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.roundedButtonEdit.Location = new System.Drawing.Point(862, 132);
            this.roundedButtonEdit.Name = "roundedButtonEdit";
            this.roundedButtonEdit.Size = new System.Drawing.Size(150, 40);
            this.roundedButtonEdit.TabIndex = 43;
            this.roundedButtonEdit.Text = "Editar";
            this.roundedButtonEdit.UseVisualStyleBackColor = false;
            this.roundedButtonEdit.Click += new System.EventHandler(this.roundedButtonEdit_Click);
            // 
            // roundedButtonCreate
            // 
            this.roundedButtonCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(242)))), ((int)(((byte)(233)))));
            this.roundedButtonCreate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(208)))), ((int)(((byte)(213)))));
            this.roundedButtonCreate.BorderRadius = 8;
            this.roundedButtonCreate.BorderSize = 0;
            this.roundedButtonCreate.FlatAppearance.BorderSize = 0;
            this.roundedButtonCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButtonCreate.Font = new System.Drawing.Font("Alkatra", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedButtonCreate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.roundedButtonCreate.Location = new System.Drawing.Point(706, 132);
            this.roundedButtonCreate.Name = "roundedButtonCreate";
            this.roundedButtonCreate.Size = new System.Drawing.Size(150, 40);
            this.roundedButtonCreate.TabIndex = 42;
            this.roundedButtonCreate.Text = "Crear";
            this.roundedButtonCreate.UseVisualStyleBackColor = false;
            this.roundedButtonCreate.Click += new System.EventHandler(this.roundedButtonCreate_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Alkatra", 50.24999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(6, 4);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(520, 116);
            this.labelTitle.TabIndex = 41;
            this.labelTitle.Text = "Gestión de salas";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLogo.BackgroundImage = global::CulturAppEscritorio.Properties.Resources.logo;
            this.pictureBoxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxLogo.Location = new System.Drawing.Point(1060, 18);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(115, 90);
            this.pictureBoxLogo.TabIndex = 40;
            this.pictureBoxLogo.TabStop = false;
            // 
            // FormManageRooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.customPanel1);
            this.Controls.Add(this.customComboBoxOrder);
            this.Controls.Add(this.roundedButtonDelete);
            this.Controls.Add(this.roundedButtonEdit);
            this.Controls.Add(this.roundedButtonCreate);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.pictureBoxLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormManageRooms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormManageRooms";
            this.Load += new System.EventHandler(this.FormManageRooms_Load);
            ((System.ComponentModel.ISupportInitialize)(dataGridViewRooms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceRoom)).EndInit();
            this.customPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GigFinder.Controls.CustomPanel customPanel1;
        private GigFinder.Controls.CustomComboBox customComboBoxOrder;
        private GigFinder.Controls.RoundedButton roundedButtonDelete;
        private GigFinder.Controls.RoundedButton roundedButtonEdit;
        private GigFinder.Controls.RoundedButton roundedButtonCreate;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.BindingSource bindingSourceRoom;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizeDataGridViewTextBoxColumn;
    }
}
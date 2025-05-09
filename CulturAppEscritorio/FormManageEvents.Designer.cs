namespace CulturAppEscritorio
{
    partial class FormManageEvents
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bindingSourceEvents = new System.Windows.Forms.BindingSource(this.components);
            this.customPanel1 = new GigFinder.Controls.CustomPanel();
            this.dataGridViewEvents = new System.Windows.Forms.DataGridView();
            this.customComboBoxOrder = new GigFinder.Controls.CustomComboBox();
            this.roundedButtonDelete = new GigFinder.Controls.RoundedButton();
            this.roundedButtonEdit = new GigFinder.Controls.RoundedButton();
            this.roundedButtonCreate = new GigFinder.Controls.RoundedButton();
            this.labelTitle = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.eventidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enddateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capacityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceEvents)).BeginInit();
            this.customPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEvents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingSourceEvents
            // 
            this.bindingSourceEvents.DataSource = typeof(CulturAppEscritorio.Models.EventsComplete);
            // 
            // customPanel1
            // 
            this.customPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.customPanel1.BorderRadius = 8;
            this.customPanel1.Controls.Add(this.dataGridViewEvents);
            this.customPanel1.Location = new System.Drawing.Point(19, 191);
            this.customPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Padding = new System.Windows.Forms.Padding(6, 0, 6, 8);
            this.customPanel1.Size = new System.Drawing.Size(1148, 454);
            this.customPanel1.TabIndex = 39;
            // 
            // dataGridViewEvents
            // 
            this.dataGridViewEvents.AllowUserToAddRows = false;
            this.dataGridViewEvents.AllowUserToDeleteRows = false;
            this.dataGridViewEvents.AllowUserToResizeRows = false;
            this.dataGridViewEvents.AutoGenerateColumns = false;
            this.dataGridViewEvents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewEvents.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewEvents.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewEvents.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewEvents.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Alkatra", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewEvents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewEvents.ColumnHeadersHeight = 35;
            this.dataGridViewEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewEvents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eventidDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.startdateDataGridViewTextBoxColumn,
            this.enddateDataGridViewTextBoxColumn,
            this.capacityDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.roomDataGridViewTextBoxColumn});
            this.dataGridViewEvents.DataSource = this.bindingSourceEvents;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("DM Serif Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewEvents.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewEvents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewEvents.EnableHeadersVisualStyles = false;
            this.dataGridViewEvents.GridColor = System.Drawing.Color.White;
            this.dataGridViewEvents.Location = new System.Drawing.Point(6, 0);
            this.dataGridViewEvents.MultiSelect = false;
            this.dataGridViewEvents.Name = "dataGridViewEvents";
            this.dataGridViewEvents.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(151)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(151)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewEvents.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewEvents.RowHeadersVisible = false;
            this.dataGridViewEvents.RowTemplate.Height = 25;
            this.dataGridViewEvents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewEvents.Size = new System.Drawing.Size(1136, 446);
            this.dataGridViewEvents.TabIndex = 1;
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
            "Titulo",
            "Fecha inicio",
            "Fecha fin",
            "Capacidad",
            "Precio"});
            this.customComboBoxOrder.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(242)))), ((int)(((byte)(233)))));
            this.customComboBoxOrder.ListTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.customComboBoxOrder.Location = new System.Drawing.Point(25, 132);
            this.customComboBoxOrder.MinimumSize = new System.Drawing.Size(100, 30);
            this.customComboBoxOrder.Name = "customComboBoxOrder";
            this.customComboBoxOrder.Padding = new System.Windows.Forms.Padding(1);
            this.customComboBoxOrder.Size = new System.Drawing.Size(162, 42);
            this.customComboBoxOrder.TabIndex = 38;
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
            this.roundedButtonDelete.TabIndex = 37;
            this.roundedButtonDelete.Text = "Eliminar";
            this.roundedButtonDelete.UseVisualStyleBackColor = false;
            this.roundedButtonDelete.Click += new System.EventHandler(this.roundedButtonDelete_Click);
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
            this.roundedButtonEdit.TabIndex = 36;
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
            this.roundedButtonCreate.TabIndex = 35;
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
            this.labelTitle.Size = new System.Drawing.Size(588, 116);
            this.labelTitle.TabIndex = 34;
            this.labelTitle.Text = "Gestión de eventos";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLogo.BackgroundImage = global::CulturAppEscritorio.Properties.Resources.logo;
            this.pictureBoxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxLogo.Location = new System.Drawing.Point(1060, 18);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(115, 90);
            this.pictureBoxLogo.TabIndex = 33;
            this.pictureBoxLogo.TabStop = false;
            // 
            // eventidDataGridViewTextBoxColumn
            // 
            this.eventidDataGridViewTextBoxColumn.DataPropertyName = "event_id";
            this.eventidDataGridViewTextBoxColumn.HeaderText = "Id";
            this.eventidDataGridViewTextBoxColumn.Name = "eventidDataGridViewTextBoxColumn";
            this.eventidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Título";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Descripción";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // startdateDataGridViewTextBoxColumn
            // 
            this.startdateDataGridViewTextBoxColumn.DataPropertyName = "start_date";
            this.startdateDataGridViewTextBoxColumn.HeaderText = "Fecha inicio";
            this.startdateDataGridViewTextBoxColumn.Name = "startdateDataGridViewTextBoxColumn";
            this.startdateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // enddateDataGridViewTextBoxColumn
            // 
            this.enddateDataGridViewTextBoxColumn.DataPropertyName = "end_date";
            this.enddateDataGridViewTextBoxColumn.HeaderText = "Fecha fin";
            this.enddateDataGridViewTextBoxColumn.Name = "enddateDataGridViewTextBoxColumn";
            this.enddateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // capacityDataGridViewTextBoxColumn
            // 
            this.capacityDataGridViewTextBoxColumn.DataPropertyName = "capacity";
            this.capacityDataGridViewTextBoxColumn.HeaderText = "Capacidad";
            this.capacityDataGridViewTextBoxColumn.Name = "capacityDataGridViewTextBoxColumn";
            this.capacityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Precio";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Tipo";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // roomDataGridViewTextBoxColumn
            // 
            this.roomDataGridViewTextBoxColumn.DataPropertyName = "room";
            this.roomDataGridViewTextBoxColumn.HeaderText = "Sala";
            this.roomDataGridViewTextBoxColumn.Name = "roomDataGridViewTextBoxColumn";
            this.roomDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FormManageEvents
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
            this.Name = "FormManageEvents";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormManageEvents";
            this.Load += new System.EventHandler(this.FormManageEvents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceEvents)).EndInit();
            this.customPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEvents)).EndInit();
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
        private System.Windows.Forms.BindingSource bindingSourceEvents;
        private System.Windows.Forms.DataGridView dataGridViewEvents;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enddateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn capacityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomDataGridViewTextBoxColumn;
    }
}
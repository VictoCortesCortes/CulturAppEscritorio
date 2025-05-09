namespace CulturAppEscritorio
{
    partial class FormCreateEvent
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.roundedButtonCancel = new GigFinder.Controls.RoundedButton();
            this.roundedButtonSave = new GigFinder.Controls.RoundedButton();
            this.labelName = new System.Windows.Forms.Label();
            this.roundedTextBoxTitle = new GigFinder.Controls.RoundedTextBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.roundedTextBoxDescription = new GigFinder.Controls.RoundedTextBox();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.labelStartDate = new System.Windows.Forms.Label();
            this.labelEndDate = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.roundedTextBoxPrice = new GigFinder.Controls.RoundedTextBox();
            this.labelCapacity = new System.Windows.Forms.Label();
            this.roundedTextBoxCapacity = new GigFinder.Controls.RoundedTextBox();
            this.customComboBoxType = new GigFinder.Controls.CustomComboBox();
            this.bindingSourceType = new System.Windows.Forms.BindingSource(this.components);
            this.customComboBoxRoom = new GigFinder.Controls.CustomComboBox();
            this.bindingSourceRoom = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceRoom)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Alkatra", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.labelTitle.Location = new System.Drawing.Point(207, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(302, 83);
            this.labelTitle.TabIndex = 52;
            this.labelTitle.Text = "Crear evento";
            // 
            // roundedButtonCancel
            // 
            this.roundedButtonCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.roundedButtonCancel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(208)))), ((int)(((byte)(213)))));
            this.roundedButtonCancel.BorderRadius = 8;
            this.roundedButtonCancel.BorderSize = 0;
            this.roundedButtonCancel.FlatAppearance.BorderSize = 0;
            this.roundedButtonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButtonCancel.Font = new System.Drawing.Font("Alkatra", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedButtonCancel.ForeColor = System.Drawing.Color.White;
            this.roundedButtonCancel.Location = new System.Drawing.Point(532, 373);
            this.roundedButtonCancel.Name = "roundedButtonCancel";
            this.roundedButtonCancel.Size = new System.Drawing.Size(150, 40);
            this.roundedButtonCancel.TabIndex = 68;
            this.roundedButtonCancel.Text = "Cancelar";
            this.roundedButtonCancel.UseVisualStyleBackColor = false;
            this.roundedButtonCancel.Click += new System.EventHandler(this.roundedButtonCancel_Click);
            // 
            // roundedButtonSave
            // 
            this.roundedButtonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(242)))), ((int)(((byte)(233)))));
            this.roundedButtonSave.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(208)))), ((int)(((byte)(213)))));
            this.roundedButtonSave.BorderRadius = 8;
            this.roundedButtonSave.BorderSize = 0;
            this.roundedButtonSave.FlatAppearance.BorderSize = 0;
            this.roundedButtonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButtonSave.Font = new System.Drawing.Font("Alkatra", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedButtonSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.roundedButtonSave.Location = new System.Drawing.Point(362, 373);
            this.roundedButtonSave.Name = "roundedButtonSave";
            this.roundedButtonSave.Size = new System.Drawing.Size(150, 40);
            this.roundedButtonSave.TabIndex = 67;
            this.roundedButtonSave.Text = "Guardar";
            this.roundedButtonSave.UseVisualStyleBackColor = false;
            this.roundedButtonSave.Click += new System.EventHandler(this.roundedButtonSave_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("DM Serif Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.labelName.Location = new System.Drawing.Point(19, 97);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(57, 22);
            this.labelName.TabIndex = 70;
            this.labelName.Text = "Título:";
            // 
            // roundedTextBoxTitle
            // 
            this.roundedTextBoxTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.roundedTextBoxTitle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.roundedTextBoxTitle.BorderFocusColor = System.Drawing.Color.Black;
            this.roundedTextBoxTitle.BorderRadius = 8;
            this.roundedTextBoxTitle.BorderSize = 2;
            this.roundedTextBoxTitle.Font = new System.Drawing.Font("DM Serif Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedTextBoxTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.roundedTextBoxTitle.Location = new System.Drawing.Point(15, 119);
            this.roundedTextBoxTitle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.roundedTextBoxTitle.Multiline = false;
            this.roundedTextBoxTitle.Name = "roundedTextBoxTitle";
            this.roundedTextBoxTitle.Padding = new System.Windows.Forms.Padding(6, 10, 6, 10);
            this.roundedTextBoxTitle.PasswordChar = false;
            this.roundedTextBoxTitle.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.roundedTextBoxTitle.PlaceholderText = "";
            this.roundedTextBoxTitle.Size = new System.Drawing.Size(323, 43);
            this.roundedTextBoxTitle.TabIndex = 65;
            this.roundedTextBoxTitle.Texts = "";
            this.roundedTextBoxTitle.UnderlinedStyle = false;
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("DM Serif Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.labelDescription.Location = new System.Drawing.Point(19, 287);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(98, 22);
            this.labelDescription.TabIndex = 69;
            this.labelDescription.Text = "Descripción:";
            // 
            // roundedTextBoxDescription
            // 
            this.roundedTextBoxDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.roundedTextBoxDescription.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.roundedTextBoxDescription.BorderFocusColor = System.Drawing.Color.Black;
            this.roundedTextBoxDescription.BorderRadius = 8;
            this.roundedTextBoxDescription.BorderSize = 2;
            this.roundedTextBoxDescription.Font = new System.Drawing.Font("DM Serif Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedTextBoxDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.roundedTextBoxDescription.Location = new System.Drawing.Point(15, 309);
            this.roundedTextBoxDescription.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.roundedTextBoxDescription.Multiline = true;
            this.roundedTextBoxDescription.Name = "roundedTextBoxDescription";
            this.roundedTextBoxDescription.Padding = new System.Windows.Forms.Padding(6, 10, 6, 10);
            this.roundedTextBoxDescription.PasswordChar = false;
            this.roundedTextBoxDescription.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.roundedTextBoxDescription.PlaceholderText = "";
            this.roundedTextBoxDescription.Size = new System.Drawing.Size(323, 104);
            this.roundedTextBoxDescription.TabIndex = 66;
            this.roundedTextBoxDescription.Texts = "";
            this.roundedTextBoxDescription.UnderlinedStyle = false;
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dateTimePickerStart.Font = new System.Drawing.Font("DM Serif Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerStart.Location = new System.Drawing.Point(15, 191);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.ShowUpDown = true;
            this.dateTimePickerStart.Size = new System.Drawing.Size(323, 29);
            this.dateTimePickerStart.TabIndex = 71;
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dateTimePickerEnd.Font = new System.Drawing.Font("DM Serif Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerEnd.Location = new System.Drawing.Point(15, 251);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.ShowUpDown = true;
            this.dateTimePickerEnd.Size = new System.Drawing.Size(323, 29);
            this.dateTimePickerEnd.TabIndex = 72;
            // 
            // labelStartDate
            // 
            this.labelStartDate.AutoSize = true;
            this.labelStartDate.Font = new System.Drawing.Font("DM Serif Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStartDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.labelStartDate.Location = new System.Drawing.Point(19, 166);
            this.labelStartDate.Name = "labelStartDate";
            this.labelStartDate.Size = new System.Drawing.Size(98, 22);
            this.labelStartDate.TabIndex = 73;
            this.labelStartDate.Text = "Fecha inicio:";
            // 
            // labelEndDate
            // 
            this.labelEndDate.AutoSize = true;
            this.labelEndDate.Font = new System.Drawing.Font("DM Serif Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEndDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.labelEndDate.Location = new System.Drawing.Point(19, 226);
            this.labelEndDate.Name = "labelEndDate";
            this.labelEndDate.Size = new System.Drawing.Size(78, 22);
            this.labelEndDate.TabIndex = 74;
            this.labelEndDate.Text = "Fecha fin:";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("DM Serif Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.labelPrice.Location = new System.Drawing.Point(363, 97);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(60, 22);
            this.labelPrice.TabIndex = 76;
            this.labelPrice.Text = "Precio:";
            // 
            // roundedTextBoxPrice
            // 
            this.roundedTextBoxPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.roundedTextBoxPrice.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.roundedTextBoxPrice.BorderFocusColor = System.Drawing.Color.Black;
            this.roundedTextBoxPrice.BorderRadius = 8;
            this.roundedTextBoxPrice.BorderSize = 2;
            this.roundedTextBoxPrice.Font = new System.Drawing.Font("DM Serif Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedTextBoxPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.roundedTextBoxPrice.Location = new System.Drawing.Point(359, 119);
            this.roundedTextBoxPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.roundedTextBoxPrice.Multiline = false;
            this.roundedTextBoxPrice.Name = "roundedTextBoxPrice";
            this.roundedTextBoxPrice.Padding = new System.Windows.Forms.Padding(6, 10, 6, 10);
            this.roundedTextBoxPrice.PasswordChar = false;
            this.roundedTextBoxPrice.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.roundedTextBoxPrice.PlaceholderText = "";
            this.roundedTextBoxPrice.Size = new System.Drawing.Size(323, 43);
            this.roundedTextBoxPrice.TabIndex = 75;
            this.roundedTextBoxPrice.Texts = "";
            this.roundedTextBoxPrice.UnderlinedStyle = false;
            this.roundedTextBoxPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.roundedTextBox1_KeyPress);
            // 
            // labelCapacity
            // 
            this.labelCapacity.AutoSize = true;
            this.labelCapacity.Font = new System.Drawing.Font("DM Serif Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCapacity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.labelCapacity.Location = new System.Drawing.Point(363, 172);
            this.labelCapacity.Name = "labelCapacity";
            this.labelCapacity.Size = new System.Drawing.Size(77, 22);
            this.labelCapacity.TabIndex = 78;
            this.labelCapacity.Text = "Capacity:";
            // 
            // roundedTextBoxCapacity
            // 
            this.roundedTextBoxCapacity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.roundedTextBoxCapacity.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.roundedTextBoxCapacity.BorderFocusColor = System.Drawing.Color.Black;
            this.roundedTextBoxCapacity.BorderRadius = 8;
            this.roundedTextBoxCapacity.BorderSize = 2;
            this.roundedTextBoxCapacity.Font = new System.Drawing.Font("DM Serif Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedTextBoxCapacity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.roundedTextBoxCapacity.Location = new System.Drawing.Point(359, 194);
            this.roundedTextBoxCapacity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.roundedTextBoxCapacity.Multiline = false;
            this.roundedTextBoxCapacity.Name = "roundedTextBoxCapacity";
            this.roundedTextBoxCapacity.Padding = new System.Windows.Forms.Padding(6, 10, 6, 10);
            this.roundedTextBoxCapacity.PasswordChar = false;
            this.roundedTextBoxCapacity.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.roundedTextBoxCapacity.PlaceholderText = "";
            this.roundedTextBoxCapacity.Size = new System.Drawing.Size(323, 43);
            this.roundedTextBoxCapacity.TabIndex = 77;
            this.roundedTextBoxCapacity.Texts = "";
            this.roundedTextBoxCapacity.UnderlinedStyle = false;
            this.roundedTextBoxCapacity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.roundedTextBoxCapacity_KeyPress);
            // 
            // customComboBoxType
            // 
            this.customComboBoxType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.customComboBoxType.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.customComboBoxType.BorderSize = 2;
            this.customComboBoxType.DataSource = this.bindingSourceType;
            this.customComboBoxType.DisplayMember = "name";
            this.customComboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.customComboBoxType.Font = new System.Drawing.Font("DM Serif Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customComboBoxType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.customComboBoxType.IconColor = System.Drawing.Color.Black;
            this.customComboBoxType.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.customComboBoxType.ListTextColor = System.Drawing.Color.Black;
            this.customComboBoxType.Location = new System.Drawing.Point(359, 254);
            this.customComboBoxType.MinimumSize = new System.Drawing.Size(200, 30);
            this.customComboBoxType.Name = "customComboBoxType";
            this.customComboBoxType.Padding = new System.Windows.Forms.Padding(2);
            this.customComboBoxType.Size = new System.Drawing.Size(320, 38);
            this.customComboBoxType.TabIndex = 79;
            this.customComboBoxType.Texts = "Tipo de evento";
            // 
            // bindingSourceType
            // 
            this.bindingSourceType.DataSource = typeof(CulturAppEscritorio.Models.Type_event);
            // 
            // customComboBoxRoom
            // 
            this.customComboBoxRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.customComboBoxRoom.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.customComboBoxRoom.BorderSize = 2;
            this.customComboBoxRoom.DataSource = this.bindingSourceRoom;
            this.customComboBoxRoom.DisplayMember = "name";
            this.customComboBoxRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.customComboBoxRoom.Font = new System.Drawing.Font("DM Serif Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customComboBoxRoom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.customComboBoxRoom.IconColor = System.Drawing.Color.Black;
            this.customComboBoxRoom.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.customComboBoxRoom.ListTextColor = System.Drawing.Color.Black;
            this.customComboBoxRoom.Location = new System.Drawing.Point(359, 312);
            this.customComboBoxRoom.MinimumSize = new System.Drawing.Size(200, 30);
            this.customComboBoxRoom.Name = "customComboBoxRoom";
            this.customComboBoxRoom.Padding = new System.Windows.Forms.Padding(2);
            this.customComboBoxRoom.Size = new System.Drawing.Size(320, 38);
            this.customComboBoxRoom.TabIndex = 80;
            this.customComboBoxRoom.Texts = "Sala";
            // 
            // bindingSourceRoom
            // 
            this.bindingSourceRoom.DataSource = typeof(CulturAppEscritorio.Models.Rooms);
            // 
            // FormCreateEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(696, 438);
            this.Controls.Add(this.customComboBoxRoom);
            this.Controls.Add(this.customComboBoxType);
            this.Controls.Add(this.labelCapacity);
            this.Controls.Add(this.roundedTextBoxCapacity);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.roundedTextBoxPrice);
            this.Controls.Add(this.labelEndDate);
            this.Controls.Add(this.labelStartDate);
            this.Controls.Add(this.dateTimePickerEnd);
            this.Controls.Add(this.dateTimePickerStart);
            this.Controls.Add(this.roundedButtonCancel);
            this.Controls.Add(this.roundedButtonSave);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.roundedTextBoxTitle);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.roundedTextBoxDescription);
            this.Controls.Add(this.labelTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormCreateEvent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCreateEvent";
            this.Load += new System.EventHandler(this.FormCreateEvent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceRoom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private GigFinder.Controls.RoundedButton roundedButtonCancel;
        private GigFinder.Controls.RoundedButton roundedButtonSave;
        private System.Windows.Forms.Label labelName;
        private GigFinder.Controls.RoundedTextBox roundedTextBoxTitle;
        private System.Windows.Forms.Label labelDescription;
        private GigFinder.Controls.RoundedTextBox roundedTextBoxDescription;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.Label labelStartDate;
        private System.Windows.Forms.Label labelEndDate;
        private System.Windows.Forms.Label labelPrice;
        private GigFinder.Controls.RoundedTextBox roundedTextBoxPrice;
        private System.Windows.Forms.Label labelCapacity;
        private GigFinder.Controls.RoundedTextBox roundedTextBoxCapacity;
        private GigFinder.Controls.CustomComboBox customComboBoxType;
        private GigFinder.Controls.CustomComboBox customComboBoxRoom;
        private System.Windows.Forms.BindingSource bindingSourceType;
        private System.Windows.Forms.BindingSource bindingSourceRoom;
    }
}
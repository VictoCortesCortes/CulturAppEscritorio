namespace CulturAppEscritorio
{
    partial class FormCreateBooking
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
            this.customComboBoxEvent = new GigFinder.Controls.CustomComboBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.roundedButtonCancel = new GigFinder.Controls.RoundedButton();
            this.roundedButtonSave = new GigFinder.Controls.RoundedButton();
            this.customComboBoxUser = new GigFinder.Controls.CustomComboBox();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.roundedTextBoxQuantity = new GigFinder.Controls.RoundedTextBox();
            this.bindingSourceEvent = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourceUsers = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceEvent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // customComboBoxEvent
            // 
            this.customComboBoxEvent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.customComboBoxEvent.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.customComboBoxEvent.BorderSize = 2;
            this.customComboBoxEvent.DataSource = this.bindingSourceEvent;
            this.customComboBoxEvent.DisplayMember = "title";
            this.customComboBoxEvent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.customComboBoxEvent.Font = new System.Drawing.Font("DM Serif Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customComboBoxEvent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.customComboBoxEvent.IconColor = System.Drawing.Color.Black;
            this.customComboBoxEvent.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.customComboBoxEvent.ListTextColor = System.Drawing.Color.Black;
            this.customComboBoxEvent.Location = new System.Drawing.Point(29, 231);
            this.customComboBoxEvent.MinimumSize = new System.Drawing.Size(200, 30);
            this.customComboBoxEvent.Name = "customComboBoxEvent";
            this.customComboBoxEvent.Padding = new System.Windows.Forms.Padding(2);
            this.customComboBoxEvent.Size = new System.Drawing.Size(320, 38);
            this.customComboBoxEvent.TabIndex = 69;
            this.customComboBoxEvent.Texts = "Evento";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Alkatra", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.labelTitle.Location = new System.Drawing.Point(29, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(320, 83);
            this.labelTitle.TabIndex = 68;
            this.labelTitle.Text = "Crear reserva";
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
            this.roundedButtonCancel.Location = new System.Drawing.Point(199, 288);
            this.roundedButtonCancel.Name = "roundedButtonCancel";
            this.roundedButtonCancel.Size = new System.Drawing.Size(150, 40);
            this.roundedButtonCancel.TabIndex = 66;
            this.roundedButtonCancel.Text = "Cancelar";
            this.roundedButtonCancel.UseVisualStyleBackColor = false;
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
            this.roundedButtonSave.Location = new System.Drawing.Point(29, 288);
            this.roundedButtonSave.Name = "roundedButtonSave";
            this.roundedButtonSave.Size = new System.Drawing.Size(150, 40);
            this.roundedButtonSave.TabIndex = 65;
            this.roundedButtonSave.Text = "Guardar";
            this.roundedButtonSave.UseVisualStyleBackColor = false;
            // 
            // customComboBoxUser
            // 
            this.customComboBoxUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.customComboBoxUser.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.customComboBoxUser.BorderSize = 2;
            this.customComboBoxUser.DataSource = this.bindingSourceUsers;
            this.customComboBoxUser.DisplayMember = "name";
            this.customComboBoxUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.customComboBoxUser.Font = new System.Drawing.Font("DM Serif Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customComboBoxUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.customComboBoxUser.IconColor = System.Drawing.Color.Black;
            this.customComboBoxUser.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.customComboBoxUser.ListTextColor = System.Drawing.Color.Black;
            this.customComboBoxUser.Location = new System.Drawing.Point(29, 174);
            this.customComboBoxUser.MinimumSize = new System.Drawing.Size(200, 30);
            this.customComboBoxUser.Name = "customComboBoxUser";
            this.customComboBoxUser.Padding = new System.Windows.Forms.Padding(2);
            this.customComboBoxUser.Size = new System.Drawing.Size(320, 38);
            this.customComboBoxUser.TabIndex = 64;
            this.customComboBoxUser.Texts = "Usuario";
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Font = new System.Drawing.Font("DM Serif Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.labelQuantity.Location = new System.Drawing.Point(30, 93);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(78, 22);
            this.labelQuantity.TabIndex = 67;
            this.labelQuantity.Text = "Cantidad:";
            // 
            // roundedTextBoxQuantity
            // 
            this.roundedTextBoxQuantity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.roundedTextBoxQuantity.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.roundedTextBoxQuantity.BorderFocusColor = System.Drawing.Color.Black;
            this.roundedTextBoxQuantity.BorderRadius = 8;
            this.roundedTextBoxQuantity.BorderSize = 2;
            this.roundedTextBoxQuantity.Font = new System.Drawing.Font("DM Serif Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedTextBoxQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.roundedTextBoxQuantity.Location = new System.Drawing.Point(26, 116);
            this.roundedTextBoxQuantity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.roundedTextBoxQuantity.Multiline = false;
            this.roundedTextBoxQuantity.Name = "roundedTextBoxQuantity";
            this.roundedTextBoxQuantity.Padding = new System.Windows.Forms.Padding(6, 10, 6, 10);
            this.roundedTextBoxQuantity.PasswordChar = true;
            this.roundedTextBoxQuantity.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.roundedTextBoxQuantity.PlaceholderText = "";
            this.roundedTextBoxQuantity.Size = new System.Drawing.Size(323, 43);
            this.roundedTextBoxQuantity.TabIndex = 63;
            this.roundedTextBoxQuantity.Texts = "";
            this.roundedTextBoxQuantity.UnderlinedStyle = false;
            // 
            // bindingSourceEvent
            // 
            this.bindingSourceEvent.DataSource = typeof(CulturAppEscritorio.Models.EventsComplete);
            // 
            // bindingSourceUsers
            // 
            this.bindingSourceUsers.DataSource = typeof(CulturAppEscritorio.Models.Users);
            // 
            // FormCreateBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(384, 353);
            this.Controls.Add(this.customComboBoxEvent);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.roundedButtonCancel);
            this.Controls.Add(this.roundedButtonSave);
            this.Controls.Add(this.customComboBoxUser);
            this.Controls.Add(this.labelQuantity);
            this.Controls.Add(this.roundedTextBoxQuantity);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormCreateBooking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCreateBooking";
            this.Load += new System.EventHandler(this.FormCreateBooking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceEvent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GigFinder.Controls.CustomComboBox customComboBoxEvent;
        private System.Windows.Forms.Label labelTitle;
        private GigFinder.Controls.RoundedButton roundedButtonCancel;
        private GigFinder.Controls.RoundedButton roundedButtonSave;
        private GigFinder.Controls.CustomComboBox customComboBoxUser;
        private System.Windows.Forms.Label labelQuantity;
        private GigFinder.Controls.RoundedTextBox roundedTextBoxQuantity;
        private System.Windows.Forms.BindingSource bindingSourceEvent;
        private System.Windows.Forms.BindingSource bindingSourceUsers;
    }
}
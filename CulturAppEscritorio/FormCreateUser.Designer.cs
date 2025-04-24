namespace CulturAppEscritorio
{
    partial class FormCreateUser
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
            this.roundedButtonCancel = new GigFinder.Controls.RoundedButton();
            this.roundedButtonSave = new GigFinder.Controls.RoundedButton();
            this.customComboBoxType = new GigFinder.Controls.CustomComboBox();
            this.labelSurname = new System.Windows.Forms.Label();
            this.roundedTextBoxSurname = new GigFinder.Controls.RoundedTextBox();
            this.labelConfirmPass = new System.Windows.Forms.Label();
            this.labelPass = new System.Windows.Forms.Label();
            this.labelMail = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.roundedTextBoxConfirmPass = new GigFinder.Controls.RoundedTextBox();
            this.roundedTextBoxPass = new GigFinder.Controls.RoundedTextBox();
            this.roundedTextBoxMail = new GigFinder.Controls.RoundedTextBox();
            this.roundedTextBoxName = new GigFinder.Controls.RoundedTextBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            this.roundedButtonCancel.Location = new System.Drawing.Point(201, 510);
            this.roundedButtonCancel.Name = "roundedButtonCancel";
            this.roundedButtonCancel.Size = new System.Drawing.Size(150, 40);
            this.roundedButtonCancel.TabIndex = 50;
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
            this.roundedButtonSave.Location = new System.Drawing.Point(31, 510);
            this.roundedButtonSave.Name = "roundedButtonSave";
            this.roundedButtonSave.Size = new System.Drawing.Size(150, 40);
            this.roundedButtonSave.TabIndex = 49;
            this.roundedButtonSave.Text = "Crear";
            this.roundedButtonSave.UseVisualStyleBackColor = false;
            this.roundedButtonSave.Click += new System.EventHandler(this.roundedButtonSave_Click);
            // 
            // customComboBoxType
            // 
            this.customComboBoxType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.customComboBoxType.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.customComboBoxType.BorderSize = 2;
            this.customComboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.customComboBoxType.Font = new System.Drawing.Font("DM Serif Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customComboBoxType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.customComboBoxType.IconColor = System.Drawing.Color.Black;
            this.customComboBoxType.Items.AddRange(new object[] {
            "super",
            "organizator",
            "basic"});
            this.customComboBoxType.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.customComboBoxType.ListTextColor = System.Drawing.Color.Black;
            this.customComboBoxType.Location = new System.Drawing.Point(31, 454);
            this.customComboBoxType.MinimumSize = new System.Drawing.Size(200, 30);
            this.customComboBoxType.Name = "customComboBoxType";
            this.customComboBoxType.Padding = new System.Windows.Forms.Padding(2);
            this.customComboBoxType.Size = new System.Drawing.Size(320, 38);
            this.customComboBoxType.TabIndex = 48;
            this.customComboBoxType.Texts = "Tipo de usuario";
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Font = new System.Drawing.Font("DM Serif Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSurname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.labelSurname.Location = new System.Drawing.Point(32, 155);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(72, 22);
            this.labelSurname.TabIndex = 56;
            this.labelSurname.Text = "Apellido:";
            // 
            // roundedTextBoxSurname
            // 
            this.roundedTextBoxSurname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.roundedTextBoxSurname.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.roundedTextBoxSurname.BorderFocusColor = System.Drawing.Color.Black;
            this.roundedTextBoxSurname.BorderRadius = 8;
            this.roundedTextBoxSurname.BorderSize = 2;
            this.roundedTextBoxSurname.Font = new System.Drawing.Font("DM Serif Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedTextBoxSurname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.roundedTextBoxSurname.Location = new System.Drawing.Point(28, 177);
            this.roundedTextBoxSurname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.roundedTextBoxSurname.Multiline = false;
            this.roundedTextBoxSurname.Name = "roundedTextBoxSurname";
            this.roundedTextBoxSurname.Padding = new System.Windows.Forms.Padding(6, 10, 6, 10);
            this.roundedTextBoxSurname.PasswordChar = false;
            this.roundedTextBoxSurname.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.roundedTextBoxSurname.PlaceholderText = "";
            this.roundedTextBoxSurname.Size = new System.Drawing.Size(323, 43);
            this.roundedTextBoxSurname.TabIndex = 44;
            this.roundedTextBoxSurname.Texts = "";
            this.roundedTextBoxSurname.UnderlinedStyle = false;
            // 
            // labelConfirmPass
            // 
            this.labelConfirmPass.AutoSize = true;
            this.labelConfirmPass.Font = new System.Drawing.Font("DM Serif Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConfirmPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.labelConfirmPass.Location = new System.Drawing.Point(32, 373);
            this.labelConfirmPass.Name = "labelConfirmPass";
            this.labelConfirmPass.Size = new System.Drawing.Size(171, 22);
            this.labelConfirmPass.TabIndex = 55;
            this.labelConfirmPass.Text = "Confirmar contraseña:";
            // 
            // labelPass
            // 
            this.labelPass.AutoSize = true;
            this.labelPass.Font = new System.Drawing.Font("DM Serif Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.labelPass.Location = new System.Drawing.Point(32, 299);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(96, 22);
            this.labelPass.TabIndex = 54;
            this.labelPass.Text = "Contraseña:";
            // 
            // labelMail
            // 
            this.labelMail.AutoSize = true;
            this.labelMail.Font = new System.Drawing.Font("DM Serif Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.labelMail.Location = new System.Drawing.Point(32, 227);
            this.labelMail.Name = "labelMail";
            this.labelMail.Size = new System.Drawing.Size(65, 22);
            this.labelMail.TabIndex = 53;
            this.labelMail.Text = "Correo:";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("DM Serif Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.labelName.Location = new System.Drawing.Point(32, 84);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(73, 22);
            this.labelName.TabIndex = 52;
            this.labelName.Text = "Nombre:";
            // 
            // roundedTextBoxConfirmPass
            // 
            this.roundedTextBoxConfirmPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.roundedTextBoxConfirmPass.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.roundedTextBoxConfirmPass.BorderFocusColor = System.Drawing.Color.Black;
            this.roundedTextBoxConfirmPass.BorderRadius = 8;
            this.roundedTextBoxConfirmPass.BorderSize = 2;
            this.roundedTextBoxConfirmPass.Font = new System.Drawing.Font("DM Serif Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedTextBoxConfirmPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.roundedTextBoxConfirmPass.Location = new System.Drawing.Point(28, 396);
            this.roundedTextBoxConfirmPass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.roundedTextBoxConfirmPass.Multiline = false;
            this.roundedTextBoxConfirmPass.Name = "roundedTextBoxConfirmPass";
            this.roundedTextBoxConfirmPass.Padding = new System.Windows.Forms.Padding(6, 10, 6, 10);
            this.roundedTextBoxConfirmPass.PasswordChar = true;
            this.roundedTextBoxConfirmPass.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.roundedTextBoxConfirmPass.PlaceholderText = "";
            this.roundedTextBoxConfirmPass.Size = new System.Drawing.Size(323, 43);
            this.roundedTextBoxConfirmPass.TabIndex = 47;
            this.roundedTextBoxConfirmPass.Texts = "";
            this.roundedTextBoxConfirmPass.UnderlinedStyle = false;
            // 
            // roundedTextBoxPass
            // 
            this.roundedTextBoxPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.roundedTextBoxPass.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.roundedTextBoxPass.BorderFocusColor = System.Drawing.Color.Black;
            this.roundedTextBoxPass.BorderRadius = 8;
            this.roundedTextBoxPass.BorderSize = 2;
            this.roundedTextBoxPass.Font = new System.Drawing.Font("DM Serif Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedTextBoxPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.roundedTextBoxPass.Location = new System.Drawing.Point(28, 322);
            this.roundedTextBoxPass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.roundedTextBoxPass.Multiline = false;
            this.roundedTextBoxPass.Name = "roundedTextBoxPass";
            this.roundedTextBoxPass.Padding = new System.Windows.Forms.Padding(6, 10, 6, 10);
            this.roundedTextBoxPass.PasswordChar = true;
            this.roundedTextBoxPass.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.roundedTextBoxPass.PlaceholderText = "";
            this.roundedTextBoxPass.Size = new System.Drawing.Size(323, 43);
            this.roundedTextBoxPass.TabIndex = 46;
            this.roundedTextBoxPass.Texts = "";
            this.roundedTextBoxPass.UnderlinedStyle = false;
            // 
            // roundedTextBoxMail
            // 
            this.roundedTextBoxMail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.roundedTextBoxMail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.roundedTextBoxMail.BorderFocusColor = System.Drawing.Color.Black;
            this.roundedTextBoxMail.BorderRadius = 8;
            this.roundedTextBoxMail.BorderSize = 2;
            this.roundedTextBoxMail.Font = new System.Drawing.Font("DM Serif Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedTextBoxMail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.roundedTextBoxMail.Location = new System.Drawing.Point(28, 249);
            this.roundedTextBoxMail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.roundedTextBoxMail.Multiline = false;
            this.roundedTextBoxMail.Name = "roundedTextBoxMail";
            this.roundedTextBoxMail.Padding = new System.Windows.Forms.Padding(6, 10, 6, 10);
            this.roundedTextBoxMail.PasswordChar = false;
            this.roundedTextBoxMail.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.roundedTextBoxMail.PlaceholderText = "";
            this.roundedTextBoxMail.Size = new System.Drawing.Size(323, 43);
            this.roundedTextBoxMail.TabIndex = 45;
            this.roundedTextBoxMail.Texts = "";
            this.roundedTextBoxMail.UnderlinedStyle = false;
            // 
            // roundedTextBoxName
            // 
            this.roundedTextBoxName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.roundedTextBoxName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.roundedTextBoxName.BorderFocusColor = System.Drawing.Color.Black;
            this.roundedTextBoxName.BorderRadius = 8;
            this.roundedTextBoxName.BorderSize = 2;
            this.roundedTextBoxName.Font = new System.Drawing.Font("DM Serif Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedTextBoxName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.roundedTextBoxName.Location = new System.Drawing.Point(28, 106);
            this.roundedTextBoxName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.roundedTextBoxName.Multiline = false;
            this.roundedTextBoxName.Name = "roundedTextBoxName";
            this.roundedTextBoxName.Padding = new System.Windows.Forms.Padding(6, 10, 6, 10);
            this.roundedTextBoxName.PasswordChar = false;
            this.roundedTextBoxName.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.roundedTextBoxName.PlaceholderText = "";
            this.roundedTextBoxName.Size = new System.Drawing.Size(323, 43);
            this.roundedTextBoxName.TabIndex = 43;
            this.roundedTextBoxName.Texts = "";
            this.roundedTextBoxName.UnderlinedStyle = false;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Alkatra", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.labelTitle.Location = new System.Drawing.Point(30, 6);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(323, 83);
            this.labelTitle.TabIndex = 51;
            this.labelTitle.Text = "Crear usuario";
            // 
            // FormCreateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(384, 561);
            this.Controls.Add(this.roundedButtonCancel);
            this.Controls.Add(this.roundedButtonSave);
            this.Controls.Add(this.customComboBoxType);
            this.Controls.Add(this.labelSurname);
            this.Controls.Add(this.roundedTextBoxSurname);
            this.Controls.Add(this.labelConfirmPass);
            this.Controls.Add(this.labelPass);
            this.Controls.Add(this.labelMail);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.roundedTextBoxConfirmPass);
            this.Controls.Add(this.roundedTextBoxPass);
            this.Controls.Add(this.roundedTextBoxMail);
            this.Controls.Add(this.roundedTextBoxName);
            this.Controls.Add(this.labelTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormCreateUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCreateUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GigFinder.Controls.RoundedButton roundedButtonCancel;
        private GigFinder.Controls.RoundedButton roundedButtonSave;
        private GigFinder.Controls.CustomComboBox customComboBoxType;
        private System.Windows.Forms.Label labelSurname;
        private GigFinder.Controls.RoundedTextBox roundedTextBoxSurname;
        private System.Windows.Forms.Label labelConfirmPass;
        private System.Windows.Forms.Label labelPass;
        private System.Windows.Forms.Label labelMail;
        private System.Windows.Forms.Label labelName;
        private GigFinder.Controls.RoundedTextBox roundedTextBoxConfirmPass;
        private GigFinder.Controls.RoundedTextBox roundedTextBoxPass;
        private GigFinder.Controls.RoundedTextBox roundedTextBoxMail;
        private GigFinder.Controls.RoundedTextBox roundedTextBoxName;
        private System.Windows.Forms.Label labelTitle;
    }
}
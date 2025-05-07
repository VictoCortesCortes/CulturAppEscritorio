namespace CulturAppEscritorio
{
    partial class FormCreateRoom
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.roundedButtonCancel = new GigFinder.Controls.RoundedButton();
            this.roundedButtonSave = new GigFinder.Controls.RoundedButton();
            this.labelSize = new System.Windows.Forms.Label();
            this.roundedTextBoxSize = new GigFinder.Controls.RoundedTextBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.roundedTextBoxDescription = new GigFinder.Controls.RoundedTextBox();
            this.roundedTextBoxName = new GigFinder.Controls.RoundedTextBox();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Alkatra", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.labelTitle.Location = new System.Drawing.Point(66, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(252, 83);
            this.labelTitle.TabIndex = 52;
            this.labelTitle.Text = "Crear sala";
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
            this.roundedButtonCancel.Location = new System.Drawing.Point(204, 357);
            this.roundedButtonCancel.Name = "roundedButtonCancel";
            this.roundedButtonCancel.Size = new System.Drawing.Size(150, 40);
            this.roundedButtonCancel.TabIndex = 61;
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
            this.roundedButtonSave.Location = new System.Drawing.Point(34, 357);
            this.roundedButtonSave.Name = "roundedButtonSave";
            this.roundedButtonSave.Size = new System.Drawing.Size(150, 40);
            this.roundedButtonSave.TabIndex = 60;
            this.roundedButtonSave.Text = "Guardar";
            this.roundedButtonSave.UseVisualStyleBackColor = false;
            this.roundedButtonSave.Click += new System.EventHandler(this.roundedButtonSave_Click);
            // 
            // labelSize
            // 
            this.labelSize.AutoSize = true;
            this.labelSize.Font = new System.Drawing.Font("DM Serif Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.labelSize.Location = new System.Drawing.Point(35, 147);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(72, 22);
            this.labelSize.TabIndex = 64;
            this.labelSize.Text = "Apellido:";
            // 
            // roundedTextBoxSize
            // 
            this.roundedTextBoxSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.roundedTextBoxSize.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.roundedTextBoxSize.BorderFocusColor = System.Drawing.Color.Black;
            this.roundedTextBoxSize.BorderRadius = 8;
            this.roundedTextBoxSize.BorderSize = 2;
            this.roundedTextBoxSize.Font = new System.Drawing.Font("DM Serif Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedTextBoxSize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.roundedTextBoxSize.Location = new System.Drawing.Point(31, 169);
            this.roundedTextBoxSize.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.roundedTextBoxSize.Multiline = false;
            this.roundedTextBoxSize.Name = "roundedTextBoxSize";
            this.roundedTextBoxSize.Padding = new System.Windows.Forms.Padding(6, 10, 6, 10);
            this.roundedTextBoxSize.PasswordChar = false;
            this.roundedTextBoxSize.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.roundedTextBoxSize.PlaceholderText = "";
            this.roundedTextBoxSize.Size = new System.Drawing.Size(323, 43);
            this.roundedTextBoxSize.TabIndex = 58;
            this.roundedTextBoxSize.Texts = "";
            this.roundedTextBoxSize.UnderlinedStyle = false;
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("DM Serif Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.labelDescription.Location = new System.Drawing.Point(35, 219);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(65, 22);
            this.labelDescription.TabIndex = 63;
            this.labelDescription.Text = "Correo:";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("DM Serif Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.labelName.Location = new System.Drawing.Point(35, 76);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(73, 22);
            this.labelName.TabIndex = 62;
            this.labelName.Text = "Nombre:";
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
            this.roundedTextBoxDescription.Location = new System.Drawing.Point(31, 241);
            this.roundedTextBoxDescription.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.roundedTextBoxDescription.Multiline = true;
            this.roundedTextBoxDescription.Name = "roundedTextBoxDescription";
            this.roundedTextBoxDescription.Padding = new System.Windows.Forms.Padding(6, 10, 6, 10);
            this.roundedTextBoxDescription.PasswordChar = false;
            this.roundedTextBoxDescription.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.roundedTextBoxDescription.PlaceholderText = "";
            this.roundedTextBoxDescription.Size = new System.Drawing.Size(323, 104);
            this.roundedTextBoxDescription.TabIndex = 59;
            this.roundedTextBoxDescription.Texts = "";
            this.roundedTextBoxDescription.UnderlinedStyle = false;
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
            this.roundedTextBoxName.Location = new System.Drawing.Point(31, 98);
            this.roundedTextBoxName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.roundedTextBoxName.Multiline = false;
            this.roundedTextBoxName.Name = "roundedTextBoxName";
            this.roundedTextBoxName.Padding = new System.Windows.Forms.Padding(6, 10, 6, 10);
            this.roundedTextBoxName.PasswordChar = false;
            this.roundedTextBoxName.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.roundedTextBoxName.PlaceholderText = "";
            this.roundedTextBoxName.Size = new System.Drawing.Size(323, 43);
            this.roundedTextBoxName.TabIndex = 57;
            this.roundedTextBoxName.Texts = "";
            this.roundedTextBoxName.UnderlinedStyle = false;
            // 
            // FormCreateRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(384, 410);
            this.Controls.Add(this.roundedButtonCancel);
            this.Controls.Add(this.roundedButtonSave);
            this.Controls.Add(this.labelSize);
            this.Controls.Add(this.roundedTextBoxSize);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.roundedTextBoxDescription);
            this.Controls.Add(this.roundedTextBoxName);
            this.Controls.Add(this.labelTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormCreateRoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCreateRooms";
            this.Load += new System.EventHandler(this.FormCreateRoom_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private GigFinder.Controls.RoundedButton roundedButtonCancel;
        private GigFinder.Controls.RoundedButton roundedButtonSave;
        private System.Windows.Forms.Label labelSize;
        private GigFinder.Controls.RoundedTextBox roundedTextBoxSize;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelName;
        private GigFinder.Controls.RoundedTextBox roundedTextBoxDescription;
        private GigFinder.Controls.RoundedTextBox roundedTextBoxName;
    }
}
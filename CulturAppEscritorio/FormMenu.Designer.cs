namespace CulturAppEscritorio
{
    partial class FormMenu
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
            this.customPanelLogin = new GigFinder.Controls.CustomPanel();
            this.customPanelEvents = new GigFinder.Controls.CustomPanel();
            this.pictureBoxEvents = new System.Windows.Forms.PictureBox();
            this.customPanelRooms = new GigFinder.Controls.CustomPanel();
            this.pictureBoxRooms = new System.Windows.Forms.PictureBox();
            this.customPanelTikets = new GigFinder.Controls.CustomPanel();
            this.pictureBoxTikets = new System.Windows.Forms.PictureBox();
            this.customPanelUsers = new GigFinder.Controls.CustomPanel();
            this.pictureBoxUsers = new System.Windows.Forms.PictureBox();
            this.customPanelLogin.SuspendLayout();
            this.customPanelEvents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEvents)).BeginInit();
            this.customPanelRooms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRooms)).BeginInit();
            this.customPanelTikets.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTikets)).BeginInit();
            this.customPanelUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // customPanelLogin
            // 
            this.customPanelLogin.BackColor = System.Drawing.Color.White;
            this.customPanelLogin.BorderRadius = 8;
            this.customPanelLogin.Controls.Add(this.customPanelEvents);
            this.customPanelLogin.Controls.Add(this.customPanelRooms);
            this.customPanelLogin.Controls.Add(this.customPanelTikets);
            this.customPanelLogin.Controls.Add(this.customPanelUsers);
            this.customPanelLogin.Location = new System.Drawing.Point(292, 55);
            this.customPanelLogin.Name = "customPanelLogin";
            this.customPanelLogin.Size = new System.Drawing.Size(600, 550);
            this.customPanelLogin.TabIndex = 2;
            // 
            // customPanelEvents
            // 
            this.customPanelEvents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(242)))), ((int)(((byte)(233)))));
            this.customPanelEvents.BorderRadius = 8;
            this.customPanelEvents.Controls.Add(this.pictureBoxEvents);
            this.customPanelEvents.Location = new System.Drawing.Point(60, 300);
            this.customPanelEvents.Name = "customPanelEvents";
            this.customPanelEvents.Size = new System.Drawing.Size(200, 200);
            this.customPanelEvents.TabIndex = 3;
            this.customPanelEvents.Click += new System.EventHandler(this.customPanelEvents_Click);
            // 
            // pictureBoxEvents
            // 
            this.pictureBoxEvents.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxEvents.BackgroundImage = global::CulturAppEscritorio.Properties.Resources.events;
            this.pictureBoxEvents.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxEvents.Location = new System.Drawing.Point(37, 26);
            this.pictureBoxEvents.Name = "pictureBoxEvents";
            this.pictureBoxEvents.Size = new System.Drawing.Size(125, 144);
            this.pictureBoxEvents.TabIndex = 3;
            this.pictureBoxEvents.TabStop = false;
            this.pictureBoxEvents.Click += new System.EventHandler(this.pictureBoxEvents_Click);
            // 
            // customPanelRooms
            // 
            this.customPanelRooms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(242)))), ((int)(((byte)(233)))));
            this.customPanelRooms.BorderRadius = 8;
            this.customPanelRooms.Controls.Add(this.pictureBoxRooms);
            this.customPanelRooms.Location = new System.Drawing.Point(340, 300);
            this.customPanelRooms.Name = "customPanelRooms";
            this.customPanelRooms.Size = new System.Drawing.Size(200, 200);
            this.customPanelRooms.TabIndex = 3;
            this.customPanelRooms.Click += new System.EventHandler(this.customPanelRooms_Click);
            // 
            // pictureBoxRooms
            // 
            this.pictureBoxRooms.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxRooms.BackgroundImage = global::CulturAppEscritorio.Properties.Resources.rooms;
            this.pictureBoxRooms.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxRooms.Location = new System.Drawing.Point(38, 26);
            this.pictureBoxRooms.Name = "pictureBoxRooms";
            this.pictureBoxRooms.Size = new System.Drawing.Size(125, 144);
            this.pictureBoxRooms.TabIndex = 4;
            this.pictureBoxRooms.TabStop = false;
            this.pictureBoxRooms.Click += new System.EventHandler(this.pictureBoxRooms_Click);
            // 
            // customPanelTikets
            // 
            this.customPanelTikets.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(242)))), ((int)(((byte)(233)))));
            this.customPanelTikets.BorderRadius = 8;
            this.customPanelTikets.Controls.Add(this.pictureBoxTikets);
            this.customPanelTikets.Location = new System.Drawing.Point(340, 50);
            this.customPanelTikets.Name = "customPanelTikets";
            this.customPanelTikets.Size = new System.Drawing.Size(200, 200);
            this.customPanelTikets.TabIndex = 3;
            this.customPanelTikets.Click += new System.EventHandler(this.customPanelTikets_Click);
            // 
            // pictureBoxTikets
            // 
            this.pictureBoxTikets.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxTikets.BackgroundImage = global::CulturAppEscritorio.Properties.Resources.tikets;
            this.pictureBoxTikets.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxTikets.Location = new System.Drawing.Point(38, 26);
            this.pictureBoxTikets.Name = "pictureBoxTikets";
            this.pictureBoxTikets.Size = new System.Drawing.Size(125, 144);
            this.pictureBoxTikets.TabIndex = 2;
            this.pictureBoxTikets.TabStop = false;
            this.pictureBoxTikets.Click += new System.EventHandler(this.pictureBoxTikets_Click);
            // 
            // customPanelUsers
            // 
            this.customPanelUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(242)))), ((int)(((byte)(233)))));
            this.customPanelUsers.BorderRadius = 8;
            this.customPanelUsers.Controls.Add(this.pictureBoxUsers);
            this.customPanelUsers.Location = new System.Drawing.Point(60, 50);
            this.customPanelUsers.Name = "customPanelUsers";
            this.customPanelUsers.Size = new System.Drawing.Size(200, 200);
            this.customPanelUsers.TabIndex = 2;
            this.customPanelUsers.Click += new System.EventHandler(this.customPanelUsers_Click);
            // 
            // pictureBoxUsers
            // 
            this.pictureBoxUsers.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxUsers.BackgroundImage = global::CulturAppEscritorio.Properties.Resources.users;
            this.pictureBoxUsers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxUsers.Location = new System.Drawing.Point(37, 26);
            this.pictureBoxUsers.Name = "pictureBoxUsers";
            this.pictureBoxUsers.Size = new System.Drawing.Size(125, 144);
            this.pictureBoxUsers.TabIndex = 1;
            this.pictureBoxUsers.TabStop = false;
            this.pictureBoxUsers.Click += new System.EventHandler(this.pictureBoxUsers_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CulturAppEscritorio.Properties.Resources.fondoescritorio;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.customPanelLogin);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMenu";
            this.Text = "FormMenu";
            this.customPanelLogin.ResumeLayout(false);
            this.customPanelEvents.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEvents)).EndInit();
            this.customPanelRooms.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRooms)).EndInit();
            this.customPanelTikets.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTikets)).EndInit();
            this.customPanelUsers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUsers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GigFinder.Controls.CustomPanel customPanelLogin;
        private GigFinder.Controls.CustomPanel customPanelEvents;
        private System.Windows.Forms.PictureBox pictureBoxEvents;
        private GigFinder.Controls.CustomPanel customPanelRooms;
        private System.Windows.Forms.PictureBox pictureBoxRooms;
        private GigFinder.Controls.CustomPanel customPanelTikets;
        private System.Windows.Forms.PictureBox pictureBoxTikets;
        private GigFinder.Controls.CustomPanel customPanelUsers;
        private System.Windows.Forms.PictureBox pictureBoxUsers;
    }
}
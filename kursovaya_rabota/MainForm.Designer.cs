namespace kursovaya_rabota
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.topPanel1 = new System.Windows.Forms.Panel();
            this.CloseApplication = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogout_Click = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnSearchRecords = new System.Windows.Forms.Button();
            this.btnRegisterDeath = new System.Windows.Forms.Button();
            this.btnRegisterBirth = new System.Windows.Forms.Button();
            this.lblGreeting = new System.Windows.Forms.Label();
            this.btnAdminPanel = new System.Windows.Forms.Button();
            this.topPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel1
            // 
            this.topPanel1.BackColor = System.Drawing.Color.White;
            this.topPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.topPanel1.Controls.Add(this.CloseApplication);
            this.topPanel1.Controls.Add(this.label1);
            this.topPanel1.Controls.Add(this.btnLogout_Click);
            this.topPanel1.Controls.Add(this.btnAbout);
            this.topPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.topPanel1.Location = new System.Drawing.Point(0, -5);
            this.topPanel1.Name = "topPanel1";
            this.topPanel1.Size = new System.Drawing.Size(802, 53);
            this.topPanel1.TabIndex = 12;
            // 
            // CloseApplication
            // 
            this.CloseApplication.BackColor = System.Drawing.Color.Transparent;
            this.CloseApplication.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CloseApplication.BackgroundImage")));
            this.CloseApplication.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CloseApplication.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseApplication.FlatAppearance.BorderSize = 0;
            this.CloseApplication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseApplication.Location = new System.Drawing.Point(748, 6);
            this.CloseApplication.Name = "CloseApplication";
            this.CloseApplication.Size = new System.Drawing.Size(49, 45);
            this.CloseApplication.TabIndex = 15;
            this.CloseApplication.UseVisualStyleBackColor = false;
            this.CloseApplication.Click += new System.EventHandler(this.CloseApplication_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(276, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 29);
            this.label1.TabIndex = 13;
            this.label1.Text = "Домашняя страница";
            // 
            // btnLogout_Click
            // 
            this.btnLogout_Click.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout_Click.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogout_Click.BackgroundImage")));
            this.btnLogout_Click.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogout_Click.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout_Click.FlatAppearance.BorderSize = 0;
            this.btnLogout_Click.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout_Click.Location = new System.Drawing.Point(699, 3);
            this.btnLogout_Click.Name = "btnLogout_Click";
            this.btnLogout_Click.Size = new System.Drawing.Size(52, 55);
            this.btnLogout_Click.TabIndex = 0;
            this.btnLogout_Click.UseVisualStyleBackColor = false;
            this.btnLogout_Click.Click += new System.EventHandler(this.btnLogout_Click_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.BackColor = System.Drawing.Color.Transparent;
            this.btnAbout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAbout.BackgroundImage")));
            this.btnAbout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAbout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAbout.FlatAppearance.BorderSize = 0;
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAbout.Location = new System.Drawing.Point(4, -3);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(50, 62);
            this.btnAbout.TabIndex = 11;
            this.btnAbout.UseVisualStyleBackColor = false;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnSearchRecords
            // 
            this.btnSearchRecords.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSearchRecords.Location = new System.Drawing.Point(216, 327);
            this.btnSearchRecords.Name = "btnSearchRecords";
            this.btnSearchRecords.Size = new System.Drawing.Size(385, 64);
            this.btnSearchRecords.TabIndex = 3;
            this.btnSearchRecords.Text = "Поиск записей";
            this.btnSearchRecords.UseVisualStyleBackColor = true;
            this.btnSearchRecords.Click += new System.EventHandler(this.btnSearchRecords_Click);
            // 
            // btnRegisterDeath
            // 
            this.btnRegisterDeath.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegisterDeath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRegisterDeath.Location = new System.Drawing.Point(216, 246);
            this.btnRegisterDeath.Name = "btnRegisterDeath";
            this.btnRegisterDeath.Size = new System.Drawing.Size(385, 64);
            this.btnRegisterDeath.TabIndex = 2;
            this.btnRegisterDeath.Text = "Регистрация смерти";
            this.btnRegisterDeath.UseVisualStyleBackColor = true;
            this.btnRegisterDeath.Click += new System.EventHandler(this.btnRegisterDeath_Click);
            // 
            // btnRegisterBirth
            // 
            this.btnRegisterBirth.BackColor = System.Drawing.Color.Transparent;
            this.btnRegisterBirth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegisterBirth.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(19)))), ((int)(((byte)(15)))));
            this.btnRegisterBirth.FlatAppearance.BorderSize = 0;
            this.btnRegisterBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRegisterBirth.Location = new System.Drawing.Point(216, 165);
            this.btnRegisterBirth.Name = "btnRegisterBirth";
            this.btnRegisterBirth.Size = new System.Drawing.Size(385, 64);
            this.btnRegisterBirth.TabIndex = 5;
            this.btnRegisterBirth.Text = "Регистрация рождения";
            this.btnRegisterBirth.UseVisualStyleBackColor = false;
            this.btnRegisterBirth.Click += new System.EventHandler(this.btnRegisterBirth_Click_1);
            // 
            // lblGreeting
            // 
            this.lblGreeting.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblGreeting.Location = new System.Drawing.Point(110, 85);
            this.lblGreeting.Name = "lblGreeting";
            this.lblGreeting.Size = new System.Drawing.Size(597, 59);
            this.lblGreeting.TabIndex = 14;
            this.lblGreeting.Text = "Приветствие";
            this.lblGreeting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAdminPanel
            // 
            this.btnAdminPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdminPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAdminPanel.Location = new System.Drawing.Point(647, 418);
            this.btnAdminPanel.Name = "btnAdminPanel";
            this.btnAdminPanel.Size = new System.Drawing.Size(153, 32);
            this.btnAdminPanel.TabIndex = 15;
            this.btnAdminPanel.Text = "Для админа";
            this.btnAdminPanel.UseVisualStyleBackColor = true;
            this.btnAdminPanel.Visible = false;
            this.btnAdminPanel.Click += new System.EventHandler(this.btnAdminPanel_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAdminPanel);
            this.Controls.Add(this.btnSearchRecords);
            this.Controls.Add(this.btnRegisterDeath);
            this.Controls.Add(this.lblGreeting);
            this.Controls.Add(this.topPanel1);
            this.Controls.Add(this.btnRegisterBirth);
            this.Name = "MainForm";
            this.Text = "Домашняя страница";
            this.Load += new System.EventHandler(this.MainForm_Load_1);
            this.topPanel1.ResumeLayout(false);
            this.topPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLogout_Click;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Panel topPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CloseApplication;
        private System.Windows.Forms.Button btnSearchRecords;
        private System.Windows.Forms.Button btnRegisterDeath;
        private System.Windows.Forms.Button btnRegisterBirth;
        private System.Windows.Forms.Label lblGreeting;
        private System.Windows.Forms.Button btnAdminPanel;
    }
}
namespace kursovaya_rabota
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.topPanel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.nazad = new System.Windows.Forms.Button();
            this.CloseApplication = new System.Windows.Forms.Button();
            this.btnLogout_Click = new System.Windows.Forms.Button();
            this.btnUserManag = new System.Windows.Forms.Button();
            this.btnAssigRol = new System.Windows.Forms.Button();
            this.btnActionLog = new System.Windows.Forms.Button();
            this.topPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel1
            // 
            this.topPanel1.BackColor = System.Drawing.Color.White;
            this.topPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.topPanel1.Controls.Add(this.nazad);
            this.topPanel1.Controls.Add(this.CloseApplication);
            this.topPanel1.Controls.Add(this.label1);
            this.topPanel1.Controls.Add(this.btnLogout_Click);
            this.topPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.topPanel1.Location = new System.Drawing.Point(-1, 0);
            this.topPanel1.Name = "topPanel1";
            this.topPanel1.Size = new System.Drawing.Size(802, 53);
            this.topPanel1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(212, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(393, 29);
            this.label1.TabIndex = 13;
            this.label1.Text = "Страница для администратора";
            // 
            // nazad
            // 
            this.nazad.BackColor = System.Drawing.Color.Transparent;
            this.nazad.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("nazad.BackgroundImage")));
            this.nazad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.nazad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nazad.FlatAppearance.BorderSize = 0;
            this.nazad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nazad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nazad.Location = new System.Drawing.Point(4, -4);
            this.nazad.Name = "nazad";
            this.nazad.Size = new System.Drawing.Size(50, 62);
            this.nazad.TabIndex = 14;
            this.nazad.UseVisualStyleBackColor = false;
            this.nazad.Click += new System.EventHandler(this.nazad_Click_1);
            // 
            // CloseApplication
            // 
            this.CloseApplication.BackColor = System.Drawing.Color.Transparent;
            this.CloseApplication.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CloseApplication.BackgroundImage")));
            this.CloseApplication.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CloseApplication.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseApplication.FlatAppearance.BorderSize = 0;
            this.CloseApplication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseApplication.Location = new System.Drawing.Point(748, 4);
            this.CloseApplication.Name = "CloseApplication";
            this.CloseApplication.Size = new System.Drawing.Size(49, 45);
            this.CloseApplication.TabIndex = 15;
            this.CloseApplication.UseVisualStyleBackColor = false;
            this.CloseApplication.Click += new System.EventHandler(this.CloseApplication_Click_1);
            // 
            // btnLogout_Click
            // 
            this.btnLogout_Click.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout_Click.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogout_Click.BackgroundImage")));
            this.btnLogout_Click.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogout_Click.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout_Click.FlatAppearance.BorderSize = 0;
            this.btnLogout_Click.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout_Click.Location = new System.Drawing.Point(699, 1);
            this.btnLogout_Click.Name = "btnLogout_Click";
            this.btnLogout_Click.Size = new System.Drawing.Size(52, 55);
            this.btnLogout_Click.TabIndex = 0;
            this.btnLogout_Click.UseVisualStyleBackColor = false;
            this.btnLogout_Click.Click += new System.EventHandler(this.btnLogout_Click_Click);
            // 
            // btnUserManag
            // 
            this.btnUserManag.BackColor = System.Drawing.Color.Transparent;
            this.btnUserManag.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUserManag.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(19)))), ((int)(((byte)(15)))));
            this.btnUserManag.FlatAppearance.BorderSize = 0;
            this.btnUserManag.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnUserManag.Location = new System.Drawing.Point(216, 142);
            this.btnUserManag.Name = "btnUserManag";
            this.btnUserManag.Size = new System.Drawing.Size(385, 64);
            this.btnUserManag.TabIndex = 14;
            this.btnUserManag.Text = "Управление пользователями";
            this.btnUserManag.UseVisualStyleBackColor = false;
            this.btnUserManag.Click += new System.EventHandler(this.btnUserManag_Click);
            // 
            // btnAssigRol
            // 
            this.btnAssigRol.BackColor = System.Drawing.Color.Transparent;
            this.btnAssigRol.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAssigRol.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(19)))), ((int)(((byte)(15)))));
            this.btnAssigRol.FlatAppearance.BorderSize = 0;
            this.btnAssigRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAssigRol.Location = new System.Drawing.Point(216, 223);
            this.btnAssigRol.Name = "btnAssigRol";
            this.btnAssigRol.Size = new System.Drawing.Size(385, 64);
            this.btnAssigRol.TabIndex = 15;
            this.btnAssigRol.Text = "Назначение ролей";
            this.btnAssigRol.UseVisualStyleBackColor = false;
            this.btnAssigRol.Click += new System.EventHandler(this.btnAssigRol_Click);
            // 
            // btnActionLog
            // 
            this.btnActionLog.BackColor = System.Drawing.Color.Transparent;
            this.btnActionLog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActionLog.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(19)))), ((int)(((byte)(15)))));
            this.btnActionLog.FlatAppearance.BorderSize = 0;
            this.btnActionLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnActionLog.Location = new System.Drawing.Point(216, 304);
            this.btnActionLog.Name = "btnActionLog";
            this.btnActionLog.Size = new System.Drawing.Size(385, 64);
            this.btnActionLog.TabIndex = 16;
            this.btnActionLog.Text = "Журнал действий";
            this.btnActionLog.UseVisualStyleBackColor = false;
            this.btnActionLog.Click += new System.EventHandler(this.btnActionLog_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnActionLog);
            this.Controls.Add(this.btnAssigRol);
            this.Controls.Add(this.btnUserManag);
            this.Controls.Add(this.topPanel1);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.topPanel1.ResumeLayout(false);
            this.topPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topPanel1;
        private System.Windows.Forms.Button CloseApplication;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogout_Click;
        private System.Windows.Forms.Button nazad;
        private System.Windows.Forms.Button btnUserManag;
        private System.Windows.Forms.Button btnAssigRol;
        private System.Windows.Forms.Button btnActionLog;
    }
}
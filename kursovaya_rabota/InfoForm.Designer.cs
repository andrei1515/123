namespace kursovaya_rabota
{
    partial class InfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfoForm));
            this.topPanel = new System.Windows.Forms.Panel();
            this.CloseApplication = new System.Windows.Forms.Button();
            this.nazad = new System.Windows.Forms.Button();
            this.o_programme = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.labelInfa = new System.Windows.Forms.Label();
            this.topPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.White;
            this.topPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.topPanel.Controls.Add(this.CloseApplication);
            this.topPanel.Controls.Add(this.nazad);
            this.topPanel.Controls.Add(this.o_programme);
            this.topPanel.Controls.Add(this.btnLogout);
            this.topPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.topPanel.Location = new System.Drawing.Point(-1, -1);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(802, 53);
            this.topPanel.TabIndex = 28;
            // 
            // CloseApplication
            // 
            this.CloseApplication.BackColor = System.Drawing.Color.Transparent;
            this.CloseApplication.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CloseApplication.BackgroundImage")));
            this.CloseApplication.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CloseApplication.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseApplication.FlatAppearance.BorderSize = 0;
            this.CloseApplication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseApplication.Location = new System.Drawing.Point(748, 3);
            this.CloseApplication.Name = "CloseApplication";
            this.CloseApplication.Size = new System.Drawing.Size(49, 45);
            this.CloseApplication.TabIndex = 14;
            this.CloseApplication.UseVisualStyleBackColor = false;
            this.CloseApplication.Click += new System.EventHandler(this.CloseApplication_Click);
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
            this.nazad.TabIndex = 13;
            this.nazad.UseVisualStyleBackColor = false;
            this.nazad.Click += new System.EventHandler(this.nazad_Click);
            // 
            // o_programme
            // 
            this.o_programme.AutoSize = true;
            this.o_programme.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.o_programme.Location = new System.Drawing.Point(318, 12);
            this.o_programme.Name = "o_programme";
            this.o_programme.Size = new System.Drawing.Size(162, 27);
            this.o_programme.TabIndex = 13;
            this.o_programme.Text = "О программе";
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogout.BackgroundImage")));
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Location = new System.Drawing.Point(697, 1);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(52, 55);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // labelInfa
            // 
            this.labelInfa.AutoSize = true;
            this.labelInfa.Location = new System.Drawing.Point(1, 52);
            this.labelInfa.Name = "labelInfa";
            this.labelInfa.Size = new System.Drawing.Size(92, 16);
            this.labelInfa.TabIndex = 31;
            this.labelInfa.Text = "Информация";
            // 
            // InfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelInfa);
            this.Controls.Add(this.topPanel);
            this.Name = "InfoForm";
            this.Text = "О программе";
            this.Load += new System.EventHandler(this.InfoForm_Load);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Button CloseApplication;
        private System.Windows.Forms.Button nazad;
        private System.Windows.Forms.Label o_programme;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label labelInfa;
    }
}
namespace kursovaya_rabota
{
    partial class DeathForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeathForm));
            this.topPanel1 = new System.Windows.Forms.Panel();
            this.CloseApplication = new System.Windows.Forms.Button();
            this.nazad = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panelSvedeniya = new System.Windows.Forms.Panel();
            this.Svedeniya = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.tbPlaceholderGender = new System.Windows.Forms.TextBox();
            this.txtDeathPlace = new System.Windows.Forms.TextBox();
            this.txtBirthPlace = new System.Windows.Forms.TextBox();
            this.dtpChildDeath = new System.Windows.Forms.DateTimePicker();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.txtChildPatronymic = new System.Windows.Forms.TextBox();
            this.dtpChildBirth = new System.Windows.Forms.DateTimePicker();
            this.txtChildFirstName = new System.Windows.Forms.TextBox();
            this.panelpodSvedeniya = new System.Windows.Forms.Panel();
            this.txtChildLastName = new System.Windows.Forms.TextBox();
            this.panelDocument = new System.Windows.Forms.Panel();
            this.txtSeriesPasport = new System.Windows.Forms.TextBox();
            this.panelPasport = new System.Windows.Forms.Panel();
            this.Pasport = new System.Windows.Forms.Label();
            this.txtExtradition = new System.Windows.Forms.TextBox();
            this.txtNumberPasport = new System.Windows.Forms.TextBox();
            this.dtpExtradition = new System.Windows.Forms.DateTimePicker();
            this.panelpodPasport = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.rbPassport = new System.Windows.Forms.RadioButton();
            this.rbCertificate = new System.Windows.Forms.RadioButton();
            this.topPanel1.SuspendLayout();
            this.panelSvedeniya.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panelDocument.SuspendLayout();
            this.panelPasport.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel1
            // 
            this.topPanel1.BackColor = System.Drawing.Color.White;
            this.topPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.topPanel1.Controls.Add(this.CloseApplication);
            this.topPanel1.Controls.Add(this.nazad);
            this.topPanel1.Controls.Add(this.label1);
            this.topPanel1.Controls.Add(this.btnLogout);
            this.topPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.topPanel1.Location = new System.Drawing.Point(-1, 1);
            this.topPanel1.Name = "topPanel1";
            this.topPanel1.Size = new System.Drawing.Size(802, 53);
            this.topPanel1.TabIndex = 28;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(274, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 29);
            this.label1.TabIndex = 13;
            this.label1.Text = "Регистрация смерти";
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
            // panelSvedeniya
            // 
            this.panelSvedeniya.BackColor = System.Drawing.Color.Transparent;
            this.panelSvedeniya.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSvedeniya.Controls.Add(this.Svedeniya);
            this.panelSvedeniya.Location = new System.Drawing.Point(-1, 0);
            this.panelSvedeniya.Name = "panelSvedeniya";
            this.panelSvedeniya.Size = new System.Drawing.Size(732, 32);
            this.panelSvedeniya.TabIndex = 41;
            // 
            // Svedeniya
            // 
            this.Svedeniya.AutoSize = true;
            this.Svedeniya.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Svedeniya.Location = new System.Drawing.Point(217, -1);
            this.Svedeniya.Name = "Svedeniya";
            this.Svedeniya.Size = new System.Drawing.Size(297, 29);
            this.Svedeniya.TabIndex = 14;
            this.Svedeniya.Text = "Сведения об умершем";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Transparent;
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.tbPlaceholderGender);
            this.panel8.Controls.Add(this.txtDeathPlace);
            this.panel8.Controls.Add(this.panelSvedeniya);
            this.panel8.Controls.Add(this.txtBirthPlace);
            this.panel8.Controls.Add(this.dtpChildDeath);
            this.panel8.Controls.Add(this.cbGender);
            this.panel8.Controls.Add(this.txtChildPatronymic);
            this.panel8.Controls.Add(this.dtpChildBirth);
            this.panel8.Controls.Add(this.txtChildFirstName);
            this.panel8.Controls.Add(this.panelpodSvedeniya);
            this.panel8.Controls.Add(this.txtChildLastName);
            this.panel8.Location = new System.Drawing.Point(38, 66);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(732, 186);
            this.panel8.TabIndex = 43;
            // 
            // tbPlaceholderGender
            // 
            this.tbPlaceholderGender.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPlaceholderGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPlaceholderGender.ForeColor = System.Drawing.Color.Gray;
            this.tbPlaceholderGender.Location = new System.Drawing.Point(24, 102);
            this.tbPlaceholderGender.Name = "tbPlaceholderGender";
            this.tbPlaceholderGender.Size = new System.Drawing.Size(67, 23);
            this.tbPlaceholderGender.TabIndex = 42;
            this.tbPlaceholderGender.Text = "Пол";
            // 
            // txtDeathPlace
            // 
            this.txtDeathPlace.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtDeathPlace.ForeColor = System.Drawing.Color.Gray;
            this.txtDeathPlace.Location = new System.Drawing.Point(385, 145);
            this.txtDeathPlace.Name = "txtDeathPlace";
            this.txtDeathPlace.Size = new System.Drawing.Size(225, 30);
            this.txtDeathPlace.TabIndex = 34;
            this.txtDeathPlace.Text = "Место смерти";
            this.txtDeathPlace.Enter += new System.EventHandler(this.textBox1_Enter);
            this.txtDeathPlace.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // txtBirthPlace
            // 
            this.txtBirthPlace.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBirthPlace.ForeColor = System.Drawing.Color.Gray;
            this.txtBirthPlace.Location = new System.Drawing.Point(121, 145);
            this.txtBirthPlace.Name = "txtBirthPlace";
            this.txtBirthPlace.Size = new System.Drawing.Size(225, 30);
            this.txtBirthPlace.TabIndex = 31;
            this.txtBirthPlace.Text = "Место рождения";
            this.txtBirthPlace.Enter += new System.EventHandler(this.txtBirthPlace_Enter);
            this.txtBirthPlace.Leave += new System.EventHandler(this.txtBirthPlace_Leave);
            // 
            // dtpChildDeath
            // 
            this.dtpChildDeath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtpChildDeath.Location = new System.Drawing.Point(490, 97);
            this.dtpChildDeath.Name = "dtpChildDeath";
            this.dtpChildDeath.Size = new System.Drawing.Size(225, 30);
            this.dtpChildDeath.TabIndex = 33;
            this.dtpChildDeath.ValueChanged += new System.EventHandler(this.dtpChildDeath_ValueChanged);
            // 
            // cbGender
            // 
            this.cbGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbGender.ForeColor = System.Drawing.Color.Black;
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Location = new System.Drawing.Point(17, 97);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(225, 33);
            this.cbGender.TabIndex = 33;
            this.cbGender.DropDown += new System.EventHandler(this.cbGender_DropDown);
            this.cbGender.DropDownClosed += new System.EventHandler(this.cbGender_DropDownClosed);
            // 
            // txtChildPatronymic
            // 
            this.txtChildPatronymic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtChildPatronymic.ForeColor = System.Drawing.Color.Gray;
            this.txtChildPatronymic.Location = new System.Drawing.Point(490, 49);
            this.txtChildPatronymic.Name = "txtChildPatronymic";
            this.txtChildPatronymic.Size = new System.Drawing.Size(225, 30);
            this.txtChildPatronymic.TabIndex = 30;
            this.txtChildPatronymic.Text = "Отчество";
            this.txtChildPatronymic.Enter += new System.EventHandler(this.txtChildPatronymic_Enter);
            this.txtChildPatronymic.Leave += new System.EventHandler(this.txtChildPatronymic_Leave);
            // 
            // dtpChildBirth
            // 
            this.dtpChildBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtpChildBirth.Location = new System.Drawing.Point(253, 97);
            this.dtpChildBirth.Name = "dtpChildBirth";
            this.dtpChildBirth.Size = new System.Drawing.Size(225, 30);
            this.dtpChildBirth.TabIndex = 32;
            this.dtpChildBirth.ValueChanged += new System.EventHandler(this.dtpChildBirth_ValueChanged);
            // 
            // txtChildFirstName
            // 
            this.txtChildFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtChildFirstName.ForeColor = System.Drawing.Color.Gray;
            this.txtChildFirstName.Location = new System.Drawing.Point(253, 49);
            this.txtChildFirstName.Name = "txtChildFirstName";
            this.txtChildFirstName.Size = new System.Drawing.Size(225, 30);
            this.txtChildFirstName.TabIndex = 29;
            this.txtChildFirstName.Text = "Имя";
            this.txtChildFirstName.Enter += new System.EventHandler(this.txtChildFirstName_Enter);
            this.txtChildFirstName.Leave += new System.EventHandler(this.txtChildFirstName_Leave);
            // 
            // panelpodSvedeniya
            // 
            this.panelpodSvedeniya.BackColor = System.Drawing.Color.Transparent;
            this.panelpodSvedeniya.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelpodSvedeniya.Location = new System.Drawing.Point(-1, 32);
            this.panelpodSvedeniya.Name = "panelpodSvedeniya";
            this.panelpodSvedeniya.Size = new System.Drawing.Size(732, 10);
            this.panelpodSvedeniya.TabIndex = 28;
            // 
            // txtChildLastName
            // 
            this.txtChildLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtChildLastName.ForeColor = System.Drawing.Color.Gray;
            this.txtChildLastName.Location = new System.Drawing.Point(17, 49);
            this.txtChildLastName.Name = "txtChildLastName";
            this.txtChildLastName.Size = new System.Drawing.Size(225, 30);
            this.txtChildLastName.TabIndex = 14;
            this.txtChildLastName.Text = "Фамилия";
            this.txtChildLastName.Enter += new System.EventHandler(this.txtChildLastName_Enter);
            this.txtChildLastName.Leave += new System.EventHandler(this.txtChildLastName_Leave);
            // 
            // panelDocument
            // 
            this.panelDocument.BackColor = System.Drawing.Color.Transparent;
            this.panelDocument.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDocument.Controls.Add(this.txtSeriesPasport);
            this.panelDocument.Controls.Add(this.panelPasport);
            this.panelDocument.Controls.Add(this.txtExtradition);
            this.panelDocument.Controls.Add(this.txtNumberPasport);
            this.panelDocument.Controls.Add(this.dtpExtradition);
            this.panelDocument.Controls.Add(this.panelpodPasport);
            this.panelDocument.Location = new System.Drawing.Point(38, 258);
            this.panelDocument.Name = "panelDocument";
            this.panelDocument.Size = new System.Drawing.Size(732, 142);
            this.panelDocument.TabIndex = 44;
            // 
            // txtSeriesPasport
            // 
            this.txtSeriesPasport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtSeriesPasport.ForeColor = System.Drawing.Color.Gray;
            this.txtSeriesPasport.Location = new System.Drawing.Point(17, 49);
            this.txtSeriesPasport.Name = "txtSeriesPasport";
            this.txtSeriesPasport.Size = new System.Drawing.Size(225, 30);
            this.txtSeriesPasport.TabIndex = 14;
            this.txtSeriesPasport.Text = "Серия документа";
            this.txtSeriesPasport.Enter += new System.EventHandler(this.txtSeriesPasport_Enter);
            this.txtSeriesPasport.Leave += new System.EventHandler(this.txtSeriesPasport_Leave);
            // 
            // panelPasport
            // 
            this.panelPasport.BackColor = System.Drawing.Color.Transparent;
            this.panelPasport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPasport.Controls.Add(this.Pasport);
            this.panelPasport.Location = new System.Drawing.Point(-1, 0);
            this.panelPasport.Name = "panelPasport";
            this.panelPasport.Size = new System.Drawing.Size(732, 32);
            this.panelPasport.TabIndex = 41;
            // 
            // Pasport
            // 
            this.Pasport.AutoSize = true;
            this.Pasport.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Pasport.Location = new System.Drawing.Point(297, -1);
            this.Pasport.Name = "Pasport";
            this.Pasport.Size = new System.Drawing.Size(137, 29);
            this.Pasport.TabIndex = 14;
            this.Pasport.Text = "Документ";
            // 
            // txtExtradition
            // 
            this.txtExtradition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtExtradition.ForeColor = System.Drawing.Color.Gray;
            this.txtExtradition.Location = new System.Drawing.Point(17, 96);
            this.txtExtradition.Name = "txtExtradition";
            this.txtExtradition.Size = new System.Drawing.Size(698, 30);
            this.txtExtradition.TabIndex = 31;
            this.txtExtradition.Text = "Кем выдан";
            this.txtExtradition.Enter += new System.EventHandler(this.txtExtradition_Enter);
            this.txtExtradition.Leave += new System.EventHandler(this.txtExtradition_Leave);
            // 
            // txtNumberPasport
            // 
            this.txtNumberPasport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtNumberPasport.ForeColor = System.Drawing.Color.Gray;
            this.txtNumberPasport.Location = new System.Drawing.Point(253, 49);
            this.txtNumberPasport.Name = "txtNumberPasport";
            this.txtNumberPasport.Size = new System.Drawing.Size(225, 30);
            this.txtNumberPasport.TabIndex = 30;
            this.txtNumberPasport.Text = "Номер документа";
            this.txtNumberPasport.Enter += new System.EventHandler(this.txtNumberPasport_Enter);
            this.txtNumberPasport.Leave += new System.EventHandler(this.txtNumberPasport_Leave);
            // 
            // dtpExtradition
            // 
            this.dtpExtradition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtpExtradition.Location = new System.Drawing.Point(490, 49);
            this.dtpExtradition.Name = "dtpExtradition";
            this.dtpExtradition.Size = new System.Drawing.Size(225, 30);
            this.dtpExtradition.TabIndex = 32;
            this.dtpExtradition.ValueChanged += new System.EventHandler(this.dtpExtradition_ValueChanged);
            // 
            // panelpodPasport
            // 
            this.panelpodPasport.BackColor = System.Drawing.Color.Transparent;
            this.panelpodPasport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelpodPasport.Location = new System.Drawing.Point(-1, 32);
            this.panelpodPasport.Name = "panelpodPasport";
            this.panelpodPasport.Size = new System.Drawing.Size(732, 10);
            this.panelpodPasport.TabIndex = 28;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(19)))), ((int)(((byte)(15)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSave.Location = new System.Drawing.Point(284, 406);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(249, 40);
            this.btnSave.TabIndex = 45;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // rbPassport
            // 
            this.rbPassport.AutoSize = true;
            this.rbPassport.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbPassport.Location = new System.Drawing.Point(38, 406);
            this.rbPassport.Name = "rbPassport";
            this.rbPassport.Size = new System.Drawing.Size(91, 20);
            this.rbPassport.TabIndex = 46;
            this.rbPassport.TabStop = true;
            this.rbPassport.Text = "Паспорт";
            this.rbPassport.UseVisualStyleBackColor = true;
            // 
            // rbCertificate
            // 
            this.rbCertificate.AutoSize = true;
            this.rbCertificate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbCertificate.Location = new System.Drawing.Point(38, 427);
            this.rbCertificate.Name = "rbCertificate";
            this.rbCertificate.Size = new System.Drawing.Size(232, 20);
            this.rbCertificate.TabIndex = 47;
            this.rbCertificate.TabStop = true;
            this.rbCertificate.Text = "Свидетельство о рождении";
            this.rbCertificate.UseVisualStyleBackColor = true;
            // 
            // DeathForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.rbPassport);
            this.Controls.Add(this.panelDocument);
            this.Controls.Add(this.rbCertificate);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.topPanel1);
            this.Name = "DeathForm";
            this.Text = "Регистрация смерти";
            this.Load += new System.EventHandler(this.DeathForm_Load);
            this.topPanel1.ResumeLayout(false);
            this.topPanel1.PerformLayout();
            this.panelSvedeniya.ResumeLayout(false);
            this.panelSvedeniya.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panelDocument.ResumeLayout(false);
            this.panelDocument.PerformLayout();
            this.panelPasport.ResumeLayout(false);
            this.panelPasport.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel topPanel1;
        private System.Windows.Forms.Button CloseApplication;
        private System.Windows.Forms.Button nazad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel panelSvedeniya;
        private System.Windows.Forms.Label Svedeniya;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.DateTimePicker dtpChildBirth;
        private System.Windows.Forms.TextBox txtBirthPlace;
        private System.Windows.Forms.TextBox txtChildPatronymic;
        private System.Windows.Forms.TextBox txtChildFirstName;
        private System.Windows.Forms.Panel panelpodSvedeniya;
        private System.Windows.Forms.TextBox txtChildLastName;
        private System.Windows.Forms.DateTimePicker dtpChildDeath;
        private System.Windows.Forms.TextBox txtDeathPlace;
        private System.Windows.Forms.Panel panelDocument;
        private System.Windows.Forms.Panel panelPasport;
        private System.Windows.Forms.Label Pasport;
        private System.Windows.Forms.TextBox txtExtradition;
        private System.Windows.Forms.TextBox txtNumberPasport;
        private System.Windows.Forms.DateTimePicker dtpExtradition;
        private System.Windows.Forms.Panel panelpodPasport;
        private System.Windows.Forms.TextBox txtSeriesPasport;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox tbPlaceholderGender;
        private System.Windows.Forms.RadioButton rbPassport;
        private System.Windows.Forms.RadioButton rbCertificate;
    }
}
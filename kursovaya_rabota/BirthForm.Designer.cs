namespace kursovaya_rabota
{
    partial class BirthForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BirthForm));
            this.topPanel1 = new System.Windows.Forms.Panel();
            this.CloseApplication = new System.Windows.Forms.Button();
            this.nazad = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtFatherFirstName = new System.Windows.Forms.TextBox();
            this.txtFatherCitizenship = new System.Windows.Forms.TextBox();
            this.txtFatherPlace = new System.Windows.Forms.TextBox();
            this.txtFatherPatronymic = new System.Windows.Forms.TextBox();
            this.dtpFatherBirth = new System.Windows.Forms.DateTimePicker();
            this.txtFatherLastName = new System.Windows.Forms.TextBox();
            this.Otec = new System.Windows.Forms.Label();
            this.panelpodPapa = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtMotherFirstName = new System.Windows.Forms.TextBox();
            this.txtMotherCitizenship = new System.Windows.Forms.TextBox();
            this.txtMotherPlace = new System.Windows.Forms.TextBox();
            this.txtMotherPatronymic = new System.Windows.Forms.TextBox();
            this.dtpMotherBirth = new System.Windows.Forms.DateTimePicker();
            this.txtMotherLastName = new System.Windows.Forms.TextBox();
            this.Mat = new System.Windows.Forms.Label();
            this.panelpodMama = new System.Windows.Forms.Panel();
            this.panelMama = new System.Windows.Forms.Panel();
            this.panelPapa = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.tbPlaceholderGender = new System.Windows.Forms.TextBox();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.dtpChildBirth = new System.Windows.Forms.DateTimePicker();
            this.txtBirthPlace = new System.Windows.Forms.TextBox();
            this.txtChildPatronymic = new System.Windows.Forms.TextBox();
            this.txtChildFirstName = new System.Windows.Forms.TextBox();
            this.panelpodRebenok = new System.Windows.Forms.Panel();
            this.txtChildLastName = new System.Windows.Forms.TextBox();
            this.panelRebenok = new System.Windows.Forms.Panel();
            this.Rebenok = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.topPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panelMama.SuspendLayout();
            this.panelPapa.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panelRebenok.SuspendLayout();
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
            this.topPanel1.Location = new System.Drawing.Point(-1, 0);
            this.topPanel1.Name = "topPanel1";
            this.topPanel1.Size = new System.Drawing.Size(802, 53);
            this.topPanel1.TabIndex = 27;
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
            this.label1.Location = new System.Drawing.Point(258, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 29);
            this.label1.TabIndex = 13;
            this.label1.Text = "Регистрация рождения";
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogout.BackgroundImage")));
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Location = new System.Drawing.Point(699, 1);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(52, 55);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.txtFatherFirstName);
            this.panel3.Controls.Add(this.txtFatherCitizenship);
            this.panel3.Controls.Add(this.txtFatherPlace);
            this.panel3.Controls.Add(this.txtFatherPatronymic);
            this.panel3.Controls.Add(this.dtpFatherBirth);
            this.panel3.Controls.Add(this.txtFatherLastName);
            this.panel3.Location = new System.Drawing.Point(408, 208);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(359, 191);
            this.panel3.TabIndex = 28;
            // 
            // txtFatherFirstName
            // 
            this.txtFatherFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtFatherFirstName.ForeColor = System.Drawing.Color.Gray;
            this.txtFatherFirstName.Location = new System.Drawing.Point(185, 46);
            this.txtFatherFirstName.Name = "txtFatherFirstName";
            this.txtFatherFirstName.Size = new System.Drawing.Size(157, 30);
            this.txtFatherFirstName.TabIndex = 38;
            this.txtFatherFirstName.Text = "Имя";
            this.txtFatherFirstName.Enter += new System.EventHandler(this.txtFatherFirstName_Enter);
            this.txtFatherFirstName.Leave += new System.EventHandler(this.txtFatherFirstName_Leave);
            // 
            // txtFatherCitizenship
            // 
            this.txtFatherCitizenship.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtFatherCitizenship.ForeColor = System.Drawing.Color.Gray;
            this.txtFatherCitizenship.Location = new System.Drawing.Point(185, 93);
            this.txtFatherCitizenship.Name = "txtFatherCitizenship";
            this.txtFatherCitizenship.Size = new System.Drawing.Size(157, 30);
            this.txtFatherCitizenship.TabIndex = 37;
            this.txtFatherCitizenship.Text = "Гражданство";
            this.txtFatherCitizenship.Enter += new System.EventHandler(this.txtFatherCitizenship_Enter);
            this.txtFatherCitizenship.Leave += new System.EventHandler(this.txtFatherCitizenship_Leave);
            // 
            // txtFatherPlace
            // 
            this.txtFatherPlace.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtFatherPlace.ForeColor = System.Drawing.Color.Gray;
            this.txtFatherPlace.Location = new System.Drawing.Point(10, 140);
            this.txtFatherPlace.Name = "txtFatherPlace";
            this.txtFatherPlace.Size = new System.Drawing.Size(157, 30);
            this.txtFatherPlace.TabIndex = 36;
            this.txtFatherPlace.Text = "Место рождения";
            this.txtFatherPlace.Enter += new System.EventHandler(this.txtFatherPlace_Enter);
            this.txtFatherPlace.Leave += new System.EventHandler(this.txtFatherPlace_Leave);
            // 
            // txtFatherPatronymic
            // 
            this.txtFatherPatronymic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtFatherPatronymic.ForeColor = System.Drawing.Color.Gray;
            this.txtFatherPatronymic.Location = new System.Drawing.Point(10, 93);
            this.txtFatherPatronymic.Name = "txtFatherPatronymic";
            this.txtFatherPatronymic.Size = new System.Drawing.Size(157, 30);
            this.txtFatherPatronymic.TabIndex = 35;
            this.txtFatherPatronymic.Text = "Отчество";
            this.txtFatherPatronymic.Enter += new System.EventHandler(this.txtFatherPatronymic_Enter);
            this.txtFatherPatronymic.Leave += new System.EventHandler(this.txtFatherPatronymic_Leave);
            // 
            // dtpFatherBirth
            // 
            this.dtpFatherBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtpFatherBirth.Location = new System.Drawing.Point(193, 140);
            this.dtpFatherBirth.Name = "dtpFatherBirth";
            this.dtpFatherBirth.Size = new System.Drawing.Size(142, 30);
            this.dtpFatherBirth.TabIndex = 34;
            this.dtpFatherBirth.ValueChanged += new System.EventHandler(this.dtpFatherBirth_ValueChanged);
            // 
            // txtFatherLastName
            // 
            this.txtFatherLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtFatherLastName.ForeColor = System.Drawing.Color.Gray;
            this.txtFatherLastName.Location = new System.Drawing.Point(10, 46);
            this.txtFatherLastName.Name = "txtFatherLastName";
            this.txtFatherLastName.Size = new System.Drawing.Size(157, 30);
            this.txtFatherLastName.TabIndex = 34;
            this.txtFatherLastName.Text = "Фамилия";
            this.txtFatherLastName.Enter += new System.EventHandler(this.txtFatherLastName_Enter);
            this.txtFatherLastName.Leave += new System.EventHandler(this.txtFatherLastName_Leave);
            // 
            // Otec
            // 
            this.Otec.AutoSize = true;
            this.Otec.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Otec.Location = new System.Drawing.Point(142, -1);
            this.Otec.Name = "Otec";
            this.Otec.Size = new System.Drawing.Size(75, 29);
            this.Otec.TabIndex = 34;
            this.Otec.Text = "Отец";
            // 
            // panelpodPapa
            // 
            this.panelpodPapa.BackColor = System.Drawing.Color.Transparent;
            this.panelpodPapa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelpodPapa.Location = new System.Drawing.Point(408, 239);
            this.panelpodPapa.Name = "panelpodPapa";
            this.panelpodPapa.Size = new System.Drawing.Size(359, 10);
            this.panelpodPapa.TabIndex = 29;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.txtMotherFirstName);
            this.panel5.Controls.Add(this.txtMotherCitizenship);
            this.panel5.Controls.Add(this.txtMotherPlace);
            this.panel5.Controls.Add(this.txtMotherPatronymic);
            this.panel5.Controls.Add(this.dtpMotherBirth);
            this.panel5.Controls.Add(this.txtMotherLastName);
            this.panel5.Location = new System.Drawing.Point(35, 209);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(359, 190);
            this.panel5.TabIndex = 39;
            // 
            // txtMotherFirstName
            // 
            this.txtMotherFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtMotherFirstName.ForeColor = System.Drawing.Color.Gray;
            this.txtMotherFirstName.Location = new System.Drawing.Point(185, 46);
            this.txtMotherFirstName.Name = "txtMotherFirstName";
            this.txtMotherFirstName.Size = new System.Drawing.Size(157, 30);
            this.txtMotherFirstName.TabIndex = 38;
            this.txtMotherFirstName.Text = "Имя";
            this.txtMotherFirstName.Enter += new System.EventHandler(this.txtMotherFirstName_Enter);
            this.txtMotherFirstName.Leave += new System.EventHandler(this.txtMotherFirstName_Leave);
            // 
            // txtMotherCitizenship
            // 
            this.txtMotherCitizenship.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtMotherCitizenship.ForeColor = System.Drawing.Color.Gray;
            this.txtMotherCitizenship.Location = new System.Drawing.Point(185, 93);
            this.txtMotherCitizenship.Name = "txtMotherCitizenship";
            this.txtMotherCitizenship.Size = new System.Drawing.Size(157, 30);
            this.txtMotherCitizenship.TabIndex = 37;
            this.txtMotherCitizenship.Text = "Гражданство";
            this.txtMotherCitizenship.Enter += new System.EventHandler(this.txtMotherCitizenship_Enter);
            this.txtMotherCitizenship.Leave += new System.EventHandler(this.txtMotherCitizenship_Leave);
            // 
            // txtMotherPlace
            // 
            this.txtMotherPlace.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtMotherPlace.ForeColor = System.Drawing.Color.Gray;
            this.txtMotherPlace.Location = new System.Drawing.Point(10, 140);
            this.txtMotherPlace.Name = "txtMotherPlace";
            this.txtMotherPlace.Size = new System.Drawing.Size(157, 30);
            this.txtMotherPlace.TabIndex = 36;
            this.txtMotherPlace.Text = "Место рождения";
            this.txtMotherPlace.Enter += new System.EventHandler(this.txtMotherPlace_Enter);
            this.txtMotherPlace.Leave += new System.EventHandler(this.txtMotherPlace_Leave);
            // 
            // txtMotherPatronymic
            // 
            this.txtMotherPatronymic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtMotherPatronymic.ForeColor = System.Drawing.Color.Gray;
            this.txtMotherPatronymic.Location = new System.Drawing.Point(10, 93);
            this.txtMotherPatronymic.Name = "txtMotherPatronymic";
            this.txtMotherPatronymic.Size = new System.Drawing.Size(157, 30);
            this.txtMotherPatronymic.TabIndex = 35;
            this.txtMotherPatronymic.Text = "Отчество";
            this.txtMotherPatronymic.Enter += new System.EventHandler(this.txtMotherPatronymic_Enter);
            this.txtMotherPatronymic.Leave += new System.EventHandler(this.txtMotherPatronymic_Leave);
            // 
            // dtpMotherBirth
            // 
            this.dtpMotherBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtpMotherBirth.Location = new System.Drawing.Point(193, 140);
            this.dtpMotherBirth.Name = "dtpMotherBirth";
            this.dtpMotherBirth.Size = new System.Drawing.Size(142, 30);
            this.dtpMotherBirth.TabIndex = 34;
            this.dtpMotherBirth.ValueChanged += new System.EventHandler(this.dtpMotherBirth_ValueChanged);
            // 
            // txtMotherLastName
            // 
            this.txtMotherLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtMotherLastName.ForeColor = System.Drawing.Color.Gray;
            this.txtMotherLastName.Location = new System.Drawing.Point(10, 46);
            this.txtMotherLastName.Name = "txtMotherLastName";
            this.txtMotherLastName.Size = new System.Drawing.Size(157, 30);
            this.txtMotherLastName.TabIndex = 34;
            this.txtMotherLastName.Text = "Фамилия";
            this.txtMotherLastName.Enter += new System.EventHandler(this.txtMotherLastName_Enter);
            this.txtMotherLastName.Leave += new System.EventHandler(this.txtMotherLastName_Leave);
            // 
            // Mat
            // 
            this.Mat.AutoSize = true;
            this.Mat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Mat.Location = new System.Drawing.Point(142, 1);
            this.Mat.Name = "Mat";
            this.Mat.Size = new System.Drawing.Size(74, 29);
            this.Mat.TabIndex = 34;
            this.Mat.Text = "Мать";
            // 
            // panelpodMama
            // 
            this.panelpodMama.BackColor = System.Drawing.Color.Transparent;
            this.panelpodMama.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelpodMama.Location = new System.Drawing.Point(35, 239);
            this.panelpodMama.Name = "panelpodMama";
            this.panelpodMama.Size = new System.Drawing.Size(359, 10);
            this.panelpodMama.TabIndex = 30;
            // 
            // panelMama
            // 
            this.panelMama.BackColor = System.Drawing.Color.Transparent;
            this.panelMama.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMama.Controls.Add(this.Mat);
            this.panelMama.Location = new System.Drawing.Point(35, 208);
            this.panelMama.Name = "panelMama";
            this.panelMama.Size = new System.Drawing.Size(359, 32);
            this.panelMama.TabIndex = 41;
            // 
            // panelPapa
            // 
            this.panelPapa.BackColor = System.Drawing.Color.Transparent;
            this.panelPapa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPapa.Controls.Add(this.Otec);
            this.panelPapa.Location = new System.Drawing.Point(408, 208);
            this.panelPapa.Name = "panelPapa";
            this.panelPapa.Size = new System.Drawing.Size(359, 32);
            this.panelPapa.TabIndex = 42;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Transparent;
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.tbPlaceholderGender);
            this.panel8.Controls.Add(this.cbGender);
            this.panel8.Controls.Add(this.dtpChildBirth);
            this.panel8.Controls.Add(this.txtBirthPlace);
            this.panel8.Controls.Add(this.txtChildPatronymic);
            this.panel8.Controls.Add(this.txtChildFirstName);
            this.panel8.Controls.Add(this.panelpodRebenok);
            this.panel8.Controls.Add(this.txtChildLastName);
            this.panel8.Location = new System.Drawing.Point(35, 65);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(732, 137);
            this.panel8.TabIndex = 34;
            // 
            // tbPlaceholderGender
            // 
            this.tbPlaceholderGender.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPlaceholderGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPlaceholderGender.ForeColor = System.Drawing.Color.Gray;
            this.tbPlaceholderGender.Location = new System.Drawing.Point(259, 95);
            this.tbPlaceholderGender.Name = "tbPlaceholderGender";
            this.tbPlaceholderGender.Size = new System.Drawing.Size(116, 23);
            this.tbPlaceholderGender.TabIndex = 34;
            this.tbPlaceholderGender.Text = "Пол";
            // 
            // cbGender
            // 
            this.cbGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbGender.ForeColor = System.Drawing.Color.Black;
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Location = new System.Drawing.Point(253, 91);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(153, 33);
            this.cbGender.TabIndex = 33;
            this.cbGender.DropDown += new System.EventHandler(this.cbGender_DropDown);
            this.cbGender.DropDownClosed += new System.EventHandler(this.cbGender_DropDownClosed);
            // 
            // dtpChildBirth
            // 
            this.dtpChildBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtpChildBirth.Location = new System.Drawing.Point(425, 92);
            this.dtpChildBirth.Name = "dtpChildBirth";
            this.dtpChildBirth.Size = new System.Drawing.Size(290, 30);
            this.dtpChildBirth.TabIndex = 32;
            this.dtpChildBirth.ValueChanged += new System.EventHandler(this.dtpChildBirth_ValueChanged);
            // 
            // txtBirthPlace
            // 
            this.txtBirthPlace.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBirthPlace.ForeColor = System.Drawing.Color.Gray;
            this.txtBirthPlace.Location = new System.Drawing.Point(17, 92);
            this.txtBirthPlace.Name = "txtBirthPlace";
            this.txtBirthPlace.Size = new System.Drawing.Size(225, 30);
            this.txtBirthPlace.TabIndex = 31;
            this.txtBirthPlace.Text = "Место рождения";
            this.txtBirthPlace.Enter += new System.EventHandler(this.txtBirthPlace_Enter_1);
            this.txtBirthPlace.Leave += new System.EventHandler(this.txtBirthPlace_Leave_1);
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
            this.txtChildPatronymic.Enter += new System.EventHandler(this.txtChildPatronymic_Enter_1);
            this.txtChildPatronymic.Leave += new System.EventHandler(this.txtChildPatronymic_Leave_1);
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
            this.txtChildFirstName.Enter += new System.EventHandler(this.txtChildFirstName_Enter_1);
            this.txtChildFirstName.Leave += new System.EventHandler(this.txtChildFirstName_Leave_1);
            // 
            // panelpodRebenok
            // 
            this.panelpodRebenok.BackColor = System.Drawing.Color.Transparent;
            this.panelpodRebenok.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelpodRebenok.Location = new System.Drawing.Point(-1, 32);
            this.panelpodRebenok.Name = "panelpodRebenok";
            this.panelpodRebenok.Size = new System.Drawing.Size(732, 10);
            this.panelpodRebenok.TabIndex = 28;
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
            this.txtChildLastName.Enter += new System.EventHandler(this.txtChildLastName_Enter_1);
            this.txtChildLastName.Leave += new System.EventHandler(this.txtChildLastName_Leave_1);
            // 
            // panelRebenok
            // 
            this.panelRebenok.BackColor = System.Drawing.Color.Transparent;
            this.panelRebenok.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelRebenok.Controls.Add(this.Rebenok);
            this.panelRebenok.Location = new System.Drawing.Point(35, 66);
            this.panelRebenok.Name = "panelRebenok";
            this.panelRebenok.Size = new System.Drawing.Size(732, 32);
            this.panelRebenok.TabIndex = 40;
            // 
            // Rebenok
            // 
            this.Rebenok.AutoSize = true;
            this.Rebenok.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Rebenok.Location = new System.Drawing.Point(307, 0);
            this.Rebenok.Name = "Rebenok";
            this.Rebenok.Size = new System.Drawing.Size(117, 29);
            this.Rebenok.TabIndex = 14;
            this.Rebenok.Text = "Ребенок";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(19)))), ((int)(((byte)(15)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSave.Location = new System.Drawing.Point(284, 405);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(249, 40);
            this.btnSave.TabIndex = 42;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // BirthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelPapa);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.panelRebenok);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panelMama);
            this.Controls.Add(this.panelpodMama);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panelpodPapa);
            this.Controls.Add(this.topPanel1);
            this.Controls.Add(this.panel3);
            this.Name = "BirthForm";
            this.Text = "Регистрация рождения";
            this.Load += new System.EventHandler(this.BirthForm_Load);
            this.topPanel1.ResumeLayout(false);
            this.topPanel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panelMama.ResumeLayout(false);
            this.panelMama.PerformLayout();
            this.panelPapa.ResumeLayout(false);
            this.panelPapa.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panelRebenok.ResumeLayout(false);
            this.panelRebenok.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button nazad;
        private System.Windows.Forms.Panel topPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtFatherLastName;
        private System.Windows.Forms.Label Otec;
        private System.Windows.Forms.DateTimePicker dtpFatherBirth;
        private System.Windows.Forms.TextBox txtFatherFirstName;
        private System.Windows.Forms.TextBox txtFatherCitizenship;
        private System.Windows.Forms.TextBox txtFatherPlace;
        private System.Windows.Forms.TextBox txtFatherPatronymic;
        private System.Windows.Forms.Panel panelpodPapa;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtMotherFirstName;
        private System.Windows.Forms.TextBox txtMotherCitizenship;
        private System.Windows.Forms.TextBox txtMotherPlace;
        private System.Windows.Forms.TextBox txtMotherPatronymic;
        private System.Windows.Forms.DateTimePicker dtpMotherBirth;
        private System.Windows.Forms.Label Mat;
        private System.Windows.Forms.TextBox txtMotherLastName;
        private System.Windows.Forms.Panel panelpodMama;
        private System.Windows.Forms.Panel panelMama;
        private System.Windows.Forms.Panel panelPapa;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.DateTimePicker dtpChildBirth;
        private System.Windows.Forms.Panel panelRebenok;
        private System.Windows.Forms.Label Rebenok;
        private System.Windows.Forms.TextBox txtBirthPlace;
        private System.Windows.Forms.TextBox txtChildPatronymic;
        private System.Windows.Forms.TextBox txtChildFirstName;
        private System.Windows.Forms.Panel panelpodRebenok;
        private System.Windows.Forms.TextBox txtChildLastName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button CloseApplication;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox tbPlaceholderGender;
    }
}
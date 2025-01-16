
namespace OCESACNA.View.Forms
{
    partial class StudentForm
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
            this.AceptBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.CedulaBox = new System.Windows.Forms.TextBox();
            this.CedulaLabel = new System.Windows.Forms.Label();
            this.LastNamesLabel = new System.Windows.Forms.Label();
            this.LastNamesBox = new System.Windows.Forms.TextBox();
            this.FirstNamesBox = new System.Windows.Forms.TextBox();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.AgeBox = new System.Windows.Forms.NumericUpDown();
            this.AgeLabel = new System.Windows.Forms.Label();
            this.SexBox = new System.Windows.Forms.ComboBox();
            this.SexLabel = new System.Windows.Forms.Label();
            this.BirthdateBox = new System.Windows.Forms.DateTimePicker();
            this.BirthdateLabel = new System.Windows.Forms.Label();
            this.BirthPlaceBox = new System.Windows.Forms.TextBox();
            this.BirthPlaceLabel = new System.Windows.Forms.Label();
            this.FederalEnttyLabel = new System.Windows.Forms.Label();
            this.FederalEnttyBox = new System.Windows.Forms.TextBox();
            this.AddressBox = new System.Windows.Forms.TextBox();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.PhoneNumberLabel = new System.Windows.Forms.Label();
            this.PhoneNumberBox = new System.Windows.Forms.TextBox();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.EmailBox = new System.Windows.Forms.TextBox();
            this.RprsentLabel = new System.Windows.Forms.Label();
            this.RprsentBox = new System.Windows.Forms.TextBox();
            this.SelectRprsentBtn = new FontAwesome.Sharp.IconButton();
            this.PersonalDataGroup = new System.Windows.Forms.GroupBox();
            this.AdditionalDataGroup = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MentionLabel = new System.Windows.Forms.Label();
            this.SectionBox = new System.Windows.Forms.ComboBox();
            this.MentionBox = new System.Windows.Forms.ComboBox();
            this.YearLabel = new System.Windows.Forms.Label();
            this.YearBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.AgeBox)).BeginInit();
            this.PersonalDataGroup.SuspendLayout();
            this.AdditionalDataGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // AceptBtn
            // 
            this.AceptBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AceptBtn.Location = new System.Drawing.Point(391, 328);
            this.AceptBtn.Name = "AceptBtn";
            this.AceptBtn.Size = new System.Drawing.Size(75, 23);
            this.AceptBtn.TabIndex = 0;
            this.AceptBtn.Text = "Aceptar";
            this.AceptBtn.UseVisualStyleBackColor = true;
            this.AceptBtn.Click += new System.EventHandler(this.AceptBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelBtn.Location = new System.Drawing.Point(305, 328);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 1;
            this.CancelBtn.Text = "Cancelar";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // CedulaBox
            // 
            this.CedulaBox.Location = new System.Drawing.Point(355, 32);
            this.CedulaBox.MaxLength = 16;
            this.CedulaBox.Name = "CedulaBox";
            this.CedulaBox.Size = new System.Drawing.Size(91, 20);
            this.CedulaBox.TabIndex = 2;
            // 
            // CedulaLabel
            // 
            this.CedulaLabel.AutoSize = true;
            this.CedulaLabel.Location = new System.Drawing.Point(355, 16);
            this.CedulaLabel.Name = "CedulaLabel";
            this.CedulaLabel.Size = new System.Drawing.Size(40, 13);
            this.CedulaLabel.TabIndex = 3;
            this.CedulaLabel.Text = "Cédula";
            // 
            // LastNamesLabel
            // 
            this.LastNamesLabel.AutoSize = true;
            this.LastNamesLabel.Location = new System.Drawing.Point(6, 16);
            this.LastNamesLabel.Name = "LastNamesLabel";
            this.LastNamesLabel.Size = new System.Drawing.Size(49, 13);
            this.LastNamesLabel.TabIndex = 5;
            this.LastNamesLabel.Text = "Apellidos";
            // 
            // LastNamesBox
            // 
            this.LastNamesBox.Location = new System.Drawing.Point(6, 32);
            this.LastNamesBox.MaxLength = 100;
            this.LastNamesBox.Name = "LastNamesBox";
            this.LastNamesBox.Size = new System.Drawing.Size(168, 20);
            this.LastNamesBox.TabIndex = 4;
            // 
            // FirstNamesBox
            // 
            this.FirstNamesBox.Location = new System.Drawing.Point(180, 32);
            this.FirstNamesBox.MaxLength = 100;
            this.FirstNamesBox.Name = "FirstNamesBox";
            this.FirstNamesBox.Size = new System.Drawing.Size(169, 20);
            this.FirstNamesBox.TabIndex = 4;
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Location = new System.Drawing.Point(177, 16);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(49, 13);
            this.FirstNameLabel.TabIndex = 5;
            this.FirstNameLabel.Text = "Nombres";
            // 
            // AgeBox
            // 
            this.AgeBox.Location = new System.Drawing.Point(6, 121);
            this.AgeBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.AgeBox.Name = "AgeBox";
            this.AgeBox.Size = new System.Drawing.Size(108, 20);
            this.AgeBox.TabIndex = 6;
            this.AgeBox.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // AgeLabel
            // 
            this.AgeLabel.AutoSize = true;
            this.AgeLabel.Location = new System.Drawing.Point(6, 105);
            this.AgeLabel.Name = "AgeLabel";
            this.AgeLabel.Size = new System.Drawing.Size(32, 13);
            this.AgeLabel.TabIndex = 7;
            this.AgeLabel.Text = "Edad";
            // 
            // SexBox
            // 
            this.SexBox.FormattingEnabled = true;
            this.SexBox.Location = new System.Drawing.Point(401, 76);
            this.SexBox.Name = "SexBox";
            this.SexBox.Size = new System.Drawing.Size(45, 21);
            this.SexBox.TabIndex = 8;
            // 
            // SexLabel
            // 
            this.SexLabel.AutoSize = true;
            this.SexLabel.Location = new System.Drawing.Point(398, 60);
            this.SexLabel.Name = "SexLabel";
            this.SexLabel.Size = new System.Drawing.Size(31, 13);
            this.SexLabel.TabIndex = 9;
            this.SexLabel.Text = "Sexo";
            // 
            // BirthdateBox
            // 
            this.BirthdateBox.Location = new System.Drawing.Point(6, 77);
            this.BirthdateBox.Name = "BirthdateBox";
            this.BirthdateBox.Size = new System.Drawing.Size(108, 20);
            this.BirthdateBox.TabIndex = 10;
            this.BirthdateBox.Value = new System.DateTime(2025, 1, 14, 9, 44, 17, 0);
            // 
            // BirthdateLabel
            // 
            this.BirthdateLabel.AutoSize = true;
            this.BirthdateLabel.Location = new System.Drawing.Point(3, 60);
            this.BirthdateLabel.Name = "BirthdateLabel";
            this.BirthdateLabel.Size = new System.Drawing.Size(108, 13);
            this.BirthdateLabel.TabIndex = 11;
            this.BirthdateLabel.Text = "Fecha de Nacimiento";
            // 
            // BirthPlaceBox
            // 
            this.BirthPlaceBox.Location = new System.Drawing.Point(120, 77);
            this.BirthPlaceBox.MaxLength = 100;
            this.BirthPlaceBox.Name = "BirthPlaceBox";
            this.BirthPlaceBox.Size = new System.Drawing.Size(168, 20);
            this.BirthPlaceBox.TabIndex = 12;
            // 
            // BirthPlaceLabel
            // 
            this.BirthPlaceLabel.AutoSize = true;
            this.BirthPlaceLabel.Location = new System.Drawing.Point(117, 60);
            this.BirthPlaceLabel.Name = "BirthPlaceLabel";
            this.BirthPlaceLabel.Size = new System.Drawing.Size(105, 13);
            this.BirthPlaceLabel.TabIndex = 13;
            this.BirthPlaceLabel.Text = "Lugar de Nacimiento";
            // 
            // FederalEnttyLabel
            // 
            this.FederalEnttyLabel.AutoSize = true;
            this.FederalEnttyLabel.Location = new System.Drawing.Point(291, 60);
            this.FederalEnttyLabel.Name = "FederalEnttyLabel";
            this.FederalEnttyLabel.Size = new System.Drawing.Size(81, 13);
            this.FederalEnttyLabel.TabIndex = 15;
            this.FederalEnttyLabel.Text = "Entidad Federal";
            // 
            // FederalEnttyBox
            // 
            this.FederalEnttyBox.Location = new System.Drawing.Point(294, 77);
            this.FederalEnttyBox.MaxLength = 100;
            this.FederalEnttyBox.Name = "FederalEnttyBox";
            this.FederalEnttyBox.Size = new System.Drawing.Size(101, 20);
            this.FederalEnttyBox.TabIndex = 14;
            // 
            // AddressBox
            // 
            this.AddressBox.Location = new System.Drawing.Point(6, 165);
            this.AddressBox.MaxLength = 100;
            this.AddressBox.Name = "AddressBox";
            this.AddressBox.Size = new System.Drawing.Size(440, 20);
            this.AddressBox.TabIndex = 16;
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Location = new System.Drawing.Point(6, 149);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(52, 13);
            this.AddressLabel.TabIndex = 17;
            this.AddressLabel.Text = "Dirección";
            // 
            // PhoneNumberLabel
            // 
            this.PhoneNumberLabel.AutoSize = true;
            this.PhoneNumberLabel.Location = new System.Drawing.Point(291, 105);
            this.PhoneNumberLabel.Name = "PhoneNumberLabel";
            this.PhoneNumberLabel.Size = new System.Drawing.Size(97, 13);
            this.PhoneNumberLabel.TabIndex = 19;
            this.PhoneNumberLabel.Text = "Número Telefónico";
            // 
            // PhoneNumberBox
            // 
            this.PhoneNumberBox.Location = new System.Drawing.Point(294, 121);
            this.PhoneNumberBox.MaxLength = 100;
            this.PhoneNumberBox.Name = "PhoneNumberBox";
            this.PhoneNumberBox.Size = new System.Drawing.Size(152, 20);
            this.PhoneNumberBox.TabIndex = 18;
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(120, 105);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(36, 13);
            this.EmailLabel.TabIndex = 21;
            this.EmailLabel.Text = "E-Mail";
            // 
            // EmailBox
            // 
            this.EmailBox.Location = new System.Drawing.Point(120, 121);
            this.EmailBox.MaxLength = 100;
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(168, 20);
            this.EmailBox.TabIndex = 20;
            // 
            // RprsentLabel
            // 
            this.RprsentLabel.AutoSize = true;
            this.RprsentLabel.Location = new System.Drawing.Point(3, 16);
            this.RprsentLabel.Name = "RprsentLabel";
            this.RprsentLabel.Size = new System.Drawing.Size(77, 13);
            this.RprsentLabel.TabIndex = 23;
            this.RprsentLabel.Text = "Representante";
            // 
            // RprsentBox
            // 
            this.RprsentBox.Location = new System.Drawing.Point(6, 32);
            this.RprsentBox.MaxLength = 100;
            this.RprsentBox.Name = "RprsentBox";
            this.RprsentBox.Size = new System.Drawing.Size(336, 20);
            this.RprsentBox.TabIndex = 22;
            // 
            // SelectRprsentBtn
            // 
            this.SelectRprsentBtn.IconChar = FontAwesome.Sharp.IconChar.ClipboardUser;
            this.SelectRprsentBtn.IconColor = System.Drawing.Color.Black;
            this.SelectRprsentBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SelectRprsentBtn.IconSize = 16;
            this.SelectRprsentBtn.Location = new System.Drawing.Point(348, 31);
            this.SelectRprsentBtn.Name = "SelectRprsentBtn";
            this.SelectRprsentBtn.Size = new System.Drawing.Size(101, 21);
            this.SelectRprsentBtn.TabIndex = 24;
            this.SelectRprsentBtn.Text = "Seleccionar";
            this.SelectRprsentBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SelectRprsentBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SelectRprsentBtn.UseVisualStyleBackColor = true;
            this.SelectRprsentBtn.Click += new System.EventHandler(this.SelectRprsentBtn_Click);
            // 
            // PersonalDataGroup
            // 
            this.PersonalDataGroup.Controls.Add(this.CedulaBox);
            this.PersonalDataGroup.Controls.Add(this.CedulaLabel);
            this.PersonalDataGroup.Controls.Add(this.LastNamesBox);
            this.PersonalDataGroup.Controls.Add(this.FirstNamesBox);
            this.PersonalDataGroup.Controls.Add(this.AddressLabel);
            this.PersonalDataGroup.Controls.Add(this.PhoneNumberLabel);
            this.PersonalDataGroup.Controls.Add(this.AddressBox);
            this.PersonalDataGroup.Controls.Add(this.EmailLabel);
            this.PersonalDataGroup.Controls.Add(this.PhoneNumberBox);
            this.PersonalDataGroup.Controls.Add(this.LastNamesLabel);
            this.PersonalDataGroup.Controls.Add(this.EmailBox);
            this.PersonalDataGroup.Controls.Add(this.FirstNameLabel);
            this.PersonalDataGroup.Controls.Add(this.SexLabel);
            this.PersonalDataGroup.Controls.Add(this.SexBox);
            this.PersonalDataGroup.Controls.Add(this.AgeBox);
            this.PersonalDataGroup.Controls.Add(this.AgeLabel);
            this.PersonalDataGroup.Controls.Add(this.FederalEnttyLabel);
            this.PersonalDataGroup.Controls.Add(this.FederalEnttyBox);
            this.PersonalDataGroup.Controls.Add(this.BirthdateLabel);
            this.PersonalDataGroup.Controls.Add(this.BirthdateBox);
            this.PersonalDataGroup.Controls.Add(this.BirthPlaceLabel);
            this.PersonalDataGroup.Controls.Add(this.BirthPlaceBox);
            this.PersonalDataGroup.Location = new System.Drawing.Point(11, 12);
            this.PersonalDataGroup.Name = "PersonalDataGroup";
            this.PersonalDataGroup.Size = new System.Drawing.Size(455, 195);
            this.PersonalDataGroup.TabIndex = 25;
            this.PersonalDataGroup.TabStop = false;
            this.PersonalDataGroup.Text = "Datos Personales";
            // 
            // AdditionalDataGroup
            // 
            this.AdditionalDataGroup.Controls.Add(this.label1);
            this.AdditionalDataGroup.Controls.Add(this.MentionLabel);
            this.AdditionalDataGroup.Controls.Add(this.SectionBox);
            this.AdditionalDataGroup.Controls.Add(this.MentionBox);
            this.AdditionalDataGroup.Controls.Add(this.YearLabel);
            this.AdditionalDataGroup.Controls.Add(this.YearBox);
            this.AdditionalDataGroup.Controls.Add(this.RprsentBox);
            this.AdditionalDataGroup.Controls.Add(this.RprsentLabel);
            this.AdditionalDataGroup.Controls.Add(this.SelectRprsentBtn);
            this.AdditionalDataGroup.Location = new System.Drawing.Point(11, 213);
            this.AdditionalDataGroup.Name = "AdditionalDataGroup";
            this.AdditionalDataGroup.Size = new System.Drawing.Size(455, 109);
            this.AdditionalDataGroup.TabIndex = 26;
            this.AdditionalDataGroup.TabStop = false;
            this.AdditionalDataGroup.Text = "Datos Adicionales";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(345, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Seción";
            // 
            // MentionLabel
            // 
            this.MentionLabel.AutoSize = true;
            this.MentionLabel.Location = new System.Drawing.Point(130, 60);
            this.MentionLabel.Name = "MentionLabel";
            this.MentionLabel.Size = new System.Drawing.Size(48, 13);
            this.MentionLabel.TabIndex = 28;
            this.MentionLabel.Text = "Mención";
            // 
            // SectionBox
            // 
            this.SectionBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.SectionBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.SectionBox.FormattingEnabled = true;
            this.SectionBox.Location = new System.Drawing.Point(348, 76);
            this.SectionBox.Name = "SectionBox";
            this.SectionBox.Size = new System.Drawing.Size(98, 21);
            this.SectionBox.TabIndex = 27;
            // 
            // MentionBox
            // 
            this.MentionBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.MentionBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.MentionBox.FormattingEnabled = true;
            this.MentionBox.Location = new System.Drawing.Point(133, 76);
            this.MentionBox.Name = "MentionBox";
            this.MentionBox.Size = new System.Drawing.Size(209, 21);
            this.MentionBox.TabIndex = 27;
            this.MentionBox.SelectedIndexChanged += new System.EventHandler(this.MentionBox_SelectedIndexChanged);
            // 
            // YearLabel
            // 
            this.YearLabel.AutoSize = true;
            this.YearLabel.Location = new System.Drawing.Point(3, 60);
            this.YearLabel.Name = "YearLabel";
            this.YearLabel.Size = new System.Drawing.Size(26, 13);
            this.YearLabel.TabIndex = 26;
            this.YearLabel.Text = "Año";
            // 
            // YearBox
            // 
            this.YearBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.YearBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.YearBox.FormattingEnabled = true;
            this.YearBox.Location = new System.Drawing.Point(6, 76);
            this.YearBox.Name = "YearBox";
            this.YearBox.Size = new System.Drawing.Size(121, 21);
            this.YearBox.TabIndex = 25;
            this.YearBox.SelectedIndexChanged += new System.EventHandler(this.YearBox_SelectedIndexChanged);
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 357);
            this.Controls.Add(this.AdditionalDataGroup);
            this.Controls.Add(this.PersonalDataGroup);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.AceptBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StudentForm";
            this.Text = "StudentForm";
            ((System.ComponentModel.ISupportInitialize)(this.AgeBox)).EndInit();
            this.PersonalDataGroup.ResumeLayout(false);
            this.PersonalDataGroup.PerformLayout();
            this.AdditionalDataGroup.ResumeLayout(false);
            this.AdditionalDataGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AceptBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.TextBox CedulaBox;
        private System.Windows.Forms.Label CedulaLabel;
        private System.Windows.Forms.Label LastNamesLabel;
        private System.Windows.Forms.TextBox LastNamesBox;
        private System.Windows.Forms.TextBox FirstNamesBox;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.NumericUpDown AgeBox;
        private System.Windows.Forms.Label AgeLabel;
        private System.Windows.Forms.ComboBox SexBox;
        private System.Windows.Forms.Label SexLabel;
        private System.Windows.Forms.DateTimePicker BirthdateBox;
        private System.Windows.Forms.Label BirthdateLabel;
        private System.Windows.Forms.TextBox BirthPlaceBox;
        private System.Windows.Forms.Label BirthPlaceLabel;
        private System.Windows.Forms.Label FederalEnttyLabel;
        private System.Windows.Forms.TextBox FederalEnttyBox;
        private System.Windows.Forms.TextBox AddressBox;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.Label PhoneNumberLabel;
        private System.Windows.Forms.TextBox PhoneNumberBox;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.TextBox EmailBox;
        private System.Windows.Forms.Label RprsentLabel;
        private System.Windows.Forms.TextBox RprsentBox;
        private FontAwesome.Sharp.IconButton SelectRprsentBtn;
        private System.Windows.Forms.GroupBox PersonalDataGroup;
        private System.Windows.Forms.GroupBox AdditionalDataGroup;
        private System.Windows.Forms.ComboBox YearBox;
        private System.Windows.Forms.Label YearLabel;
        private System.Windows.Forms.ComboBox SectionBox;
        private System.Windows.Forms.ComboBox MentionBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label MentionLabel;
    }
}
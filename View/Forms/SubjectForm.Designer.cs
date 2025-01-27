
namespace OCESACNA.View.Forms
{
    partial class SubjectForm
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
            this.DataGroup = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CourseBox = new System.Windows.Forms.TextBox();
            this.TeacherBox = new System.Windows.Forms.TextBox();
            this.ChoiceCourseBtn = new FontAwesome.Sharp.IconButton();
            this.ChoiceTeacherBtn = new FontAwesome.Sharp.IconButton();
            this.SbjetModuleBox = new System.Windows.Forms.TextBox();
            this.ChoiceSbjetModuleBtn = new FontAwesome.Sharp.IconButton();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.AceptBtn = new System.Windows.Forms.Button();
            this.DataGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataGroup
            // 
            this.DataGroup.Controls.Add(this.label3);
            this.DataGroup.Controls.Add(this.label2);
            this.DataGroup.Controls.Add(this.label1);
            this.DataGroup.Controls.Add(this.CourseBox);
            this.DataGroup.Controls.Add(this.TeacherBox);
            this.DataGroup.Controls.Add(this.ChoiceCourseBtn);
            this.DataGroup.Controls.Add(this.ChoiceTeacherBtn);
            this.DataGroup.Controls.Add(this.SbjetModuleBox);
            this.DataGroup.Controls.Add(this.ChoiceSbjetModuleBtn);
            this.DataGroup.Controls.Add(this.NameBox);
            this.DataGroup.Controls.Add(this.NameLabel);
            this.DataGroup.Location = new System.Drawing.Point(13, 13);
            this.DataGroup.Name = "DataGroup";
            this.DataGroup.Size = new System.Drawing.Size(448, 309);
            this.DataGroup.TabIndex = 0;
            this.DataGroup.TabStop = false;
            this.DataGroup.Text = "Datos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Curso";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Docente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Área de Formación";
            // 
            // CourseBox
            // 
            this.CourseBox.Location = new System.Drawing.Point(6, 164);
            this.CourseBox.MaxLength = 100;
            this.CourseBox.Name = "CourseBox";
            this.CourseBox.ReadOnly = true;
            this.CourseBox.Size = new System.Drawing.Size(341, 20);
            this.CourseBox.TabIndex = 15;
            // 
            // TeacherBox
            // 
            this.TeacherBox.Location = new System.Drawing.Point(6, 120);
            this.TeacherBox.MaxLength = 100;
            this.TeacherBox.Name = "TeacherBox";
            this.TeacherBox.ReadOnly = true;
            this.TeacherBox.Size = new System.Drawing.Size(341, 20);
            this.TeacherBox.TabIndex = 15;
            // 
            // ChoiceCourseBtn
            // 
            this.ChoiceCourseBtn.IconChar = FontAwesome.Sharp.IconChar.Shapes;
            this.ChoiceCourseBtn.IconColor = System.Drawing.Color.Black;
            this.ChoiceCourseBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ChoiceCourseBtn.IconSize = 16;
            this.ChoiceCourseBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ChoiceCourseBtn.Location = new System.Drawing.Point(353, 162);
            this.ChoiceCourseBtn.Name = "ChoiceCourseBtn";
            this.ChoiceCourseBtn.Size = new System.Drawing.Size(89, 23);
            this.ChoiceCourseBtn.TabIndex = 16;
            this.ChoiceCourseBtn.Text = "Seleccionar";
            this.ChoiceCourseBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ChoiceCourseBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ChoiceCourseBtn.UseVisualStyleBackColor = true;
            this.ChoiceCourseBtn.Click += new System.EventHandler(this.ChoiceCourseBtn_Click);
            // 
            // ChoiceTeacherBtn
            // 
            this.ChoiceTeacherBtn.IconChar = FontAwesome.Sharp.IconChar.Shapes;
            this.ChoiceTeacherBtn.IconColor = System.Drawing.Color.Black;
            this.ChoiceTeacherBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ChoiceTeacherBtn.IconSize = 16;
            this.ChoiceTeacherBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ChoiceTeacherBtn.Location = new System.Drawing.Point(353, 118);
            this.ChoiceTeacherBtn.Name = "ChoiceTeacherBtn";
            this.ChoiceTeacherBtn.Size = new System.Drawing.Size(89, 23);
            this.ChoiceTeacherBtn.TabIndex = 16;
            this.ChoiceTeacherBtn.Text = "Seleccionar";
            this.ChoiceTeacherBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ChoiceTeacherBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ChoiceTeacherBtn.UseVisualStyleBackColor = true;
            this.ChoiceTeacherBtn.Click += new System.EventHandler(this.ChoiceTeacherBtn_Click);
            // 
            // SbjetModuleBox
            // 
            this.SbjetModuleBox.Location = new System.Drawing.Point(6, 76);
            this.SbjetModuleBox.MaxLength = 100;
            this.SbjetModuleBox.Name = "SbjetModuleBox";
            this.SbjetModuleBox.ReadOnly = true;
            this.SbjetModuleBox.Size = new System.Drawing.Size(341, 20);
            this.SbjetModuleBox.TabIndex = 15;
            // 
            // ChoiceSbjetModuleBtn
            // 
            this.ChoiceSbjetModuleBtn.IconChar = FontAwesome.Sharp.IconChar.Shapes;
            this.ChoiceSbjetModuleBtn.IconColor = System.Drawing.Color.Black;
            this.ChoiceSbjetModuleBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ChoiceSbjetModuleBtn.IconSize = 16;
            this.ChoiceSbjetModuleBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ChoiceSbjetModuleBtn.Location = new System.Drawing.Point(353, 74);
            this.ChoiceSbjetModuleBtn.Name = "ChoiceSbjetModuleBtn";
            this.ChoiceSbjetModuleBtn.Size = new System.Drawing.Size(89, 23);
            this.ChoiceSbjetModuleBtn.TabIndex = 16;
            this.ChoiceSbjetModuleBtn.Text = "Seleccionar";
            this.ChoiceSbjetModuleBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ChoiceSbjetModuleBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ChoiceSbjetModuleBtn.UseVisualStyleBackColor = true;
            this.ChoiceSbjetModuleBtn.Click += new System.EventHandler(this.ChoiceSbjetModuleBtn_Click);
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(6, 32);
            this.NameBox.MaxLength = 100;
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(436, 20);
            this.NameBox.TabIndex = 1;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(3, 16);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(44, 13);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Nombre";
            // 
            // CancelBtn
            // 
            this.CancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelBtn.Location = new System.Drawing.Point(310, 328);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 3;
            this.CancelBtn.Text = "Cancelar";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // AceptBtn
            // 
            this.AceptBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AceptBtn.Location = new System.Drawing.Point(391, 328);
            this.AceptBtn.Name = "AceptBtn";
            this.AceptBtn.Size = new System.Drawing.Size(75, 23);
            this.AceptBtn.TabIndex = 2;
            this.AceptBtn.Text = "Aceptar";
            this.AceptBtn.UseVisualStyleBackColor = true;
            this.AceptBtn.Click += new System.EventHandler(this.AceptBtn_Click);
            // 
            // SubjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 357);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.AceptBtn);
            this.Controls.Add(this.DataGroup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SubjectForm";
            this.Text = "SubjectForm";
            this.DataGroup.ResumeLayout(false);
            this.DataGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox DataGroup;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox SbjetModuleBox;
        private FontAwesome.Sharp.IconButton ChoiceSbjetModuleBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TeacherBox;
        private FontAwesome.Sharp.IconButton ChoiceTeacherBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CourseBox;
        private FontAwesome.Sharp.IconButton ChoiceCourseBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button AceptBtn;
    }
}
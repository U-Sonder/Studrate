namespace Studrate
{
    partial class wf_studPlagList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wf_studPlagList));
            this.dgvStudent = new System.Windows.Forms.DataGridView();
            this.dgvPlag = new System.Windows.Forms.DataGridView();
            this.cbDiscipline = new System.Windows.Forms.ComboBox();
            this.lDiscipline = new System.Windows.Forms.Label();
            this.lLab = new System.Windows.Forms.Label();
            this.lCourse = new System.Windows.Forms.Label();
            this.lGroup = new System.Windows.Forms.Label();
            this.cbLab = new System.Windows.Forms.ComboBox();
            this.cbCourse = new System.Windows.Forms.ComboBox();
            this.cbGroup = new System.Windows.Forms.ComboBox();
            this.lSurnameSeek = new System.Windows.Forms.Label();
            this.tbSurnameSeek = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlag)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvStudent
            // 
            this.dgvStudent.AllowUserToAddRows = false;
            this.dgvStudent.BackgroundColor = System.Drawing.Color.LightCyan;
            this.dgvStudent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStudent.GridColor = System.Drawing.Color.LightCyan;
            this.dgvStudent.Location = new System.Drawing.Point(3, 3);
            this.dgvStudent.Margin = new System.Windows.Forms.Padding(3, 3, 5, 3);
            this.dgvStudent.Name = "dgvStudent";
            this.dgvStudent.ReadOnly = true;
            this.dgvStudent.Size = new System.Drawing.Size(544, 407);
            this.dgvStudent.TabIndex = 0;
            this.dgvStudent.DoubleClick += new System.EventHandler(this.dgvStudent_DoubleClick);
            // 
            // dgvPlag
            // 
            this.dgvPlag.AllowUserToAddRows = false;
            this.dgvPlag.BackgroundColor = System.Drawing.Color.LightCyan;
            this.dgvPlag.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvPlag.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlag.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPlag.GridColor = System.Drawing.Color.LightCyan;
            this.dgvPlag.Location = new System.Drawing.Point(557, 3);
            this.dgvPlag.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.dgvPlag.Name = "dgvPlag";
            this.dgvPlag.ReadOnly = true;
            this.dgvPlag.Size = new System.Drawing.Size(203, 407);
            this.dgvPlag.TabIndex = 1;
            // 
            // cbDiscipline
            // 
            this.cbDiscipline.BackColor = System.Drawing.Color.PaleTurquoise;
            this.cbDiscipline.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbDiscipline.FormattingEnabled = true;
            this.cbDiscipline.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbDiscipline.Location = new System.Drawing.Point(55, 48);
            this.cbDiscipline.Name = "cbDiscipline";
            this.cbDiscipline.Size = new System.Drawing.Size(73, 21);
            this.cbDiscipline.TabIndex = 3;
            this.cbDiscipline.SelectedIndexChanged += new System.EventHandler(this.cbDiscipline_SelectedIndexChanged);
            // 
            // lDiscipline
            // 
            this.lDiscipline.AutoSize = true;
            this.lDiscipline.Location = new System.Drawing.Point(67, 32);
            this.lDiscipline.Name = "lDiscipline";
            this.lDiscipline.Size = new System.Drawing.Size(52, 13);
            this.lDiscipline.TabIndex = 4;
            this.lDiscipline.Text = "Discipline";
            // 
            // lLab
            // 
            this.lLab.AutoSize = true;
            this.lLab.Location = new System.Drawing.Point(182, 32);
            this.lLab.Name = "lLab";
            this.lLab.Size = new System.Drawing.Size(25, 13);
            this.lLab.TabIndex = 6;
            this.lLab.Text = "Lab";
            // 
            // lCourse
            // 
            this.lCourse.AutoSize = true;
            this.lCourse.Location = new System.Drawing.Point(73, 102);
            this.lCourse.Name = "lCourse";
            this.lCourse.Size = new System.Drawing.Size(40, 13);
            this.lCourse.TabIndex = 8;
            this.lCourse.Text = "Course";
            // 
            // lGroup
            // 
            this.lGroup.AutoSize = true;
            this.lGroup.Location = new System.Drawing.Point(178, 102);
            this.lGroup.Name = "lGroup";
            this.lGroup.Size = new System.Drawing.Size(36, 13);
            this.lGroup.TabIndex = 10;
            this.lGroup.Text = "Group";
            // 
            // cbLab
            // 
            this.cbLab.BackColor = System.Drawing.Color.PaleTurquoise;
            this.cbLab.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbLab.FormattingEnabled = true;
            this.cbLab.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbLab.Location = new System.Drawing.Point(165, 48);
            this.cbLab.Name = "cbLab";
            this.cbLab.Size = new System.Drawing.Size(59, 21);
            this.cbLab.TabIndex = 3;
            this.cbLab.Tag = "";
            this.cbLab.SelectedIndexChanged += new System.EventHandler(this.cbLab_SelectedIndexChanged);
            // 
            // cbCourse
            // 
            this.cbCourse.BackColor = System.Drawing.Color.PaleTurquoise;
            this.cbCourse.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbCourse.FormattingEnabled = true;
            this.cbCourse.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbCourse.Location = new System.Drawing.Point(55, 118);
            this.cbCourse.Name = "cbCourse";
            this.cbCourse.Size = new System.Drawing.Size(73, 21);
            this.cbCourse.TabIndex = 12;
            this.cbCourse.SelectedIndexChanged += new System.EventHandler(this.cbCourse_SelectedIndexChanged);
            // 
            // cbGroup
            // 
            this.cbGroup.BackColor = System.Drawing.Color.PaleTurquoise;
            this.cbGroup.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbGroup.FormattingEnabled = true;
            this.cbGroup.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbGroup.Location = new System.Drawing.Point(165, 118);
            this.cbGroup.Name = "cbGroup";
            this.cbGroup.Size = new System.Drawing.Size(59, 21);
            this.cbGroup.TabIndex = 13;
            this.cbGroup.SelectedIndexChanged += new System.EventHandler(this.cbGroup_SelectedIndexChanged);
            // 
            // lSurnameSeek
            // 
            this.lSurnameSeek.AutoSize = true;
            this.lSurnameSeek.Location = new System.Drawing.Point(279, 70);
            this.lSurnameSeek.Name = "lSurnameSeek";
            this.lSurnameSeek.Size = new System.Drawing.Size(100, 13);
            this.lSurnameSeek.TabIndex = 14;
            this.lSurnameSeek.Text = "Search by Surname";
            // 
            // tbSurnameSeek
            // 
            this.tbSurnameSeek.BackColor = System.Drawing.Color.PaleTurquoise;
            this.tbSurnameSeek.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSurnameSeek.Location = new System.Drawing.Point(279, 86);
            this.tbSurnameSeek.Name = "tbSurnameSeek";
            this.tbSurnameSeek.Size = new System.Drawing.Size(100, 20);
            this.tbSurnameSeek.TabIndex = 15;
            this.tbSurnameSeek.TextChanged += new System.EventHandler(this.tbSurnameSeek_TextChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.47707F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.52294F));
            this.tableLayoutPanel1.Controls.Add(this.dgvStudent, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgvPlag, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 162);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(763, 413);
            this.tableLayoutPanel1.TabIndex = 16;
            // 
            // lInfo
            // 
            this.lInfo.AutoSize = true;
            this.lInfo.Location = new System.Drawing.Point(429, 48);
            this.lInfo.Name = "lInfo";
            this.lInfo.Size = new System.Drawing.Size(236, 13);
            this.lInfo.TabIndex = 17;
            this.lInfo.Text = "Hint: for details double click on cell with lab work";
            // 
            // wf_studPlagList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(764, 575);
            this.Controls.Add(this.lInfo);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tbSurnameSeek);
            this.Controls.Add(this.lSurnameSeek);
            this.Controls.Add(this.cbGroup);
            this.Controls.Add(this.cbCourse);
            this.Controls.Add(this.cbLab);
            this.Controls.Add(this.lGroup);
            this.Controls.Add(this.lCourse);
            this.Controls.Add(this.lLab);
            this.Controls.Add(this.lDiscipline);
            this.Controls.Add(this.cbDiscipline);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(700, 300);
            this.Name = "wf_studPlagList";
            this.Text = "lagiarism";
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlag)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStudent;
        private System.Windows.Forms.DataGridView dgvPlag;
        private System.Windows.Forms.ComboBox cbDiscipline;
        private System.Windows.Forms.Label lDiscipline;
        private System.Windows.Forms.Label lLab;
        private System.Windows.Forms.Label lCourse;
        private System.Windows.Forms.Label lGroup;
        private System.Windows.Forms.ComboBox cbLab;
        private System.Windows.Forms.ComboBox cbCourse;
        private System.Windows.Forms.ComboBox cbGroup;
        private System.Windows.Forms.Label lSurnameSeek;
        private System.Windows.Forms.TextBox tbSurnameSeek;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lInfo;
    }
}
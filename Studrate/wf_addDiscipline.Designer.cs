namespace Studrate
{
    partial class wf_addDiscipline
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wf_addDiscipline));
            this.bAddDiscipline = new System.Windows.Forms.Button();
            this.lNickname = new System.Windows.Forms.Label();
            this.tbNickname = new System.Windows.Forms.TextBox();
            this.lCourse = new System.Windows.Forms.Label();
            this.lFullname = new System.Windows.Forms.Label();
            this.tbFullname = new System.Windows.Forms.TextBox();
            this.tbCourse = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bAddDiscipline
            // 
            this.bAddDiscipline.BackColor = System.Drawing.Color.PaleTurquoise;
            this.bAddDiscipline.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bAddDiscipline.Location = new System.Drawing.Point(60, 150);
            this.bAddDiscipline.Name = "bAddDiscipline";
            this.bAddDiscipline.Size = new System.Drawing.Size(75, 23);
            this.bAddDiscipline.TabIndex = 0;
            this.bAddDiscipline.Text = "Add";
            this.bAddDiscipline.UseVisualStyleBackColor = false;
            this.bAddDiscipline.Click += new System.EventHandler(this.bAddDiscipline_Click);
            // 
            // lNickname
            // 
            this.lNickname.AutoSize = true;
            this.lNickname.Location = new System.Drawing.Point(30, 15);
            this.lNickname.Name = "lNickname";
            this.lNickname.Size = new System.Drawing.Size(55, 13);
            this.lNickname.TabIndex = 1;
            this.lNickname.Text = "Nickname";
            // 
            // tbNickname
            // 
            this.tbNickname.BackColor = System.Drawing.Color.PaleTurquoise;
            this.tbNickname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbNickname.Location = new System.Drawing.Point(30, 30);
            this.tbNickname.MaxLength = 7;
            this.tbNickname.Name = "tbNickname";
            this.tbNickname.Size = new System.Drawing.Size(55, 20);
            this.tbNickname.TabIndex = 2;
            // 
            // lCourse
            // 
            this.lCourse.AutoSize = true;
            this.lCourse.Location = new System.Drawing.Point(120, 15);
            this.lCourse.Name = "lCourse";
            this.lCourse.Size = new System.Drawing.Size(40, 13);
            this.lCourse.TabIndex = 3;
            this.lCourse.Text = "Course";
            // 
            // lFullname
            // 
            this.lFullname.AutoSize = true;
            this.lFullname.Location = new System.Drawing.Point(26, 65);
            this.lFullname.Name = "lFullname";
            this.lFullname.Size = new System.Drawing.Size(52, 13);
            this.lFullname.TabIndex = 4;
            this.lFullname.Text = "Full name";
            // 
            // tbFullname
            // 
            this.tbFullname.BackColor = System.Drawing.Color.PaleTurquoise;
            this.tbFullname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbFullname.Location = new System.Drawing.Point(30, 80);
            this.tbFullname.MaxLength = 255;
            this.tbFullname.Multiline = true;
            this.tbFullname.Name = "tbFullname";
            this.tbFullname.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbFullname.Size = new System.Drawing.Size(130, 60);
            this.tbFullname.TabIndex = 5;
            // 
            // tbCourse
            // 
            this.tbCourse.BackColor = System.Drawing.Color.PaleTurquoise;
            this.tbCourse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbCourse.Location = new System.Drawing.Point(120, 30);
            this.tbCourse.MaxLength = 1;
            this.tbCourse.Name = "tbCourse";
            this.tbCourse.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbCourse.Size = new System.Drawing.Size(37, 20);
            this.tbCourse.TabIndex = 6;
            this.tbCourse.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCourse_KeyPress);
            // 
            // wf_addDiscipline
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(184, 191);
            this.Controls.Add(this.tbCourse);
            this.Controls.Add(this.tbFullname);
            this.Controls.Add(this.lFullname);
            this.Controls.Add(this.lCourse);
            this.Controls.Add(this.tbNickname);
            this.Controls.Add(this.lNickname);
            this.Controls.Add(this.bAddDiscipline);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "wf_addDiscipline";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "lagiarism";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.wf_addDiscipline_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bAddDiscipline;
        private System.Windows.Forms.Label lNickname;
        private System.Windows.Forms.TextBox tbNickname;
        private System.Windows.Forms.Label lCourse;
        private System.Windows.Forms.Label lFullname;
        private System.Windows.Forms.TextBox tbFullname;
        private System.Windows.Forms.TextBox tbCourse;
    }
}
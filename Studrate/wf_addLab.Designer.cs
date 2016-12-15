namespace Studrate
{
    partial class wf_addLab
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wf_addLab));
            this.bAddLab = new System.Windows.Forms.Button();
            this.lDiscipline = new System.Windows.Forms.Label();
            this.cbDiscipline = new System.Windows.Forms.ComboBox();
            this.tbLabNumber = new System.Windows.Forms.TextBox();
            this.lLabNumber = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bAddLab
            // 
            this.bAddLab.BackColor = System.Drawing.Color.PaleTurquoise;
            this.bAddLab.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bAddLab.Location = new System.Drawing.Point(89, 90);
            this.bAddLab.Name = "bAddLab";
            this.bAddLab.Size = new System.Drawing.Size(75, 23);
            this.bAddLab.TabIndex = 0;
            this.bAddLab.Text = "Add";
            this.bAddLab.UseVisualStyleBackColor = false;
            this.bAddLab.Click += new System.EventHandler(this.bAddLab_Click);
            // 
            // lDiscipline
            // 
            this.lDiscipline.AutoSize = true;
            this.lDiscipline.Location = new System.Drawing.Point(18, 20);
            this.lDiscipline.Name = "lDiscipline";
            this.lDiscipline.Size = new System.Drawing.Size(52, 13);
            this.lDiscipline.TabIndex = 1;
            this.lDiscipline.Text = "Discipline";
            // 
            // cbDiscipline
            // 
            this.cbDiscipline.BackColor = System.Drawing.Color.PaleTurquoise;
            this.cbDiscipline.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbDiscipline.FormattingEnabled = true;
            this.cbDiscipline.Location = new System.Drawing.Point(21, 36);
            this.cbDiscipline.Name = "cbDiscipline";
            this.cbDiscipline.Size = new System.Drawing.Size(121, 21);
            this.cbDiscipline.TabIndex = 2;
            // 
            // tbLabNumber
            // 
            this.tbLabNumber.BackColor = System.Drawing.Color.PaleTurquoise;
            this.tbLabNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbLabNumber.Location = new System.Drawing.Point(177, 36);
            this.tbLabNumber.MaxLength = 2;
            this.tbLabNumber.Name = "tbLabNumber";
            this.tbLabNumber.Size = new System.Drawing.Size(34, 20);
            this.tbLabNumber.TabIndex = 3;
            this.tbLabNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbLabNumber_KeyPress);
            // 
            // lLabNumber
            // 
            this.lLabNumber.AutoSize = true;
            this.lLabNumber.Location = new System.Drawing.Point(161, 20);
            this.lLabNumber.Name = "lLabNumber";
            this.lLabNumber.Size = new System.Drawing.Size(63, 13);
            this.lLabNumber.TabIndex = 4;
            this.lLabNumber.Text = "Lab number";
            // 
            // wf_addLab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(251, 140);
            this.Controls.Add(this.lLabNumber);
            this.Controls.Add(this.tbLabNumber);
            this.Controls.Add(this.cbDiscipline);
            this.Controls.Add(this.lDiscipline);
            this.Controls.Add(this.bAddLab);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "wf_addLab";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "lagiarism";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.wf_addLab_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bAddLab;
        private System.Windows.Forms.Label lDiscipline;
        private System.Windows.Forms.ComboBox cbDiscipline;
        private System.Windows.Forms.TextBox tbLabNumber;
        private System.Windows.Forms.Label lLabNumber;
    }
}
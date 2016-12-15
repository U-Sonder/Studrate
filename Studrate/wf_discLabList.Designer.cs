namespace Studrate
{
    partial class wf_discLabList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wf_discLabList));
            this.lbLab = new System.Windows.Forms.ListBox();
            this.lLab = new System.Windows.Forms.Label();
            this.bLabDelete = new System.Windows.Forms.Button();
            this.bLabAdd = new System.Windows.Forms.Button();
            this.bDisciplineAdd = new System.Windows.Forms.Button();
            this.bDisciplineDelete = new System.Windows.Forms.Button();
            this.bRefresh = new System.Windows.Forms.Button();
            this.lbDiscipline = new System.Windows.Forms.ListBox();
            this.lDiscipline = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbLab
            // 
            this.lbLab.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lbLab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbLab.FormattingEnabled = true;
            this.lbLab.Location = new System.Drawing.Point(290, 35);
            this.lbLab.Name = "lbLab";
            this.lbLab.Size = new System.Drawing.Size(156, 171);
            this.lbLab.TabIndex = 7;
            this.lbLab.DoubleClick += new System.EventHandler(this.lbLab_DoubleClick);
            // 
            // lLab
            // 
            this.lLab.AutoSize = true;
            this.lLab.Location = new System.Drawing.Point(287, 20);
            this.lLab.Name = "lLab";
            this.lLab.Size = new System.Drawing.Size(30, 13);
            this.lLab.TabIndex = 6;
            this.lLab.Text = "Labs";
            // 
            // bLabDelete
            // 
            this.bLabDelete.BackColor = System.Drawing.Color.PaleTurquoise;
            this.bLabDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bLabDelete.Location = new System.Drawing.Point(371, 223);
            this.bLabDelete.Name = "bLabDelete";
            this.bLabDelete.Size = new System.Drawing.Size(75, 23);
            this.bLabDelete.TabIndex = 5;
            this.bLabDelete.Text = "Delete";
            this.bLabDelete.UseVisualStyleBackColor = false;
            this.bLabDelete.Click += new System.EventHandler(this.bLabDelete_Click);
            // 
            // bLabAdd
            // 
            this.bLabAdd.BackColor = System.Drawing.Color.PaleTurquoise;
            this.bLabAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bLabAdd.Location = new System.Drawing.Point(290, 223);
            this.bLabAdd.Name = "bLabAdd";
            this.bLabAdd.Size = new System.Drawing.Size(75, 23);
            this.bLabAdd.TabIndex = 4;
            this.bLabAdd.Text = "Add";
            this.bLabAdd.UseVisualStyleBackColor = false;
            this.bLabAdd.Click += new System.EventHandler(this.bLabAdd_Click);
            // 
            // bDisciplineAdd
            // 
            this.bDisciplineAdd.BackColor = System.Drawing.Color.PaleTurquoise;
            this.bDisciplineAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bDisciplineAdd.Location = new System.Drawing.Point(50, 223);
            this.bDisciplineAdd.Name = "bDisciplineAdd";
            this.bDisciplineAdd.Size = new System.Drawing.Size(75, 23);
            this.bDisciplineAdd.TabIndex = 0;
            this.bDisciplineAdd.Text = "Add";
            this.bDisciplineAdd.UseVisualStyleBackColor = false;
            this.bDisciplineAdd.Click += new System.EventHandler(this.bDisciplineAdd_Click);
            // 
            // bDisciplineDelete
            // 
            this.bDisciplineDelete.BackColor = System.Drawing.Color.PaleTurquoise;
            this.bDisciplineDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bDisciplineDelete.Location = new System.Drawing.Point(131, 223);
            this.bDisciplineDelete.Name = "bDisciplineDelete";
            this.bDisciplineDelete.Size = new System.Drawing.Size(75, 23);
            this.bDisciplineDelete.TabIndex = 1;
            this.bDisciplineDelete.Text = "Delete";
            this.bDisciplineDelete.UseVisualStyleBackColor = false;
            this.bDisciplineDelete.Click += new System.EventHandler(this.bDisciplineDelete_Click);
            // 
            // bRefresh
            // 
            this.bRefresh.BackColor = System.Drawing.Color.PaleTurquoise;
            this.bRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bRefresh.Location = new System.Drawing.Point(210, 274);
            this.bRefresh.Name = "bRefresh";
            this.bRefresh.Size = new System.Drawing.Size(75, 23);
            this.bRefresh.TabIndex = 8;
            this.bRefresh.Text = "Refresh";
            this.bRefresh.UseVisualStyleBackColor = false;
            this.bRefresh.Click += new System.EventHandler(this.bRefresh_Click);
            // 
            // lbDiscipline
            // 
            this.lbDiscipline.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lbDiscipline.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbDiscipline.FormattingEnabled = true;
            this.lbDiscipline.Location = new System.Drawing.Point(50, 35);
            this.lbDiscipline.Name = "lbDiscipline";
            this.lbDiscipline.Size = new System.Drawing.Size(156, 171);
            this.lbDiscipline.TabIndex = 3;
            this.lbDiscipline.SelectedIndexChanged += new System.EventHandler(this.lbDiscipline_SelectedIndexChanged);
            // 
            // lDiscipline
            // 
            this.lDiscipline.AutoSize = true;
            this.lDiscipline.Location = new System.Drawing.Point(47, 20);
            this.lDiscipline.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.lDiscipline.Name = "lDiscipline";
            this.lDiscipline.Size = new System.Drawing.Size(57, 13);
            this.lDiscipline.TabIndex = 2;
            this.lDiscipline.Text = "Disciplines";
            // 
            // wf_discLabList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(498, 318);
            this.Controls.Add(this.lDiscipline);
            this.Controls.Add(this.bDisciplineAdd);
            this.Controls.Add(this.lbDiscipline);
            this.Controls.Add(this.bDisciplineDelete);
            this.Controls.Add(this.lbLab);
            this.Controls.Add(this.bRefresh);
            this.Controls.Add(this.lLab);
            this.Controls.Add(this.bLabDelete);
            this.Controls.Add(this.bLabAdd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(514, 357);
            this.MinimumSize = new System.Drawing.Size(514, 357);
            this.Name = "wf_discLabList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "lagiarism";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lbLab;
        private System.Windows.Forms.Label lLab;
        private System.Windows.Forms.Button bLabDelete;
        private System.Windows.Forms.Button bLabAdd;
        private System.Windows.Forms.Button bDisciplineAdd;
        private System.Windows.Forms.Button bDisciplineDelete;
        private System.Windows.Forms.Button bRefresh;
        public System.Windows.Forms.ListBox lbDiscipline;
        private System.Windows.Forms.Label lDiscipline;
    }
}
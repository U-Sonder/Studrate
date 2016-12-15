namespace Studrate
{
    partial class wf_Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wf_Menu));
            this.bAddData = new System.Windows.Forms.Button();
            this.bStudPlagList = new System.Windows.Forms.Button();
            this.bDiscLabLis = new System.Windows.Forms.Button();
            this.bClearAll = new System.Windows.Forms.Button();
            this.bExit = new System.Windows.Forms.Button();
            this.tlpButtons = new System.Windows.Forms.TableLayoutPanel();
            this.tlpButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // bAddData
            // 
            this.bAddData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bAddData.BackColor = System.Drawing.Color.PaleTurquoise;
            this.bAddData.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bAddData.Location = new System.Drawing.Point(85, 10);
            this.bAddData.Name = "bAddData";
            this.bAddData.Size = new System.Drawing.Size(75, 30);
            this.bAddData.TabIndex = 0;
            this.bAddData.Text = "Add data";
            this.bAddData.UseVisualStyleBackColor = false;
            this.bAddData.Click += new System.EventHandler(this.bAddData_Click);
            // 
            // bStudPlagList
            // 
            this.bStudPlagList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bStudPlagList.BackColor = System.Drawing.Color.PaleTurquoise;
            this.bStudPlagList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bStudPlagList.Location = new System.Drawing.Point(85, 111);
            this.bStudPlagList.Name = "bStudPlagList";
            this.bStudPlagList.Size = new System.Drawing.Size(75, 30);
            this.bStudPlagList.TabIndex = 2;
            this.bStudPlagList.Text = "Plagiarism";
            this.bStudPlagList.UseVisualStyleBackColor = false;
            this.bStudPlagList.Click += new System.EventHandler(this.bStudPlagList_Click);
            // 
            // bDiscLabLis
            // 
            this.bDiscLabLis.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bDiscLabLis.BackColor = System.Drawing.Color.PaleTurquoise;
            this.bDiscLabLis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bDiscLabLis.Location = new System.Drawing.Point(85, 60);
            this.bDiscLabLis.Name = "bDiscLabLis";
            this.bDiscLabLis.Size = new System.Drawing.Size(75, 30);
            this.bDiscLabLis.TabIndex = 4;
            this.bDiscLabLis.Text = "Lab list";
            this.bDiscLabLis.UseVisualStyleBackColor = false;
            this.bDiscLabLis.Click += new System.EventHandler(this.bDiscLabLis_Click);
            // 
            // bClearAll
            // 
            this.bClearAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bClearAll.BackColor = System.Drawing.Color.PaleTurquoise;
            this.bClearAll.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bClearAll.Location = new System.Drawing.Point(12, 207);
            this.bClearAll.Name = "bClearAll";
            this.bClearAll.Size = new System.Drawing.Size(78, 35);
            this.bClearAll.TabIndex = 5;
            this.bClearAll.Text = "Clear all data";
            this.bClearAll.UseVisualStyleBackColor = false;
            this.bClearAll.Click += new System.EventHandler(this.bClearAll_Click);
            // 
            // bExit
            // 
            this.bExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bExit.BackColor = System.Drawing.Color.PaleTurquoise;
            this.bExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bExit.Location = new System.Drawing.Point(180, 207);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(78, 35);
            this.bExit.TabIndex = 6;
            this.bExit.Text = "Exit";
            this.bExit.UseVisualStyleBackColor = false;
            this.bExit.Click += new System.EventHandler(this.bExit_Click);
            // 
            // tlpButtons
            // 
            this.tlpButtons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpButtons.ColumnCount = 1;
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpButtons.Controls.Add(this.bAddData, 0, 0);
            this.tlpButtons.Controls.Add(this.bStudPlagList, 0, 2);
            this.tlpButtons.Controls.Add(this.bDiscLabLis, 0, 1);
            this.tlpButtons.Location = new System.Drawing.Point(12, 36);
            this.tlpButtons.Name = "tlpButtons";
            this.tlpButtons.RowCount = 3;
            this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.51515F));
            this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.48485F));
            this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tlpButtons.Size = new System.Drawing.Size(246, 154);
            this.tlpButtons.TabIndex = 7;
            // 
            // wf_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(270, 254);
            this.Controls.Add(this.tlpButtons);
            this.Controls.Add(this.bExit);
            this.Controls.Add(this.bClearAll);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(286, 293);
            this.Name = "wf_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "lagiarism";
            this.tlpButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bAddData;
        private System.Windows.Forms.Button bStudPlagList;
        private System.Windows.Forms.Button bDiscLabLis;
        private System.Windows.Forms.Button bClearAll;
        private System.Windows.Forms.Button bExit;
        private System.Windows.Forms.TableLayoutPanel tlpButtons;
    }
}
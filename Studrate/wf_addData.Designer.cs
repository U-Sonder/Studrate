namespace Studrate
{
    partial class wf_addData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wf_addData));
            this.bDisciplineAdd = new System.Windows.Forms.Button();
            this.lDiscipline = new System.Windows.Forms.Label();
            this.cbDiscipline = new System.Windows.Forms.ComboBox();
            this.ofdPlag = new System.Windows.Forms.OpenFileDialog();
            this.bFile = new System.Windows.Forms.Button();
            this.bAddPlag = new System.Windows.Forms.Button();
            this.rtbErrorRow = new System.Windows.Forms.RichTextBox();
            this.bSave = new System.Windows.Forms.Button();
            this.lError = new System.Windows.Forms.Label();
            this.sfdErrorText = new System.Windows.Forms.SaveFileDialog();
            this.tlpErrorList = new System.Windows.Forms.TableLayoutPanel();
            this.tlpErrorList.SuspendLayout();
            this.SuspendLayout();
            // 
            // bDisciplineAdd
            // 
            this.bDisciplineAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bDisciplineAdd.BackColor = System.Drawing.Color.PaleTurquoise;
            this.bDisciplineAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bDisciplineAdd.Location = new System.Drawing.Point(379, 83);
            this.bDisciplineAdd.Name = "bDisciplineAdd";
            this.bDisciplineAdd.Size = new System.Drawing.Size(75, 23);
            this.bDisciplineAdd.TabIndex = 0;
            this.bDisciplineAdd.Text = "Add";
            this.bDisciplineAdd.UseVisualStyleBackColor = false;
            this.bDisciplineAdd.Click += new System.EventHandler(this.bDisciplineAdd_Click);
            // 
            // lDiscipline
            // 
            this.lDiscipline.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lDiscipline.AutoSize = true;
            this.lDiscipline.Location = new System.Drawing.Point(388, 18);
            this.lDiscipline.Name = "lDiscipline";
            this.lDiscipline.Size = new System.Drawing.Size(52, 13);
            this.lDiscipline.TabIndex = 1;
            this.lDiscipline.Text = "Discipline";
            // 
            // cbDiscipline
            // 
            this.cbDiscipline.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbDiscipline.BackColor = System.Drawing.Color.PaleTurquoise;
            this.cbDiscipline.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbDiscipline.FormattingEnabled = true;
            this.cbDiscipline.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbDiscipline.Location = new System.Drawing.Point(357, 44);
            this.cbDiscipline.Name = "cbDiscipline";
            this.cbDiscipline.Size = new System.Drawing.Size(121, 21);
            this.cbDiscipline.TabIndex = 2;
            // 
            // ofdPlag
            // 
            this.ofdPlag.FileName = "plagFile";
            // 
            // bFile
            // 
            this.bFile.BackColor = System.Drawing.Color.PaleTurquoise;
            this.bFile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bFile.Location = new System.Drawing.Point(57, 35);
            this.bFile.Name = "bFile";
            this.bFile.Size = new System.Drawing.Size(75, 23);
            this.bFile.TabIndex = 3;
            this.bFile.Text = "Chose file";
            this.bFile.UseVisualStyleBackColor = false;
            this.bFile.Click += new System.EventHandler(this.bFile_Click);
            // 
            // bAddPlag
            // 
            this.bAddPlag.BackColor = System.Drawing.Color.PaleTurquoise;
            this.bAddPlag.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bAddPlag.Location = new System.Drawing.Point(57, 64);
            this.bAddPlag.Name = "bAddPlag";
            this.bAddPlag.Size = new System.Drawing.Size(75, 23);
            this.bAddPlag.TabIndex = 4;
            this.bAddPlag.Text = "Parse file";
            this.bAddPlag.UseVisualStyleBackColor = false;
            this.bAddPlag.Click += new System.EventHandler(this.bAddPlag_Click);
            // 
            // rtbErrorRow
            // 
            this.rtbErrorRow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbErrorRow.BackColor = System.Drawing.Color.PaleTurquoise;
            this.rtbErrorRow.Location = new System.Drawing.Point(10, 23);
            this.rtbErrorRow.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.rtbErrorRow.Name = "rtbErrorRow";
            this.rtbErrorRow.Size = new System.Drawing.Size(504, 201);
            this.rtbErrorRow.TabIndex = 5;
            this.rtbErrorRow.Text = "";
            // 
            // bSave
            // 
            this.bSave.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.bSave.BackColor = System.Drawing.Color.PaleTurquoise;
            this.bSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bSave.Location = new System.Drawing.Point(30, 239);
            this.bSave.Margin = new System.Windows.Forms.Padding(30, 3, 3, 3);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(75, 23);
            this.bSave.TabIndex = 6;
            this.bSave.Text = "Save";
            this.bSave.UseVisualStyleBackColor = false;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // lError
            // 
            this.lError.AutoSize = true;
            this.lError.Location = new System.Drawing.Point(15, 0);
            this.lError.Margin = new System.Windows.Forms.Padding(15, 0, 3, 0);
            this.lError.Name = "lError";
            this.lError.Size = new System.Drawing.Size(47, 13);
            this.lError.TabIndex = 7;
            this.lError.Text = "Error list:";
            // 
            // tlpErrorList
            // 
            this.tlpErrorList.ColumnCount = 1;
            this.tlpErrorList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpErrorList.Controls.Add(this.rtbErrorRow, 0, 1);
            this.tlpErrorList.Controls.Add(this.bSave, 0, 2);
            this.tlpErrorList.Controls.Add(this.lError, 0, 0);
            this.tlpErrorList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tlpErrorList.Location = new System.Drawing.Point(0, 126);
            this.tlpErrorList.Name = "tlpErrorList";
            this.tlpErrorList.RowCount = 3;
            this.tlpErrorList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpErrorList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpErrorList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tlpErrorList.Size = new System.Drawing.Size(528, 275);
            this.tlpErrorList.TabIndex = 8;
            // 
            // wf_addData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(528, 401);
            this.Controls.Add(this.tlpErrorList);
            this.Controls.Add(this.bAddPlag);
            this.Controls.Add(this.bFile);
            this.Controls.Add(this.cbDiscipline);
            this.Controls.Add(this.lDiscipline);
            this.Controls.Add(this.bDisciplineAdd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "wf_addData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "lagiarism";
            this.tlpErrorList.ResumeLayout(false);
            this.tlpErrorList.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bDisciplineAdd;
        private System.Windows.Forms.Label lDiscipline;
        private System.Windows.Forms.OpenFileDialog ofdPlag;
        private System.Windows.Forms.Button bFile;
        private System.Windows.Forms.Button bAddPlag;
        private System.Windows.Forms.RichTextBox rtbErrorRow;
        public System.Windows.Forms.ComboBox cbDiscipline;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.Label lError;
        private System.Windows.Forms.SaveFileDialog sfdErrorText;
        private System.Windows.Forms.TableLayoutPanel tlpErrorList;
    }
}
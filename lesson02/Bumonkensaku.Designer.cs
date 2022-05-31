namespace lesson02
{
    partial class Bumonkensaku
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.RD_PartialMatch = new System.Windows.Forms.RadioButton();
            this.RD_FirstMatch = new System.Windows.Forms.RadioButton();
            this.TXT_Bumonname = new System.Windows.Forms.TextBox();
            this.TXT_Bumoncode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.DGV_Bumonlist = new System.Windows.Forms.DataGridView();
            this.cbumon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sbumon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BT_Kensaku = new System.Windows.Forms.Button();
            this.BT_Yomi = new System.Windows.Forms.Button();
            this.BT_Clear = new System.Windows.Forms.Button();
            this.BTN_Close = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Bumonlist)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.TXT_Bumonname);
            this.panel1.Controls.Add(this.TXT_Bumoncode);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(647, 85);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.RD_PartialMatch);
            this.panel2.Controls.Add(this.RD_FirstMatch);
            this.panel2.Location = new System.Drawing.Point(402, 47);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(162, 19);
            this.panel2.TabIndex = 6;
            // 
            // RD_PartialMatch
            // 
            this.RD_PartialMatch.AutoSize = true;
            this.RD_PartialMatch.Checked = true;
            this.RD_PartialMatch.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.RD_PartialMatch.Location = new System.Drawing.Point(87, 1);
            this.RD_PartialMatch.Name = "RD_PartialMatch";
            this.RD_PartialMatch.Size = new System.Drawing.Size(71, 16);
            this.RD_PartialMatch.TabIndex = 5;
            this.RD_PartialMatch.TabStop = true;
            this.RD_PartialMatch.Text = "部分一致";
            this.RD_PartialMatch.UseVisualStyleBackColor = true;
            this.RD_PartialMatch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RD_PartialMatch_KeyDown);
            // 
            // RD_FirstMatch
            // 
            this.RD_FirstMatch.AutoSize = true;
            this.RD_FirstMatch.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.RD_FirstMatch.Location = new System.Drawing.Point(8, 1);
            this.RD_FirstMatch.Name = "RD_FirstMatch";
            this.RD_FirstMatch.Size = new System.Drawing.Size(71, 16);
            this.RD_FirstMatch.TabIndex = 4;
            this.RD_FirstMatch.Text = "先頭一致";
            this.RD_FirstMatch.UseVisualStyleBackColor = true;
            this.RD_FirstMatch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RD_FirstMatch_KeyDown);
            // 
            // TXT_Bumonname
            // 
            this.TXT_Bumonname.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.TXT_Bumonname.Location = new System.Drawing.Point(81, 47);
            this.TXT_Bumonname.Name = "TXT_Bumonname";
            this.TXT_Bumonname.Size = new System.Drawing.Size(304, 19);
            this.TXT_Bumonname.TabIndex = 3;
            this.TXT_Bumonname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TXT_Bumonname_KeyDown);
            // 
            // TXT_Bumoncode
            // 
            this.TXT_Bumoncode.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.TXT_Bumoncode.Location = new System.Drawing.Point(81, 19);
            this.TXT_Bumoncode.MaxLength = 2;
            this.TXT_Bumoncode.Name = "TXT_Bumoncode";
            this.TXT_Bumoncode.Size = new System.Drawing.Size(20, 19);
            this.TXT_Bumoncode.TabIndex = 2;
            this.TXT_Bumoncode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TXT_Bumoncode_KeyDown);
            this.TXT_Bumoncode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXT_Bumoncode_KeyPress);
            this.TXT_Bumoncode.Leave += new System.EventHandler(this.TXT_Bumoncode_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(8, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "部門名";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(8, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "部門コード";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.DGV_Bumonlist);
            this.panel3.Location = new System.Drawing.Point(3, 92);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(647, 444);
            this.panel3.TabIndex = 1;
            // 
            // DGV_Bumonlist
            // 
            this.DGV_Bumonlist.AllowUserToAddRows = false;
            this.DGV_Bumonlist.AllowUserToDeleteRows = false;
            this.DGV_Bumonlist.AllowUserToResizeRows = false;
            this.DGV_Bumonlist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCellsExceptHeader;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_Bumonlist.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGV_Bumonlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Bumonlist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cbumon,
            this.sbumon});
            this.DGV_Bumonlist.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.DGV_Bumonlist.Location = new System.Drawing.Point(3, 2);
            this.DGV_Bumonlist.MultiSelect = false;
            this.DGV_Bumonlist.Name = "DGV_Bumonlist";
            this.DGV_Bumonlist.ReadOnly = true;
            this.DGV_Bumonlist.RowHeadersVisible = false;
            this.DGV_Bumonlist.RowTemplate.Height = 21;
            this.DGV_Bumonlist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Bumonlist.Size = new System.Drawing.Size(639, 438);
            this.DGV_Bumonlist.TabIndex = 0;
            this.DGV_Bumonlist.TabStop = false;
            this.DGV_Bumonlist.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Bumonlist_CellDoubleClick);
            // 
            // cbumon
            // 
            this.cbumon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.cbumon.DataPropertyName = "bumoncode";
            this.cbumon.HeaderText = "部門コード";
            this.cbumon.Name = "cbumon";
            this.cbumon.ReadOnly = true;
            this.cbumon.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cbumon.Width = 140;
            // 
            // sbumon
            // 
            this.sbumon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.sbumon.DataPropertyName = "bumonname";
            this.sbumon.HeaderText = "部門名";
            this.sbumon.Name = "sbumon";
            this.sbumon.ReadOnly = true;
            this.sbumon.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.sbumon.Width = 480;
            // 
            // BT_Kensaku
            // 
            this.BT_Kensaku.BackColor = System.Drawing.Color.Gold;
            this.BT_Kensaku.Font = new System.Drawing.Font("ＭＳ ゴシック", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BT_Kensaku.Location = new System.Drawing.Point(656, 1);
            this.BT_Kensaku.Name = "BT_Kensaku";
            this.BT_Kensaku.Size = new System.Drawing.Size(75, 48);
            this.BT_Kensaku.TabIndex = 2;
            this.BT_Kensaku.Text = "検索";
            this.BT_Kensaku.UseVisualStyleBackColor = false;
            this.BT_Kensaku.Click += new System.EventHandler(this.BT_Kensaku_Click);
            // 
            // BT_Yomi
            // 
            this.BT_Yomi.BackColor = System.Drawing.Color.Gold;
            this.BT_Yomi.Enabled = false;
            this.BT_Yomi.Font = new System.Drawing.Font("ＭＳ ゴシック", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BT_Yomi.Location = new System.Drawing.Point(656, 91);
            this.BT_Yomi.Name = "BT_Yomi";
            this.BT_Yomi.Size = new System.Drawing.Size(75, 48);
            this.BT_Yomi.TabIndex = 3;
            this.BT_Yomi.Text = "読込む";
            this.BT_Yomi.UseVisualStyleBackColor = false;
            this.BT_Yomi.Click += new System.EventHandler(this.BT_Yomi_Click);
            // 
            // BT_Clear
            // 
            this.BT_Clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(231)))), ((int)(((byte)(249)))));
            this.BT_Clear.Enabled = false;
            this.BT_Clear.Font = new System.Drawing.Font("ＭＳ ゴシック", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BT_Clear.Location = new System.Drawing.Point(656, 146);
            this.BT_Clear.Name = "BT_Clear";
            this.BT_Clear.Size = new System.Drawing.Size(75, 48);
            this.BT_Clear.TabIndex = 4;
            this.BT_Clear.Text = "クリア";
            this.BT_Clear.UseVisualStyleBackColor = false;
            this.BT_Clear.Click += new System.EventHandler(this.BT_Clear_Click);
            // 
            // BTN_Close
            // 
            this.BTN_Close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(231)))), ((int)(((byte)(249)))));
            this.BTN_Close.Font = new System.Drawing.Font("ＭＳ ゴシック", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BTN_Close.Location = new System.Drawing.Point(656, 488);
            this.BTN_Close.Name = "BTN_Close";
            this.BTN_Close.Size = new System.Drawing.Size(75, 48);
            this.BTN_Close.TabIndex = 5;
            this.BTN_Close.Text = "閉じる";
            this.BTN_Close.UseVisualStyleBackColor = false;
            this.BTN_Close.Click += new System.EventHandler(this.BTN_Close_Click);
            // 
            // Bumonkensaku
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(734, 540);
            this.Controls.Add(this.BTN_Close);
            this.Controls.Add(this.BT_Clear);
            this.Controls.Add(this.BT_Yomi);
            this.Controls.Add(this.BT_Kensaku);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.MaximizeBox = false;
            this.Name = "Bumonkensaku";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "部門検索";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Bumonlist)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXT_Bumoncode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TXT_Bumonname;
        private System.Windows.Forms.RadioButton RD_FirstMatch;
        private System.Windows.Forms.RadioButton RD_PartialMatch;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button BT_Kensaku;
        private System.Windows.Forms.Button BT_Yomi;
        private System.Windows.Forms.Button BT_Clear;
        private System.Windows.Forms.Button BTN_Close;
        private System.Windows.Forms.DataGridView DGV_Bumonlist;
        private System.Windows.Forms.DataGridViewTextBoxColumn cbumon;
        private System.Windows.Forms.DataGridViewTextBoxColumn sbumon;
    }
}
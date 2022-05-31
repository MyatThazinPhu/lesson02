namespace lesson02
{
    partial class FRM_Bumon
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.BT_Close = new System.Windows.Forms.Button();
            this.BT_Cancel = new System.Windows.Forms.Button();
            this.BT_Save = new System.Windows.Forms.Button();
            this.BT_ChangeInput = new System.Windows.Forms.Button();
            this.BT_NewInput = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.TXT_Bumonname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BT_Jidocode = new System.Windows.Forms.Button();
            this.TXT_Bumoncode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.BT_Close);
            this.panel1.Controls.Add(this.BT_Cancel);
            this.panel1.Controls.Add(this.BT_Save);
            this.panel1.Controls.Add(this.BT_ChangeInput);
            this.panel1.Controls.Add(this.BT_NewInput);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1259, 68);
            this.panel1.TabIndex = 0;
            // 
            // BT_Close
            // 
            this.BT_Close.Font = new System.Drawing.Font("ＭＳ ゴシック", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BT_Close.Location = new System.Drawing.Point(1116, 11);
            this.BT_Close.Name = "BT_Close";
            this.BT_Close.Size = new System.Drawing.Size(91, 44);
            this.BT_Close.TabIndex = 4;
            this.BT_Close.Text = "閉じる";
            this.BT_Close.UseVisualStyleBackColor = true;
            this.BT_Close.Click += new System.EventHandler(this.BT_Close_Click);
            // 
            // BT_Cancel
            // 
            this.BT_Cancel.Enabled = false;
            this.BT_Cancel.Font = new System.Drawing.Font("ＭＳ ゴシック", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BT_Cancel.Location = new System.Drawing.Point(402, 11);
            this.BT_Cancel.Name = "BT_Cancel";
            this.BT_Cancel.Size = new System.Drawing.Size(91, 44);
            this.BT_Cancel.TabIndex = 3;
            this.BT_Cancel.Text = "取消";
            this.BT_Cancel.UseVisualStyleBackColor = true;
            this.BT_Cancel.Click += new System.EventHandler(this.BT_Cancel_Click);
            // 
            // BT_Save
            // 
            this.BT_Save.Enabled = false;
            this.BT_Save.Font = new System.Drawing.Font("ＭＳ ゴシック", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BT_Save.Location = new System.Drawing.Point(304, 11);
            this.BT_Save.Name = "BT_Save";
            this.BT_Save.Size = new System.Drawing.Size(91, 44);
            this.BT_Save.TabIndex = 2;
            this.BT_Save.Text = "保存";
            this.BT_Save.UseVisualStyleBackColor = true;
            this.BT_Save.Click += new System.EventHandler(this.BT_Save_Click);
            // 
            // BT_ChangeInput
            // 
            this.BT_ChangeInput.Font = new System.Drawing.Font("ＭＳ ゴシック", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BT_ChangeInput.Location = new System.Drawing.Point(110, 11);
            this.BT_ChangeInput.Name = "BT_ChangeInput";
            this.BT_ChangeInput.Size = new System.Drawing.Size(91, 44);
            this.BT_ChangeInput.TabIndex = 1;
            this.BT_ChangeInput.Text = "変更入力";
            this.BT_ChangeInput.UseVisualStyleBackColor = true;
            this.BT_ChangeInput.Click += new System.EventHandler(this.BT_ChangeInput_Click);
            // 
            // BT_NewInput
            // 
            this.BT_NewInput.Font = new System.Drawing.Font("ＭＳ ゴシック", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BT_NewInput.Location = new System.Drawing.Point(12, 11);
            this.BT_NewInput.Name = "BT_NewInput";
            this.BT_NewInput.Size = new System.Drawing.Size(91, 44);
            this.BT_NewInput.TabIndex = 0;
            this.BT_NewInput.Text = "新規入力";
            this.BT_NewInput.UseVisualStyleBackColor = true;
            this.BT_NewInput.Click += new System.EventHandler(this.BT_NewInput_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(412, 412);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(430, 41);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("ＭＳ ゴシック", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(172, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "入力画面";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.TXT_Bumonname);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.BT_Jidocode);
            this.panel3.Controls.Add(this.TXT_Bumoncode);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(412, 459);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(430, 92);
            this.panel3.TabIndex = 2;
            // 
            // TXT_Bumonname
            // 
            this.TXT_Bumonname.BackColor = System.Drawing.SystemColors.Window;
            this.TXT_Bumonname.Enabled = false;
            this.TXT_Bumonname.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.TXT_Bumonname.Location = new System.Drawing.Point(104, 53);
            this.TXT_Bumonname.Name = "TXT_Bumonname";
            this.TXT_Bumonname.Size = new System.Drawing.Size(301, 19);
            this.TXT_Bumonname.TabIndex = 2;
            this.TXT_Bumonname.TextChanged += new System.EventHandler(this.TXT_Bumonname_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("ＭＳ ゴシック", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(20, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "部門名";
            // 
            // BT_Jidocode
            // 
            this.BT_Jidocode.BackColor = System.Drawing.Color.Gold;
            this.BT_Jidocode.Enabled = false;
            this.BT_Jidocode.Location = new System.Drawing.Point(132, 14);
            this.BT_Jidocode.Name = "BT_Jidocode";
            this.BT_Jidocode.Size = new System.Drawing.Size(75, 23);
            this.BT_Jidocode.TabIndex = 0;
            this.BT_Jidocode.TabStop = false;
            this.BT_Jidocode.Text = "自動コード";
            this.BT_Jidocode.UseVisualStyleBackColor = false;
            this.BT_Jidocode.Click += new System.EventHandler(this.BT_Jidocode_Click);
            // 
            // TXT_Bumoncode
            // 
            this.TXT_Bumoncode.Enabled = false;
            this.TXT_Bumoncode.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.TXT_Bumoncode.Location = new System.Drawing.Point(104, 16);
            this.TXT_Bumoncode.MaxLength = 2;
            this.TXT_Bumoncode.Name = "TXT_Bumoncode";
            this.TXT_Bumoncode.Size = new System.Drawing.Size(20, 19);
            this.TXT_Bumoncode.TabIndex = 1;
            this.TXT_Bumoncode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXT_Bumoncode_KeyPress);
            this.TXT_Bumoncode.Leave += new System.EventHandler(this.TXT_Bumoncode_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("ＭＳ ゴシック", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(20, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "部門コード";
            // 
            // FRM_Bumon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1264, 985);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Name = "FRM_Bumon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "部門";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FRM_Bumon_FormClosing);
            this.Load += new System.EventHandler(this.FRM_Bumon_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Button BT_NewInput;
        public System.Windows.Forms.Button BT_Cancel;
        public System.Windows.Forms.Button BT_Save;
        public System.Windows.Forms.Button BT_ChangeInput;
        public System.Windows.Forms.Button BT_Close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button BT_Jidocode;
        public System.Windows.Forms.TextBox TXT_Bumoncode;
        public System.Windows.Forms.TextBox TXT_Bumonname;
        private System.Windows.Forms.Label label3;
    }
}


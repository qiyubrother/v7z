namespace v7zConfiguration
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label2 = new System.Windows.Forms.Label();
            this.txtCompressionFileDirectory = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.rbHide = new System.Windows.Forms.RadioButton();
            this.rbShow = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txt7z = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtv7z = new System.Windows.Forms.TextBox();
            this.btnDefault = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUncompressionFileDirectory = new System.Windows.Forms.TextBox();
            this.txtv7zuncompress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Compression File Directory";
            // 
            // txtCompressionFileDirectory
            // 
            this.txtCompressionFileDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCompressionFileDirectory.Location = new System.Drawing.Point(198, 64);
            this.txtCompressionFileDirectory.Name = "txtCompressionFileDirectory";
            this.txtCompressionFileDirectory.Size = new System.Drawing.Size(562, 20);
            this.txtCompressionFileDirectory.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword.Location = new System.Drawing.Point(198, 90);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(562, 20);
            this.txtPassword.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(198, 220);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // rbHide
            // 
            this.rbHide.AutoSize = true;
            this.rbHide.Checked = true;
            this.rbHide.Location = new System.Drawing.Point(198, 116);
            this.rbHide.Name = "rbHide";
            this.rbHide.Size = new System.Drawing.Size(97, 17);
            this.rbHide.TabIndex = 4;
            this.rbHide.TabStop = true;
            this.rbHide.Text = "Hide File Name";
            this.rbHide.UseVisualStyleBackColor = true;
            // 
            // rbShow
            // 
            this.rbShow.AutoSize = true;
            this.rbShow.Location = new System.Drawing.Point(301, 116);
            this.rbShow.Name = "rbShow";
            this.rbShow.Size = new System.Drawing.Size(102, 17);
            this.rbShow.TabIndex = 5;
            this.rbShow.Text = "Show File Name";
            this.rbShow.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "7z";
            // 
            // txt7z
            // 
            this.txt7z.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt7z.Location = new System.Drawing.Point(198, 38);
            this.txt7z.Name = "txt7z";
            this.txt7z.Size = new System.Drawing.Size(562, 20);
            this.txt7z.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "v7z";
            // 
            // txtv7z
            // 
            this.txtv7z.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtv7z.Location = new System.Drawing.Point(198, 12);
            this.txtv7z.Name = "txtv7z";
            this.txtv7z.Size = new System.Drawing.Size(562, 20);
            this.txtv7z.TabIndex = 0;
            // 
            // btnDefault
            // 
            this.btnDefault.Location = new System.Drawing.Point(20, 220);
            this.btnDefault.Name = "btnDefault";
            this.btnDefault.Size = new System.Drawing.Size(75, 23);
            this.btnDefault.TabIndex = 6;
            this.btnDefault.Text = "Default";
            this.btnDefault.UseVisualStyleBackColor = true;
            this.btnDefault.Click += new System.EventHandler(this.btnDefault_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Uncompression File Directory";
            // 
            // txtUncompressionFileDirectory
            // 
            this.txtUncompressionFileDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUncompressionFileDirectory.Location = new System.Drawing.Point(198, 185);
            this.txtUncompressionFileDirectory.Name = "txtUncompressionFileDirectory";
            this.txtUncompressionFileDirectory.Size = new System.Drawing.Size(562, 20);
            this.txtUncompressionFileDirectory.TabIndex = 13;
            // 
            // txtv7zuncompress
            // 
            this.txtv7zuncompress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtv7zuncompress.Location = new System.Drawing.Point(198, 159);
            this.txtv7zuncompress.Name = "txtv7zuncompress";
            this.txtv7zuncompress.Size = new System.Drawing.Size(562, 20);
            this.txtv7zuncompress.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "v7zUncompress";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 257);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtv7zuncompress);
            this.Controls.Add(this.txtUncompressionFileDirectory);
            this.Controls.Add(this.btnDefault);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtv7z);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt7z);
            this.Controls.Add(this.rbShow);
            this.Controls.Add(this.rbHide);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCompressionFileDirectory);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "v7zConfiguration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCompressionFileDirectory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.RadioButton rbHide;
        private System.Windows.Forms.RadioButton rbShow;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt7z;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtv7z;
        private System.Windows.Forms.Button btnDefault;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUncompressionFileDirectory;
        private System.Windows.Forms.TextBox txtv7zuncompress;
        private System.Windows.Forms.Label label6;
    }
}


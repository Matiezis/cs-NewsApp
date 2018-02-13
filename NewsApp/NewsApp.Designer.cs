namespace NewsApp
{
    partial class NewsApp
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
            this.rtbInput = new System.Windows.Forms.RichTextBox();
            this.tbKeyword = new System.Windows.Forms.TextBox();
            this.bttnRun = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.rtbOutput = new System.Windows.Forms.RichTextBox();
            this.bttnSend = new System.Windows.Forms.Button();
            this.tbMailInput = new System.Windows.Forms.TextBox();
            this.tbEmailAdress = new System.Windows.Forms.TextBox();
            this.tbEmailLogin = new System.Windows.Forms.TextBox();
            this.tbEmailPassword = new System.Windows.Forms.TextBox();
            this.lblEmailAdress = new System.Windows.Forms.Label();
            this.lblEmailLogin = new System.Windows.Forms.Label();
            this.lblEmailPassword = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bttnSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbInput
            // 
            this.rtbInput.Location = new System.Drawing.Point(12, 43);
            this.rtbInput.Name = "rtbInput";
            this.rtbInput.Size = new System.Drawing.Size(495, 230);
            this.rtbInput.TabIndex = 0;
            this.rtbInput.Text = "";
            // 
            // tbKeyword
            // 
            this.tbKeyword.Enabled = false;
            this.tbKeyword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbKeyword.Location = new System.Drawing.Point(513, 12);
            this.tbKeyword.Name = "tbKeyword";
            this.tbKeyword.Size = new System.Drawing.Size(375, 24);
            this.tbKeyword.TabIndex = 2;
            // 
            // bttnRun
            // 
            this.bttnRun.Enabled = false;
            this.bttnRun.Location = new System.Drawing.Point(894, 12);
            this.bttnRun.Name = "bttnRun";
            this.bttnRun.Size = new System.Drawing.Size(114, 23);
            this.bttnRun.TabIndex = 3;
            this.bttnRun.Text = "Filter";
            this.bttnRun.UseVisualStyleBackColor = true;
            this.bttnRun.Click += new System.EventHandler(this.bttnRun_Click);
            // 
            // tabControl
            // 
            this.tabControl.Location = new System.Drawing.Point(12, 279);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(495, 299);
            this.tabControl.TabIndex = 4;
            // 
            // rtbOutput
            // 
            this.rtbOutput.Enabled = false;
            this.rtbOutput.Location = new System.Drawing.Point(514, 43);
            this.rtbOutput.Name = "rtbOutput";
            this.rtbOutput.Size = new System.Drawing.Size(494, 386);
            this.rtbOutput.TabIndex = 5;
            this.rtbOutput.Text = "";
            // 
            // bttnSend
            // 
            this.bttnSend.Enabled = false;
            this.bttnSend.Location = new System.Drawing.Point(713, 555);
            this.bttnSend.Name = "bttnSend";
            this.bttnSend.Size = new System.Drawing.Size(114, 23);
            this.bttnSend.TabIndex = 6;
            this.bttnSend.Text = "Send via Mail";
            this.bttnSend.UseVisualStyleBackColor = true;
            this.bttnSend.Click += new System.EventHandler(this.bttnSend_Click);
            // 
            // tbMailInput
            // 
            this.tbMailInput.Enabled = false;
            this.tbMailInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbMailInput.Location = new System.Drawing.Point(633, 525);
            this.tbMailInput.Name = "tbMailInput";
            this.tbMailInput.Size = new System.Drawing.Size(375, 24);
            this.tbMailInput.TabIndex = 7;
            // 
            // tbEmailAdress
            // 
            this.tbEmailAdress.Enabled = false;
            this.tbEmailAdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbEmailAdress.Location = new System.Drawing.Point(633, 435);
            this.tbEmailAdress.Name = "tbEmailAdress";
            this.tbEmailAdress.Size = new System.Drawing.Size(375, 24);
            this.tbEmailAdress.TabIndex = 8;
            // 
            // tbEmailLogin
            // 
            this.tbEmailLogin.Enabled = false;
            this.tbEmailLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbEmailLogin.Location = new System.Drawing.Point(633, 465);
            this.tbEmailLogin.Name = "tbEmailLogin";
            this.tbEmailLogin.Size = new System.Drawing.Size(375, 24);
            this.tbEmailLogin.TabIndex = 9;
            // 
            // tbEmailPassword
            // 
            this.tbEmailPassword.Enabled = false;
            this.tbEmailPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbEmailPassword.Location = new System.Drawing.Point(633, 495);
            this.tbEmailPassword.Name = "tbEmailPassword";
            this.tbEmailPassword.PasswordChar = '*';
            this.tbEmailPassword.Size = new System.Drawing.Size(375, 24);
            this.tbEmailPassword.TabIndex = 10;
            // 
            // lblEmailAdress
            // 
            this.lblEmailAdress.AutoSize = true;
            this.lblEmailAdress.Location = new System.Drawing.Point(535, 442);
            this.lblEmailAdress.Name = "lblEmailAdress";
            this.lblEmailAdress.Size = new System.Drawing.Size(92, 13);
            this.lblEmailAdress.TabIndex = 11;
            this.lblEmailAdress.Text = "Your Email Adress";
            // 
            // lblEmailLogin
            // 
            this.lblEmailLogin.AutoSize = true;
            this.lblEmailLogin.Location = new System.Drawing.Point(541, 472);
            this.lblEmailLogin.Name = "lblEmailLogin";
            this.lblEmailLogin.Size = new System.Drawing.Size(86, 13);
            this.lblEmailLogin.TabIndex = 12;
            this.lblEmailLogin.Text = "Your Email Login";
            // 
            // lblEmailPassword
            // 
            this.lblEmailPassword.AutoSize = true;
            this.lblEmailPassword.Location = new System.Drawing.Point(521, 502);
            this.lblEmailPassword.Name = "lblEmailPassword";
            this.lblEmailPassword.Size = new System.Drawing.Size(106, 13);
            this.lblEmailPassword.TabIndex = 13;
            this.lblEmailPassword.Text = "Your Email Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(514, 532);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Recipent Email Adress";
            // 
            // bttnSearch
            // 
            this.bttnSearch.Location = new System.Drawing.Point(176, 12);
            this.bttnSearch.Name = "bttnSearch";
            this.bttnSearch.Size = new System.Drawing.Size(114, 23);
            this.bttnSearch.TabIndex = 15;
            this.bttnSearch.Text = "Search";
            this.bttnSearch.UseVisualStyleBackColor = true;
            this.bttnSearch.Click += new System.EventHandler(this.bttnSearch_Click);
            // 
            // NewsApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 590);
            this.Controls.Add(this.bttnSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblEmailPassword);
            this.Controls.Add(this.lblEmailLogin);
            this.Controls.Add(this.lblEmailAdress);
            this.Controls.Add(this.tbEmailPassword);
            this.Controls.Add(this.tbEmailLogin);
            this.Controls.Add(this.tbEmailAdress);
            this.Controls.Add(this.tbMailInput);
            this.Controls.Add(this.bttnSend);
            this.Controls.Add(this.rtbOutput);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.bttnRun);
            this.Controls.Add(this.tbKeyword);
            this.Controls.Add(this.rtbInput);
            this.Name = "NewsApp";
            this.Text = "NewsApp";
            this.Load += new System.EventHandler(this.NewsApp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbInput;
        private System.Windows.Forms.TextBox tbKeyword;
        private System.Windows.Forms.Button bttnRun;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.RichTextBox rtbOutput;
        private System.Windows.Forms.Button bttnSend;
        private System.Windows.Forms.TextBox tbMailInput;
        private System.Windows.Forms.TextBox tbEmailAdress;
        private System.Windows.Forms.TextBox tbEmailLogin;
        private System.Windows.Forms.TextBox tbEmailPassword;
        private System.Windows.Forms.Label lblEmailAdress;
        private System.Windows.Forms.Label lblEmailLogin;
        private System.Windows.Forms.Label lblEmailPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bttnSearch;
    }
}


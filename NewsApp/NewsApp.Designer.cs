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
            this.bttnReadFile = new System.Windows.Forms.Button();
            this.bttnSaveFile = new System.Windows.Forms.Button();
            this.panelCover = new System.Windows.Forms.Panel();
            this.lblPressSearch = new System.Windows.Forms.Label();
            this.lblInsertSite = new System.Windows.Forms.Label();
            this.lblInsertKeyword = new System.Windows.Forms.Label();
            this.panelCover.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtbInput
            // 
            this.rtbInput.Location = new System.Drawing.Point(12, 32);
            this.rtbInput.Name = "rtbInput";
            this.rtbInput.Size = new System.Drawing.Size(495, 261);
            this.rtbInput.TabIndex = 0;
            this.rtbInput.Text = "";
            this.rtbInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rtbInput_KeyPress);
            // 
            // tbKeyword
            // 
            this.tbKeyword.Enabled = false;
            this.tbKeyword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbKeyword.Location = new System.Drawing.Point(513, 32);
            this.tbKeyword.Name = "tbKeyword";
            this.tbKeyword.Size = new System.Drawing.Size(375, 24);
            this.tbKeyword.TabIndex = 5;
            this.tbKeyword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbKeyword_KeyPress);
            // 
            // bttnRun
            // 
            this.bttnRun.Enabled = false;
            this.bttnRun.Location = new System.Drawing.Point(894, 32);
            this.bttnRun.Name = "bttnRun";
            this.bttnRun.Size = new System.Drawing.Size(114, 23);
            this.bttnRun.TabIndex = 6;
            this.bttnRun.Text = "Filter";
            this.bttnRun.UseVisualStyleBackColor = true;
            this.bttnRun.Click += new System.EventHandler(this.bttnRun_Click);
            // 
            // tabControl
            // 
            this.tabControl.Location = new System.Drawing.Point(12, 328);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(495, 270);
            this.tabControl.TabIndex = 4;
            // 
            // rtbOutput
            // 
            this.rtbOutput.Enabled = false;
            this.rtbOutput.Location = new System.Drawing.Point(514, 63);
            this.rtbOutput.Name = "rtbOutput";
            this.rtbOutput.Size = new System.Drawing.Size(494, 386);
            this.rtbOutput.TabIndex = 5;
            this.rtbOutput.Text = "";
            // 
            // bttnSend
            // 
            this.bttnSend.Enabled = false;
            this.bttnSend.Location = new System.Drawing.Point(713, 575);
            this.bttnSend.Name = "bttnSend";
            this.bttnSend.Size = new System.Drawing.Size(114, 23);
            this.bttnSend.TabIndex = 11;
            this.bttnSend.Text = "Send via Mail";
            this.bttnSend.UseVisualStyleBackColor = true;
            this.bttnSend.Click += new System.EventHandler(this.bttnSend_Click);
            // 
            // tbMailInput
            // 
            this.tbMailInput.Enabled = false;
            this.tbMailInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbMailInput.Location = new System.Drawing.Point(633, 545);
            this.tbMailInput.Name = "tbMailInput";
            this.tbMailInput.Size = new System.Drawing.Size(375, 24);
            this.tbMailInput.TabIndex = 10;
            // 
            // tbEmailAdress
            // 
            this.tbEmailAdress.Enabled = false;
            this.tbEmailAdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbEmailAdress.Location = new System.Drawing.Point(633, 455);
            this.tbEmailAdress.Name = "tbEmailAdress";
            this.tbEmailAdress.Size = new System.Drawing.Size(375, 24);
            this.tbEmailAdress.TabIndex = 7;
            // 
            // tbEmailLogin
            // 
            this.tbEmailLogin.Enabled = false;
            this.tbEmailLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbEmailLogin.Location = new System.Drawing.Point(633, 485);
            this.tbEmailLogin.Name = "tbEmailLogin";
            this.tbEmailLogin.Size = new System.Drawing.Size(375, 24);
            this.tbEmailLogin.TabIndex = 8;
            // 
            // tbEmailPassword
            // 
            this.tbEmailPassword.Enabled = false;
            this.tbEmailPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbEmailPassword.Location = new System.Drawing.Point(633, 515);
            this.tbEmailPassword.Name = "tbEmailPassword";
            this.tbEmailPassword.PasswordChar = '*';
            this.tbEmailPassword.Size = new System.Drawing.Size(375, 24);
            this.tbEmailPassword.TabIndex = 9;
            // 
            // lblEmailAdress
            // 
            this.lblEmailAdress.AutoSize = true;
            this.lblEmailAdress.Location = new System.Drawing.Point(535, 462);
            this.lblEmailAdress.Name = "lblEmailAdress";
            this.lblEmailAdress.Size = new System.Drawing.Size(92, 13);
            this.lblEmailAdress.TabIndex = 11;
            this.lblEmailAdress.Text = "Your Email Adress";
            // 
            // lblEmailLogin
            // 
            this.lblEmailLogin.AutoSize = true;
            this.lblEmailLogin.Location = new System.Drawing.Point(541, 492);
            this.lblEmailLogin.Name = "lblEmailLogin";
            this.lblEmailLogin.Size = new System.Drawing.Size(86, 13);
            this.lblEmailLogin.TabIndex = 12;
            this.lblEmailLogin.Text = "Your Email Login";
            // 
            // lblEmailPassword
            // 
            this.lblEmailPassword.AutoSize = true;
            this.lblEmailPassword.Location = new System.Drawing.Point(521, 522);
            this.lblEmailPassword.Name = "lblEmailPassword";
            this.lblEmailPassword.Size = new System.Drawing.Size(106, 13);
            this.lblEmailPassword.TabIndex = 13;
            this.lblEmailPassword.Text = "Your Email Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(514, 552);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Recipent Email Adress";
            // 
            // bttnSearch
            // 
            this.bttnSearch.Location = new System.Drawing.Point(12, 299);
            this.bttnSearch.Name = "bttnSearch";
            this.bttnSearch.Size = new System.Drawing.Size(114, 23);
            this.bttnSearch.TabIndex = 1;
            this.bttnSearch.Text = "Search for articles";
            this.bttnSearch.UseVisualStyleBackColor = true;
            this.bttnSearch.Click += new System.EventHandler(this.bttnSearch_Click);
            // 
            // bttnReadFile
            // 
            this.bttnReadFile.Location = new System.Drawing.Point(273, 299);
            this.bttnReadFile.Name = "bttnReadFile";
            this.bttnReadFile.Size = new System.Drawing.Size(114, 23);
            this.bttnReadFile.TabIndex = 2;
            this.bttnReadFile.Text = "Read from file";
            this.bttnReadFile.UseVisualStyleBackColor = true;
            this.bttnReadFile.Click += new System.EventHandler(this.bttnReadFile_Click);
            // 
            // bttnSaveFile
            // 
            this.bttnSaveFile.Location = new System.Drawing.Point(393, 299);
            this.bttnSaveFile.Name = "bttnSaveFile";
            this.bttnSaveFile.Size = new System.Drawing.Size(114, 23);
            this.bttnSaveFile.TabIndex = 3;
            this.bttnSaveFile.Text = "Save to file...";
            this.bttnSaveFile.UseVisualStyleBackColor = true;
            this.bttnSaveFile.Click += new System.EventHandler(this.bttnSaveFile_Click);
            // 
            // panelCover
            // 
            this.panelCover.Controls.Add(this.lblPressSearch);
            this.panelCover.Location = new System.Drawing.Point(12, 328);
            this.panelCover.Name = "panelCover";
            this.panelCover.Size = new System.Drawing.Size(495, 270);
            this.panelCover.TabIndex = 4;
            // 
            // lblPressSearch
            // 
            this.lblPressSearch.AutoSize = true;
            this.lblPressSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPressSearch.Location = new System.Drawing.Point(78, 122);
            this.lblPressSearch.Name = "lblPressSearch";
            this.lblPressSearch.Size = new System.Drawing.Size(308, 25);
            this.lblPressSearch.TabIndex = 0;
            this.lblPressSearch.Text = "Searching for articles. Please wait.";
            this.lblPressSearch.Visible = false;
            // 
            // lblInsertSite
            // 
            this.lblInsertSite.AutoSize = true;
            this.lblInsertSite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblInsertSite.Location = new System.Drawing.Point(12, 9);
            this.lblInsertSite.Name = "lblInsertSite";
            this.lblInsertSite.Size = new System.Drawing.Size(402, 20);
            this.lblInsertSite.TabIndex = 19;
            this.lblInsertSite.Text = "Insert site urls from which you would like to get the titles.";
            // 
            // lblInsertKeyword
            // 
            this.lblInsertKeyword.AutoSize = true;
            this.lblInsertKeyword.Enabled = false;
            this.lblInsertKeyword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblInsertKeyword.Location = new System.Drawing.Point(513, 9);
            this.lblInsertKeyword.Name = "lblInsertKeyword";
            this.lblInsertKeyword.Size = new System.Drawing.Size(291, 20);
            this.lblInsertKeyword.TabIndex = 20;
            this.lblInsertKeyword.Text = "Press the search button to get the titles.";
            // 
            // NewsApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 629);
            this.Controls.Add(this.lblInsertKeyword);
            this.Controls.Add(this.lblInsertSite);
            this.Controls.Add(this.panelCover);
            this.Controls.Add(this.bttnSaveFile);
            this.Controls.Add(this.bttnReadFile);
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
            this.panelCover.ResumeLayout(false);
            this.panelCover.PerformLayout();
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
        private System.Windows.Forms.Button bttnReadFile;
        private System.Windows.Forms.Button bttnSaveFile;
        private System.Windows.Forms.Panel panelCover;
        private System.Windows.Forms.Label lblPressSearch;
        private System.Windows.Forms.Label lblInsertSite;
        private System.Windows.Forms.Label lblInsertKeyword;
    }
}


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
            this.lbSites = new System.Windows.Forms.ListBox();
            this.tbKeyword = new System.Windows.Forms.TextBox();
            this.bttnRun = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.SuspendLayout();
            // 
            // rtbInput
            // 
            this.rtbInput.Location = new System.Drawing.Point(12, 12);
            this.rtbInput.Name = "rtbInput";
            this.rtbInput.Size = new System.Drawing.Size(495, 231);
            this.rtbInput.TabIndex = 0;
            this.rtbInput.Text = "";
            // 
            // lbSites
            // 
            this.lbSites.FormattingEnabled = true;
            this.lbSites.Location = new System.Drawing.Point(513, 12);
            this.lbSites.Name = "lbSites";
            this.lbSites.Size = new System.Drawing.Size(495, 329);
            this.lbSites.TabIndex = 1;
            // 
            // tbKeyword
            // 
            this.tbKeyword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbKeyword.Location = new System.Drawing.Point(513, 348);
            this.tbKeyword.Name = "tbKeyword";
            this.tbKeyword.Size = new System.Drawing.Size(375, 24);
            this.tbKeyword.TabIndex = 2;
            // 
            // bttnRun
            // 
            this.bttnRun.Location = new System.Drawing.Point(894, 348);
            this.bttnRun.Name = "bttnRun";
            this.bttnRun.Size = new System.Drawing.Size(114, 23);
            this.bttnRun.TabIndex = 3;
            this.bttnRun.Text = "Run";
            this.bttnRun.UseVisualStyleBackColor = true;
            // 
            // tabControl
            // 
            this.tabControl.Location = new System.Drawing.Point(12, 249);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(495, 329);
            this.tabControl.TabIndex = 4;
            // 
            // NewsApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 590);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.bttnRun);
            this.Controls.Add(this.tbKeyword);
            this.Controls.Add(this.lbSites);
            this.Controls.Add(this.rtbInput);
            this.Name = "NewsApp";
            this.Text = "NewsApp";
            this.Load += new System.EventHandler(this.NewsApp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbInput;
        private System.Windows.Forms.ListBox lbSites;
        private System.Windows.Forms.TextBox tbKeyword;
        private System.Windows.Forms.Button bttnRun;
        private System.Windows.Forms.TabControl tabControl;
    }
}


namespace Email_App
{
    partial class Settings_Form
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
            this.Cancal_BTN = new System.Windows.Forms.Button();
            this.Save_BTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.EmailAddress_TB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.EmailPassword_TB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Cancal_BTN
            // 
            this.Cancal_BTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Cancal_BTN.Location = new System.Drawing.Point(182, 88);
            this.Cancal_BTN.Name = "Cancal_BTN";
            this.Cancal_BTN.Size = new System.Drawing.Size(75, 23);
            this.Cancal_BTN.TabIndex = 0;
            this.Cancal_BTN.Text = "cancal";
            this.Cancal_BTN.UseVisualStyleBackColor = true;
            this.Cancal_BTN.Click += new System.EventHandler(this.Cancal_BTN_Click);
            // 
            // Save_BTN
            // 
            this.Save_BTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Save_BTN.Location = new System.Drawing.Point(101, 88);
            this.Save_BTN.Name = "Save_BTN";
            this.Save_BTN.Size = new System.Drawing.Size(75, 23);
            this.Save_BTN.TabIndex = 1;
            this.Save_BTN.Text = "save";
            this.Save_BTN.UseVisualStyleBackColor = true;
            this.Save_BTN.Click += new System.EventHandler(this.Save_BTN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Email Address";
            // 
            // EmailAddress_TB
            // 
            this.EmailAddress_TB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmailAddress_TB.Location = new System.Drawing.Point(91, 6);
            this.EmailAddress_TB.Name = "EmailAddress_TB";
            this.EmailAddress_TB.Size = new System.Drawing.Size(166, 20);
            this.EmailAddress_TB.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Email Password";
            // 
            // EmailPassword_TB
            // 
            this.EmailPassword_TB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmailPassword_TB.Location = new System.Drawing.Point(99, 32);
            this.EmailPassword_TB.Name = "EmailPassword_TB";
            this.EmailPassword_TB.PasswordChar = '*';
            this.EmailPassword_TB.Size = new System.Drawing.Size(158, 20);
            this.EmailPassword_TB.TabIndex = 5;
            // 
            // Settings_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 123);
            this.Controls.Add(this.EmailPassword_TB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EmailAddress_TB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Save_BTN);
            this.Controls.Add(this.Cancal_BTN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Settings_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cancal_BTN;
        private System.Windows.Forms.Button Save_BTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox EmailAddress_TB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox EmailPassword_TB;
    }
}
namespace Email_App
{
    partial class Compose_Form
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
            this.send_BTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TO_TB = new System.Windows.Forms.TextBox();
            this.CC_TB = new System.Windows.Forms.TextBox();
            this.BCC_TB = new System.Windows.Forms.TextBox();
            this.EmailMessage_RTB = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SUBJECT_TB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // send_BTN
            // 
            this.send_BTN.Location = new System.Drawing.Point(713, 415);
            this.send_BTN.Name = "send_BTN";
            this.send_BTN.Size = new System.Drawing.Size(75, 23);
            this.send_BTN.TabIndex = 0;
            this.send_BTN.Text = "send";
            this.send_BTN.UseVisualStyleBackColor = true;
            this.send_BTN.Click += new System.EventHandler(this.send_BTN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "To";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cc";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Bcc";
            // 
            // TO_TB
            // 
            this.TO_TB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TO_TB.Location = new System.Drawing.Point(38, 12);
            this.TO_TB.Name = "TO_TB";
            this.TO_TB.Size = new System.Drawing.Size(750, 20);
            this.TO_TB.TabIndex = 4;
            // 
            // CC_TB
            // 
            this.CC_TB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CC_TB.Location = new System.Drawing.Point(38, 38);
            this.CC_TB.Name = "CC_TB";
            this.CC_TB.Size = new System.Drawing.Size(750, 20);
            this.CC_TB.TabIndex = 5;
            // 
            // BCC_TB
            // 
            this.BCC_TB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BCC_TB.Location = new System.Drawing.Point(44, 64);
            this.BCC_TB.Name = "BCC_TB";
            this.BCC_TB.Size = new System.Drawing.Size(744, 20);
            this.BCC_TB.TabIndex = 6;
            // 
            // EmailMessage_RTB
            // 
            this.EmailMessage_RTB.Location = new System.Drawing.Point(12, 116);
            this.EmailMessage_RTB.Name = "EmailMessage_RTB";
            this.EmailMessage_RTB.Size = new System.Drawing.Size(776, 293);
            this.EmailMessage_RTB.TabIndex = 7;
            this.EmailMessage_RTB.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Subject";
            // 
            // SUBJECT_TB
            // 
            this.SUBJECT_TB.Location = new System.Drawing.Point(61, 90);
            this.SUBJECT_TB.Name = "SUBJECT_TB";
            this.SUBJECT_TB.Size = new System.Drawing.Size(727, 20);
            this.SUBJECT_TB.TabIndex = 9;
            // 
            // Compose_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SUBJECT_TB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.EmailMessage_RTB);
            this.Controls.Add(this.BCC_TB);
            this.Controls.Add(this.CC_TB);
            this.Controls.Add(this.TO_TB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.send_BTN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Compose_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compose";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button send_BTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TO_TB;
        private System.Windows.Forms.TextBox CC_TB;
        private System.Windows.Forms.TextBox BCC_TB;
        private System.Windows.Forms.RichTextBox EmailMessage_RTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox SUBJECT_TB;
    }
}
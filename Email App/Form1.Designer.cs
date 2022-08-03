namespace Email_App
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Compose_BTN = new System.Windows.Forms.Button();
            this.Settings_BTN = new System.Windows.Forms.Button();
            this.Inbix_TC = new System.Windows.Forms.TabControl();
            this.Primary_tab = new System.Windows.Forms.TabPage();
            this.Promotions_tab = new System.Windows.Forms.TabPage();
            this.Inbox_BTN = new System.Windows.Forms.Button();
            this.Send_BTN = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.Inbix_TC.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.Send_BTN);
            this.panel1.Controls.Add(this.Inbox_BTN);
            this.panel1.Controls.Add(this.Settings_BTN);
            this.panel1.Controls.Add(this.Compose_BTN);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(74, 450);
            this.panel1.TabIndex = 0;
            // 
            // Compose_BTN
            // 
            this.Compose_BTN.Dock = System.Windows.Forms.DockStyle.Top;
            this.Compose_BTN.Location = new System.Drawing.Point(0, 0);
            this.Compose_BTN.Name = "Compose_BTN";
            this.Compose_BTN.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Compose_BTN.Size = new System.Drawing.Size(74, 23);
            this.Compose_BTN.TabIndex = 0;
            this.Compose_BTN.Text = "Compose";
            this.Compose_BTN.UseVisualStyleBackColor = true;
            this.Compose_BTN.Click += new System.EventHandler(this.Compose_BTN_Click);
            // 
            // Settings_BTN
            // 
            this.Settings_BTN.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Settings_BTN.Location = new System.Drawing.Point(0, 427);
            this.Settings_BTN.Name = "Settings_BTN";
            this.Settings_BTN.Size = new System.Drawing.Size(74, 23);
            this.Settings_BTN.TabIndex = 1;
            this.Settings_BTN.Text = "Setting";
            this.Settings_BTN.UseVisualStyleBackColor = true;
            this.Settings_BTN.Click += new System.EventHandler(this.Settings_BTN_Click);
            // 
            // Inbix_TC
            // 
            this.Inbix_TC.Controls.Add(this.Primary_tab);
            this.Inbix_TC.Controls.Add(this.Promotions_tab);
            this.Inbix_TC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Inbix_TC.Location = new System.Drawing.Point(74, 0);
            this.Inbix_TC.Name = "Inbix_TC";
            this.Inbix_TC.SelectedIndex = 0;
            this.Inbix_TC.Size = new System.Drawing.Size(726, 450);
            this.Inbix_TC.TabIndex = 1;
            // 
            // Primary_tab
            // 
            this.Primary_tab.Location = new System.Drawing.Point(4, 22);
            this.Primary_tab.Name = "Primary_tab";
            this.Primary_tab.Padding = new System.Windows.Forms.Padding(3);
            this.Primary_tab.Size = new System.Drawing.Size(718, 424);
            this.Primary_tab.TabIndex = 0;
            this.Primary_tab.Text = "Primary";
            this.Primary_tab.UseVisualStyleBackColor = true;
            // 
            // Promotions_tab
            // 
            this.Promotions_tab.Location = new System.Drawing.Point(4, 22);
            this.Promotions_tab.Name = "Promotions_tab";
            this.Promotions_tab.Padding = new System.Windows.Forms.Padding(3);
            this.Promotions_tab.Size = new System.Drawing.Size(718, 424);
            this.Promotions_tab.TabIndex = 1;
            this.Promotions_tab.Text = "Promotions";
            this.Promotions_tab.UseVisualStyleBackColor = true;
            // 
            // Inbox_BTN
            // 
            this.Inbox_BTN.Dock = System.Windows.Forms.DockStyle.Top;
            this.Inbox_BTN.Location = new System.Drawing.Point(0, 23);
            this.Inbox_BTN.Name = "Inbox_BTN";
            this.Inbox_BTN.Size = new System.Drawing.Size(74, 23);
            this.Inbox_BTN.TabIndex = 2;
            this.Inbox_BTN.Text = "Inbox";
            this.Inbox_BTN.UseVisualStyleBackColor = true;
            // 
            // Send_BTN
            // 
            this.Send_BTN.Dock = System.Windows.Forms.DockStyle.Top;
            this.Send_BTN.Location = new System.Drawing.Point(0, 46);
            this.Send_BTN.Name = "Send_BTN";
            this.Send_BTN.Size = new System.Drawing.Size(74, 23);
            this.Send_BTN.TabIndex = 3;
            this.Send_BTN.Text = "Sent";
            this.Send_BTN.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Inbix_TC);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.Inbix_TC.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Compose_BTN;
        private System.Windows.Forms.Button Settings_BTN;
        private System.Windows.Forms.TabControl Inbix_TC;
        private System.Windows.Forms.TabPage Primary_tab;
        private System.Windows.Forms.TabPage Promotions_tab;
        private System.Windows.Forms.Button Inbox_BTN;
        private System.Windows.Forms.Button Send_BTN;
    }
}


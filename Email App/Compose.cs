using System;
using System.Windows.Forms;
using System.Net.Mail;
using Email_App.Configs;
using Newtonsoft.Json;
using System.IO;
using Utils.Windows;

namespace Email_App {
    public partial class Compose_Form : Form {
        public Compose_Form() {
            InitializeComponent();
        }
            string CurrentPath = Directory.GetCurrentDirectory();


        private void send_BTN_Click(object sender, EventArgs e) {
            var _res = JsonConvert.DeserializeObject<EmailSettingsConfig>(File.ReadAllText(Path.Combine(CurrentPath, "Config", "EmailSettingsContig.json")));

            if (TO_TB.Text == null) {
                Forms.MessageBox_Error_OK("Email App", "Invalid To field");
            }

            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient(_res.SMTPServerHost);
            mail.From = new MailAddress(_res.EmailAddress);
            mail.To.Add(TO_TB.Text);
            mail.CC.Add(CC_TB.Text);
            mail.Bcc.Add(BCC_TB.Text);
            mail.Subject = SUBJECT_TB.Text;
            mail.Body = EmailMessage_RTB.Text;

            SmtpServer.Port = _res.SMTPServerPort;
            SmtpServer.Credentials = new System.Net.NetworkCredential(_res.EmailAddress, _res.EmailPassword);
            SmtpServer.EnableSsl = true;

            SmtpServer.Send(mail);
        }
    }
}

using System;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
using Email_App.Configs;

namespace Email_App {
    public partial class Settings_Form : Form {
        public Settings_Form() {
            InitializeComponent();
            Focus();
            var _res = JsonConvert.DeserializeObject<EmailSettingsConfig>(File.ReadAllText(Path.Combine(CurrentPath, "Config", "EmailSettingsContig.json")));
            EmailAddress_TB.Text = _res.EmailAddress;
            EmailPassword_TB.Text = _res.EmailAddress;
        }
        string CurrentPath = Directory.GetCurrentDirectory();



        private void Cancal_BTN_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void Save_BTN_Click(object sender, EventArgs e) {
            var _res = JsonConvert.DeserializeObject<EmailSettingsConfig>(File.ReadAllText(Path.Combine(CurrentPath, "Config", "EmailSettingsContig.json")));
            _res.EmailAddress = EmailAddress_TB.Text;
            _res.EmailPassword = EmailPassword_TB.Text;
        }
    }
}

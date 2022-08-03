using System;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace Email_App {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            ConfigFileChecker.ConfigFileGenerater();
        }

        private void Settings_BTN_Click(object sender, EventArgs e) {
            Settings_Form settings = new Settings_Form();
            settings.ShowDialog();
        }

        private void Compose_BTN_Click(object sender, EventArgs e) {
            Compose_Form compose = new Compose_Form();
            compose.ShowDialog();
        }
    }
}

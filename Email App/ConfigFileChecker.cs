using Newtonsoft.Json;
using System.IO;
using Email_App.Configs;

namespace Email_App {
    public static class ConfigFileChecker {
        public static void ConfigFileGenerater() {
            string CurrentPath = Directory.GetCurrentDirectory();

           #region EmailSettings
            EmailSettingsConfig config = new EmailSettingsConfig{
                EmailAddress = "",
                EmailPassword = "",
                SMTPServerHost = "smtp.gmail.com",
                SMTPServerPort = 587
            };

            string strResultJson = JsonConvert.SerializeObject(config, Formatting.Indented);

            if (!Directory.Exists(Path.Combine(CurrentPath, "Config"))) {
                Directory.CreateDirectory(Path.Combine(CurrentPath, "Config"));
            }
            if (!File.Exists(Path.Combine(CurrentPath, "Config", "EmailSettingsContig.json"))) {
                File.WriteAllText(Path.Combine(CurrentPath, "Config", "EmailSettingsContig.json"), strResultJson);
            }
            #endregion
        }

    }
}

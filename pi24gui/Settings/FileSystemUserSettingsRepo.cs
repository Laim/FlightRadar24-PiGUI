using pi24gui.Models;
using System.Text.Json;

namespace pi24gui.Settings
{
    sealed class FileSystemUserSettingsRepo : IUserSettingsRepo
    {
        private const string AppName = "pi24gui";
        private const string SettingsFileName = "userSettings.json";

        private readonly string _settingsFolderPath = GetSettingsFolderPath();
        private readonly string _settingsFilePath = GetSettingsFilePath();

        public async Task<UserSettings> GetSettings()
        {
            if (!File.Exists(_settingsFilePath))
            {
                await SaveSettings(new UserSettings());
            }

            using var settingsFileStream = new FileStream(_settingsFilePath, FileMode.Open);
            var deserializedSettings = await JsonSerializer.DeserializeAsync<UserSettings>(settingsFileStream);

            if (deserializedSettings is null)
            {
                throw new InvalidOperationException("Can't deserialize user settings");
            }

            return deserializedSettings;
        }

        public async Task SaveSettings(UserSettings userSettings)
        {
            if (!Directory.Exists(_settingsFolderPath))
            {
                Directory.CreateDirectory(_settingsFolderPath);
            }

            using var settingsFileStream = new FileStream(_settingsFilePath, FileMode.OpenOrCreate);
            await JsonSerializer.SerializeAsync(settingsFileStream, userSettings);
        }

        private static string GetSettingsFolderPath()
        {
            var appDataFolder = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            return Path.Combine(appDataFolder, AppName);
        }

        private static string GetSettingsFilePath()
        {
            var settingsFolder = GetSettingsFolderPath();
            return Path.Combine(settingsFolder, SettingsFileName);
        }
    }
}

using pi24gui.Models;

namespace pi24gui.Settings
{
    public interface IUserSettingsRepo
    {
        Task<UserSettings> GetSettings();

        Task SaveSettings(UserSettings userSettings);
    }
}

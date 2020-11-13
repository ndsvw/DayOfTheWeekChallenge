using Blazored.LocalStorage;

namespace DayOfTheWeekChallenge.Core
{
    public class Settings : ISettings
    {
        public Settings(ISyncLocalStorageService pLocalStorage)
        {
            IsSundayFirstDotw = new LocalStorageSetting<bool>(pLocalStorage, nameof(IsSundayFirstDotw), true);
            PreferNumbericAnswers = new LocalStorageSetting<bool>(pLocalStorage, nameof(PreferNumbericAnswers), false);
            PreferEfficientNumbers = new LocalStorageSetting<bool>(pLocalStorage, nameof(PreferEfficientNumbers), true);
            IsStatisticsAreaVisible = new LocalStorageSetting<bool>(pLocalStorage, nameof(IsStatisticsAreaVisible), true);
        }

        public LocalStorageSetting<bool> IsSundayFirstDotw { get; }

        public LocalStorageSetting<bool> PreferNumbericAnswers { get; }

        public LocalStorageSetting<bool> PreferEfficientNumbers { get; }

        public LocalStorageSetting<bool> IsStatisticsAreaVisible { get; }
    }
}

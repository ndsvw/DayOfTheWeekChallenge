namespace DayOfTheWeekChallenge.Core
{
    public interface ISettings
    {
        public LocalStorageSetting<bool> IsSundayFirstDotw { get; }

        public LocalStorageSetting<bool> PreferNumbericAnswers { get; }

        public LocalStorageSetting<bool> PreferEfficientNumbers { get; }

        public LocalStorageSetting<bool> IsStatisticsAreaVisible { get; }
    }
}

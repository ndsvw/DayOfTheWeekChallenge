namespace DayOfTheWeekChallenge.Core
{
    public class Settings : ISettings
    {
        public bool PreferNumbericAnswers { get; set; } = false;

        public bool PreferEfficientNumbers { get; set; } = true;

        public bool IsSundayFirstDotw { get; set; } = true;
    }
}

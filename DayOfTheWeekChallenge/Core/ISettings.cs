namespace DayOfTheWeekChallenge.Core
{
    public interface ISettings
    {
        bool PreferNumbericAnswers { get; set; }

        bool PreferEfficientNumbers { get; set; }

        bool IsSundayFirstDotw { get; set; }
    }
}
    
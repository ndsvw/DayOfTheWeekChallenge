using System;
namespace DayOfTheWeekChallenge.Core
{
    public class UserAnswer<TAnswer>
    {
        public string Question { get; set; }

        public TAnswer GivenAnswer { get; set; }

        public TAnswer CorrectAnswer { get; set; }

        public bool AnsweredCorrectly { get; set; }

        public TimeSpan Time { get; set; }
    }
}

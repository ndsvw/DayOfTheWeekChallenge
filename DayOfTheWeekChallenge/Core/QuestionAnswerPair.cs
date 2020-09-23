using System;
namespace DayOfTheWeekChallenge.Core
{
    public readonly struct QuestionAnswerPair<TAnswer>
    {
        public string Question { get; }

        public TAnswer Answer { get; }

        public QuestionAnswerPair(string pQuestion, TAnswer pAnswer)
        {
            Question = pQuestion;
            Answer = pAnswer;
        }
    }
}

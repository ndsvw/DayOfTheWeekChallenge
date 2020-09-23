
namespace DayOfTheWeekChallenge.Core
{
    public readonly struct AnswerOption<TAnswer>
    {
        public TAnswer DisplayText { get; }

        public TAnswer Value { get; }

        public char? KeyDownChar { get; }

        public AnswerOption(TAnswer pDisplayText, TAnswer pValue, char? pKeyDownChar)
        {
            DisplayText = pDisplayText;
            Value = pValue;
            KeyDownChar = pKeyDownChar;
        }
    }
}

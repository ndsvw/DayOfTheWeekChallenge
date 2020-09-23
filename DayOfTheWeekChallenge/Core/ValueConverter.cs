using System;
namespace DayOfTheWeekChallenge.Core
{
    public class ValueConverter<TSource, TTarget>
    {
        public Func<TSource, TTarget> Convert { get; private set; }

        public ValueConverter(Func<TSource, TTarget> pConvert)
        {
            Convert = pConvert;
        }
    }
}

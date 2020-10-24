using System;
namespace DayOfTheWeekChallenge.Core
{
    public readonly struct DotwCalculation
    {
        public DateTime Date { get; }

        // step 1
        public int Step1ValueA { get; }

        public int Step1ValueB { get; }

        public int Step1ValueC { get; }

        public int Step1ValueD { get; }

        public int Step1EfficientValueA { get; }

        public int Step1EfficientValueB { get; }

        public int Step1EfficientValueC { get; }

        public int Step1Code { get; }

        // step 2
        public int Step2ValueA { get; }

        public int Step2Code { get; }

        // step 3

        public string Step3MonthName { get; }

        public int Step3Code { get; }

        // step 4

        public int Step4ValueA { get; }

        public int Step4Code { get; }

        // step 5

        public int Step5AbsoluteCode { get; }

        // step 6

        public int Step6ValueA { get; }

        public int Step6ValueB { get; }

        public string Step6Dotw { get; }

        public DotwCalculation(DateTime pDate)
        {
            if (pDate < new DateTime(1600, 1, 1) || pDate > new DateTime(9999, 12, 31))
                throw new ArgumentException($"{nameof(pDate)} must be between 1600-1-1 and 9999-12-31.");

            Date = pDate;

            // step 1
            Step1ValueA = Date.Year % 100;
            Step1ValueB = Step1ValueA / 4;
            Step1ValueC = Step1ValueA + Step1ValueB;
            Step1ValueD = Step1ValueC % 7;

            Step1EfficientValueA = Step1ValueA % 7;
            Step1EfficientValueB = Step1ValueB % 7;
            Step1EfficientValueC = Step1EfficientValueA + Step1EfficientValueB;

            Step1Code = Step1ValueC % 7;

            // step 2
            Step2ValueA = (Date.Year - (Date.Year % 100)) / 100;
            Console.WriteLine(Step2ValueA % 4);
            Step2Code = new int[] { 0, 5, 3, 1 }[Step2ValueA % 4];

            // step 3
            Console.WriteLine(Date.Month - 1);
            Step3MonthName = new[] {
                        "January", "February", "March", "April", "May", "June",
                        "July", "August", "September", "October", "November", "December"
                    }[Date.Month - 1];
            Step3Code = new int[] { 6, 2, 2, 5, 0, 3, 5, 1, 4, 6, 2, 4 }[Date.Month - 1];

            // step 4
            Step4ValueA = Date.Day;
            Step4Code = Step4ValueA % 7;

            // step 5
            Step5AbsoluteCode = DateTime.IsLeapYear(pDate.Year) && pDate.Month <= 2 ? 1 : 0;

            // step 6
            Step6ValueA = Step1Code + Step2Code + Step3Code + Step4Code - Step5AbsoluteCode;

            Step6ValueB = Step6ValueA % 7;

            Console.WriteLine("hi" + Step6ValueB);
            Step6Dotw = new[] { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" }[Step6ValueB];

        }
    }
}

using System;
using System.Collections;
using NUnit.Framework;

namespace Open_Lab_05._01
{
    [TestFixture]
    public class Tests
    {

        private DateTools tools;

        private const int RandYearMin = 1;
        private const int RandYearMax = 5000;
        private const int RandSeed = 501501501;
        private const int RandTestCasesCount = 95;

        [OneTimeSetUp]
        public void Init() => tools = new DateTools();

        [TestCase(1756, "18th century")]
        [TestCase(1555, "16th century")]
        [TestCase(1000, "10th century")]
        [TestCase(1001, "11th century")]
        [TestCase(2005, "21st century")]
        [TestCaseSource(nameof(GetRandom))]
        public void CenturyTest(int year, string expected) =>
            Assert.That(tools.Century(year), Is.EqualTo(expected));

        private static IEnumerable GetRandom()
        {
            var rand = new Random(RandSeed);

            for (var i = 0; i < RandTestCasesCount; i++)
            {
                var year = rand.Next(RandYearMin, RandYearMax + 1);

                var num = year / 100 + (year % 100 != 0 ? 1 : 0);
                var suffix = num == 11 || num == 12 || num == 13 ? "th" : num.ToString()[^1] switch
                {
                    '1' => "st",
                    '2' => "nd",
                    '3' => "rd",
                    _ => "th"
                };

                yield return new TestCaseData(year, $"{num}{suffix} century");
            }
        }

    }
}

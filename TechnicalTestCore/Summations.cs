namespace TechnicalTestCore
{
    using System;
    internal class Summations
    {
        public static int SumOfNumbersFrom1TillNrAsInt(int maxNrAsInt)
        {
            int sum = 0;
            // Adapt the method body to make the corresponding unit test in 'TechnicalTestUnitTests' pass
            for (int i = 1; i <= maxNrAsInt; i++) {
                sum += i;
            }
            return sum;
        }

        public static string SumOfNumbersFrom1TillNrAsString(string maxNrAsString)
        {
            int maxNrAsInt = Convert.ToInt32(maxNrAsString);
            double sum = 0;

            for (int i = 1; i <= maxNrAsInt; i++) {
                sum += i;
            }
           
            // Adapt the method body to make the corresponding unit test in 'TechnicalTestUnitTests' pass
            return Convert.ToString(sum);
        }
    }
}

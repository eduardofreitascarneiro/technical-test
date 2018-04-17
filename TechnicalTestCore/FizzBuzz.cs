namespace TechnicalTestCore
{
    using System;

    internal class FizzBuzz
    {
        public static void PrintFizzBuzzStyleIntegersFrom1Till(string[] args)
        {
            int maxInt = Convert.ToInt32(args[0]);
            var stringBuilder = new System.Text.StringBuilder();
            // Write a method body which makes the corresponding unit test in the 'TechnicalTestUnitTest' project pass
            // For this to happen the method needs to do the following:
            // -- It prints the integers from 1 till args[0] to the screen
            // -- One integer per line
            for (int i = 1; i <= maxInt; i++) {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    // -- For every multiple of three print 'Fizz'
                    stringBuilder.AppendLine("FizzBuzz");
                }else if (i % 5 == 0)
                {
                    // -- For every multiple of five print 'Buzz'
                    stringBuilder.AppendLine("Buzz");
                }else if ((i % 3 == 0))
                {
                    // -- For every multiple of both three and five print 'FizzBuzz'
                    stringBuilder.AppendLine("Fizz");
                }else {
                    stringBuilder.AppendLine(Convert.ToString(i));
                }                
            }
            Console.WriteLine(stringBuilder.ToString().Trim());
        }
    }
}

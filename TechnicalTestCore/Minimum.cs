namespace TechnicalTestCore
{
    using System.Collections.Generic;

    internal class Minimum
    {
        public static int MinimumElementIn(List<int> intlist)
        {
            // Adapt the method body to make the corresponding unit test in 'TechnicalTestUnitTests' pass
            intlist.Sort();
            return intlist[0];
        }
    }
}

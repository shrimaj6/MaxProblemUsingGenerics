using System;
using System.Collections.Generic;
using System.Text;

namespace MaxProblemUsingGenerics
{
    public class MaxOfThree
    {

        public void ReturnMax(int n1, int n2, int n3)
        {
            if (n1.CompareTo(n2) > 0 && n1.CompareTo(n3) > 0 || n1.CompareTo(n2) >= 0 && n1.CompareTo(n3) > 0 || n1.CompareTo(n2) > 0 && n1.CompareTo(n3) >= 0)
            {
                Console.WriteLine(n1 + " is greter than " + n2 + " " + n3);
            }
            else if (n2.CompareTo(n1) > 0 && n2.CompareTo(n3) > 0 || n2.CompareTo(n1) >= 0 && n2.CompareTo(n3) > 0 || n2.CompareTo(n1) > 0 && n2.CompareTo(n3) >= 0)
            {
                Console.WriteLine(n2 + " is greter than " + n1 + " " + n3);
            }
            else if (n3.CompareTo(n1) > 0 && n3.CompareTo(n2) > 0 || n3.CompareTo(n2) >= 0 && n3.CompareTo(n1) > 0 || n3.CompareTo(n2) > 0 && n3.CompareTo(n2) >= 0)
            {
                Console.WriteLine(n3 + " is greter than " + n2 + " " + n1);
            }
        }
    }
}


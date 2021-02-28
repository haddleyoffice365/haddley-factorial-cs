using System;

namespace Functions
{
    public class Recursive
    {
        public static double factorial(int n)
        {
            if (n < 2) return 1;
            return n * factorial(n - 1);
        }

        private static double fac_tr_aux(int n, double acc)
        {
            if (n < 2)
                return acc;
            return fac_tr_aux(n - 1, n * acc);
        }

        public static double factorial_tr(int n)
        {
            return fac_tr_aux(n, 1);
        }
        
        public static double factorial_it(int n)
        {
            double acc = 1;

            for (int i = n; i > 1; i--)
            {
                acc = acc * i;
            }

            return acc;
        }

    }
}
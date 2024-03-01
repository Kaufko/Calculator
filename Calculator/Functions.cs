using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{
    public static class Operators
    {
        public static float Pow(float number, int powerOf)
        {
            float result = number;
            for (int i = 0; i < powerOf; i++)
            {
                result *= number;
            }
            return result;
        }

        public static int Sqrt(int n)
        {
            if (n < 2)
            {
                return n;
            }
            int low = 1, high = n;
            while (low <= high)
            {
                int mid = (low + high) / 2;
                if (mid * mid == n)
                {
                    return mid;
                }
                else if (mid * mid < n)
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }
            return high;
        }

        public static int Factorial(int number)
        {
            int result = 0;
            for (int i = 0;i < number;i++)
            {
                result *= number;
            }
            return result;
        }
        
    }

    public static class Miscellaneous
    {
        public static void WriteToHistory(string operation, float result)
        {
            File.AppendAllText($"{Path.GetTempPath()}history.log", $"{operation} {result}\n");
        }
    }
}

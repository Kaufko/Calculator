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

        public static float Sqrt(float number, int sqrtNum)
        {
            float result = number;
            result *= 1.0f / sqrtNum;
            return result;
        }
        
    }

    public static class Miscellaneous
    {
        public static void WriteToHistory(string operation, float result)
        {
            File.AppendAllText($"{Path.GetTempPath()}history.log", $"{operation} {result}");
        }
    }
}

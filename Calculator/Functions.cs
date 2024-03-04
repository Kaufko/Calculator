namespace Functions
{
    public static class Operators
    {
        public static double Pow(double number, int powerOf)
        {
            double result = number;
            for (int i = 0; i < powerOf-1; i++)
            {
                result *= number;
            }
            return result;
        }
        public static double Abs(double number)
        {
            return number = number < 0 ? -number : number;
            
        }
        public static double Root(double num, int sqrtNum)
        {
            int precision = (int)Pow(10, num.ToString().Length);
            if (num < 2)
            {
                return num;
            }
            double low = 1d/precision, high = num;
            while (low <= high)
            {
                double mid = (low + high) / 2.0d;
                if (Abs(Pow(mid, sqrtNum) - num) <= 0.0000000000000001d)
                {
                    return mid;
                }
                else if (Pow(mid, sqrtNum) < num)
                {
                    low = mid + 0.000000000000001d;
                }
                else
                {
                    high = mid - 0.000000000000001d;
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

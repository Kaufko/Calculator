using NCalc;

namespace Functions
{
    public static class Operators
    {
        public static int SumWhole(int[] nums)
        {
            int result = 0;
            foreach(int num in nums)
            {
                result += num;
            }
            return result;
        }
        public static int SubWhole(int[] nums)
        {
            int result = 0;
            foreach (int num in nums)
            {
                result -= num;
            }
            return result;
        }
        public static int MulWhole(int[] nums)
        {
            int result = 0;
            foreach(int num in nums)
            {
                result *= num;
            }
            return result;
        }
        public static int Factorial(int number)
        {
            int result = 0;
            for (int i = 0; i < number; i++)
            {
                result *= number;
            }
            return result;
        }
        public static int PowWhole(int number, int powerOf)
        {
            int result = number;
            for (int i = 0; i < powerOf - 1; i++)
            {
                result *= number;
            }
            return result;
        }
        public static double SumDec(double[] nums)
        {
            double result = 0;
            foreach (double num in nums)
            {
                result += num;
            }
            return result;
        }
        public static double SubDec(double[] nums)
        {
            double result = 0;
            foreach (double num in nums)
            {
                result -= num;
            }
            return result;
        }
        public static double MulDec(double[] nums)
        {
            double result = 0;
            foreach (double num in nums)
            {
                result *= num;
            }
            return result;
        }
        public static double PowDec(double number, int powerOf)
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
            int precision = PowWhole(10, num.ToString().Length);
            if (num < 2)
            {
                return num;
            }
            double low = 1d/precision, high = num;
            while (low <= high)
            {
                double mid = (low + high) / 2.0d;
                if (Abs(PowDec(mid, sqrtNum) - num) <= 0.0000000000000001d)
                {
                    return mid;
                }
                else if (PowDec(mid, sqrtNum) < num)
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
    }

    public static class Miscellaneous
    {
        public static void WriteToHistory(string operation, float result)
        {
            File.AppendAllText($"{Path.GetTempPath()}history.log", $"{operation} {result}\n");
        }
        private static void Evaluate(string input)
        {
            NCalc.Expression expression = new NCalc.Expression(input);
            var result = expression.Evaluate();

            Console.WriteLine(result);

        }
        public static void Eval()
        {
            Console.WriteLine("Napiš matematický vzorec");
            string input = Console.ReadLine();
            try
            {
                Evaluate(input);
            }
            catch (Exception)
            {

                Console.WriteLine("Napsal si vzorec špatně");
            }
            Console.ReadKey();
        }
        public static void CwControls()
        {
            Console.WriteLine("yay");
            Console.ReadKey();
        }
    }
}

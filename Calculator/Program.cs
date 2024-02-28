using System.Buffers;

namespace MathK
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Operators.WriteToHistory("Test", 1.0f);
        }
    }
    
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
            result *= 1.0f/sqrtNum;
            return result;
        }
        public static void WriteToHistory(string operation, float result)
        {
            File.AppendAllText($"{Path.GetTempPath()}history.log", $"{operation} {result}");
        }
    }
}
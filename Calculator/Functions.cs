namespace Functions
{
    public static class Operators
    {
        public static void SumWhole()
        {
            Console.WriteLine("Zadej čísla ve formátu(1,2,3,4...)");
            int[] nums = Array.ConvertAll(Console.ReadLine().Split(","), int.Parse);
            int result = 0;
            string expression = "";
            foreach (int num in nums)
            {
                expression += $"{num}+";
                result += num;
            }
            expression = expression.Remove(expression.Length - 1);
            Console.WriteLine(result + "\nZmáčkněte jakékoli tlačítko pro pokračování");
            Console.ReadKey();
            Miscellaneous.WriteToHistory(expression, result);
        }
        public static void SubWhole()
        {
            Console.WriteLine("Zadej číslo");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Zadej čísla které se budou odčítat od prvního čísla ve formátu(1,2,3,4...)");
            int[] subdividers = Array.ConvertAll(Console.ReadLine().Split(","), int.Parse);
            int result = num;
            string expression = Convert.ToString(num);
            foreach (int subdivider in subdividers)
            {
                expression += $"-{subdivider}";
                result -= subdivider;
            }
            Console.WriteLine(result + "\nZmáčkněte jakékoli tlačítko pro pokračování");
            Console.ReadKey();
            Miscellaneous.WriteToHistory(expression, result);
        }
        public static void MulWhole()
        {
            Console.WriteLine("Zadej čísla ve formátu(1,2,3,4...)");
            int[] nums = Array.ConvertAll(Console.ReadLine().Split(","), int.Parse);
            int result = 1;
            string expression = "";
            foreach (int num in nums)
            {
                expression += $"{num}*";
                result *= num;
            }
            expression = expression.Remove(expression.Length - 1);
            Console.WriteLine(result + "\nZmáčkněte jakékoli tlačítko pro pokračování");
            Console.ReadKey();
            Miscellaneous.WriteToHistory(expression, result);
        }
        public static void DivWhole()
        {
            Console.WriteLine("Zadej číslo");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Zadej dělitele ve formátu(1,2,3,4...)");
            int[] divideres = Array.ConvertAll(Console.ReadLine().Split(","), int.Parse);
            string expression = Convert.ToString(num);
            foreach (int divider in divideres)
            {
                expression += $"/{divider}";
                num /= divider;
            }
            Console.WriteLine(num + "\nZmáčkněte jakékoli tlačítko pro pokračování");
            Console.ReadKey();
            Miscellaneous.WriteToHistory(expression, num);
        }
        public static void PowWhole()
        {
            Console.WriteLine("Zadej číslo");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Zadej mocninu");
            int powerOf = Convert.ToInt32(Console.ReadLine());
            int result = 1;
            for (int i = 0; i < powerOf; i++)
            {
                result *= number;
            }
            Console.WriteLine(result + "\nZmáčkněte jakékoli tlačítko pro pokračování");
            Console.ReadKey();
            Miscellaneous.WriteToHistory($"{number}^{powerOf}", result);
        }
        public static void Modulo()
        {
            Console.WriteLine("Zadej číslo");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Zadej dělitele");
            int divider = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine((number % divider) + "\nZmáčkněte jakékoli tlačítko pro pokračování");
            Console.ReadKey();
            Miscellaneous.WriteToHistory($"{number}%{divider}", number % divider);
        }
        public static void Factorial()
        {
            Console.WriteLine("Zadej číslo");
            int number = Convert.ToInt32(Console.ReadLine());
            int result = 1;
            for (int i = number; i > 0; i--)
            {
                result *= i;
            }
            Console.WriteLine(result + "\nZmáčkněte jakékoli tlačítko pro pokračování");
            Console.ReadKey();
            Miscellaneous.WriteToHistory($"!{number}", result);
        }
        public static void SumDec()
        {
            Console.WriteLine("Zadej čísla ve formátu(1.1,2.2,3.3,4.5 ...)");
            double[] nums = Array.ConvertAll(Console.ReadLine().Split(","), double.Parse);
            double result = 0;
            string expression = "";
            foreach (double num in nums)
            {
                expression += $"{num}+";
                result += num;
            }
            expression = expression.Remove(expression.Length - 1);
            Console.WriteLine(result + "\nZmáčkněte jakékoli tlačítko pro pokračování");
            Console.ReadKey();
            Miscellaneous.WriteToHistory(expression, result);
        }
        public static void SubDec()
        {
            Console.WriteLine("Zadej číslo");
            double num = Convert.ToDouble(Console.ReadLine()); 
            Console.WriteLine("Zadej čísla které se budou odčítat od prvního čísla ve formátu(1.1,2.2,3.3,4.5 ...)");
            double[] subdividers = Array.ConvertAll(Console.ReadLine().Split(","), double.Parse);
            double result = num;
            string expression = Convert.ToString(num);
            foreach (double subdivider in subdividers)
            {
                expression += $"-{subdivider}";
                result -= subdivider;
            }
            Console.WriteLine(result + "\nZmáčkněte jakékoli tlačítko pro pokračování");
            Console.ReadKey();
            Miscellaneous.WriteToHistory(expression, result);
        }
        public static void MulDec()
        {
            Console.WriteLine("Zadej čísla ve formátu(1.1,2.2,3.3,4.5 ...)");
            double[] nums = Array.ConvertAll(Console.ReadLine().Split(","), double.Parse);
            double result = 1;
            string expression = "";
            foreach (double num in nums)
            {
                expression += $"*{num}";
                result *= num;
            }
            expression = expression.Remove(expression.Length - 1);
            Console.WriteLine(result + "\nZmáčkněte jakékoli tlačítko pro pokračování");
            Console.ReadKey();
            Miscellaneous.WriteToHistory(expression, result);
        }
        public static void DivDec()
        {
            Console.WriteLine("Zadej čísla ve formátu(1.1,2.2,3.3,4.5 ...)");
            double[] dividers = Array.ConvertAll(Console.ReadLine().Split(","), double.Parse);
            double number = Convert.ToDouble(Console.ReadLine());
            string expression = Convert.ToString(number);
            foreach (double divider in dividers)
            {
                expression += $"/{divider}";
                number /= divider;
            }
            Console.WriteLine(number + "\nZmáčkněte jakékoli tlačítko pro pokračování");
            Console.ReadKey();
            Miscellaneous.WriteToHistory(expression, number);
        }
        public static void PowDec()
        {
            Console.WriteLine("Zadej číslo");
            double number = Convert.ToDouble(Miscellaneous.replaceAns(Console.ReadLine()));
            Console.WriteLine("Zadej mocninu");
            Int16 powerOf = Convert.ToInt16(Console.ReadLine());
            double result = 1;
            for (int i = 0; i < powerOf; i++)
            {
                result *= number;
            }
            Console.WriteLine(result + "\nZmáčkněte jakékoli tlačítko pro pokračování");
            Console.ReadKey();
            Miscellaneous.WriteToHistory($"{number}^{powerOf}", result);
        }
        public static void Root()
        {
            Console.WriteLine("Zadej číslo na odmocnění");
            double num = Convert.ToDouble(Miscellaneous.replaceAns(Console.ReadLine()));
            Console.WriteLine("Zadej mocnitele");
            Int16 sqrtNum = Convert.ToInt16(Miscellaneous.replaceAns(Console.ReadLine()));
            if (num < 2)
            {
                Console.WriteLine(num + "\nZmáčkněte jakékoli tlačítko pro pokračování");
                Console.ReadKey();
                Miscellaneous.WriteToHistory($"{sqrtNum}\u221a{num}", num);
                return;
            }
            double low = 1, high = num;
            while (low <= high)
            {
                double mid = (low + high) / 2.0d;
                if (Math.Abs(Math.Pow(mid, sqrtNum) - num) <= 0.0000000000000001d)
                {
                    Console.WriteLine(mid + "\nZmáčkněte jakékoli tlačítko pro pokračování");
                    Console.ReadKey();
                    Miscellaneous.WriteToHistory($"{sqrtNum}\u221a{num}", mid);
                    return;
                }
                else if (Math.Pow(mid, sqrtNum) < num)
                {
                    low = mid + 0.000000000000001d;
                }
                else
                {
                    high = mid - 0.000000000000001d;
                }
            }
            Console.WriteLine(high + "\nZmáčkněte jakékoli tlačítko pro pokračování");
            Console.ReadKey();
            Miscellaneous.WriteToHistory($"{sqrtNum}\u221a{num}", (float)high);
            return;
        }
    }

    public static class Miscellaneous
    {
        public static void WriteHistory()
        {
            string[] lines = File.ReadAllLines($"{Path.GetTempPath()}history.log");
            for(int i = lines.Count(); i > 0; i--)
            {
                Console.WriteLine(lines[i-1]);
            }
            Console.ReadKey();
        }
        public static void WriteToHistory(string operation, double result)
        {
            File.AppendAllText(
                $"{Path.GetTempPath()}history.log", //gets history.log in /temp
                $"{operation} {result}\n"
                );
        }
        public static void Eval()
        {
            Console.WriteLine("Napiš matematický vzorec, pro poslední výsledek použijte Ans (1+Ans)");
            string input = replaceAns(Console.ReadLine());
            try
            {
                NCalc.Expression expression = new NCalc.Expression(input);
                var result = expression.Evaluate();

                

                Console.WriteLine(Convert.ToString(result));
                WriteToHistory(input, Convert.ToDouble(result));
            }
            catch (Exception e)
            {
                
                Console.WriteLine(e);
            }
            
            Console.ReadKey();
            
        }
        public static void CwControls()
        {
            Console.Clear();
            Console.WriteLine("Zmáčkni klávesu Enter pro spuštění vybrané položky");
            Console.WriteLine("Zmáčkni šipku dolů a nahorů pro vybýrání položek");
            Console.WriteLine("Zmáčkni Backspace pro návrat do hlavního menu");
            Console.WriteLine("Zmáčkni Escape pro ukončení aplikace");
            Console.WriteLine("\nZmáčkni jakoukoli klávesu pro pokračování");
            Console.ReadKey();
        }

        internal static string replaceAns(string input)
        {
            //replaces Ans with value of last answer result
            return input.Replace(
                "Ans",
                File.ReadLines($"{Path.GetTempPath()}history.log")
                .Last().Split()[1]
                ); 
        }
    }
}

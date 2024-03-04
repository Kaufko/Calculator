using Functions;
using MenuLib;

namespace Calculator
{
    public static class Program
    {
        static List<Menu> mainMenu;
        static List<Menu> calcMenu;
        static List<Menu> wholeNumMenu;
        static List<Menu> decNumMenu;
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            mainMenu = new List<Menu>
            {
                new Menu("Kalkulačka", () => MenuK.SelectSubMenu(calcMenu)),
                new Menu("Ovládání", () => Miscellaneous.CwControls())
            };

            calcMenu = new List<Menu>
            {
                new Menu("Celá čísla", () => MenuK.SelectSubMenu(wholeNumMenu)),
                new Menu("Desetiná čísla", () => MenuK.SelectSubMenu(decNumMenu)),
                new Menu("Vlastní vzorec", () => Miscellaneous.Eval())
            };

            wholeNumMenu = new List<Menu>
            {
                new Menu("Sčítaní", () => Operators.SumWhole()),
                new Menu("Odčítaní", () => Operators.SubWhole()),
                new Menu("Násobení", () => Operators.MulWhole()),
                new Menu("Dělení", () => Operators.DivWhole()),
                new Menu("Faktoriál", () => Operators.Factorial()),
                new Menu("Mocnění", () => Operators.PowWhole()),
                new Menu("Zbytek", () => Operators.Modulo()),
                new Menu("Odmocnění", () => Operators.Root()),
            };

            decNumMenu = new List<Menu>
            {
                new Menu("Sčítaní", () => Operators.SumDec()),
                new Menu("Odčítaní", () => Operators.SubDec()),
                new Menu("Násobení", () => Operators.MulDec()),
                new Menu("Dělení", () => Operators.DivDec()),
                new Menu("Mocnění", () => Operators.PowDec()),
                new Menu("Odmocnění", () => Operators.Root()),
            };


            MenuK.Start(mainMenu); //run last
        }

        

    }
}
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
                new Menu("", () => ),
                new Menu("", () => ),
                new Menu("", () => ),
                new Menu("", () => ),
                new Menu("", () => ),
                new Menu("", () => ),
                new Menu("", () => ),
                new Menu("", () => ),
            };

            MenuK.Start(mainMenu); //run last
        }

        

    }
}
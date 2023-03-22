using System;

namespace LW3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var app= new UIClass();

            app.StartUI();
            Console.WriteLine("Hello World!");
        }
    }

    public class UIClass 
    {
        public void StartUI()
        {
            while (true) 
            {
                Console.WriteLine("1. Plus");
                Console.WriteLine("2. Minus");
                Console.WriteLine("3. Divided");
                Console.WriteLine("4. Multiply");
                Console.WriteLine("5. Close Console");
                Console.WriteLine("Chose menu item:");
                
                
                switch (CoreLogic.CheckInput())
                {
                    case 1:
                        Console.WriteLine("Input 2 numbers:");
                        Console.WriteLine(CoreLogic.DoPlus(CoreLogic.CheckInput(), CoreLogic.CheckInput()));
                        break;
                    case 2:
                        Console.WriteLine("Input 2 numbers:");
                        Console.WriteLine(CoreLogic.DoPlus(CoreLogic.CheckInput(), CoreLogic.CheckInput()));
                        break;
                    case 3:
                        Console.WriteLine("Input 2 numbers:");
                        Console.WriteLine(CoreLogic.DoPlus(CoreLogic.CheckInput(), CoreLogic.CheckInput()));
                        break;
                    case 4:
                        Console.WriteLine("Input 2 numbers:");
                        Console.WriteLine(CoreLogic.DoPlus(CoreLogic.CheckInput(), CoreLogic.CheckInput()));
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                }

            }

        }

    }

    public static class CoreLogic
    {
        public static int DoPlus(int x, int y) => x + y;
        public static int DoMinus(int x, int y) => x - y; 
        public static int DoDivided(int x, int y) => x / y;
        public static int DoMultiply(int x, int y) => x * y;

        public static int CheckInput()
        {
            int result;

            while (!int.TryParse(Console.ReadLine(), out result))
            {
                Console.WriteLine("Incorrect input, try again");
            }

            return result;
        }


    }

}

using System;

namespace CalculatorX
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            calc.FirstNumber = 5;
            calc.SecondNumber = 10;
            calc.NumberInMemory = 123;
            bool programRunning = true;

            while (programRunning) {
                Console.WriteLine("1. Add two numbers\n" +
                "2. Multiply two numbers\n" +
                "3. Sum the numbers between two numbers\n" +
                "4. Add number to memory\n" +
                "5. Clear memory\n" +
                "6. Print calculator contents\n" +
                "7. Quit\n"
                );
                string selectedString = Console.ReadLine();
                int selected = int.Parse(selectedString);

                switch(selected) {
                    case 1:
                        calc.enterNumOne();
                        calc.enterNumTwo();
                        Console.WriteLine("Sum: " + calc.SumNumbers());
                        break;
                    case 2:
                        calc.enterNumOne();
                        calc.enterNumTwo();
                        Console.WriteLine("Multiply: " + calc.MultiplyNumbers());
                        break;
                    case 3:
                        calc.enterNumOne();
                        calc.enterNumTwo();
                        Console.WriteLine("Sum-Between: " + calc.SumInBetween());
                        break;
                    case 4:
                        calc.addNumToMemory();
                        break;
                    case 5:
                        calc.clearMemory();
                        break;
                    case 6:
                        Console.WriteLine(calc.ToString());
                        break;
                    case 7:
                        Console.WriteLine("Goodbye!");
                        programRunning = false;
                        break;
                    default:
                        Console.WriteLine("Default");
                        break;
                }
            }
        }
    }
}

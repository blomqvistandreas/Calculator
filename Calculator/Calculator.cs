using System;

namespace CalculatorX
{
    internal class Calculator
    {
        public int FirstNumber { get; set; }
        public int SecondNumber { get; set; }
        public int NumberInMemory { get; set; }

        public Calculator()
        {
            FirstNumber = 0;
            SecondNumber = 0;
            NumberInMemory = 0;
        }

        public void calculatorMenu() {

        }

        public override string ToString()
        {
            return "First number: " + FirstNumber.ToString() +"\n"+
                "Second number: " + SecondNumber.ToString() + "\n" +
                "Number in memory: " + NumberInMemory.ToString();
        }

        public int SumNumbers() {
            return FirstNumber + SecondNumber;
        }

        public int MultiplyNumbers() {
            return FirstNumber * SecondNumber;
        }

        public int SumInBetween() {
            int sum = 0;
            for (int i = FirstNumber; i < SecondNumber; i++) {
                sum = sum + i;
            }
            return sum;
        }

        public void enterNumOne() {
            Console.WriteLine("Skriv in ett tal: ");
            string numOne = Console.ReadLine();
            FirstNumber = int.Parse(numOne);
        }

        public void enterNumTwo() {
            Console.WriteLine("Skriv ditt andra tal: ");
            string numTwo = Console.ReadLine();
            SecondNumber = int.Parse(numTwo);
        }

        public void addNumToMemory() {
            Console.WriteLine("Skriv in ett tal: ");
            string num = Console.ReadLine();
            NumberInMemory = int.Parse(num);
            Console.WriteLine("Number successfully added to memory");
        }

        public void clearMemory() {
            NumberInMemory = 0;
            Console.WriteLine("Number in memory cleared");
        }
    }
}
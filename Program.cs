using System;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double number1 = 0;
            double number2 = 0;
            string operation = null;

            Console.Write("Enter the first number: ");
            number1 = double.Parse(Console.ReadLine());
 
            do
            {
                Console.Write("Enter the operator: ");
                operation = Console.ReadLine();

                if (operation != "=")
                {
                    Console.Write("Enter the next number: ");
                    number2 = int.Parse(Console.ReadLine());

                    switch (operation)
                    {
                        case "+":
                            number1 += number2;
                            // Console.WriteLine(number1);
                            break;
                        case "-":
                            number1 -= number2;
                            // Console.WriteLine(number1);
                            break;
                        case "*":
                            number1 *= number2;
                            // Console.WriteLine(number1);
                            break;
                        case "/":
                            number1 /= number2;
                            // Console.WriteLine(number1);
                            break;

                    }
                }
                
            } while (operation != "=");

            Console.WriteLine(number1);
            Console.Read();
        }
    }
}

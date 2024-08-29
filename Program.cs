using Calculator.Contracts;
using Calculator.Enums;
using Calculator.Models;

namespace Calculator
{
    public class Program
    {
        private static void Main(string[] args)
        {
            while (true)
            {
                DisplayMenu();
                OperatorSelection();
            }
        }

        private static void DisplayMenu()
        {
            Console.Clear();

            Console.WriteLine("What do you want to do?");
            Console.WriteLine("1 - Sum");
            Console.WriteLine("2 - Subtraction");
            Console.WriteLine("3 - Division");
            Console.WriteLine("4 - Multiplication");
            Console.WriteLine("5 - Exit");

            Console.WriteLine("-------------------");

            Console.Write("Select option: ");
        }

        private static void OperatorSelection()
        {
            if (TryGetOption(out EOptionType option))
            {
                if (option == EOptionType.Exit)
                {
                    Environment.Exit(0);
                }

                var (v1, v2) = GetOperands();

                var @operator = SelectOption(option, v1, v2);

                DisplayResult(@operator);
            }
            else
            {
                DisplayInvalidOptionMessage();
            }
        }

        private static void DisplayResult(IOperation? @operator)
        {
            if (@operator != null)
            {
                Console.Write($"Result: {@operator.Calculate()}");
                Console.ReadKey();
            }
        }

        private static void DisplayInvalidOptionMessage()
        {
            Console.WriteLine("Invalid input. Please enter a valid option.");
            Console.ReadKey();
        }

        private static bool TryGetOption(out EOptionType option)
        {
            return Enum.TryParse(Console.ReadLine(), out option) && Enum.IsDefined(typeof(EOptionType), option);
        }

        private static IOperation? SelectOption(EOptionType option, float v1, float v2) => option switch
        {
            EOptionType.Sum => new Sum(v1, v2),
            EOptionType.Subtraction => new Subtraction(v1, v2),
            EOptionType.Division => new Division(v1, v2),
            EOptionType.Multiplication => new Multiplication(v1, v2),
            _ => null
        };

        private static (float, float) GetOperands()
        {
            Console.Clear();

            var v1 = GetOperand("First value: ");

            var v2 = GetOperand("Second value: ");

            return (v1, v2);
        }

        private static float GetOperand(string prompt)
        {
            Console.Write(prompt);

            return float.Parse(Console.ReadLine()!);
        }
    }
}
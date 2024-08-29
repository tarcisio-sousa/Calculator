namespace Calculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
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
            try
            {
                var option = short.Parse(Console.ReadLine()!);
                SelectOption(option);
            }
            catch (ArgumentOutOfRangeException exception)
            {
                Console.WriteLine(exception.Message);
            }
            finally
            {
                Console.ReadKey();
                Menu();
            }
        }

        static void SelectOption(short option)
        {
            switch (option)
            {
                case 1:
                    Sum();
                    break;
                case 2:
                    Subtraction();
                    break;
                case 3:
                    Multiplication();
                    break;
                case 4:
                    Division();
                    break;
                case 5:
                    System.Environment.Exit(0);
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(option), $"Not expected option value: {option}");
            }
        }

        static void Sum()
        {
            Console.Clear();

            Console.Write("First value: ");
            var v1 = float.Parse(Console.ReadLine()!);

            Console.Write("Second value: ");
            var v2 = float.Parse(Console.ReadLine()!);

            Console.WriteLine("");

            var result = v1 + v2;

            Console.Write($"The result of the sum is {result}");
        }

        static void Subtraction()
        {
            Console.Clear();

            Console.Write("First value: ");
            var v1 = float.Parse(Console.ReadLine()!);

            Console.Write("Second value: ");
            var v2 = float.Parse(Console.ReadLine()!);

            Console.WriteLine("");

            var result = v1 - v2;

            Console.Write($"The result of the subtraction is {result}");
        }

        static void Division()
        {
            Console.Clear();

            Console.Write("First value: ");
            var v1 = float.Parse(Console.ReadLine()!);

            Console.Write("Second value: ");
            var v2 = float.Parse(Console.ReadLine()!);

            Console.WriteLine("");

            var result = v1 / v2;
            Console.WriteLine($"The result of the division is {result}");
        }

        static void Multiplication()
        {
            Console.Clear();

            Console.Write("First value: ");
            var v1 = float.Parse(Console.ReadLine()!);

            Console.Write("Second value: ");
            var v2 = float.Parse(Console.ReadLine()!);

            Console.WriteLine("");

            var result = v1 * v2;

            Console.WriteLine($"The result of the multiplication is {result}");
        }
    }
}
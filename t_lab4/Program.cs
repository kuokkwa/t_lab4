namespace t_lab4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose operation: ");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");

            if (!int.TryParse(Console.ReadLine(), out int choice) || choice < 1 || choice > 4)
            {
                Console.WriteLine("Incorrect choice of operation.");
                return;
            }

            Console.Write("Enter first numeric: ");
            if (!double.TryParse(Console.ReadLine(), out double number1))
            {
                Console.WriteLine("Incorrect number format.");
                return;
            }

            Console.Write("Enter second numeric: ");
            if (!double.TryParse(Console.ReadLine(), out double number2))
            {
                Console.WriteLine("Incorrect number format.");
                return;
            }

            double result = 0;

            switch (choice)
            {
                case 1:
                    result = number1 + number2;
                    break;
                case 2:
                    result = number1 - number2;
                    break;
                case 3:
                    result = number1 * number2;
                    break;
                case 4:
                    if (Math.Abs(number2) < double.Epsilon)
                    {
                        Console.WriteLine("Error: division by zero.");
                        return;
                    }
                    result = number1 / number2;
                    break;
            }

            Console.WriteLine($"Result: {result}");
        }
    }
}
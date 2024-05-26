using collections_exceptions_task_6;

public static class Program
{
    public static void Main(string[] args)
    {
        Calculator<double> calculator = new Calculator<double>();

        while (true)
        {
            Console.WriteLine();
        NumberOneLine: Console.WriteLine("Enter Number 1:");
            double NumOne;
            if (!double.TryParse(Console.ReadLine(), out NumOne))
            {
                Console.WriteLine("Enter correct format...");
                goto NumberOneLine;
            }
        NumberTwoLine: Console.WriteLine("Enter Number 2:");
            double NumTwo;
            if (!double.TryParse(Console.ReadLine(), out NumTwo))
            {
                Console.WriteLine("Enter correct format...");
                goto NumberTwoLine;
            }

            Console.WriteLine();
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Subtract");
            Console.WriteLine("3. Divide");
            Console.WriteLine("4. Multiply");

            string operation = Console.ReadLine();

            switch (operation)
            {
                case "1":
                    Console.WriteLine(calculator.Add(NumOne, NumTwo));
                    break;
                case "2":
                    Console.WriteLine(calculator.Subtract(NumOne, NumTwo));
                    break;
                case "3":
                    Console.WriteLine(calculator.Divide(NumOne, NumTwo));
                    break;
                case "4":
                    Console.WriteLine(calculator.Multiply(NumOne, NumTwo));
                    break;
                default:
                    Console.WriteLine("Choose correct operation...");
                    break;
            }
        }
    }
}
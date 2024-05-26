using collections_exceptions_task_4;

public static class Program
{
    public static void Main(string[] args)
    {
        Inventory inventory = new Inventory();

        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("1. Add Product to Inventory");
            Console.WriteLine("2. Remove Product from Inventory");
            Console.WriteLine("3. Update Product Quantity By Name");
            Console.WriteLine("4. Get Product Quantity By Name");
            Console.WriteLine("5. Exit");

            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    Console.WriteLine();
                    Console.WriteLine("Enter Product Name: ");
                    string name = Console.ReadLine();
                    Console.WriteLine("Enter Product Quantity: ");
                    int count = Convert.ToInt32(Console.ReadLine());

                    inventory.AddProduct(name, count);
                    break;
                case "2":
                    Console.WriteLine();
                    Console.WriteLine("Enter Product Name: ");
                    name = Console.ReadLine();

                    inventory.RemoveProduct(name);
                    break;
                case "3":
                    Console.WriteLine();
                    Console.WriteLine("Enter Product Name: ");
                    name = Console.ReadLine();
                    Console.WriteLine("Enter New Quantity for Product: ");
                    count = Convert.ToInt32(Console.ReadLine());

                    inventory.UpdateQuantity(name, count);
                    break;
                case "4":
                    Console.WriteLine();
                    Console.WriteLine("Enter Product Name: ");
                    name = Console.ReadLine();

                    inventory.GetQuantityByProduct(name);
                    break;
                case "5":
                    return;
                default:
                    Console.WriteLine("Choose right option");
                    break;
            }
        }
    }
}
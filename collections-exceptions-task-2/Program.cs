using collections_exceptions_task_2;

public static class Program
{
    public static void Main(string[] args)
    {
        PhoneBook phoneBook = new PhoneBook();

        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("1. Add Contact");
            Console.WriteLine("2. Remove Contact");
            Console.WriteLine("3. Get All Contacts");
            Console.WriteLine("4. Find Contact By Name");
            Console.WriteLine("5. Exit");

            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    Console.WriteLine();
                    Console.WriteLine("Enter Name:");
                    string name = Console.ReadLine();
                    Console.WriteLine("Enter Number:");
                    string number = Console.ReadLine();
                    Console.WriteLine();
                    phoneBook.AddContact(name, number);
                    break;
                case "2":
                    Console.WriteLine();
                    Console.WriteLine("Enter Name:");
                    name = Console.ReadLine();
                    phoneBook.RemoveContact(name);
                    Console.WriteLine();
                    break;
                case "3":
                    Console.WriteLine();
                    phoneBook.GetAllContacts();
                    break;
                case "4":
                    Console.WriteLine();
                    Console.WriteLine("Enter name: ");
                    name = Console.ReadLine();
                    phoneBook.FindContactByName(name);
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
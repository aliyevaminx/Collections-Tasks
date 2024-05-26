
using collections_exceptions_task_5;

public static class Program
{
    public static void Main(string[] args)
    {
        SocialMedia student = new SocialMedia();


        while (true)
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("1. Add Friend");
            Console.WriteLine("2. Remove Friend");
            Console.WriteLine("3. Get All Friends By Username");
            Console.WriteLine("4. Exit");


            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    Console.WriteLine();
                    Console.WriteLine("Enter Username:");
                    string name = Console.ReadLine();
                    Console.WriteLine("Enter Name: ");
                    string friend = Console.ReadLine();

                    student.AddFriend(name, friend);
                    break;
                case "2":
                    Console.WriteLine();
                    Console.WriteLine("Enter Username:");
                    name = Console.ReadLine();
                    Console.WriteLine("Enter name: ");
                    friend = Console.ReadLine();

                    student.RemoveFriend(name, friend);
                    break;
                case "3":
                    Console.WriteLine();
                    Console.WriteLine("Enter Username:");
                    name = Console.ReadLine();

                    student.GetAllFriendsByUsername(name);
                    break;
                case "4":
                    return;
                default:
                    Console.WriteLine("Choose right option");
                    break;
            }
        }
    }
}

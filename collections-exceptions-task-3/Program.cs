using collections_exceptions_task_3;

public static class Program
{
    public static void Main(string[] args)
    {
        Student student = new Student();

    
        while (true)
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("1. Add Grade");
            Console.WriteLine("2. Remove Grade");
            Console.WriteLine("3. Get Average Grade");
            Console.WriteLine("4. Get All Grades By Student");
            Console.WriteLine("5. Exit");


            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    Console.WriteLine();
                    Console.WriteLine("Enter name:");
                    string name = Console.ReadLine();
                    Console.WriteLine("Enter grade: ");
                    int grade = Convert.ToInt32(Console.ReadLine());

                    student.AddGrade(name, grade);
                    break;
                case "2":
                    Console.WriteLine();
                    Console.WriteLine("Enter name:");
                    name = Console.ReadLine();
                    Console.WriteLine("Enter grade: ");
                    grade = Convert.ToInt32(Console.ReadLine());

                    student.RemoveGrade(name, grade);
                    break;
                case "3":
                    Console.WriteLine();
                    Console.WriteLine("Enter name:");
                    name = Console.ReadLine();

                    student.GetAverageGrade(name);
                    break;
                case "4":
                    Console.WriteLine();
                    Console.WriteLine("Enter name:");
                    name = Console.ReadLine();

                    student.GetAllGradesByStudent(name);
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

public static class Program
{
    public static void Main(string[] args)
    {
        string str = Console.ReadLine();

        ReverseString(str);


    }
    public static void ReverseString(string str)
    {
        Stack<char> stack = new Stack<char>();
        string reversedString = String.Empty;

        foreach (char charr in str)
        {
            stack.Push(charr);
        }

        //char[] reversedString = new char[stack.Count];

        //for (int i = 0; i < reversedString.Length; i++)
        //{
        //    reversedString[i] = stack.Pop();
        //}

        //Console.WriteLine(reversedString);

        while (stack.Count > 0)
        {
            reversedString += stack.Pop(); 
        }

        Console.WriteLine(reversedString);
    }

}
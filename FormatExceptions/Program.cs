class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        try
        {
            string input = Console.ReadLine();
            int number = int.Parse(input);

        }
        catch (FormatException)
        {
            Console.WriteLine("That's not a valid number");
        }
    }
}


using Lab.Library;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("This program encrypts the characters of a message using the Vigenere method.\nPlease enter the message:\n");
        string? msg = Console.ReadLine();
        Console.WriteLine("Write and Encrytion Key:\n");
        string? key = Console.ReadLine();
        Console.WriteLine(inputValidation.IsValidInput("This is NOT LOwercase"));



    }
}
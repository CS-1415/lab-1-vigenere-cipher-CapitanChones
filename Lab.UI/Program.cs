// Amando Thomas 9/4/24
using Lab.Library;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("This program encrypts the characters of a message using the Vigenere method.\nPlease enter the message:\n");
        string? msg = Console.ReadLine();
        while (!inputValidation.IsValidInput(msg))
        {
            Console.Clear();
            Console.WriteLine("Please Enter Only Lowercase Letters and no special characters or spaces, press any key to try again: \n");
            Console.ReadKey();
            msg = Console.ReadLine();
        }
        Console.WriteLine("Write and Encrytion Key:\n");
        string? key = Console.ReadLine();
        while (!inputValidation.IsValidInput(key))
        {
            Console.Clear();
            Console.WriteLine("Please Enter Only Lowercase Letters and no special characters or spaces, press any key to try again:\n");
            Console.ReadKey();
            Console.WriteLine("Write and Encrytion Key:\n");
            key = Console.ReadLine();
        }
        Console.WriteLine($"Congratulations {msg} has become:\n" + Vigenere.ShiftMessage(msg, key));




    }
}
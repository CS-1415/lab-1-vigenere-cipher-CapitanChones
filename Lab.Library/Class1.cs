namespace Lab.Library;

public class Vigenere
{

}
public class inputValidation
{
    public static bool IsLowercaseLetter(char c)

    {
        if (c >= 65 && c <= 90)
        {
            return false;
        }
        if (c <= 122 && c >= 97)
        {
            return true;
        }

        return false;
    }

    public static bool IsValidInput(string msg)
    {
        return false;
    }
}

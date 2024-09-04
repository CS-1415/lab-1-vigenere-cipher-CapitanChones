namespace Lab.Library;

public class Vigenere
{

}
public class inputValidation
{
    public bool IsLowercaseLetter(char c)

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
}

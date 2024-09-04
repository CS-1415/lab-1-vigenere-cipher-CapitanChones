﻿namespace Lab.Library;

public class Vigenere
{
    public static char Shiftletter(char cval, char ckey)
    {

        int temp;
        if (cval == 122)
        {
            temp = ckey - 97;
            temp = 96 + temp;
            return (char)temp;
        }
        temp = ckey - 97;
        temp = cval + temp;

        //this checks to see if it went past 'z' and corrects it.
        if (temp > 122)
        {
            int _temp = temp - 122;
            _temp += 96;
            return (char)_temp;
        }

        return (char)temp;
    }

    public static string ShiftMessage(string message, string key)
    {

        return "pain";
    }    

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
        bool isval = false;
        foreach (char c in msg)
        {
            if (c >= 65 && c <= 90)
            {
                isval = false;
                return false;
            }
            else if (c <= 122 && c >= 97)
            {
                isval = true;
            }
            else
            {
                isval = false;
            }
        }
        return isval;
    }
}

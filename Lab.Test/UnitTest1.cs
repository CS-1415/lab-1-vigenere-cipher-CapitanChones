namespace Lab.Test;
using System.Diagnostics;
using Lab.Library;

public class UnitTest1
{
    [Fact]

    public static void TestIsLowercaseLetter()
    {
        var _Char = new inputValidation();

        Debug.Assert(_Char.IsLowercaseLetter('a'));
        Debug.Assert(_Char.IsLowercaseLetter('b'));
        Debug.Assert(_Char.IsLowercaseLetter('z'));
        Debug.Assert(!_Char.IsLowercaseLetter('A'));
        Debug.Assert(!_Char.IsLowercaseLetter('`'));
        Debug.Assert(!_Char.IsLowercaseLetter('{'));
    }
}
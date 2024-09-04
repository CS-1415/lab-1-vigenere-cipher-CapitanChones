namespace Lab.Test;
using static System.Diagnostics.Debug;
using Lab.Library;
using System.Diagnostics;

public class UnitTest1
{
    [Fact]

    public static void TestIsLowercaseLetter()
    {
        var _Char = new inputValidation();

        Assert(inputValidation.IsLowercaseLetter('a'));
        Assert(inputValidation.IsLowercaseLetter('b'));
        Assert(inputValidation.IsLowercaseLetter('z'));
        Assert(!inputValidation.IsLowercaseLetter('A'));
        Assert(!inputValidation.IsLowercaseLetter('`'));
        Assert(!inputValidation.IsLowercaseLetter('{'));
    }

    [Fact]
    public static void TestIsValidInput()
    {

        Assert(inputValidation.IsValidInput("this is lowercase"));
        Assert(!inputValidation.IsValidInput("This is NOT lowercase"));

    }
}
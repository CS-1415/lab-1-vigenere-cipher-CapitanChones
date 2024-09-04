namespace Lab.Test;
using static System.Diagnostics.Debug;
using Lab.Library;
using System.Diagnostics;

public class UnitTest1
{
    [Fact]

    public static void TestIsLowercaseLetter()
    {

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
        Assert(inputValidation.IsValidInput("this is passes"));
        Assert(!inputValidation.IsValidInput("This is NOT LOwercase"));
        Assert(!inputValidation.IsValidInput("this sentance should fail!"));
        Assert(!inputValidation.IsValidInput("this sentance should fail for a different reasoN"));

    }

    [Fact]
    public void TestShiftLetter()
    {
        Assert(Vigenere.Shiftletter('a', 'b') == 'b');
        Assert(Vigenere.Shiftletter('z', 'b') == 'a');
        Assert(Vigenere.Shiftletter('b', 'f') == 'g');
        Assert(Vigenere.Shiftletter('w', 'f') == 'b');


    }
    [Fact]
    public void TestShiftMessage()
    {
        Assert(Vigenere.ShiftMessage("aaaaaa","bbbbbb") =="bbbbbb" );
        Assert(Vigenere.ShiftMessage("cccccc","c") =="eeeeee");
        Assert(Vigenere.ShiftMessage("all lowercase","bc") =="bnmnpfsebuf");
        Assert(Vigenere.ShiftMessage("this is a message","key") =="dlgcmqkqccwyqi");

        
    }
}
namespace Lab.Test;
using static System.Diagnostics.Debug;
using Lab.Library;

public class UnitTest1
{
    [Fact]

    public void TestIsLowercaseLetter()
    {
        var _Char = new inputValidation();

        Assert(_Char.IsLowercaseLetter('a'));
        Assert(_Char.IsLowercaseLetter('b'));
        Assert(_Char.IsLowercaseLetter('z'));
        Assert(!_Char.IsLowercaseLetter('A'));
        Assert(!_Char.IsLowercaseLetter('`'));
        Assert(!_Char.IsLowercaseLetter('{'));
    }
}
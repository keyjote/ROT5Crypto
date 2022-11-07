using ROT5Crypto;

namespace Test;

public class UnitTest1
{
    [Theory]
    [InlineData("FML14", "FML69")]
    [InlineData("007", "552")]
    [InlineData("9*6=42", "4*1=97")]
    [InlineData("Just text", "Just text")]
    public void LeRot5(string input, string expectedResult)
    {
        var result = "";
        foreach (var leChar in input.ToCharArray())
        {
            result += Rot5.CryptMe(leChar);
        }

        Assert.Equal(expectedResult, result);
    }
    
    [Theory]
    [InlineData("DECERNO14", "QRPREAB14")]
    [InlineData("Let Me Ask DECERNO a silly QUESTION", "Yrg Zr Nfx QRPREAB n fvyyl DHRFGVBA")]
    [InlineData("abcdefghijklmnopqrstuvwqxy", "nopqrstuvwxyzabcdefghijdkl")]
    public void LeRot13(string input, string expectedResult)
    {
        var result = "";
        foreach (var leChar in input.ToCharArray())
        {
            result += Rot13.CryptMe(leChar);
        }

        Assert.Equal(expectedResult, result);
    }
    
    [Theory]
    [InlineData("$~=Gb E9=D 7@C bIEC2 3C288`?8 C`89ED] j\\\\X", "SOlv3 thls for 3xtra bragg1ng r1ghts. ;--)")]
    [InlineData("Why are you skipping spaces? that was cheating man!", "(9J 2C6 J@F D<:AA:?8 DA246Dn E92E H2D 4962E:?8 >2?P")]
    [InlineData("(9J cCb J_F D<`AA`?8 DAc4bDn E9cE HcD 49bef`?8 >2?P", "Why 4r3 y0u sk1pp1ng sp4c3s? th4t w4s ch3671ng man!")]
    public void LeRotAscii(string input, string expectedResult)
    {
        var result = "";
        foreach (var leChar in input.ToCharArray())
        {
            result += RotASCII.CryptMe(leChar);
        }

        Assert.Equal(expectedResult, result);
    }
}
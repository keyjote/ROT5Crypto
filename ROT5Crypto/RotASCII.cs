namespace ROT5Crypto;

public static class RotASCII 
{
    private static short _zeroLetter = (short)' ';
    private static short _add = 47;
    private static short _leMod = 94;

    public static char CryptMe(char val)
    {
        if (val == ' ')
        {
            return val;
        }
        if (char.IsAscii(val))
        {
            return (char) (((val + _add - _zeroLetter) % _leMod) + _zeroLetter);
        }

        return val;
    }
}
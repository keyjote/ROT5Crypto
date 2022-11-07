namespace ROT5Crypto;

public static class Rot13 
{
    private static short _add = 13;
    private static short _leMod = 26;

    public static char CryptMe(char val)
    {
        if (char.IsLetter(val))
        {
            var zeroLetter = (short) 'a';
            if (char.IsUpper(val))
            {
                zeroLetter = (short) 'A';
            }
            return (char) (((val + _add - zeroLetter) % _leMod) + zeroLetter);
        }

        return val;
    }
}
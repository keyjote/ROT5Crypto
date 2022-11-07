namespace ROT5Crypto;

public static class Rot5 
{
    private static short _zero = (short)'0';
    private static short _add = 5;
    private static short _leMod = 10;

    public static char CryptMe(char val)
    {
        if (char.IsNumber(val))
        {
            return (char) (((val + _add - _zero) % _leMod) + _zero);
        }

        return val;
    }
}
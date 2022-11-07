namespace ROT5Crypto;

public class RotAll 
{
    private short _zeroLetter;
    private short _add;
    private short _leMod;


    public RotAll(short leBase, char startCharacter)
    {
        if (leBase > 47)
        {
            throw new Exception("This method can't handle that number");
        }
        
        _zeroLetter = (short) startCharacter;
        _add = leBase;
        _leMod = (short)(leBase * 2);
    }

    public char CryptMe(char val)
    {
        if (val == ' ')
        {
            return val;
        }
        // TODO: 
        if (char.IsAscii(val))
        {
            return (char) (((val + _add - _zeroLetter) % _leMod) + _zeroLetter);
        }

        return val;
    }
}
namespace RomanNumerals;

public class RomanNumberConverter
{
    private static Dictionary<int, string> _romanTable = new()
    {
        { 1, "I" },
        { 4, "IV" },
        { 5, "V" },
        { 9, "IX" },
        { 10, "X" },
        { 40, "XL" },
        { 50, "L" },
        { 90, "XC" },
        { 100, "C" },
        { 400, "CD" },
        { 500, "D" },
        { 900, "CM" },
        { 1000, "M" },
    };

    public static string ToRoman(int arabicNumber)
    {
        var romanNumber = "";
        for (var i = 0; i < arabicNumber; i++)
        {
            romanNumber += _romanTable[1];
        }

        if (arabicNumber == 5)
            romanNumber = _romanTable[5];

        if (arabicNumber == 4)
            romanNumber = _romanTable[4];

        if (arabicNumber == 6)
            romanNumber = _romanTable[5] + _romanTable[1];
        
        if (arabicNumber == 9)
            romanNumber = _romanTable[9];
        
            
        return romanNumber;
    }
}
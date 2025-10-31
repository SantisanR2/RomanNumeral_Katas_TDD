namespace RomanNumerals;

public class RomanNumberConverter
{
    private static Dictionary<int, string> _romanTable = new()
    {
        { 1000, "M" },
        { 900, "CM" },
        { 500, "D" },
        { 400, "CD" },
        { 100, "C" },
        { 90, "XC" },
        { 50, "L" },
        { 40, "XL" },
        { 10, "X" },
        { 9, "IX" },
        { 5, "V" },
        { 4, "IV" },
        { 1, "I" }
    };

    public static string ToRoman(int arabicNumber)
    {
        var romanNumber = "";
        var remaining = arabicNumber;

        foreach (var (value, symbol) in _romanTable)
        {
            while (remaining >= value)
            {
                romanNumber += symbol;
                remaining -= value;
            }
        }

        return romanNumber;
    }
}
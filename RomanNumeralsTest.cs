using AwesomeAssertions;

namespace RomanNumerals;

public class RomanNumeralsTest
{
    [Theory]
    [InlineData(1, "I")]
    [InlineData(2, "II")]
    [InlineData(5, "V")]
    [InlineData(4, "IV")]
    public void Si_IngresoUnNumeroArabico_Debe_DarSuNumeroRomano(int arabicNUmber, string expectedRomanNumber)
    {
        var romanNumber = ToRoman(arabicNUmber);

        romanNumber.Should().Be(expectedRomanNumber);
    }

    private string ToRoman(int arabicNumber)
    {
        var romanNumber = "";
        for (var i = 0; i < arabicNumber; i++)
        {
            romanNumber += "I";
        }

        if (arabicNumber == 5)
            romanNumber = "V";

        if (arabicNumber == 4)
            romanNumber = "I" + "V";
            
        return romanNumber;
    }
}
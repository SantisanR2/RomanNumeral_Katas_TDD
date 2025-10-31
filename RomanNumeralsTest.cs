using AwesomeAssertions;

namespace RomanNumerals;

public class RomanNumeralsTest
{
    [Theory]
    [InlineData(1, "I")]
    [InlineData(2, "II")]
    [InlineData(5, "V")]
    [InlineData(4, "IV")]
    [InlineData(6, "VI")]
    public void Si_IngresoUnNumeroArabico_Debe_DarSuNumeroRomano(int arabicNumber, string expectedRomanNumber)
    {
        var romanNumber = RomanNumberConverter.ToRoman(arabicNumber);

        romanNumber.Should().Be(expectedRomanNumber);
    }
}
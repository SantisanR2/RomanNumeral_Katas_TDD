using AwesomeAssertions;

namespace RomanNumerals;

public class RomanNumeralsTest
{
    [Fact]
    public void Si_Ingreso_1_Debe_Dar_I()
    {
        var romanNumber = ToRoman(1);

        romanNumber.Should().Be("I");
    }

    private string ToRoman(int arabicNumber)
    {
        return "I";
    }
}
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

    [Fact]
    public void Si_Ingreso_2_Debe_Dar_II()
    {
        var romanNumber = ToRoman(2);

        romanNumber.Should().Be("II");
    }

    private string ToRoman(int arabicNumber)
    {
        return "I";
    }
}
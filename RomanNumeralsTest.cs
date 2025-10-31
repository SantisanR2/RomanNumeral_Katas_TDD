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

    [Fact]
    public void Si_Ingreso_5_Debe_Dar_V()
    {
        var romanNumber = ToRoman(5);

        romanNumber.Should().Be("V");
    }

    [Fact]
    public void Si_Ingreso_4_Debe_Dar_IV()
    {
        var romanNumber = ToRoman(4);

        romanNumber.Should().Be("IV");
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
            
        return romanNumber;
    }
}
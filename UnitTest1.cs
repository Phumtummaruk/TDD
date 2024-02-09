using converter;

namespace TDD_2;

public class UnitTest1
{
    [Fact]
    public void milliMeters()
    {
        double inches = 1;

        InchConverter converter = new InchConverter();

        double result = converter.InchesToMillimeters(inches);

        Assert.Equal(25.4, result);
        return;
    }

    [Fact]
    public void centimeters()
    {
        double inches = 1;

        InchConverter converter = new InchConverter();

        double result = converter.InchesToCentimeters(inches);

        Assert.Equal(2.54, result);
        return;
    }
    [Fact]
    public void meters()
    {
        double inches = 1;

        InchConverter converter = new InchConverter();

        double result = converter.InchesToMeters(inches);

        Assert.Equal(0.254, result);
        return;
    }

    void TestExtended(Func<int, string> toTest, int input, string expected, string description = "Best test for value")
    {
        string got = toTest(input);
        if (got == expected)
        {
            Console.WriteLine($"Yes {description}");
        }
        else
        {
            Console.WriteLine($"No {description}, Expected: {expected}, got {got}");
        }
    }

    [Fact]
    public void TestYourMethod()
    {
        InchConverter converter = new InchConverter();
        Func<int, string> millimeters = (int inches) => converter.InchesToMillimeters(inches).ToString();
        TestExtended(millimeters, 1, "25.4");
        Func<int, string> centimeters = (int inches) => converter.InchesToCentimeters(inches).ToString();
        TestExtended(centimeters, 1, "2.54");
        Func<int, string> meters = (int inches) => converter.InchesToMeters(inches).ToString();
        TestExtended(meters, 1, "0.254");
    }

}

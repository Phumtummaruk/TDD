namespace converter;

public class InchConverter
{
    public double InchesToMillimeters(double inches)
    {
        return inches * 25.4;
    }

    public double InchesToCentimeters(double inches)
    {
        return inches * 2.54;
    }

    public double InchesToMeters(double inches)
    {
        return inches * 0.0254;
    }
}



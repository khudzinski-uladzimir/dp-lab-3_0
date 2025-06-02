namespace lab_3;

public class Cube : IFigure
{
    public double Side { get; set; }

    public Cube(double side)
    {
        Side = side;
    }

    public void CalculateVolume()
    {
        Console.WriteLine("Calculating volume of the cube...");
        Console.WriteLine("Volume: " + Math.Pow(Side, 3));
    }
    public void Accept(IVisitor visitor)
    {
        visitor.Visit(this);
    }

}
namespace lab_3;

public class Cube : IFigure
{
    public double Side { get; set; }

    public Cube(double side)
    {
        Side = side;
    }

    public void Accept(IVisitor visitor)
    {
        visitor.Visit(this);
    }
}

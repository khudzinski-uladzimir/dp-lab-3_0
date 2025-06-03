namespace lab_3;

public class Visitor : IVisitor
{
    public void Visit(Sphere sphere)
    {
        Console.WriteLine($"Volume of sphere: " + 4.0 / 3.0 * Math.PI * Math.Pow(sphere.Radius, 3));
    }

    public void Visit(Torus torus)
    {
        Console.WriteLine(
            $"Volume of torus: " + 2 * Math.PI * Math.PI * Math.Pow(torus.MajorRadius, 3)
        );
    }

    public void Visit(Parallelepiped parallelepiped)
    {
        Console.WriteLine(
            $"Volume of parallelepiped: "
                + parallelepiped.Lenght * parallelepiped.Width * parallelepiped.Height
        );
    }

    public void Visit(Cube cube)
    {
        Console.WriteLine($"Volume of cube: " + Math.Pow(cube.Side, 3));
    }
}

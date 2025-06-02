namespace lab_3;

public class Visitor : IVisitor
{
    public void Visit(Sphere sphere)
    {
        sphere.CalculateVolume();
    }

    public void Visit(Torus torus)
    {
        torus.CalculateVolume();
    }

    public void Visit(Parallelepiped parallelepiped)
    {
        parallelepiped.CalculateVolume();
    }

    public void Visit(Cube cube)
    {
        cube.CalculateVolume();
    }
}
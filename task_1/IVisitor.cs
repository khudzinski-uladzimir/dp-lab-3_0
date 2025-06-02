namespace lab_3;

public interface IVisitor
{
    void Visit(Sphere sphere);
    void Visit(Torus torus);
    void Visit(Parallelepiped parallelepiped);
    void Visit(Cube cube);
}

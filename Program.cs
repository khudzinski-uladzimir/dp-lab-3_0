namespace lab_3;


internal class Program
{
    private static void Main(string[] args)
    {
        // Task 1: Visitor
        var visitor = new Visitor();
        var cube = new Cube(3);
        cube.Accept(visitor);
        var sphere = new Sphere(5);
        sphere.Accept(visitor);
        var torus = new Torus(2);
        torus.Accept(visitor);
        var parallelepiped = new Parallelepiped(2, 3, 4);
        parallelepiped.Accept(visitor);

        Console.WriteLine("\n\n");

        //Task 2: Strategy
        var context = new Context();
        context.SetStrategy(new StrategyTakeAway());
        context.HandleOrder("123 Main St", "Cafe A");
        context.SetStrategy(new StrategyDelivery());
        context.HandleOrder("456 Elm St", "Cafe B");
    }
}

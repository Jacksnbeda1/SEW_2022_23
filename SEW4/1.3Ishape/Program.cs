using _1._3Ishape;

public class Program
{
    public static void Main()
    {
        Rectangle rect1 = new Rectangle(4, 5);
        Rectangle rect2 = new Rectangle(6, 3);

        Circle circle1 = new Circle(2.5);
        Circle circle2 = new Circle(3.0);

        List<IShape> shapes = new List<IShape>(); 

        shapes.Add(rect1); 
        shapes.Add(rect2);
        shapes.Add(circle1); 
        shapes.Add(circle2);

        foreach (IShape shape in shapes)
        {
            Console.WriteLine("Area:{0}, Circumference: {1} ", shape.CalculateArea(), shape.CalculateCircumference());
        }
    }
}

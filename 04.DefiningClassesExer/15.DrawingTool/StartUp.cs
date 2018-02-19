using System;

public class StartUp
{
    public static Shape shape;

    public static void Main()
    {
        {
            string inputShape = Console.ReadLine();

            int n = int.Parse(Console.ReadLine());

            if (inputShape == "Rectangle")
            {
                int len = int.Parse(Console.ReadLine());

                shape = new Rectangle(n, len);
                var tool = new DrawingTool(shape);
                tool.Tool.Draw();
                return;
            }

            shape = new Square(n);
            shape.Draw();
        }
    }
}


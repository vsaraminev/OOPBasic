public class Rectangle : Shape
{
    private double height;
    private double width;

    public Rectangle(double height, double width)
    {
        this.Height = height;
        this.Width = width;
    }

    public double Height
    {
        get { return height; }
        private set { height = value; }
    }

    public double Width
    {
        get { return width; }
        private set { width = value; }
    }

    public override double CalculateArea()
    {
        var area = this.Height * this.Width;

        return area;
    }

    public override double CalculatePerimeter()
    {
        var perimeter = 2 * (this.Height + this.Width);

        return perimeter;
    }

    public override string Draw()
    {
        return base.Draw() + "Rectangle";
    }
}

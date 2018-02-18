public class Rectangle
{
    public Point TopLeft { get; set; }

    public Point BottmRight { get; set; }

    public Rectangle(int topLeftX, int TopLeftY, int bottomRightX, int bottomRightY)
    {
        TopLeft = new Point(topLeftX, TopLeftY);

        BottmRight = new Point(bottomRightX, bottomRightY);
    }

    public bool Contains(Point point)
    {
        return point.X >= TopLeft.X && point.X <= BottmRight.X &&
            point.Y >= TopLeft.Y && point.Y <= BottmRight.Y;
    }
}

using System;

public class Box
{
    private double length;
    private double width;
    private double height;

    public Box(double length, double width, double height)
    {
        this.Length = length;
        this.Width = width;
        this.Height = height;
    }

    public double Length
    {
        get { return length; }
        private set { length = value; }
    }

    public double Width
    {
        get { return width; }
        private set { width = value; }
    }

    public double Height
    {
        get { return height; }
        private set { height = value; }
    }

    public double GetSurfaceArea()
    {
        return 2 * (this.Length * this.Width + this.Length * this.Height + this.Width * this.Height);
    }

    public double GetLeteralSurfaceArea()
    {
        return 2 * this.Height * (this.Length + this.Width);
    }

    public double GetVolume()
    {
        return this.Length * this.Width * this.Height;
    }

    public override string ToString()
    {
        return $"Surface Area - {this.GetSurfaceArea():f2}{Environment.NewLine}Lateral Surface Area - {this.GetLeteralSurfaceArea():f2}{Environment.NewLine}Volume - {this.GetVolume():f2}";
    }
}


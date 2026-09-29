namespace newStart;

public abstract class Shape
{
    public abstract void CalcArea();
    public abstract void CalcPerimetr();

    public abstract double GetArea();
    public abstract double GetPerimetr();
}

public class Circle : Shape
{
    public double Radius {get; set;}

    public override void CalcArea()
    {
        Console.WriteLine(GetArea());
    }

    public override double GetArea()
    {
        return (Math.PI * Math.Pow(Radius, 2));
    }

    public override void CalcPerimetr()
    {
        Console.WriteLine(GetPerimetr());
    }

    public override double GetPerimetr()
    {
        return (2 * Math.PI * Radius);
    }
}

public class Square : Shape
{
    public double Side { get; set; }

    public override void CalcArea()
    {
        Console.WriteLine(GetArea());
    }
    public override double GetArea()
    {
        return Math.Pow(Side, 2);
    }
    public override void CalcPerimetr()
    {
        Console.WriteLine(GetPerimetr());
    }
    public override double GetPerimetr()
    {
        return (Side * 4);
    }
}

public class Triangle : Shape
{
    public double Side1 { get; set; }
    public double Side2 { get; set; }
    public double Side3 { get; set; }

    public override void CalcArea()
    {
        Console.WriteLine(GetArea());
    }
    public override double GetArea()
    {
        double p = (Side1 + Side2 + Side3) / 2;
        return Math.Sqrt(p * (p - Side1) * (p - Side2) * (p - Side3));
    }
    public override void CalcPerimetr()
    {
        Console.WriteLine(GetPerimetr());
    }
    public override double GetPerimetr()
    {
        return Side1 + Side2 + Side3;
    }
}

public class Rectangle : Shape{
    public double Side1 { get; set; }
    public double Side2 { get; set; }

    public override void CalcArea()
    {
        Console.WriteLine(GetArea());
    }
    public override double GetArea()
    {
        return Side1 * Side2;
    }
    public override void CalcPerimetr()
    {
        Console.WriteLine(GetPerimetr());
    }
    public override double GetPerimetr()
    {
        return (Side1 + Side2) * 2;
    }
}

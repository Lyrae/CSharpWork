using System;

namespace hw2_04_05
{
  public abstract class Shape
  {
    public abstract double calSize();

    public abstract bool isLegal();
  }

  class Rectangle : Shape
  {
    double width;
    double height;
    public Rectangle(double a, double b) { width = a; height = b; }
    public override double calSize()
    {
      return width * height;
    }

    public override bool isLegal()
    {

      if (width > 0 && height > 0)
      {
        Console.Write("该长方形合法");
        return true;
      }
      else
      {
        Console.Write("该长方形不合法");
        return false;
      }

    }
  }


  class Square : Shape
  {
    double a;
    public Square(double n) { a = n; }
    public override double calSize()
    {
      return a * a;
    }
    public override bool isLegal()
    {

      if (a > 0)
      {
        Console.Write("该正方形合法");
        return true;
      }
      else
      {
        Console.Write("该正方形不合法");
        return false;
      }
    }
  }

  class Triangle : Shape
  {
    double a, b, c;
    public Triangle(double x, double y, double z) { a = x; b = y; c = z; }
    public override double calSize()
    {
      double p = (a + b + c) / 2;
      return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
    }
    public override bool isLegal()
    {
      if (a > 0 && b > 0 && c > 0 && a + b > c && a + c > b && b + c > a)
      {
        Console.Write("该三角形合法");
        return true;
      }
      else
      {
        Console.WriteLine("该三角形不合法");
        return false;
      }
    }
  }

  class Factory
  {
    public static Shape CreateShape(int type, double a, double b, double c)
    {
      switch (type)
      {
        case 1: return new Rectangle(a, b);

        case 2: return new Square(a);

        case 3: return new Triangle(a, b, c);

        default: return null;
      }
    }
  }

  class program
  {
    static void Main(string[] args)
    {
      double area = 0;
      for (int i = 0; i < 10; i++)
      {
        Random r = new Random();
        int type = r.Next(1, 4);
        Random r2 = new Random();
        double a = Math.Round(r.NextDouble() * 9 + 1);
        double b = Math.Round(r.NextDouble() * 9 + 1);
        double c = Math.Round(r.NextDouble() * 9 + 1);

        Shape shape = Factory.CreateShape(type, a, b, c);
        if (shape.isLegal())
        {
          area += shape.calSize();
          // Console.WriteLine(type + " " + a + " " + b + " " + c + " " + shape.calSize());
          Console.WriteLine(" 面积为：" + shape.calSize());
        }
        else
        {
          continue;
        }
      }
      Console.WriteLine("总面积为（不包括不合法图形的面积）：" + area);
    }
  }
}




using System;


class Program
{

    static void Main(string[] args)
    {

        Circle circle1 = new Circle();
        circle1.radius = 7;
        circle1.getArea();

        pie = 3.142;

        Rectangle rectangle1 = new Rectangle();
        rectangle1.height = 4;
        rectangle1.length = 2;
        rectangle1.getArea();



    }

    public abstract class Shape
    {
        public abstract void getArea();
    }

    public class Circle : Shape
    {
        public double radius;

        public override void getArea()
        {
            double area = pie * (radius * radius);
            Console.WriteLine(area);
        }
    }

    public class Rectangle : Shape
    {
        public double length;
        public double height;

        public override void getArea()
        {
            double area = height * length;
            Console.WriteLine(area);
        }

    }


}
using AbstractFactoryPattern.Shapes;
using System;

namespace AbstractFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ShapeFactory shapefactory = new ShapeFactory();
            Circle circle = (Circle) shapefactory.GetData(1).circle;
            var mm = shape.DataItem;

            Console.WriteLine(mm);

        }
    }
}

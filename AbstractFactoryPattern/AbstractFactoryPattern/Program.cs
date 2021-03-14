using AbstractFactoryPattern.Shapes;

namespace AbstractFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ShapeFactory shapefactory = new ShapeFactory();
            Circle circle = shapefactory.GetData((int)ShapeTypes.Circle).DataItem as Circle;
            circle.GetInfo();

        }
    }
}

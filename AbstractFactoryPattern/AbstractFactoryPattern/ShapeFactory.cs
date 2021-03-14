using AbstractFactoryPattern.Shapes;

namespace AbstractFactoryPattern
{
    class ShapeFactory : AbstractFactory
    {
        public override FactoryDataItem GetData(int type)
        {
            FactoryDataItem factoryDataItem = null;
            switch ((ShapeTypes)type)
            {
                case ShapeTypes.Circle:
                    factoryDataItem = new FactoryDataItem(new Circle());
                    break;
                case ShapeTypes.Rectangle:
                    factoryDataItem = new FactoryDataItem(new Rectangle());
                    break;
                case ShapeTypes.Square:
                    factoryDataItem = new FactoryDataItem(new Square());
                    break;
            }
            return factoryDataItem;
        }
    }
}

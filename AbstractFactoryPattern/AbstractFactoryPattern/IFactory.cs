namespace AbstractFactoryPattern
{
    interface IFactory
    {
        FactoryDataItem GetData(int type);
    }
}

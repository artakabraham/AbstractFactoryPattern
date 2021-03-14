using System;

namespace AbstractFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            FactoryDataItem factoryDataItem = new FactoryDataItem(5555);
            var ccc = factoryDataItem.DataItem;

            Console.WriteLine(ccc);

        }
    }
}

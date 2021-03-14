using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    abstract class AbstractFactory : IFactory
    {
        public abstract FactoryDataItem GetData(int type);
    }
}

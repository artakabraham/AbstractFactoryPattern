using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    interface IFactory
    {
        FactoryDataItem GetData(int type);
    }
}

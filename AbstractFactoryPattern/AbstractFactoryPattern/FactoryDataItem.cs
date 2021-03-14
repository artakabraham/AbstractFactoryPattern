﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    class FactoryDataItem
    {
        private readonly object _dataItem;
        public object DataItem { get { return _dataItem; } }

        public FactoryDataItem(object dataItem)
        {
            _dataItem = dataItem;
        }
    }
}

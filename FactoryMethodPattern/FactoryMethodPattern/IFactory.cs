﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryMethodPattern
{
    public interface IFactory
    {
        Operation CreateOperation();
    }
}

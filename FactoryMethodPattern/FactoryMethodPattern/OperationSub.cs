﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryMethodPattern
{
    public class OperationSub : Operation
    {
        public override double GetResult()
        {
            return NumberA - NumberB;
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones.Factory
{
    public class ConcretoProductA1 : IAbstractProductA
    {
        public string MetodoA()
        {
            return "Desde MetodoA en CocnretoProductA1";
        }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones.Factory
{
    public interface IAbstractProductB
    {
        string MetodoB();
        string OtroMetodoB(IAbstractProductA colaborador);
    }
}
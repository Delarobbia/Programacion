using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones.Factory
{
    public class ConcretoProductA2 : IAbstractProductA
    {
        public string MetodoA()
        {
            return "DEsde MetodoA en ConcretoProductA2";
        }
    }
}
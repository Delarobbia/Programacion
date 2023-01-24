using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones.Factory
{
    public class ConcretoProductB2 : IAbstractProductB
    {
        public string MetodoB()
        {
            return "El MetodoB llamado desde ConcretoProductoB2";
        }
        public string OtroMetodoB(IAbstractProductA colaborador)
        {
            var resultado = colaborador.MetodoA();
            return $"El resultado de la colaboracón de A es: {resultado} en B2";
        }
    }
}
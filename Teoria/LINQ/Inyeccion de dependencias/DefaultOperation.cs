using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inyeccion_de_dependencias
{
    public class DefaultOperation : IScopedOperation,ISingletonOperation,ITransientOperation

    {
        public string OperationID { get; }
    }
}

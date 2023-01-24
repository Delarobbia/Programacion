using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public class OperationLogger
    {
        private readonly ITransientOperation _transientOperation;
        private readonly IScopedOperation _scopedOperation;
        private readonly ISingletonOperation _singletonOperation;

        public OperationLogger(ITransientOperation transientOperation,
        IScopedOperation scopedOperation,
        ISingletonOperation singletonOperation) =>
            (_transientOperation, _scopedOperation, _singletonOperation) = (transientOperation, scopedOperation, singletonOperation);
        public void LogOperations(string scope)
        {
            LogOperation(_transientOperation,scope,"Desde TransienOperation");
            LogOperation(_scopedOperation,scope,"Desde scopedoperation");
            LogOperation(_singletonOperation,scope,"Desde singletonoperation");
        }

        private static void LogOperation<T>(T operation, string scope, string msg)
        where T : IOperation =>
            Console.WriteLine(scope+":"+typeof(T).Name+" "+operation.OperationID+" "+msg);

    }


using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCore.Web
{
    /// <summary>
    /// https://docs.microsoft.com/en-us/aspnet/core/fundamentals/dependency-injection?view=aspnetcore-2.1
    /// </summary>
    public interface IOperation
    {
        Guid OperationId { get; }
    }

    public interface IOperationTransient : IOperation
    {
    }

    public interface IOperationScoped : IOperation
    {
    }

    public interface IOperationSingleton : IOperation
    {
    }

    public interface IOperationSingletonInstance : IOperation
    {
    }

    public class Operation : IOperationTransient,
          IOperationScoped,
    IOperationSingleton,
    IOperationSingletonInstance
    {
        public Operation() : this(Guid.NewGuid())
        {
        }

        public Operation(Guid id)
        {
            OperationId = id;
        }
        public Guid OperationId { get; private set; }
    }

    public interface IOperationService
    {
        void writeMessag();
    }
    public class OperationService : IOperationService
    {
        public IOperationTransient TransientOperation { get; }
        public IOperationScoped ScopedOperation { get; }
        public IOperationSingleton SingletonOperation { get; }
        public IOperationSingletonInstance SingletonInstanceOperation { get; }
        public OperationService(
            IOperationTransient transientOperation,
            IOperationScoped scopedOperation,
            IOperationSingleton singletonOperation,
            IOperationSingletonInstance instanceOperation)
        {
            TransientOperation = transientOperation;
            ScopedOperation = scopedOperation;
            SingletonOperation = singletonOperation;
            SingletonInstanceOperation = instanceOperation;
        }

        public void writeMessag()
        {
            Debug.WriteLine("Operation Service WriteMessage Method Called TransientOperation:" + TransientOperation.OperationId);
            Debug.WriteLine("Operation Service WriteMessage Method Called ScopedOperation:" + ScopedOperation.OperationId);
            Debug.WriteLine("Operation Service WriteMessage Method Called SingletonOperation:" + SingletonOperation.OperationId);
            Debug.WriteLine("Operation Service WriteMessage Method Called SingletonInstanceOperation:" + SingletonInstanceOperation.OperationId);
        }
    }
}

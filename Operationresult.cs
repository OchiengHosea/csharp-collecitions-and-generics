using System;

namespace ACM{
    public class OperationResult<T>
    {
        public T Result { get; set; }
        public string Message { get; set; }
        public OperationResult(T result, string message)
        {
            this.Result = result;
            this.Message = message;
        }
    }
}


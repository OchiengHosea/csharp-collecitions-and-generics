using System;

namespace ACM{
    public class OperationResult<TResult, TMessage>
    {
        public TResult Result { get; set; }
        public TMessage Message { get; set; }
        public OperationResult(TResult result, TMessage message)
        {
            this.Result = result;
            this.Message = message;
        }
    }

    public class Operation
    {
        public void performOperation()
        {
            var operationResult = new OperationResult<bool, string>(true, "No new message");
        }

        public T RetreaveValue<T>(string sql, T defaultValue)
        {
            T value = defaultValue;
            return value;
        }

        // generic constraints
        public T RetreaveValueContrained<T>(string sql, T defaultValue) where T:class, new()
        {
            T value = new T();
            return value;
        }
    }
}


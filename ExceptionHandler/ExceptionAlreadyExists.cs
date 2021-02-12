using System;

namespace ModuleException.ExceptionHandler
{
    [Serializable]
    public class ExceptionAlreadyExists : System.Exception
    {

        public StatusCode code { get; }

        public ExceptionAlreadyExists() { }

        public ExceptionAlreadyExists(string message) 
            : base(message)
        {
            code = StatusCode.AlreadyExist;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ModuleException.ExceptionHandler
{
    [Serializable]
    public class ExceptionNotFound : System.Exception
    {

        public StatusCode code { get; }

        public ExceptionNotFound() { }

        public ExceptionNotFound(string message) 
            : base(message)
        {
            code = StatusCode.NotFoundEntity;
        }

    }
}

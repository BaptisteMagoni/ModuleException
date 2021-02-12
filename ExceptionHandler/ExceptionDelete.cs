using System;
using System.Collections.Generic;
using System.Text;

namespace ModuleException.ExceptionHandler
{
    public class ExceptionDelete : System.Exception
    {

        public StatusCode code { get; }

        public ExceptionDelete() { }

        public ExceptionDelete(string message) 
            : base(message)
        {
            code = StatusCode.DeleteEntity;
        }

    }
}

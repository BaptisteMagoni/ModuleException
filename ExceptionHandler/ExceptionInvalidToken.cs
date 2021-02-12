using System;
using System.Collections.Generic;
using System.Text;

namespace ModuleException.ExceptionHandler
{
    public class ExceptionInvalidToken : System.Exception
    {
        public StatusCode code { get; }

        public ExceptionInvalidToken() { }

        public ExceptionInvalidToken(string message) : base(message)
        {
            code = StatusCode.AuthentificationMissing;
        }
    }
}

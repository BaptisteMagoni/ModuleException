using System;
using System.Collections.Generic;
using System.Text;

namespace ModuleException.Exception
{
    [Serializable]
    public class ExceptionAuthentification : System.Exception
    {

        public StatusCode code { get; }

        public ExceptionAuthentification() { }

        public ExceptionAuthentification(string message) : base(message)
        {
            code = StatusCode.AuthentificationMissing;
        }

    }
}

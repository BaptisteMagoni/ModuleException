using System;
using System.Collections.Generic;
using System.Text;

namespace ModuleException
{
    public enum StatusCode
    {
        BadRequest = 400,
        NotFound = 404,
        AuthentificationMissing = 401,
        NotFoundEntity = 406,
        AlreadyExist = 407,
        DeleteEntity = 408,
        InternalServerError = 500
    }
}

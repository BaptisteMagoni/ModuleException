using Microsoft.AspNetCore.Http;
using ModuleException.Exception;
using ModuleException.ExceptionHandler;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace ModuleException.Handler
{
    public class ErrorHandlingMiddleware
    {
        private readonly RequestDelegate next;

        public ErrorHandlingMiddleware(RequestDelegate next) 
        { 
            this.next = next; 
        }

        public async Task Invoke(HttpContext context) 
        { 
            try 
            { 
                await next(context); 
            }
            catch (System.Exception ex) 
            { 
                await HandleExceptionAsync(context, ex); 
            } 
        }

        private static Task HandleExceptionAsync(HttpContext context, System.Exception exception)
        {
            var code = StatusCode.InternalServerError;

            switch(exception)
            {
                case ExceptionAuthentification:
                    code = StatusCode.AuthentificationMissing;
                    break;
                case ExceptionNotFound:
                    code = StatusCode.NotFoundEntity;
                    break;
                case ExceptionAlreadyExists:
                    code = StatusCode.AlreadyExist;
                    break;
                case ExceptionDelete:
                    code = StatusCode.DeleteEntity;
                    break;
                case ExceptionInvalidToken:
                    code = StatusCode.InvalideToken;
                    break;
                case System.Exception:
                    code = StatusCode.BadRequest;
                    break;
                default:
                    code = StatusCode.NotFound;
                    break;
            }
            var result = JsonConvert.SerializeObject(new { message = exception.Message, statusCode = code }); 
            context.Response.ContentType = "application/json"; 
            context.Response.StatusCode = (int)code; 
            return context.Response.WriteAsync(result);

        }

    }
}

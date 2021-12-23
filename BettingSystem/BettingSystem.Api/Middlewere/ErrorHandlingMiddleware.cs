

using BettingSystem.Services.CustomExceptions;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Net;
using System.Threading.Tasks;

namespace BettingSystem.Api.Middlewere
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
            catch (Exception ex)
            {
                await HandleException(context, ex);
            }
        }

        private static Task HandleException(HttpContext context, Exception ex)
        {
            HttpStatusCode code = HttpStatusCode.InternalServerError; 

           
            if (ex is ValidationException)
            {
                code = HttpStatusCode.BadRequest;
            }
            else if (ex is DuplicateResourceException)
            {
                code = HttpStatusCode.Conflict;
            }

            string result = JsonConvert.SerializeObject(new { error = ex.Message });


            context.Response.ContentType = "application/json";
            context.Response.StatusCode = (int)code;

            return context.Response.WriteAsync(result);
        }
    }
}

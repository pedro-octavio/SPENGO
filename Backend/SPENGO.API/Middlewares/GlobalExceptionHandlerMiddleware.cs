using System;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using SPENGO.Domain.Models.ResponseModel.Shared;

namespace SPENGO.API.Middlewares
{
    public class GlobalExceptionHandlerMiddleware
    {
        private readonly RequestDelegate next;

        public GlobalExceptionHandlerMiddleware(RequestDelegate next)
        {
            this.next = next;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            try
            {

                await next(httpContext);
            }
            catch (Exception ex)
            {

                await HandleExceptionAsync(httpContext, ex);
            }
        }

        private static Task HandleExceptionAsync(HttpContext httpContext, Exception exception)
        {
            httpContext.Response.ContentType = "application/json";
            httpContext.Response.StatusCode = (int)HttpStatusCode.InternalServerError;

            var responseModel = new ResponseModel<object>
            {
                IsValid = false,
                ErrorMessage = exception.Message,
                Data = null
            };

            return httpContext.Response.WriteAsync(JsonConvert.SerializeObject(responseModel));
        }
    }
}

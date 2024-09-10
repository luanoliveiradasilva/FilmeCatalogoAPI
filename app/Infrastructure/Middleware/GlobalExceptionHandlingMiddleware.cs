using System.Net;
using System.Text.Json;

namespace app.Infrastructure.Middleware
{
    public class GlobalExceptionHandlingMiddleware(
        RequestDelegate next,
        ILogger<GlobalExceptionHandlingMiddleware> logger
        )
    {
        private readonly RequestDelegate _next = next;
        private readonly ILogger<GlobalExceptionHandlingMiddleware> _logger = logger;

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _next.Invoke(context);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                await HandlerExceptionAsync(context, ex);
            }
        }

        private static async Task HandlerExceptionAsync(HttpContext context, Exception exception)
        {
            var ctxResponse = context.Response;

            ResponseModel responseModel = new();

            switch (exception)
            {
                case ApplicationException ex:
                    ctxResponse.StatusCode = (int)HttpStatusCode.BadRequest;
                    responseModel.ResponseCode = (int)HttpStatusCode.BadRequest;
                    responseModel.ResponseMessage = "Application Exception Occured.";
                    break;
                case FileNotFoundException ex:
                    ctxResponse.StatusCode = (int)HttpStatusCode.NotFound;
                    responseModel.ResponseCode = (int)HttpStatusCode.NotFound;
                    responseModel.ResponseMessage = "The request resource is not found";
                    break;
                default:
                    ctxResponse.StatusCode = (int)HttpStatusCode.InternalServerError;
                    responseModel.ResponseCode = (int)HttpStatusCode.InternalServerError;
                    responseModel.ResponseMessage = "Internal server Error";
                    break;
            }

            context.Response.ContentType = "application/json";

            var exResult = JsonSerializer.Serialize(responseModel);

            await context.Response.WriteAsync(exResult);
        }
    }
}
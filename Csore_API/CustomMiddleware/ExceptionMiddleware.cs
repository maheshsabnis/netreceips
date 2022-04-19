namespace Csore_API.CustomMiddleware
{
    /// <summary>
    /// This class will be JSON serialized to client when
    /// Error Occures
    /// </summary>
    public class ErrorInfo
    {
        public int ErrorCode { get; set; }
        public string ErrorMessage { get; set; }
    }

    /// <summary>
    /// The Custom Middlware Logic Class
    /// </summary>
    public class ExceptionMiddleware
    {
        public readonly RequestDelegate next;
        public ExceptionMiddleware(RequestDelegate request)
        {
            next = request;
        }
        /// <summary>
        /// The Method the contains the Middlweare logic
        /// Current Middleware will use try..catch block since it is used for exception handling 
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                // If no Error then move to next midleware
                await next(context);
            }
            catch (Exception ex)
            {
                // Else Handle an exception and return HTTP Response
                // 1. Set the Statuc code
                context.Response.StatusCode = 500;
                // 2. Read the exception MEssage
                string message = ex.Message;
                // 3. Set this information to ErrorInfo class
                var errorInfo = new ErrorInfo()
                { 
                    ErrorCode= context.Response.StatusCode,
                    ErrorMessage= message
                };
                // 4. Write the ErrorInfo object into the Response
                // with JSON Serialization
               await  context.Response.WriteAsJsonAsync<ErrorInfo>(errorInfo);
            }
        }
    }

    /// <summary>
    /// AN Extension CLass that provides an extension method
    /// For Registering Custom Middleare into the Http Pipeline  
    /// </summary>
    public static class ErrorInfoExtensions
    {
        public static void UseRequesException(this IApplicationBuilder builder)
        { 
            // Registering the CLass as Custom Middleware
            // so that it can be used in Pipeline
            builder.UseMiddleware<ExceptionMiddleware>();
        }
    }
}

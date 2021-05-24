using System.Net;

namespace korsback.dotnet.extensions
{
    public class Result : IResult
    {
        public Result()
        {
            
        }
        
        public Result(HttpStatusCode statusCode, string message = null)
        {
            StatusCode = statusCode;

            Success = (statusCode == HttpStatusCode.OK || statusCode == HttpStatusCode.Created ) ? true : false;

            Message = message;
        }

        public void Set(HttpStatusCode statusCode, string message = null)
        {
            StatusCode = statusCode;

            Success = (statusCode == HttpStatusCode.OK || statusCode == HttpStatusCode.Created ) ? true : false;

            Message = message;
        }

        public HttpStatusCode StatusCode { get; private set; }
        public bool Success { get; private set; }
        public string Message { get; private set; }
    }
}
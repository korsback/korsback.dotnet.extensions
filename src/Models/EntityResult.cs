using System.Net;

namespace korsback.dotnet.extensions.models
{
    public class EntityResult<T> : IResult, IEntityResult<T> where T : class, new()
    {
        public EntityResult()
        {
            
        }
        
        public EntityResult(T result, HttpStatusCode statusCode, string message = null)
        {
            Result = result;

            Success = (statusCode == HttpStatusCode.OK || statusCode == HttpStatusCode.Created) ? true : false;
            
            StatusCode = statusCode;

            Message = message;
        }

        public void Set(T result, HttpStatusCode statusCode, string message = null)
        {
            Result = result;

            Success = (statusCode == HttpStatusCode.OK || statusCode == HttpStatusCode.Created) ? true : false;
            
            StatusCode = statusCode;

            Message = message;
        }

        public T Result { get; private set; }
        public bool Success { get; private set; }
        public HttpStatusCode StatusCode { get; private set; }
        public string Message { get; private set; }
    }
}
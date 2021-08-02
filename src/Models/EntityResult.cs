using System.Net;
using Newtonsoft.Json;

namespace korsback.dotnet.extensions.models
{
    public class EntityResult<T> : IResult, IEntityResult<T>
    {
        public EntityResult()
        {

        }

        public EntityResult(T result, HttpStatusCode statusCode, string message = null)
        {
            Result = result;

            Success = ((int)statusCode >= 200 && (int)statusCode <= 299) ? true : false;

            StatusCode = statusCode;

            Message = message;
        }

        public void Set(T result, HttpStatusCode statusCode, string message = null)
        {
            Result = result;

            Success = ((int)statusCode >= 200 && (int)statusCode <= 299) ? true : false;

            StatusCode = statusCode;

            Message = message;
        }

        [JsonProperty]
        public T Result { get; private set; }

        [JsonProperty]
        public bool Success { get; private set; }

        [JsonProperty]
        public HttpStatusCode StatusCode { get; private set; }

        [JsonProperty]
        public string Message { get; private set; }
    }
}
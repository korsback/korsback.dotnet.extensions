using System.Net;

namespace korsback.dotnet.extensions.models
{
    public interface IResult
    {
        public HttpStatusCode StatusCode { get; }
        public bool Success { get; }
        public string Message { get; }
    }
} 

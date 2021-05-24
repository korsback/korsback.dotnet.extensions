using System.Net;

namespace korsback.dotnet.extensions.models
{
    public interface IEntityResult<T>
    {
        T Result { get; }
    }
}
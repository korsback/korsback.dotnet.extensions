using System.Net;

namespace korsback.dotnet.extensions
{
    public interface IEntityResult<T>
    {
        T Result { get; }
    }
}
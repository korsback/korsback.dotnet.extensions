namespace korsback.dotnet.extensions
{
    public interface IDate<TDateTime> : ICreatedDate<TDateTime>, IUpdatedDate<TDateTime>
    {
    }
}
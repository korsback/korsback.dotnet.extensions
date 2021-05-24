namespace korsback.dotnet.extensions.interfaces
{
    public interface IUpdatedDate<TDateTime>
    {
        TDateTime UpdatedDateTimeUTC { get; set; }
    }
}
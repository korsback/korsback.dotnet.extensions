namespace korsback.dotnet.extensions
{
    public interface IUpdatedDate<TDateTime>
    {
        TDateTime UpdatedDateTimeUTC { get; set; }
    }
}
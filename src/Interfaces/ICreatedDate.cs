namespace korsback.dotnet.extensions
{
    public interface ICreatedDate<TDateTime>
    {
        TDateTime CreatedDateTimeUTC { get; set; }
    }
}
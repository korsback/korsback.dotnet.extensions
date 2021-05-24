using System;

namespace korsback.dotnet.extensions
{
    public abstract class Entity : IEntity, IDate<DateTime>
    {
        public Guid Id { get; set; }
        public DateTime CreatedDateTimeUTC { get; set; }
        public DateTime UpdatedDateTimeUTC { get; set; }
    }
}
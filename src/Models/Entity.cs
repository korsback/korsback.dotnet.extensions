using System;
using korsback.dotnet.extensions.interfaces;

namespace korsback.dotnet.extensions.models
{
    public abstract class Entity : IEntity, IDate<DateTime>
    {
        public Guid Id { get; set; }
        public DateTime CreatedDateTimeUTC { get; set; }
        public DateTime UpdatedDateTimeUTC { get; set; }
    }
}
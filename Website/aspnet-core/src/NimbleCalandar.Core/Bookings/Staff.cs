using Abp.Domain.Entities;

namespace NimbleCalandar.Bookings
{
    public class Staff : Entity, IMustHaveTenant
    {
        public int TenantId { get; set; }

        public string Name { get; set; }
    }
}

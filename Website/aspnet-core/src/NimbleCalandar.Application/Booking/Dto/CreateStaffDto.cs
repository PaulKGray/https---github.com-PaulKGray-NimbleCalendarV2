using Abp.AutoMapper;
using NimbleCalandar.Bookings;
using System.ComponentModel.DataAnnotations;

namespace NimbleCalandar.Booking.Dto
{
    [AutoMapTo(typeof(Staff))]
    public class CreateStaffDto
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public int TenantId { get; set; }
    }
}

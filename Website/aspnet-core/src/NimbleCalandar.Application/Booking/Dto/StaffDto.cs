using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using NimbleCalandar.Bookings;
using System.ComponentModel.DataAnnotations;

namespace NimbleCalandar.Booking.Dto
{
    [AutoMapFrom(typeof(Staff))]
    public class StaffDto : EntityDto<int>
    {
        [Required] 
        public string Name { get; set; }

        [Required]
        public int TenantId { get; set; }
    }
}

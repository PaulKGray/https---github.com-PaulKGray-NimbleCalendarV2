using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using NimbleCalandar.Bookings;
using System.ComponentModel.DataAnnotations;

namespace NimbleCalandar.Booking.Dto
{
    [AutoMapFrom(typeof(Staff))]
    public class UpdateStaffDto : EntityDto<int>
    {
        [Required] 
        public string Name { get; set; } 
    }
}

using AutoMapper;
using NimbleCalandar.Bookings;

namespace NimbleCalandar.Booking.Dto
{
    public class StaffMapProfile : Profile
    {
        public StaffMapProfile()
        {
            CreateMap<UpdateStaffDto, Staff>()
                .ForMember(x => x.TenantId, opt => opt.Ignore());
        }
    }
}

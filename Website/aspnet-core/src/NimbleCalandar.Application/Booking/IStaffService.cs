using Abp.Application.Services;
using NimbleCalandar.Booking.Dto;

namespace NimbleCalandar.Booking
{
    public interface IStaffService : IAsyncCrudAppService<StaffDto, int, PagedStaffResultRequestDto, CreateStaffDto, StaffDto>
    {
    }
}

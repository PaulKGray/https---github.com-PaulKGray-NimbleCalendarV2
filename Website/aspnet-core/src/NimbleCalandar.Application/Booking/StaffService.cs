using Abp.Application.Services;
using Abp.Authorization;
using Abp.Domain.Repositories;
using NimbleCalandar.Authorization;
using NimbleCalandar.Booking.Dto;
using NimbleCalandar.Bookings;

namespace NimbleCalandar.Booking
{
    
    public class StaffService : AsyncCrudAppService<Staff, StaffDto, int, PagedStaffResultRequestDto, CreateStaffDto, UpdateStaffDto>, IStaffService
    {
        private readonly IRepository<Staff, int> _staffRepository;

        public StaffService(IRepository<Staff, int> repository)
            : base(repository)
        {
            _staffRepository = repository;
        }
    }
}

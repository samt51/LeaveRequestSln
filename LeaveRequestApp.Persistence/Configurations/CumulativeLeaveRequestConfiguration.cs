using LeaveRequestApp.Domain.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveRequestApp.Persistence.Configurations
{
    public class CumulativeLeaveRequestConfiguration : IEntityTypeConfiguration<CumulativeLeaveRequest>
    {
        public void Configure(EntityTypeBuilder<CumulativeLeaveRequest> builder)
        {
            CumulativeLeaveRequest cumulativeLeaveRequest = new()
            {
                Id = Guid.Parse("85a3bd68-2f6b-49f8-9f03-2cb0eaa54d13"),
                UserId = Guid.Parse("e21cd525-031c-4364-b173-4150a4e18c37"),
                LeaveType = 10,
                Year = 2023,
                TotalHours = 80,
            };

            CumulativeLeaveRequest cumulativeLeaveRequest1 = new()
            {
                Id = Guid.Parse("dc808a4f-8ae8-4d7a-b228-e1cb957f815d"),
                UserId = Guid.Parse("59fb152a-2d59-435d-8fc1-cbc35c0f1d82"),
                LeaveType = 20,
                Year = 2023,
                TotalHours = 60,
            };

            CumulativeLeaveRequest cumulativeLeaveRequest2 = new()
            {
                Id = Guid.Parse("f47b75ae-6318-413c-ab36-ad82d380c0dd"),
                UserId = Guid.Parse("23591451-1cf1-46a5-907a-ee3e52abe394"),
                LeaveType = 10,
                Year = 2023,
                TotalHours = 32,
            };

            CumulativeLeaveRequest cumulativeLeaveRequest3 = new()
            {
                Id = Guid.Parse("7fa9f56c-a54e-49ae-a9bf-2266a449992b"),
                UserId = Guid.Parse("23591451-1cf1-46a5-907a-ee3e52abe394"),
                LeaveType = 20,
                Year = 2023,
                TotalHours = 16,
            };

            builder.HasData(cumulativeLeaveRequest, cumulativeLeaveRequest1, cumulativeLeaveRequest2, cumulativeLeaveRequest3);
        }
    }
}

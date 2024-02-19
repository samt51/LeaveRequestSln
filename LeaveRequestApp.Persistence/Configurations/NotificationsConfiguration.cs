using LeaveRequestApp.Domain.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveRequestApp.Persistence.Configurations
{
    public class NotificationsConfiguration : IEntityTypeConfiguration<Notifications>
    {
        public void Configure(EntityTypeBuilder<Notifications> builder)
        {
            Notifications notifications = new()
            {
                UserId = Guid.Parse("23591451-1cf1-46a5-907a-ee3e52abe394"),
                CumulativeLeaveRequestId = Guid.Parse("7fa9f56c-a54e-49ae-a9bf-2266a449992b"),
                CreatedDate = new DateTime(2023, 11, 30),
                Message = "Kalan ExcusedAbsence 8 saat",
                Id = Guid.Parse("0422b3bb-7618-43d2-b694-3229396d724b")
            };

            Notifications notifications1 = new()
            {
                UserId = Guid.Parse("e21cd525-031c-4364-b173-4150a4e18c37"),
                CumulativeLeaveRequestId = Guid.Parse("85a3bd68-2f6b-49f8-9f03-2cb0eaa54d13"),
                CreatedDate = new DateTime(2023, 12, 11),
                Message = "Aşılan AnnualLeave 1 gün",
                Id = Guid.Parse("b89210d0-541f-4718-854a-e0d2d64c9f75")
            };


            Notifications notifications2 = new()
            {
                UserId = Guid.Parse("59fb152a-2d59-435d-8fc1-cbc35c0f1d82"),
                CumulativeLeaveRequestId = null,
                CreatedDate = new DateTime(2023, 12, 19),
                Message = "Kalan AnnualLeave 2 gün ",
                Id = Guid.Parse("405287b8-2321-4d22-b96f-15f36afb9b3e")
            };

            builder.HasData(notifications, notifications1, notifications2);
        }
    }
}

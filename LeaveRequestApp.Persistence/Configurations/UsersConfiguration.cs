using LeaveRequestApp.Domain.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveRequestApp.Persistence.Configurations
{
    public class UsersConfiguration : IEntityTypeConfiguration<Users>
    {
        public void Configure(EntityTypeBuilder<Users> builder)
        {

            Users users = new()
            {
                Id = Guid.Parse("e21cd525-031c-4364-b173-4150a4e18c37"),
                FirstName = "Münir",
                LastName = "Özkul",
                Email = "munir.ozkul@negzel.net",
                UserType = 30,
                ManagerId = Guid.Empty,
            };

            Users users1 = new()
            {
                Id = Guid.Parse("59fb152a-2d59-435d-8fc1-cbc35c0f1d82"),
                FirstName = "Şener",
                LastName = "Şen",
                Email = "sener.sen@negzel.net ",
                UserType = 10,
                ManagerId = Guid.Parse("e21cd525-031c-4364-b173-4150a4e18c37")
            };

            Users users2 = new()
            {

                Id = Guid.Parse("23591451-1cf1-46a5-907a-ee3e52abe394"),
                FirstName = "Kemal",
                LastName = "Sunal",
                Email = "kemal.sunal@negzel.net",
                UserType = 20,
                ManagerId = Guid.Parse("59fb152a-2d59-435d-8fc1-cbc35c0f1d82")
            };

            builder.HasData(users, users1, users2);
        }
    }
}

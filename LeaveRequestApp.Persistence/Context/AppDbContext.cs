using LeaveRequestApp.Domain.Entites;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace LeaveRequestApp.Persistence.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() { }

        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Users> Users { get; set; }
        public DbSet<CumulativeLeaveRequest> CumulativeLeaveRequests { get; set; }
        public DbSet<LeaveRequest> LeaveRequests { get; set; }
        public DbSet<Notifications> Notifications { get; set; }
        public DbSet<Permissions> Permissions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());


            modelBuilder.Entity<LeaveRequest>()
               .HasOne(l => l.CreatedByUser)
               .WithMany()
               .HasForeignKey(l => l.CreatedByUserId)
                   .IsRequired(false); ;

            modelBuilder.Entity<LeaveRequest>()
             .HasOne(l => l.LastModifiedByUser)
             .WithMany()
             .HasForeignKey(l => l.LastModifiedById)
              .IsRequired(false); ;

            modelBuilder.Entity<LeaveRequest>()
    .HasOne(lr => lr.Users)
    .WithMany(u => u.AssignedUsers)
    .HasForeignKey(lr => lr.Id)
    .IsRequired(false);

            modelBuilder.Entity<CumulativeLeaveRequest>()
               .HasOne(l => l.Users)
               .WithMany(l => l.CumulativeLeaveRequests)
               .HasForeignKey(l => l.UserId);

            modelBuilder.Entity<Notifications>()
               .HasOne(l => l.Users)
               .WithMany(l => l.Notifications)
               .HasForeignKey(l => l.UserId);
        }
    }
}

using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace TodoServerApp.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public virtual DbSet<ForumItem> ForumItems { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<ForumItem>().HasData([
            new() { Id = 1, Name="���� 1", Question="���������� ������", Answer="������� �����"},
            new() { Id = 2, Name="���� 2", Question="������������ ������", Answer="�������� �����"},
            new() { Id = 3, Name="���� 3", Question="������� ������", Answer="������ �����"},
            new() { Id = 4, Name="���� 4", Question="������", Answer="�����"},
            ]);
        }
    }
}

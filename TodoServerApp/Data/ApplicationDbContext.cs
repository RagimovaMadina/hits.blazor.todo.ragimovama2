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
            new() { Id = 1, Name="тема 1", Question="интересный вопрос", Answer="сложный ответ"},
            new() { Id = 2, Name="тема 2", Question="неинтересный вопрос", Answer="понятный ответ"},
            new() { Id = 3, Name="тема 3", Question="простой вопрос", Answer="просто ответ"},
            new() { Id = 4, Name="тема 4", Question="вопрос", Answer="ответ"},
            ]);
        }
    }
}

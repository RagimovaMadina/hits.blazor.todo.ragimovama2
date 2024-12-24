using Microsoft.EntityFrameworkCore;
using TodoServerApp.Data.Interfaces;

namespace TodoServerApp.Data.Services
{
    public class MSSQLDataService(ApplicationDbContext context) : IDataService
    {
        public async Task<IEnumerable<ForumItem>> GetForumItemsAsync()
        {
            return await context.ForumItems.ToArrayAsync();
        }
    }
}

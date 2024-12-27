using TodoServerApp.Data;

namespace TodoServerApp.Data.Interfaces
{
    public interface IDataService
    {
        Task<IEnumerable<ForumItem>> GetForumItemsAsync();
        Task SaveAsync(ForumItem item);
        Task<ForumItem> GetForumAsync(int id);
    }
}

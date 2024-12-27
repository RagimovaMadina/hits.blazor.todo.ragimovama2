using System.Threading.Tasks;
using TodoServerApp.Components.Pages;
using TodoServerApp.Data.Interfaces;

namespace TodoServerApp.Data.Services
{
    public class MemoryDataService : IDataService
    {
        private static IEnumerable<ForumItem> Forums { get; } = [
            new() { Id = 1, Name="тема 1", Question="интересный вопрос", Answer="сложный ответ"},
            new() { Id = 2, Name="тема 2", Question="неинтересный вопрос", Answer="понятный ответ"},
            new() { Id = 3, Name="тема 3", Question="простой вопрос", Answer="просто ответ"},
        ];

        public async Task<IEnumerable<ForumItem>> GetForumItemsAsync()
        {
            await Task.Delay(1000);
            return await Task.FromResult(Forums);
        }

        public Task<ForumItem> GetForumAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task SaveAsync(ForumItem item)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}

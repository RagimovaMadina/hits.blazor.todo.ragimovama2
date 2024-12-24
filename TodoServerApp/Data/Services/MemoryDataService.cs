using System.Threading.Tasks;
using TodoServerApp.Components.Pages;
using TodoServerApp.Data.Interfaces;

namespace TodoServerApp.Data.Services
{
    public class MemoryDataService : IDataService
    {
        private static IEnumerable<ForumItem> Forums { get; } = [
            new() { Id = 1, Name="тема", Question="вопрос", Answer="ответ"},
            new() { Id = 2, Name="тема", Question="вопрос", Answer="ответ"},
            new() { Id = 3, Name="тема", Question="вопрос", Answer="ответ"},
        ];

        public async Task<IEnumerable<ForumItem>> GetForumItemsAsync()
        {
            await Task.Delay(1000);
            return await Task.FromResult(Forums);
        }
    }
}

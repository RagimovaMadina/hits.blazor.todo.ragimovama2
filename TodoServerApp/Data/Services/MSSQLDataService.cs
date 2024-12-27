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

        public async Task SaveAsync(ForumItem forumItem)
        {
            if (forumItem.Id == 0) //Проверяет, является ли объект новым (Id == 0
            {
                await context.ForumItems.AddAsync(forumItem); //Если объект новый, он добавляется в таблицу EmployeeItems
            }
            else
            {
                context.ForumItems.Update(forumItem); // Если объект существует, он обновляется
            }
            await context.SaveChangesAsync(); //Сохраняет изменения в базе данных
        }

        public async Task<ForumItem> GetForumAsync(int id) // Получение сотрудника по ID
        {
            return await context.ForumItems.FirstAsync(x => x.Id == id);
            //Использует FirstAsync, чтобы найти первую запись в таблице, где Id совпадает с переданным значением
        }

        public async Task DeleteAsync(int id)
        {
            var forumItem = await context.ForumItems.FirstAsync(x => x.Id == id);
            // Ищет объект в таблице EmployeeItems по ID
            context.ForumItems.Remove(forumItem); // Удаляет найденный объект из базы данных
            await context.SaveChangesAsync(); // Сохраняет изменения в базе данных
        }
    }
}

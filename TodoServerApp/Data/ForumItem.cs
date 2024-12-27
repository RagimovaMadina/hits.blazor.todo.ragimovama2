using System.ComponentModel.DataAnnotations;

namespace TodoServerApp.Data
{
    public class ForumItem
    {
        public int Id { get; set; }
        public string? Name { get; set; } //тема вопроса
        public string? Question { get; set; } //вопрос
        public string? Answer { get; set; } //ответ
        public int Quantity { get; set; } = 0; // Количество товаров
    }
}

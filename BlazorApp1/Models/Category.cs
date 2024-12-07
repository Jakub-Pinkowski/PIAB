using SQLite;

namespace BlazorApp1.Models
{
    public class Category : IIdentifiable
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;
    }
}

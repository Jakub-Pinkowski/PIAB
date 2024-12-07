using SQLite;

namespace BlazorApp1.Models
{
    public class Supplier : IIdentifiable
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string ContactEmail { get; set; } = string.Empty;
    }
}
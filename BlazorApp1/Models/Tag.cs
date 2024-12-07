using SQLite;

namespace BlazorApp1.Models
{
    public class Tag : IIdentifiable
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [NotNull]
        public string Name { get; set; } = string.Empty;
    }
}

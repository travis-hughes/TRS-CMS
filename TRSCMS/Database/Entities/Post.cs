namespace TRSCMS.Database.Entities;

public class Post
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Slug { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }

    public List<Field> Fields { get; set; } = new();
}
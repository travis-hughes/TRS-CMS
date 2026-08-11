namespace TRSCMS.Database.Entities;


public class Post
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Slug { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }

    public int FieldGroupId { get; set; }
    public FieldGroup FieldGroup { get; set; }

    public int PostTypeId { get; set; }
    public PostType Post { get; set; }
}
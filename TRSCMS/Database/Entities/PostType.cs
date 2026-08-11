using System.Runtime.CompilerServices;

namespace TRSCMS.Database.Entities;

public class PostType
{
    public int Id { get; set; }
    public string Name { get; set; }

    public List<Post> Posts { get; set; } = new();


    public int WebsiteId { get; set; }
    public Website Website { get; set; }
}
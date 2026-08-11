namespace TRSCMS.Database.Entities;

public class NavigationMenuItem
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Url { get; set; }

    public List<Field> Fields { get; set; } = new();

}
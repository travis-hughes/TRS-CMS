namespace TRSCMS.Database.Entities;

public class NavigationMenu
{
    public int Id { get; set; }
    public string Title { get; set; }

    public List<NavigationMenuItem> Items { get; set; } = new();

    public int WebsiteId { get; set; }
    public Website Website { get; set; }
}
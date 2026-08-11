namespace TRSCMS.Database.Entities;

public class NavigationMenuItem
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Url { get; set; }

    public int FieldGroupId { get; set; }
    public FieldGroup FieldGroup { get; set; }
}
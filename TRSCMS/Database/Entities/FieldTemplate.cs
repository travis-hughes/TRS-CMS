namespace TRSCMS.Database.Entities;

/// <summary>
/// Groups Fields Together.
/// </summary>
public class FieldTemplate
{
    public int Id { get; set; }
    public string Name { get; set; }


    public List<FieldTemplateItem> Items { get; set; }


    /// <summary>
    /// We use this to HasMany the relationship between entities.
    /// </summary>
    public int EntityReferanceId { get; set; }
}
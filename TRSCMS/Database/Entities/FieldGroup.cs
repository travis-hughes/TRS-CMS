namespace TRSCMS.Database.Entities;

/// <summary>
/// A groups Fields Together.
/// </summary>
public class FieldGroup
{
    public int Id { get; set; }
    public string Name { get; set; }


    public List<Field> Fields { get; set; }


    /// <summary>
    /// We use this to HasMany the relationship between entities.
    /// </summary>
    public int EntityReferanceId { get; set; }
}
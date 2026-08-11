namespace TRSCMS.Database.Entities;

/// <summary>
/// Stores data about a field, unlike other entities this one does not have a single table.
/// </summary>
public class Field
{
    public int Id { get; set; }
    public string Label { get; set; }
    public object Value { get; set; }

    public int FieldId { get; set; }
    public FieldType Type { get; set; }

    public int FieldGroupId { get; set; }
    public FieldGroup FieldGroup { get; set; }


    /// <summary>
    /// We use this to HasMany the relationship between entities.
    /// </summary>
    public int EntityReferanceId { get; set; }
}
namespace TRSCMS.Database.Entities;

/// <summary>
/// Stores data about a field, unlike other entities this one does not have a single table.
/// </summary>
public class FieldTemplateItem
{
    public int Id { get; set; }
    public string Label { get; set; }
    public string Key { get; set; }
    public string HelperText { get; set; }
    public bool IsRequired { get; set; }
    public string? Value { get; set; }

    public FieldTypeEnum FieldType { get; set; }

    public int FieldTemplateId { get; set; }
    public FieldTemplate FieldTemplate { get; set; }
}
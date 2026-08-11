namespace TRSCMS.Database.Entities;

/// <summary>
/// Stores data about a field, unlike other entities this one does not have a single table.
/// </summary>
public class Field
{
    public int Id { get; set; }
    public string Label { get; set; }
    public string Key { get; set; }
    public string HelperText { get; set; }
    public bool IsRequired { get; set; }
    public object Value { get; set; }

    public int FieldTypeId { get; set; }
    public FieldType Type { get; set; }

    public int FieldGroupId { get; set; }
    public FieldGroup FieldGroup { get; set; }
}
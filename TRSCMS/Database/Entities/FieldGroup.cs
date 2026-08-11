namespace TRSCMS.Database.Entities;

/// <summary>
/// A group of fields.
/// </summary>
public class FieldGroup
{
    public int Id { get; set; }
    public string Name { get; set; }


    public List<Field> Fields { get; set; }
}
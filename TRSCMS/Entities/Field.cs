namespace TRSCMS.Database.Entities;

public class Field
{
    public int Id { get; set; }
    public string Name { get; set; }
    public object Value { get; set; }

    public int FieldId { get; set; }
    public FieldType Type { get; set; }
}
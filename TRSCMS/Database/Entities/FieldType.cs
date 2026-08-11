namespace TRSCMS.Database.Entities;

/// <summary>
/// The FieldType, define how we render the value on screen.
/// Should it be a Editor? Text Area? Input Box? This entity defines which one it will be.
/// </summary>
public class FieldType
{
    public int Id { get; set; }
    public string Name { get; set; }
}
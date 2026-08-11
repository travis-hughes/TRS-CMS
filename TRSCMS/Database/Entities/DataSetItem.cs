namespace TRSCMS.Database.Entities;


public class DataSetItem
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Slug { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }

    public int FieldTemplateId { get; set; }
    public FieldGroup FieldTemplate { get; set; }

    public int DataSetId { get; set; }
    public DataSet DataSet { get; set; }
}
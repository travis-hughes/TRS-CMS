using System.Runtime.CompilerServices;

namespace TRSCMS.Database.Entities;

/// <summary>
/// DataSet are lists of data containg fields.
/// </summary>
public class DataSet
{
    public int Id { get; set; }
    public string Name { get; set; }

    public List<DataSetItem> DataSetItems { get; set; } = new();


    public int WebsiteId { get; set; }
    public Website Website { get; set; }
}
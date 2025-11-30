using LiteDB;

namespace BlitzBomEx.Datamodels;

public class MetaDataModel
{
    public string Id { get; set; } = "singleton";
    public string? BomVersion { get; set; } = string.Empty;
    public DateTime? BomUpdateDate { get; set; }
    public string? TaggingVersion { get; set; } = string.Empty;
    public DateTime? TaggingUpdateDate { get; set; }
    public string? SalesVersion { get; set; } = string.Empty;
    public DateTime? SalesUpdateDate { get; set; }
    public DateTime? SalesStartDate { get; set; }
    public DateTime? SalesEndDate { get; set; }
}
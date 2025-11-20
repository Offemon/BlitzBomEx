namespace BlitzBomEx.Datamodels;

public class MetaDataModel
{
    public string? BomVersion { get; set; } = string.Empty;
    public DateTime BomUpdateDate { get; set; }
    public string? TaggingVersion { get; set; } = string.Empty;
    public DateTime TaggingUpdateDate { get; set; }
    public string? SalesVersion { get; set; } = string.Empty;
    public DateTime SalesUpdateDate { get; set; }
    public DateOnly SalesStartDate { get; set; }
    public DateOnly SalesEndDate { get; set; }
}
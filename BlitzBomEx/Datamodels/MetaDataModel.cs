namespace BlitzBomEx.Datamodels;

public class MetaDataModel
{
    public string? BomVersion { get; set; } = string.Empty;
    public DateTime BomUpdateDate { get; set; } = DateTime.Now;
    public string? TaggingVersion { get; set; } = string.Empty;
    public DateTime TaggingUpdateDate { get; set; } = DateTime.Now;
}
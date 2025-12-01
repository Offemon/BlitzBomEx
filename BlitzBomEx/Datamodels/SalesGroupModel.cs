namespace BlitzBomEx.Datamodels;

public class SalesGroupModel
{
    public required string BrandCode { get; set; } =  string.Empty;
    public required string StoreCode { get; set; } =  string.Empty;
    public required string StoreName { get; set; } =  string.Empty;
    public required string BrandPosCode { get; set; } =  string.Empty;
    public required string PosCode { get; set; } =  string.Empty;
    public required string PosItemDescription { get; set; } = string.Empty;
    public int SalesQty { get; set; } = 0;
}
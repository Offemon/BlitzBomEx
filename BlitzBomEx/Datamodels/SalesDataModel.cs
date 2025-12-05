namespace BlitzBomEx.Datamodels;

public class SalesDataModel
{
    public required string StoreCode {get; set;} = string.Empty;
    public required string StoreName {get; set;} = string.Empty;
    public required string BrandCode {get; set;} = string.Empty;
    public required string BrandPosCode {get; set;} = string.Empty;
    public required DateTime SalesDateTime {get; set;}
    public required string SalesPosCode {get; set;} = string.Empty;
    public required string SalesItemName {get; set;} = string.Empty;
    public required int SalesQuantity {get; set;}
    public required decimal SalesAmount {get; set;}
}
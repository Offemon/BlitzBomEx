namespace BlitzBomEx.Datamodels;

public class SalesDataModel
{
    public required string StoreCode {get; set;} = string.Empty;
    public required string StoreName {get; set;} = string.Empty;
    public required string SalesBrandName {get; set;} = string.Empty;
    public required string SalesItemName {get; set;} = string.Empty;
    public required int SalesQuantity {get; set;} = 0;
    public DateTime? SalesDate {get; set;}
}
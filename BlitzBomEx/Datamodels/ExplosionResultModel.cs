namespace BlitzBomEx.Datamodels;

public class ExplosionResultModel
{
    public string BrandCode { get; set; } = string.Empty;
    public string StoreCode { get; set; } = string.Empty;
    public string StoreName { get; set; } = string.Empty;
    public string PosSalesCode { get; set; } = string.Empty;
    public string PosSalesName { get; set; } = string.Empty;
    public int SalesQuantity { get; set; }
    public decimal SalesAmount { get; set; }
    public string BrandRecipeName { get; set; } = string.Empty;
    public string ComponentItemCode { get; set; } = string.Empty;
    public string ComponentGenericDesc { get; set; } = string.Empty;
    public string ComponentItemDesc { get; set; } = string.Empty;
    public decimal ComponentContentQty { get; set; } = 0m;
    public string ComponentWholeUom { get; set; } = string.Empty;
    public decimal ComponentWholeCost { get; set; } = 0m;
    public decimal ComponentUnitQty { get; set; } = 0m;
    public string ComponentUnitUom { get; set; } = string.Empty;
    public decimal ComponentUnitCost { get; set; } = 0m;
    public decimal ComponentTotalUnitQty { get; set; } = 0m;
    public decimal ComponentTotalUnitCost { get; set; } = 0m;
    public decimal TotalWholeUomConsumed { get; set; } = 0m;
    public decimal TotalWholeCost { get; set; } = 0m;
}
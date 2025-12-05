namespace BlitzBomEx.Datamodels;

public class ComponentModel
{
    public required string BlitzId  { get; set; }
    public required string BrandRecipeName { get; set; }
    public required string ComponentGenericDesc { get; set; } = string.Empty;
    public required string ComponentName { get; set; }
    public required string ComponentBlitzId { get; set; }
    public required string ComponentItemCode { get; set; } = string.Empty;
    public required string Classification { get; set; }
    public required decimal ContentQty  { get; set; }
    public required decimal WholeCost  { get; set; }
    public required string WholeUom { get; set; }
    public required decimal UnitQty  { get; set; }
    public required string UnitUom { get; set; }    
    public required decimal CostPerUnit { get; set; }
    public required decimal TotalUnitQty { get; set; } = 0m;
    public required string BrandCode { get; set; }
}
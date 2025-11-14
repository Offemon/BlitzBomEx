namespace BlitzBomEx.Datamodels;

public class ComponentModel
{
    public required string ComponentName { get; set; }
    public required string Classification { get; set; }
    public required decimal ContentQty  { get; set; }
    public required decimal WholeCost  { get; set; }
    public required string WholeUom { get; set; }
    public required decimal UnitCost  { get; set; }
    public required string UnitUom { get; set; }    
    public required decimal CostPerUnit  { get; set; }
    public required string BrandCode { get; set; }
}
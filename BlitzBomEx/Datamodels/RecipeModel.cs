namespace BlitzBomEx.Datamodels;

public class RecipeModel
{
    // public required string BomVersion { get; set; }
    // public required DateTime BomVersionDate { get; set; }
    public required string BrandRecipeName { get; set; }
    public required string RecipeName { get; set; }
    public required string Classification { get; set; }
    public required string GeneralClassification { get; set; }
    public required string ComponentName { get; set; }
    public required decimal ContentQty  { get; set; }
    public required decimal WholeCost  { get; set; }
    public required string WholeUom { get; set; }
    public required decimal UnitQty  { get; set; }
    public required string UnitUom { get; set; }    
    public required decimal CostPerUnit  { get; set; }
    public required string BrandCode { get; set; }
    public required string GenericDescription { get; set; }
    public required string BlitzId { get; set; }
    public required string ComponentBlitzId { get; set; }
}
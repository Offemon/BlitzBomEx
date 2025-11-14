namespace BlitzBomEx.Datamodels;

public class PosBomTaggingModel
{
    public required string BrandInitial { get; set; }
    public required string PosItemCode { get; set; }
    public required string PosItemName { get; set; }
    public required string SearchKey { get; set; }
    public required string BomRecipeName { get; set; }
    public required decimal FoodCost { get; set; }
    public required decimal PaperCost { get; set; }
    public required decimal MarginOfError { get; set; }
    public required decimal CostOfGoods { get; set; }
}
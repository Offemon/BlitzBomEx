namespace BlitzBomEx.Datamodels;

public class RecipeNodeModel
{
    public required string BlitzId {get; set;} = string.Empty;
    public required string BrandRecipeName {get; set;} = string.Empty;
    public required string GeneralClassification {get; set;} = string.Empty;
    public required List<ComponentModel> Components = new List<ComponentModel>();
}
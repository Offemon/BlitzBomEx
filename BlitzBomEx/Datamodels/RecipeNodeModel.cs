namespace BlitzBomEx.Datamodels;

public class RecipeNodeModel
{
    public string BlitzId {get; set;} = string.Empty;
    public string BrandRecipeName {get; set;} = string.Empty;
    public List<ComponentModel> Components = new List<ComponentModel>();
}
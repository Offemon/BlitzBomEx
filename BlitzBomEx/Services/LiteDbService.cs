using LiteDB;
using BlitzBomEx.Datamodels;
namespace BlitzBomEx.Services;

public class LiteDbService
{
    private readonly LiteDatabase _db;
    private readonly ILiteCollection<RecipeModel> _recipes;
    // private readonly ILiteCollection<AssembledComponentModel> _subrecipes;
    private readonly ILiteCollection<PosBomTaggingModel> _posBomTaggings;
    private readonly ILiteCollection<MetaDataModel> _metaData;

    public LiteDbService(string dbPath = "BlitzBomEx.db")
    {
        _db = new LiteDatabase(dbPath);
        _recipes = _db.GetCollection<RecipeModel>("Recipes");
        // _subrecipes = _db.GetCollection<AssembledComponentModel>("AssembledComponents");
        _posBomTaggings =  _db.GetCollection<PosBomTaggingModel>("PosToBomTagging");
        _metaData = _db.GetCollection<MetaDataModel>("MetaData");
    }
    public List<RecipeModel> GetRecipes() => _recipes.FindAll().ToList();
    public void AddRecipe(RecipeModel recipe) => _recipes.Insert(recipe);
    public void AddRecipes(List<RecipeModel> recipes) => _recipes.InsertBulk(recipes);
    
    public List<PosBomTaggingModel> GetPosBomTaggings() => _posBomTaggings.FindAll().ToList();
    public void AddPosBomTagging(PosBomTaggingModel tagging) => _posBomTaggings.Insert(tagging);
    public void AddPosBomTaggings(List<PosBomTaggingModel> taggings) => _posBomTaggings.InsertBulk(taggings);

    public MetaDataModel? GetMetaData() => _metaData.FindAll().FirstOrDefault();
    public void CreateMetaData(MetaDataModel metaData) => _metaData.Insert(metaData);
    public void UpdateMetaData(MetaDataModel metaData) => _metaData.Update(metaData);
    
    
}
    // public List<AssembledComponentModel> GetSubRecipes() => _subrecipes.FindAll().ToList();
    //public void AddAssembledComponent(AssembledComponentModel recipe) => _subrecipes.Insert(recipe);
    //public void AddAssembledComponents(List<AssembledComponentModel> recipe) => _subrecipes.InsertBulk(recipe);

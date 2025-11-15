using LiteDB;
using BlitzBomEx.Datamodels;
namespace BlitzBomEx.Services;

public class LiteDbService
{
    private readonly LiteDatabase _db;
    private readonly ILiteCollection<RecipeModel> _recipes;
    private readonly ILiteCollection<PosBomTaggingModel> _posBomTaggings;
    private readonly ILiteCollection<MetaDataModel> _metaData;
    
    private readonly ILiteCollection<DummyDataModel> _dummyData;
    // private readonly ILiteCollection<AssembledComponentModel> _subrecipes;

    public LiteDbService(string dbPath = "BlitzBomEx.db")
    {
        _db = new LiteDatabase(dbPath);
        _recipes = _db.GetCollection<RecipeModel>("Recipes");
        // _subrecipes = _db.GetCollection<AssembledComponentModel>("AssembledComponents");
        _posBomTaggings =  _db.GetCollection<PosBomTaggingModel>("PosToBomTagging");
        _metaData = _db.GetCollection<MetaDataModel>("MetaData");
        _dummyData = _db.GetCollection<DummyDataModel>("DummyData");
    }
    public List<RecipeModel> GetRecipes() => _recipes.FindAll().ToList();
    public void AddRecipe(RecipeModel recipe) => _recipes.Insert(recipe);
    public void AddRecipe(List<RecipeModel> recipes) => _recipes.InsertBulk(recipes);
    public void PurgeRecipes() => _recipes.DeleteAll();
    
    public List<PosBomTaggingModel> GetPosBomTaggings() => _posBomTaggings.FindAll().ToList();
    public void AddPosBomTagging(PosBomTaggingModel tagging) => _posBomTaggings.Insert(tagging);
    public void AddPosBomTagging(List<PosBomTaggingModel> taggings) => _posBomTaggings.InsertBulk(taggings);
    public void PurgePosBomTaggings() => _posBomTaggings.DeleteAll();

    public MetaDataModel? GetMetaData() => _metaData.FindAll().FirstOrDefault();
    public void CreateMetaData(MetaDataModel metaData) => _metaData.Insert(metaData);
    public void UpdateMetaData(MetaDataModel metaData) => _metaData.Update(metaData);
    public void PurgeMetaData() => _metaData.DeleteAll();
    
    
    // For Testing
    public List<DummyDataModel> GetDummyData() => _dummyData.FindAll().ToList();
    public void AddDummyData(DummyDataModel dummyData) => _dummyData.Insert(dummyData);
    public void AddDummyData(List<DummyDataModel> dummyData) => _dummyData.InsertBulk(dummyData);
    public void PurgeDummyData() => _dummyData.DeleteAll();
}
    // public List<AssembledComponentModel> GetSubRecipes() => _subrecipes.FindAll().ToList();
    //public void AddAssembledComponent(AssembledComponentModel recipe) => _subrecipes.Insert(recipe);
    //public void AddAssembledComponents(List<AssembledComponentModel> recipe) => _subrecipes.InsertBulk(recipe);

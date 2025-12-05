using LiteDB;
using BlitzBomEx.Datamodels;
namespace BlitzBomEx.Services;

public class LiteDbService
{
    private readonly LiteDatabase _db;
    private readonly ILiteCollection<RecipeModel> _recipes;
    private readonly ILiteCollection<PosBomTaggingModel> _posBomTaggings;
    private readonly ILiteCollection<MetaDataModel> _metaData;
    private readonly ILiteCollection<SalesDataModel> _salesData;
    private readonly ILiteCollection<BlitzGuardModel> _guards;

    public LiteDbService(string dbPath = "BlitzBomEx.db")
    {
        _db = new LiteDatabase(dbPath);
        _recipes = _db.GetCollection<RecipeModel>("Recipes");
        _posBomTaggings =  _db.GetCollection<PosBomTaggingModel>("PosToBomTagging");
        _metaData = _db.GetCollection<MetaDataModel>("MetaData");
        _salesData = _db.GetCollection<SalesDataModel>("SalesData");
        _guards = _db.GetCollection<BlitzGuardModel>("Guards");
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
    // public void CreateMetaData(MetaDataModel metaData) => _metaData.Insert(metaData);
    public void UpdateMetaData(MetaDataModel metaData) => _metaData.Upsert("singleton",metaData);
    public void PurgeMetaData() => _metaData.DeleteAll();
    
    public List<SalesDataModel> GetSalesData() => _salesData.FindAll().ToList();
    public void AddSalesData(List<SalesDataModel> salesData) => _salesData.Insert(salesData);
    public void PurgeSalesData() => _salesData.DeleteAll();
    
    public BlitzGuardModel? GetBlitzGuard() => _guards.FindAll().FirstOrDefault();
    public void UpdateBlitzGuard(BlitzGuardModel blitzguard) => _guards.Upsert("singleton", blitzguard);

    // public void Dispose()
    // {
    //     _db?.Dispose();
    // }

}


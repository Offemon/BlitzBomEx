namespace BlitzBomEx.Datamodels;

public class BlitzGuardModel
{
    public string Id { get; init; } = "singleton";
    public required string Umac { get; set; } = string.Empty;
    // public required DateTime ActivationDate { get; set; }
}
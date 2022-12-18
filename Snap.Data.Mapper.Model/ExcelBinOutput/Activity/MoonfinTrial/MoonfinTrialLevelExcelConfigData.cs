namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.MoonfinTrial;

public class MoonfinTrialLevelExcelConfigData : DataObject
{
    [JsonPropertyName("levelId")]
    public int LevelId { get; set; }

    [JsonPropertyName("openDay")]
    public int OpenDay { get; set; }

    [JsonPropertyName("MIIJOHIJPNP")]
    public IList<int> MIIJOHIJPNP { get; set; } = default!;

    [JsonPropertyName("mainQuest")]
    public int MainQuest { get; set; }

    [JsonPropertyName("KKLKONNFDBG")]
    public IList<float> KKLKONNFDBG { get; set; } = default!;

    [JsonPropertyName("levelNameTextMapHash")]
    public Text LevelNameTextMapHash { get; set; }

    [JsonPropertyName("descriptionTextMapHash")]
    public Text DescriptionTextMapHash { get; set; }

    [JsonPropertyName("titleTextMapHash")]
    public Text TitleTextMapHash { get; set; }

    [JsonPropertyName("FBCBFLICJMO")]
    public string FBCBFLICJMO { get; set; } = default!;

    [JsonPropertyName("PGEFACLHJAF")]
    public int? PGEFACLHJAF { get; set; }

    [JsonPropertyName("galleryId")]
    public int? GalleryId { get; set; }

    [JsonPropertyName("challengeId")]
    public int? ChallengeId { get; set; }

    [JsonPropertyName("IBEONKCOHBL")]
    public int? IBEONKCOHBL { get; set; }

    [JsonPropertyName("DEAOPEHLJEP")]
    public int? DEAOPEHLJEP { get; set; }

    [JsonPropertyName("rewardPreviewId")]
    public int? RewardPreviewId { get; set; }
}
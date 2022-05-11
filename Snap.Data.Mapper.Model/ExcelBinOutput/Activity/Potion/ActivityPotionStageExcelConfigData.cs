namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.Potion;

public class ActivityPotionStageExcelConfigData : DataObject
{
    [JsonPropertyName("stageId")]
    public int StageId { get; set; }

    [JsonPropertyName("openDay")]
    public int OpenDay { get; set; }

    [JsonPropertyName("HCEBDAPDFIH")]
    public IList<int> HCEBDAPDFIH { get; set; } = default!;

    [JsonPropertyName("OFJJHCOBOCC")]
    public int OFJJHCOBOCC { get; set; }

    [JsonPropertyName("watcherIdList")]
    public IList<int> WatcherIdList { get; set; } = default!;

    [JsonPropertyName("trialAvatarList")]
    public IList<int> TrialAvatarList { get; set; } = default!;

    [JsonPropertyName("CMGNPDAJMNA")]
    public IList<int> CMGNPDAJMNA { get; set; } = default!;

    [JsonPropertyName("titleTextMapHash")]
    public Text TitleTextMapHash { get; set; }

    [JsonPropertyName("MLMOEEHLIJM")]
    public Text MLMOEEHLIJM { get; set; }
}
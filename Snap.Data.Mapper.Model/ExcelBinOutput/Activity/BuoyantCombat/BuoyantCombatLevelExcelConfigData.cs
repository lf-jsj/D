namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.BuoyantCombat;

public class BuoyantCombatLevelExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("galleryId")]
    public int GalleryId { get; set; }

    [JsonPropertyName("groupId")]
    public int GroupId { get; set; }

    [JsonPropertyName("dayIndex")]
    public int DayIndex { get; set; }

    [JsonPropertyName("rewardPreview")]
    public int RewardPreview { get; set; }

    [JsonPropertyName("FJOLJMHDDHC")]
    public Text FJOLJMHDDHC { get; set; }

    [JsonPropertyName("LPEEGMLIBMD")]
    public Text LPEEGMLIBMD { get; set; }

    [JsonPropertyName("MIIJOHIJPNP")]
    public IList<int> MIIJOHIJPNP { get; set; } = default!;

    [JsonPropertyName("MMCOKEAADEP")]
    public IList<int> MMCOKEAADEP { get; set; } = default!;

    [JsonPropertyName("recommendLevel")]
    public IList<int> RecommendLevel { get; set; } = default!;

    [JsonPropertyName("PHHPONIMAEE")]
    public IList<float> PHHPONIMAEE { get; set; } = default!;
}
namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.Salvage;

public class SalvageOverAllExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("activityId")]
    public int ActivityId { get; set; }

    [JsonPropertyName("JKMBCEHKMKF")]
    public int JKMBCEHKMKF { get; set; }

    [JsonPropertyName("preQuestId")]
    public int PreQuestId { get; set; }

    [JsonPropertyName("guideQuestId")]
    public int GuideQuestId { get; set; }

    [JsonPropertyName("nameTextMapHash")]
    public Text NameTextMapHash { get; set; }

    [JsonPropertyName("descTextMapHash")]
    public Text DescTextMapHash { get; set; }

    [JsonPropertyName("regionCenter")]
    public IList<float> RegionCenter { get; set; } = default!;

    [JsonPropertyName("regionRadius")]
    public int RegionRadius { get; set; }

    [JsonPropertyName("PJDPNMJBNPE")]
    public int PJDPNMJBNPE { get; set; }

    [JsonPropertyName("reminderId")]
    public int ReminderId { get; set; }

    [JsonPropertyName("IJGOFGIMNIO")]
    public int IJGOFGIMNIO { get; set; }

    [JsonPropertyName("rewardPreviewId")]
    public int RewardPreviewId { get; set; }

    [JsonPropertyName("AMHIMBFCPEI")]
    public int AMHIMBFCPEI { get; set; }

    [JsonPropertyName("MNHMNKNCNNB")]
    public int MNHMNKNCNNB { get; set; }
}
namespace Snap.Data.Mapper.Model.ExcelBinOutput.Aster;

public class AsterTeamBuffExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("activityId")]
    public int ActivityId { get; set; }

    [JsonPropertyName("nameTextMapHash")]
    public Text NameTextMapHash { get; set; }

    [JsonPropertyName("descTextMapHash")]
    public Text DescTextMapHash { get; set; }

    [JsonPropertyName("icon")]
    public string Icon { get; set; } = default!;
}
namespace Snap.Data.Mapper.Model.ExcelBinOutput.Coop;
public class CoopActivityExcelConfigData : DataObject
{
    [JsonPropertyName("activityId")]
    public int ActivityId { get; set; }

    [JsonPropertyName("prefabPath")]
    public string PrefabPath { get; set; } = default!;

    [JsonPropertyName("activityNameTextMapHash")]
    public Text ActivityNameTextMapHash { get; set; }

    [JsonPropertyName("activityDesTextMapHash")]
    public Text ActivityDesTextMapHash { get; set; }
}
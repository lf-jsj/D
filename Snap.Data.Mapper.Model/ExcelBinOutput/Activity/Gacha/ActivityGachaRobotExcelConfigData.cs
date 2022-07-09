namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.Gacha;
public class ActivityGachaRobotExcelConfigData : DataObject
{
    [JsonPropertyName("type")]
    public string Type { get; set; } = default!;

    [JsonPropertyName("materialId")]
    public int MaterialId { get; set; }

    [JsonPropertyName("modelPath")]
    public string ModelPath { get; set; } = default!;

    [JsonPropertyName("descTextMapHash")]
    public Text DescTextMapHash { get; set; }
}


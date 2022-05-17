namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.LanV2.Projection;

public class LanV2ProjectionStageExcelConfigData : DataObject
{
    [JsonPropertyName("stageId")]
    public int StageId { get; set; }

    [JsonPropertyName("titleTextMapHash")]
    public Text TitleTextMapHash { get; set; }

    [JsonPropertyName("descTextMapHash")]
    public Text DescTextMapHash { get; set; }

    [JsonPropertyName("openDay")]
    public int OpenDay { get; set; }
}
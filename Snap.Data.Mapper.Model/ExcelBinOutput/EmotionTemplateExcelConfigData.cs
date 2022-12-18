namespace Snap.Data.Mapper.Model.ExcelBinOutput;

public class EmotionTemplateExcelConfigData : DataObject
{
    [JsonPropertyName("ID")]
    public int ID { get; set; }

    [JsonPropertyName("freeStyleId")]
    public int FreeStyleId { get; set; }

    [JsonPropertyName("bubbleName")]
    public string BubbleName { get; set; } = default!;

    [JsonPropertyName("emotionPath")]
    public string EmotionPath { get; set; } = default!;

    [JsonPropertyName("protectTime")]
    public float ProtectTime { get; set; }
}

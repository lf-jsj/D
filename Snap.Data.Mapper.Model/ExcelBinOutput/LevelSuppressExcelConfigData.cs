namespace Snap.Data.Mapper.Model.ExcelBinOutput;

public class LevelSuppressExcelConfigData : DataObject
{
    [JsonPropertyName("levelSuppressDamageCo")]
    public float LevelSuppressDamageCo { get; set; }

    [JsonPropertyName("levelSuppressEndure")]
    public float LevelSuppressEndure { get; set; }

    [JsonPropertyName("levelSuppressDisMinHorizontal")]
    public float LevelSuppressDisMinHorizontal { get; set; }

    [JsonPropertyName("levelSuppressDisMaxHorizontal")]
    public float LevelSuppressDisMaxHorizontal { get; set; }

    [JsonPropertyName("levelSuppressDisMinVertical")]
    public float LevelSuppressDisMinVertical { get; set; }

    [JsonPropertyName("levelSuppressDisMaxVertical")]
    public float LevelSuppressDisMaxVertical { get; set; }

    [JsonPropertyName("isAttackerPlayer")]
    public bool IsAttackerPlayer { get; set; }

    [JsonPropertyName("isDefenserPlayer")]
    public bool IsDefenserPlayer { get; set; }

    [JsonPropertyName("level")]
    public int? Level { get; set; }
}

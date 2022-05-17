namespace Snap.Data.Mapper.Model.ExcelBinOutput;

public class LevelSuppressExcelConfigData : DataObject
{
    [JsonPropertyName("levelSuppressDamageCo")]
    public double LevelSuppressDamageCo { get; set; }

    [JsonPropertyName("levelSuppressEndure")]
    public double LevelSuppressEndure { get; set; }

    [JsonPropertyName("levelSuppressDisMinHorizontal")]
    public double LevelSuppressDisMinHorizontal { get; set; }

    [JsonPropertyName("levelSuppressDisMaxHorizontal")]
    public double LevelSuppressDisMaxHorizontal { get; set; }

    [JsonPropertyName("levelSuppressDisMinVertical")]
    public double LevelSuppressDisMinVertical { get; set; }

    [JsonPropertyName("levelSuppressDisMaxVertical")]
    public double LevelSuppressDisMaxVertical { get; set; }

    [JsonPropertyName("isAttackerPlayer")]
    public bool IsAttackerPlayer { get; set; }

    [JsonPropertyName("isDefenserPlayer")]
    public bool IsDefenserPlayer { get; set; }

    [JsonPropertyName("level")]
    public int? Level { get; set; }
}

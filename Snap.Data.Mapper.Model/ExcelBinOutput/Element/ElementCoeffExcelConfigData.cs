namespace Snap.Data.Mapper.Model.ExcelBinOutput.Element;
public class ElementCoeffExcelConfigData : DataObject
{
    [JsonPropertyName("crashCo")]
    public float CrashCo { get; set; }

    [JsonPropertyName("elementLevelCo")]
    public float ElementLevelCo { get; set; }

    [JsonPropertyName("playerElementLevelCo")]
    public float PlayerElementLevelCo { get; set; }

    [JsonPropertyName("playerShieldLevelCo")]
    public float PlayerShieldLevelCo { get; set; }

    [JsonPropertyName("level")]
    public int? Level { get; set; }
}

namespace Snap.Data.Mapper.Model.ExcelBinOutput.Element;
public class ElementCoeffExcelConfigData : DataObject
{
    [JsonPropertyName("crashCo")]
    public double CrashCo { get; set; }

    [JsonPropertyName("elementLevelCo")]
    public double ElementLevelCo { get; set; }

    [JsonPropertyName("playerElementLevelCo")]
    public double PlayerElementLevelCo { get; set; }

    [JsonPropertyName("playerShieldLevelCo")]
    public double PlayerShieldLevelCo { get; set; }

    [JsonPropertyName("level")]
    public int? Level { get; set; }
}

namespace Snap.Data.Mapper.Model.ExcelBinOutput.CustomLevel;

public class CustomLevelUIConfigData : DataObject
{
    [JsonPropertyName("configId")]
    public int ConfigId { get; set; }

    [JsonPropertyName("openDay")]
    public int OpenDay { get; set; }

    [JsonPropertyName("watcherIdList")]
    public IList<int> WatcherIdList { get; set; } = default!;

    [JsonPropertyName("OHHOKGNHBIL")]
    public IList<int> OHHOKGNHBIL { get; set; } = default!;
}
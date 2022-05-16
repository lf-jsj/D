namespace Snap.Data.Mapper.Model.ExcelBinOutput.EnvAnimal;

public class EnvAnimalGatherExcelConfigData : DataObject
{
    [JsonPropertyName("animalId")]
    public int AnimalId { get; set; }

    [JsonPropertyName("entityType")]
    public string EntityType { get; set; } = default!;

    [JsonPropertyName("gatherItemId")]
    public IList<CountableItem> GatherItemId { get; set; } = default!;

    [JsonPropertyName("escapeRadius")]
    public int EscapeRadius { get; set; }

    [JsonPropertyName("escapeTime")]
    public int EscapeTime { get; set; }

    [JsonPropertyName("aliveTime")]
    public int AliveTime { get; set; }

    [JsonPropertyName("excludeWeathers")]
    public string ExcludeWeathers { get; set; } = default!;
}

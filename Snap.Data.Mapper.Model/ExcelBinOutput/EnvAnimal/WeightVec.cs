namespace Snap.Data.Mapper.Model.ExcelBinOutput.EnvAnimal;

public class WeightVec : DataObject
{
    [JsonPropertyName("animalId")]
    public int AnimalId { get; set; }

    [JsonPropertyName("entityType")]
    public string EntityType { get; set; } = default!;

    [JsonPropertyName("weight")]
    public int Weight { get; set; }

    [JsonPropertyName("aliveHourMap")]
    public IDictionary<string, int> AliveHourMap { get; set; } = default!;
}

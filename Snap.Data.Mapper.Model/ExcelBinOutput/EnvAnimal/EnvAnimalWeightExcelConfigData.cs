namespace Snap.Data.Mapper.Model.ExcelBinOutput.EnvAnimal;

public class EnvAnimalWeightExcelConfigData : DataObject
{
    [JsonPropertyName("envType")]
    public string EnvType { get; set; } = default!;

    [JsonPropertyName("weightVec")]
    public IList<WeightVec> WeightVec { get; set; } = default!;
}
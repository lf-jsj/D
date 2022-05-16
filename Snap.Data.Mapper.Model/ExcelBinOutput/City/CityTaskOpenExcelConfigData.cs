namespace Snap.Data.Mapper.Model.ExcelBinOutput.City;

public class CityTaskOpenExcelConfigData : DataObject
{
    [JsonPropertyName("cityId")]
    public int CityId { get; set; }

    [JsonPropertyName("questId")]
    public int QuestId { get; set; }

    [JsonPropertyName("DDANAHMGNLE")]
    public IList<int> DDANAHMGNLE { get; set; } = default!;
}

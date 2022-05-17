namespace Snap.Data.Mapper.Model.ExcelBinOutput.Investigation;

public class InvestigationDungeonConfigData : DataObject
{
    [JsonPropertyName("entranceId")]
    public int EntranceId { get; set; }

    [JsonPropertyName("cityId")]
    public int CityId { get; set; }

    [JsonPropertyName("dungeonIdList")]
    public IList<int> DungeonIdList { get; set; } = default!;
}
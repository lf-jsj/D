using Snap.Data.Mapper.Model.Common;

namespace Snap.Data.Mapper.Model.ExcelBinOutput.Reliquary;
public class ReliquaryAffixExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("depotId")]
    public int DepotId { get; set; }

    [JsonPropertyName("groupId")]
    public int GroupId { get; set; }

    [JsonPropertyName("propType")]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public FightProperty PropType { get; set; } = default!;

    [JsonPropertyName("propValue")]
    public float PropValue { get; set; }
}

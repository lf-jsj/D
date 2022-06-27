using Snap.Data.Mapper.Model.Common;

namespace Snap.Data.Mapper.Model.ExcelBinOutput.Reliquary;

public class ReliquaryMainPropExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("propDepotId")]
    public int PropDepotId { get; set; }

    [JsonPropertyName("propType")]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public FightProperty PropType { get; set; } = default!;

    [JsonPropertyName("affixName")]
    public string AffixName { get; set; } = default!;
}
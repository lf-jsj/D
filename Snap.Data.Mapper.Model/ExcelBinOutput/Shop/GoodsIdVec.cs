namespace Snap.Data.Mapper.Model.ExcelBinOutput.Shop;

public class GoodsIdVec : DataObject
{
    [JsonPropertyName("type")]
    public string Type { get; set; } = default!;

    [JsonPropertyName("IOODBPEAAKB")]
    public string IOODBPEAAKB { get; set; } = default!;

    [JsonPropertyName("ANACLEHGLHE")]
    public string ANACLEHGLHE { get; set; } = default!;
}

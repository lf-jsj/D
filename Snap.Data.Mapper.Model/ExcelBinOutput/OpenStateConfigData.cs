namespace Snap.Data.Mapper.Model.ExcelBinOutput;

public class OpenStateConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("allowClientOpen")]
    public bool AllowClientOpen { get; set; }

    [JsonPropertyName("cond")]
    public IList<Param2CondType> Cond { get; set; } = default!;

    [JsonPropertyName("defaultState")]
    public bool? DefaultState { get; set; }

    [JsonPropertyName("systemOpenUiId")]
    public int? SystemOpenUiId { get; set; }
}
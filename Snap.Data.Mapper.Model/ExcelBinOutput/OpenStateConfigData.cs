using Snap.Data.Mapper.Model.Common.Param;

namespace Snap.Data.Mapper.Model.ExcelBinOutput;

public class OpenStateConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("allowClientOpen")]
    public bool AllowClientOpen { get; set; }

    [JsonPropertyName("cond")]
    public IList<CondTypeParamParam2> Cond { get; set; } = default!;

    [JsonPropertyName("defaultState")]
    public bool? DefaultState { get; set; }

    [JsonPropertyName("systemOpenUiId")]
    public int? SystemOpenUiId { get; set; }
}
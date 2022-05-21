using Snap.Data.Mapper.Model.Common;

namespace Snap.Data.Mapper.Model.ExcelBinOutput.Reward;

public class RewardPreviewExcelConfigData : DataObject
{
    [JsonPropertyName("Desc")]
    public string Desc { get; set; } = default!;

    [JsonPropertyName("previewItems")]
    public IList<IdCount<string>> PreviewItems { get; set; } = default!;

    [JsonPropertyName("id")]
    public int? Id { get; set; }
}
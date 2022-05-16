namespace Snap.Data.Mapper.Model.ExcelBinOutput.Daily;

public class DropVec : DataObject
{
    [JsonPropertyName("dropId")]
    public int DropId { get; set; }

    [JsonPropertyName("previewRewardId")]
    public int PreviewRewardId { get; set; }
}

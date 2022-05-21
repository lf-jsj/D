namespace Snap.Data.Mapper.Model.Common;

public class DropIdPreviewRewardId : DataObject
{
    [JsonPropertyName("dropId")]
    public int DropId { get; set; }

    [JsonPropertyName("previewRewardId")]
    public int PreviewRewardId { get; set; }
}

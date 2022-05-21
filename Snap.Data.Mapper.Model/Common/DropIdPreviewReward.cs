namespace Snap.Data.Mapper.Model.Common;

public class DropIdPreviewReward : DataObject
{
    [JsonPropertyName("dropId")]
    public int DropId { get; set; }

    [JsonPropertyName("previewReward")]
    public int PreviewReward { get; set; }
}

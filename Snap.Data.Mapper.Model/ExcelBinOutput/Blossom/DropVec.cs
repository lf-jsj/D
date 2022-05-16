namespace Snap.Data.Mapper.Model.ExcelBinOutput.Blossom;

public class DropVec : DataObject
{
    [JsonPropertyName("dropId")]
    public int DropId { get; set; }

    [JsonPropertyName("previewReward")]
    public int PreviewReward { get; set; }
}

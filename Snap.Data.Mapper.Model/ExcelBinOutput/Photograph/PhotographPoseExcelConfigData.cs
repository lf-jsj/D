namespace Snap.Data.Mapper.Model.ExcelBinOutput.Photograph;

public class PhotographPoseExcelConfigData : DataObject
{
    [JsonPropertyName("characterId")]
    public int CharacterId { get; set; }

    [JsonPropertyName("poseId")]
    public IList<int> PoseId { get; set; } = default!;
}
namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.BlitzRush;

public class BlitzRushExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("activityId")]
    public int ActivityId { get; set; }

    [JsonPropertyName("contentDuration")]
    public int ContentDuration { get; set; }

    [JsonPropertyName("dungeonId")]
    public int DungeonId { get; set; }

    [JsonPropertyName("HIPJDDGPAAL")]
    public int HIPJDDGPAAL { get; set; }

    [JsonPropertyName("CGFNPOHBFGK")]
    public int CGFNPOHBFGK { get; set; }

    [JsonPropertyName("JMNOODIMIOO")]
    public int JMNOODIMIOO { get; set; }

    [JsonPropertyName("BEPHEAGDDNK")]
    public IList<int> BEPHEAGDDNK { get; set; } = default!;

    [JsonPropertyName("rewardPreview")]
    public int RewardPreview { get; set; }
}

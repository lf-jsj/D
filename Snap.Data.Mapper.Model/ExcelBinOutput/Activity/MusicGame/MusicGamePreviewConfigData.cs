namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.MusicGame;

public class MusicGamePreviewConfigData : DataObject
{
    [JsonPropertyName("activityID")]
    public int ActivityID { get; set; }

    [JsonPropertyName("OODPPFGHDDE")]
    public IList<int> OODPPFGHDDE { get; set; } = default!;
}
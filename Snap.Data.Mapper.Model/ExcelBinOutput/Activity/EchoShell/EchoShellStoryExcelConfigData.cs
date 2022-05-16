namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.EchoShell;

public class EchoShellStoryExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("storyTitleTextMapHash")]
    public Text StoryTitleTextMapHash { get; set; }
}
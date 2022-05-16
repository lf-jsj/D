namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.EchoShell;

public class EchoShellExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("storyId")]
    public int StoryId { get; set; }

    [JsonPropertyName("BECHHEFFNJK")]
    public Text BECHHEFFNJK { get; set; }

    [JsonPropertyName("OHNGAGGDDCL")]
    public Text OHNGAGGDDCL { get; set; }

    [JsonPropertyName("IMEHFIAIBND")]
    public IList<int> IMEHFIAIBND { get; set; } = default!;
}
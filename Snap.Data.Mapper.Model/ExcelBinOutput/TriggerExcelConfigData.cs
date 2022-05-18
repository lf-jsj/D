namespace Snap.Data.Mapper.Model.ExcelBinOutput;

public class TriggerExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("sceneId")]
    public int SceneId { get; set; }

    [JsonPropertyName("groupId")]
    public int GroupId { get; set; }

    [JsonPropertyName("triggerName")]
    public string TriggerName { get; set; } = default!;
}
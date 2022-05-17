namespace Snap.Data.Mapper.Model.ExcelBinOutput;

public class LimitRegionExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; } = default!;

    [JsonPropertyName("sceneId")]
    public int SceneId { get; set; }

    [JsonPropertyName("type")]
    public string Type { get; set; } = default!;

    [JsonPropertyName("IHCKNINEHPB")]
    public string IHCKNINEHPB { get; set; } = default!;

    [JsonPropertyName("order")]
    public int? Order { get; set; }
}
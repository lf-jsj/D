namespace Snap.Data.Mapper.Model.ExcelBinOutput.World;

public class WorldExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("type")]
    public string Type { get; set; } = default!;

    [JsonPropertyName("mainSceneId")]
    public int MainSceneId { get; set; }

    [JsonPropertyName("subSceneIdVec")]
    public IList<int> SubSceneIdVec { get; set; } = default!;
}
namespace Snap.Data.Mapper.Model.ExcelBinOutput.Room;
public class RoomExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("prefabPath")]
    public string PrefabPath { get; set; } = default!;

    [JsonPropertyName("navMeshPath")]
    public string NavMeshPath { get; set; } = default!;
}

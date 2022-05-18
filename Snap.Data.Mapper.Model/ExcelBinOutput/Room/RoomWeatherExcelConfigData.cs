namespace Snap.Data.Mapper.Model.ExcelBinOutput.Room;

public class RoomWeatherExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("roomID")]
    public int RoomID { get; set; }

    [JsonPropertyName("areaID")]
    public int AreaID { get; set; }

    [JsonPropertyName("profileName")]
    public string ProfileName { get; set; } = default!;
}
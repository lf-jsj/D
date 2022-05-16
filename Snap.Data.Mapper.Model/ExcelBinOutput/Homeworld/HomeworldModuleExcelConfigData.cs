namespace Snap.Data.Mapper.Model.ExcelBinOutput.Homeworld;

public class HomeworldModuleExcelConfigData : DataObject
{
    [JsonPropertyName("Id")]
    public int Id { get; set; }

    [JsonPropertyName("GKIBGDNCEHD")]
    public Text GKIBGDNCEHD { get; set; }

    [JsonPropertyName("worldSceneId")]
    public int WorldSceneId { get; set; }

    [JsonPropertyName("defaultRoomSceneId")]
    public int DefaultRoomSceneId { get; set; }

    [JsonPropertyName("optionalRoomSceneIdVec")]
    public IList<int> OptionalRoomSceneIdVec { get; set; } = default!;

    [JsonPropertyName("moduleNameTextMapHash")]
    public Text ModuleNameTextMapHash { get; set; }

    [JsonPropertyName("moduleDescTextMapHash")]
    public Text ModuleDescTextMapHash { get; set; }

    [JsonPropertyName("region")]
    public IList<string> Region { get; set; } = default!;

    [JsonPropertyName("regionPointPos")]
    public IList<string> RegionPointPos { get; set; } = default!;

    [JsonPropertyName("smallImageAddr")]
    public string SmallImageAddr { get; set; } = default!;

    [JsonPropertyName("bigImageAddr")]
    public string BigImageAddr { get; set; } = default!;

    [JsonPropertyName("isFree")]
    public bool? IsFree { get; set; }
}
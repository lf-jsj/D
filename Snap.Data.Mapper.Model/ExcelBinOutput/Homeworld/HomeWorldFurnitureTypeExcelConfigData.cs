namespace Snap.Data.Mapper.Model.ExcelBinOutput.Homeworld;

public class HomeWorldFurnitureTypeExcelConfigData : DataObject
{
    [JsonPropertyName("typeID")]
    public int TypeID { get; set; }

    [JsonPropertyName("JODPFHBLFIM")]
    public int JODPFHBLFIM { get; set; }

    [JsonPropertyName("typeNameTextMapHash")]
    public Text TypeNameTextMapHash { get; set; }

    [JsonPropertyName("typeName2TextMapHash")]
    public Text TypeName2TextMapHash { get; set; }

    [JsonPropertyName("tabIcon")]
    public string TabIcon { get; set; } = default!;

    [JsonPropertyName("isShowInBag")]
    public bool IsShowInBag { get; set; }

    [JsonPropertyName("sceneType")]
    public string SceneType { get; set; } = default!;

    [JsonPropertyName("PAJMHBMFEBI")]
    public int? PAJMHBMFEBI { get; set; }
}
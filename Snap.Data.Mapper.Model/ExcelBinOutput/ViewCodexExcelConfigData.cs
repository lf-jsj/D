namespace Snap.Data.Mapper.Model.ExcelBinOutput;

public class ViewCodexExcelConfigData : DataObject
{
    [JsonPropertyName("Id")]
    public int Id { get; set; }

    [JsonPropertyName("gadgetId")]
    public int GadgetId { get; set; }

    [JsonPropertyName("sceneId")]
    public int SceneId { get; set; }

    [JsonPropertyName("groupId")]
    public int GroupId { get; set; }

    [JsonPropertyName("configId")]
    public int ConfigId { get; set; }

    [JsonPropertyName("nameTextMapHash")]
    public Text NameTextMapHash { get; set; }

    [JsonPropertyName("descTextMapHash")]
    public Text DescTextMapHash { get; set; }

    [JsonPropertyName("image")]
    public string Image { get; set; } = default!;

    [JsonPropertyName("cityId")]
    public int CityId { get; set; }

    [JsonPropertyName("worldAreaId")]
    public int WorldAreaId { get; set; }

    [JsonPropertyName("SortOrder")]
    public int SortOrder { get; set; }

    [JsonPropertyName("showOnlyUnlocked")]
    public bool? ShowOnlyUnlocked { get; set; }
}
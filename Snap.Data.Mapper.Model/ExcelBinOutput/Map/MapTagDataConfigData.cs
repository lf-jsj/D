namespace Snap.Data.Mapper.Model.ExcelBinOutput.Map;

public class MapTagDataConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("type")]
    public string Type { get; set; } = default!;

    [JsonPropertyName("nameTextMapHash")]
    public Text NameTextMapHash { get; set; }

    [JsonPropertyName("LKGMBGLFFHM")]
    public int LKGMBGLFFHM { get; set; }

    [JsonPropertyName("icon")]
    public string Icon { get; set; } = default!;

    [JsonPropertyName("hideBeforeUnlock")]
    public bool HideBeforeUnlock { get; set; }

    [JsonPropertyName("sceneIdList")]
    public IList<int> SceneIdList { get; set; } = default!;

    [JsonPropertyName("PLJNNLDLDME")]
    public double? PLJNNLDLDME { get; set; }

    [JsonPropertyName("FOIAKKOFLPB")]
    public double? FOIAKKOFLPB { get; set; }

    [JsonPropertyName("unlockByDefault")]
    public bool? UnlockByDefault { get; set; }

    [JsonPropertyName("cityID")]
    public int? CityID { get; set; }

    [JsonPropertyName("FHPHGLPCJJO")]
    public int? FHPHGLPCJJO { get; set; }
}
namespace Snap.Data.Mapper.Model.ExcelBinOutput.Avatar;

public class AvatarFlycloakExcelConfigData : DataObject
{
    [JsonPropertyName("flycloakId")]
    public int FlycloakId { get; set; }

    [JsonPropertyName("nameTextMapHash")]
    public Text NameTextMapHash { get; set; }

    [JsonPropertyName("descTextMapHash")]
    public Text DescTextMapHash { get; set; }

    [JsonPropertyName("prefabPath")]
    public string PrefabPath { get; set; } = default!;

    [JsonPropertyName("jsonName")]
    public string JsonName { get; set; } = default!;

    [JsonPropertyName("icon")]
    public string Icon { get; set; } = default!;

    [JsonPropertyName("materialId")]
    public int MaterialId { get; set; }

    [JsonPropertyName("hide")]
    public bool? Hide { get; set; }
}

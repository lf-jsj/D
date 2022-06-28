namespace Snap.Data.Mapper.Model.ExcelBinOutput.Weapon;

public class WeaponExcelConfigData : DataObject
{
    [JsonPropertyName("weaponType")]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public WeaponType WeaponType { get; set; } = default!;

    [JsonPropertyName("rankLevel")]
    public int RankLevel { get; set; }

    [JsonPropertyName("weaponBaseExp")]
    public int WeaponBaseExp { get; set; }

    [JsonPropertyName("skillAffix")]
    public IList<int> SkillAffix { get; set; } = default!;

    [JsonPropertyName("weaponProp")]
    public IList<WeaponProp> WeaponProp { get; set; } = default!;

    [JsonPropertyName("awakenTexture")]
    public string AwakenTexture { get; set; } = default!;

    [JsonPropertyName("awakenLightMapTexture")]
    public string AwakenLightMapTexture { get; set; } = default!;

    [JsonPropertyName("awakenIcon")]
    public string AwakenIcon { get; set; } = default!;

    [JsonPropertyName("weaponPromoteId")]
    public int WeaponPromoteId { get; set; }

    [JsonPropertyName("storyId")]
    public int StoryId { get; set; }

    [JsonPropertyName("awakenCosts")]
    public IList<int> AwakenCosts { get; set; } = default!;

    [JsonPropertyName("gachaCardNameHashSuffix")]
    public HashSuffix GachaCardNameHashSuffix { get; set; }

    [JsonPropertyName("gachaCardNameHashPre")]
    public HashPre GachaCardNameHashPre { get; set; }

    [JsonPropertyName("destroyRule")]
    public string DestroyRule { get; set; } = default!;

    [JsonPropertyName("destroyReturnMaterial")]
    public IList<int> DestroyReturnMaterial { get; set; } = default!;

    [JsonPropertyName("destroyReturnMaterialCount")]
    public IList<int> DestroyReturnMaterialCount { get; set; } = default!;

    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("nameTextMapHash")]
    public Text NameTextMapHash { get; set; }

    [JsonPropertyName("descTextMapHash")]
    public Text DescTextMapHash { get; set; }

    [JsonPropertyName("icon")]
    public string Icon { get; set; } = default!;

    [JsonPropertyName("itemType")]
    public string ItemType { get; set; } = default!;

    [JsonPropertyName("weight")]
    public int Weight { get; set; }

    [JsonPropertyName("rank")]
    public int Rank { get; set; }

    [JsonPropertyName("gadgetId")]
    public int GadgetId { get; set; }

    [JsonPropertyName("initialLockState")]
    public int? InitialLockState { get; set; }

    [JsonPropertyName("awakenMaterial")]
    public int? AwakenMaterial { get; set; }

    [JsonPropertyName("enhanceRule")]
    public int? EnhanceRule { get; set; }

    [JsonPropertyName("unRotate")]
    public bool? UnRotate { get; set; }
}
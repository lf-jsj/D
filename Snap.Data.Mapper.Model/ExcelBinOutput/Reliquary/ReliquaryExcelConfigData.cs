namespace Snap.Data.Mapper.Model.ExcelBinOutput.Reliquary;

public class ReliquaryExcelConfigData : DataObject
{
    [JsonPropertyName("equipType")]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public EquipType EquipType { get; set; } = default!;

    [JsonPropertyName("showPic")]
    public string ShowPic { get; set; } = default!;

    [JsonPropertyName("rankLevel")]
    public int RankLevel { get; set; }

    [JsonPropertyName("mainPropDepotId")]
    public int MainPropDepotId { get; set; }

    [JsonPropertyName("appendPropDepotId")]
    public int AppendPropDepotId { get; set; }

    [JsonPropertyName("addPropLevels")]
    public IList<int> AddPropLevels { get; set; } = default!;

    [JsonPropertyName("baseConvExp")]
    public int BaseConvExp { get; set; }

    [JsonPropertyName("maxLevel")]
    public int MaxLevel { get; set; }

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
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public ItemType ItemType { get; set; } = default!;

    [JsonPropertyName("weight")]
    public int Weight { get; set; }

    [JsonPropertyName("rank")]
    public int Rank { get; set; }

    [JsonPropertyName("gadgetId")]
    public int GadgetId { get; set; }

    [JsonPropertyName("appendPropNum")]
    public int? AppendPropNum { get; set; }

    [JsonPropertyName("setId")]
    public int? SetId { get; set; }

    [JsonPropertyName("storyId")]
    public int? StoryId { get; set; }

    [JsonPropertyName("destroyRule")]
    public string DestroyRule { get; set; } = default!;

    [JsonPropertyName("dropable")]
    public bool? Dropable { get; set; }
}

public enum EquipType
{
    EQUIP_NONE = 0,
    EQUIP_BRACER = 1,
    EQUIP_NECKLACE = 2,
    EQUIP_SHOES = 3,
    EQUIP_RING = 4,
    EQUIP_DRESS = 5,
    EQUIP_WEAPON = 6,
}
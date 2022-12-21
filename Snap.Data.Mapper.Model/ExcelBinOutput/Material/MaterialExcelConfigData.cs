namespace Snap.Data.Mapper.Model.ExcelBinOutput.Material;

public class MaterialExcelConfigData : IndexableDataObject
{
    [JsonPropertyName("interactionTitleTextMapHash")]
    public Text InteractionTitleTextMapHash { get; set; }

    [JsonPropertyName("noFirstGetHint")]
    public bool NoFirstGetHint { get; set; }

    [JsonPropertyName("itemUse")]
    public IList<UseOpUseParam> ItemUse { get; set; } = default!;

    [JsonPropertyName("rankLevel")]
    public int RankLevel { get; set; }

    [JsonPropertyName("effectDescTextMapHash")]
    public Text EffectDescTextMapHash { get; set; }

    [JsonPropertyName("specialDescTextMapHash")]
    public Text SpecialDescTextMapHash { get; set; }

    [JsonPropertyName("typeDescTextMapHash")]
    public Text TypeDescTextMapHash { get; set; }

    [JsonPropertyName("effectIcon")]
    public string EffectIcon { get; set; } = default!;

    [JsonPropertyName("effectName")]
    public string EffectName { get; set; } = default!;

    [JsonPropertyName("picPath")]
    public IList<string> PicPath { get; set; } = default!;

    [JsonPropertyName("satiationParams")]
    public IList<int> SatiationParams { get; set; } = default!;

    [JsonPropertyName("destroyReturnMaterial")]
    public IList<DataObject> DestroyReturnMaterial { get; set; } = default!;

    [JsonPropertyName("destroyReturnMaterialCount")]
    public IList<DataObject> DestroyReturnMaterialCount { get; set; } = default!;

    [JsonPropertyName("id")]
    [PrimaryKey]
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

    [JsonPropertyName("rank")]
    public int? Rank { get; set; }

    [JsonPropertyName("effectGadgetID")]
    public int? EffectGadgetID { get; set; }

    [JsonPropertyName("materialType")]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public MaterialType MaterialType { get; set; } = default!;

    [JsonPropertyName("gadgetId")]
    public int? GadgetId { get; set; }

    [JsonPropertyName("isForceGetHint")]
    public bool? IsForceGetHint { get; set; }

    [JsonPropertyName("stackLimit")]
    public int? StackLimit { get; set; }

    [JsonPropertyName("maxUseCount")]
    public int? MaxUseCount { get; set; }

    [JsonPropertyName("useOnGain")]
    public bool? UseOnGain { get; set; }

    [JsonPropertyName("useTarget")]
    public string UseTarget { get; set; } = default!;

    [JsonPropertyName("useLevel")]
    public int? UseLevel { get; set; }

    [JsonPropertyName("isSplitDrop")]
    public bool? IsSplitDrop { get; set; }

    [JsonPropertyName("destroyRule")]
    public string DestroyRule { get; set; } = default!;

    [JsonPropertyName("weight")]
    public int? Weight { get; set; }

    [JsonPropertyName("setID")]
    public int? SetID { get; set; }

    [JsonPropertyName("closeBagAfterUsed")]
    public bool? CloseBagAfterUsed { get; set; }

    [JsonPropertyName("foodQuality")]
    public string FoodQuality { get; set; } = default!;

    [JsonPropertyName("globalItemLimit")]
    public int? GlobalItemLimit { get; set; }

    [JsonPropertyName("cdTime")]
    public int? CdTime { get; set; }

    [JsonPropertyName("cdGroup")]
    public int? CdGroup { get; set; }

    [JsonPropertyName("playGainEffect")]
    public bool? PlayGainEffect { get; set; }

    [JsonPropertyName("isHidden")]
    public bool? IsHidden { get; set; }

    public override int GetIndex()
    {
        return Id;
    }
}

public enum MaterialType
{
    MATERIAL_NONE = 0,
    MATERIAL_FOOD = 1,
    MATERIAL_QUEST = 2,
    MATERIAL_EXCHANGE = 4,
    MATERIAL_CONSUME,
    MATERIAL_EXP_FRUIT,
    MATERIAL_AVATAR,
    MATERIAL_ADSORBATE,
    MATERIAL_CRICKET,
    MATERIAL_ELEM_CRYSTAL,
    MATERIAL_WEAPON_EXP_STONE,
    MATERIAL_CHEST,
    MATERIAL_RELIQUARY_MATERIAL,
    MATERIAL_AVATAR_MATERIAL,
    MATERIAL_NOTICE_ADD_HP,
    MATERIAL_SEA_LAMP,
    MATERIAL_SELECTABLE_CHEST,
    MATERIAL_FLYCLOAK,
    MATERIAL_NAMECARD,
    MATERIAL_TALENT,
    MATERIAL_WIDGET,
    MATERIAL_CHEST_BATCH_USE,
    MATERIAL_FAKE_ABSORBATE,
    MATERIAL_CONSUME_BATCH_USE,
    MATERIAL_WOOD,
    MATERIAL_FURNITURE_FORMULA = 27,
    MATERIAL_CHANNELLER_SLAB_BUFF,
    MATERIAL_FURNITURE_SUITE_FORMULA,
    MATERIAL_COSTUME,
    MATERIAL_HOME_SEED,
    MATERIAL_FISH_BAIT,
    MATERIAL_FISH_ROD,
    MATERIAL_SUMO_BUFF,//never appear
    MATERIAL_FIREWORKS,
    MATERIAL_BGM,
    MATERIAL_SPICE_FOOD,
    MATERIAL_ACTIVITY_ROBOT,
    MATERIAL_ACTIVITY_GEAR,
    MATERIAL_ACTIVITY_JIGSAW,
    MATERIAL_ARANARA,
    MATERIAL_GCG_CARD,
    MATERIAL_GCG_CARD_FACE, // 影幻卡面
    MATERIAL_GCG_CARD_BACK,
    MATERIAL_GCG_FIELD,
    MATERIAL_DESHRET_MANUAL,
    MATERIAL_RENAME_ITEM,
    MATERIAL_GCG_EXCHANGE_ITEM,
}
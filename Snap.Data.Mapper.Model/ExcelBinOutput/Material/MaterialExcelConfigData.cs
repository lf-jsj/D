namespace Snap.Data.Mapper.Model.ExcelBinOutput.Material;

public class MaterialExcelConfigData : DataObject
{
    [JsonPropertyName("interactionTitleTextMapHash")]
    public Text InteractionTitleTextMapHash { get; set; }

    [JsonPropertyName("noFirstGetHint")]
    public bool NoFirstGetHint { get; set; }

    [JsonPropertyName("itemUse")]
    public IList<ItemUse> ItemUse { get; set; } = default!;

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
    public int Id { get; set; }

    [JsonPropertyName("nameTextMapHash")]
    public Text NameTextMapHash { get; set; }

    [JsonPropertyName("descTextMapHash")]
    public Text DescTextMapHash { get; set; }

    [JsonPropertyName("icon")]
    public string Icon { get; set; } = default!;

    [JsonPropertyName("itemType")]
    public string ItemType { get; set; } = default!;

    [JsonPropertyName("rank")]
    public int Rank { get; set; }

    [JsonPropertyName("effectGadgetID")]
    public int? EffectGadgetID { get; set; }

    [JsonPropertyName("materialType")]
    public string MaterialType { get; set; } = default!;

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
}
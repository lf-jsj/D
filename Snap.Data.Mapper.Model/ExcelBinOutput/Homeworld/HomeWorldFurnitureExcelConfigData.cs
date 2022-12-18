namespace Snap.Data.Mapper.Model.ExcelBinOutput.Homeworld;

public class HomeWorldFurnitureExcelConfigData : DataObject
{
    [JsonPropertyName("furnitureGadgetID")]
    public IList<int> FurnitureGadgetID { get; set; } = default!;

    [JsonPropertyName("furnType")]
    public IList<int> FurnType { get; set; } = default!;

    [JsonPropertyName("surfaceType")]
    public string SurfaceType { get; set; } = default!;

    [JsonPropertyName("gridStyle")]
    public int GridStyle { get; set; }

    [JsonPropertyName("comfort")]
    public int Comfort { get; set; }

    [JsonPropertyName("stackLimit")]
    public int StackLimit { get; set; }

    [JsonPropertyName("cost")]
    public int Cost { get; set; }

    [JsonPropertyName("furnitureNameTextMapHash")]
    public int FurnitureNameTextMapHash { get; set; }

    [JsonPropertyName("itemIcon")]
    public string ItemIcon { get; set; } = default!;

    [JsonPropertyName("effectIcon")]
    public string EffectIcon { get; set; } = default!;

    [JsonPropertyName("rankLevel")]
    public int RankLevel { get; set; }

    [JsonPropertyName("jsonName")]
    public string JsonName { get; set; } = default!;

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

    [JsonPropertyName("MMBDNPGBGOG")]
    public string MMBDNPGBGOG { get; set; } = default!;

    [JsonPropertyName("isUnique")]
    public int? IsUnique { get; set; }

    [JsonPropertyName("isSpecialFurniture")]
    public int? IsSpecialFurniture { get; set; }

    [JsonPropertyName("height")]
    public float? Height { get; set; }

    [JsonPropertyName("GPABMPMJDEB")]
    public int? GPABMPMJDEB { get; set; }

    [JsonPropertyName("HHFEOBHEAII")]
    public float? HHFEOBHEAII { get; set; }

    [JsonPropertyName("MFFNHIOPPNH")]
    public int? MFFNHIOPPNH { get; set; }

    [JsonPropertyName("JEPHMCAEIHO")]
    public int? JEPHMCAEIHO { get; set; }

    [JsonPropertyName("BKGLOPMNFEH")]
    public float? BKGLOPMNFEH { get; set; }

    [JsonPropertyName("NGCNIGDJDJB")]
    public int? NGCNIGDJDJB { get; set; }

    [JsonPropertyName("roomSceneID")]
    public int? RoomSceneID { get; set; }

    [JsonPropertyName("pushTipsId")]
    public int? PushTipsId { get; set; }

    [JsonPropertyName("HABFGFJBNDA")]
    public string HABFGFJBNDA { get; set; } = default!;
}
namespace Snap.Data.Mapper.Model.ExcelBinOutput.Reliquary;

public class ReliquaryExcelConfigData : DataObject
{
    public EquipType EquipType { get; set; } = default!;

    public int RankLevel { get; set; }

    public int Id { get; set; }

    public Text NameTextMapHash { get; set; }

    public Text DescTextMapHash { get; set; }

    public string Icon { get; set; } = default!;

    public ItemType ItemType { get; set; } = default!;

    public int SetId { get; set; }
}

public enum ItemType
{
    ITEM_NONE = 0,
    ITEM_VIRTUAL = 1,
    ITEM_MATERIAL = 2,
    ITEM_RELIQUARY = 3,
    ITEM_WEAPON = 4,
    ITEM_DISPLAY = 5,
    ITEM_FURNITURE = 6,
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
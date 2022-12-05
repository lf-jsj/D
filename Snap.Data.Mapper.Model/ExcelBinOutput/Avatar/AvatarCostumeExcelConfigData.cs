namespace Snap.Data.Mapper.Model.ExcelBinOutput.Avatar;

public class AvatarCostumeExcelConfigData : DataObject
{
    public int SkinId { get; set; }

    public Text NameTextMapHash { get; set; }

    public Text DescTextMapHash { get; set; }

    public int CharacterId { get; set; }

    public int ItemId { get; set; }

    public string JsonName { get; set; } = default!;

    public string FrontIconName { get; set; } = default!;

    public string SideIconName { get; set; } = default!;

    public bool Hide { get; set; }

    public bool IsDefault { get; set; }
}
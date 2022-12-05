namespace Snap.Data.Mapper.Model.ExcelBinOutput.Material;

public class MaterialExcelConfigData : IndexableDataObject
{
    public int RankLevel { get; set; }

    public Text EffectDescTextMapHash { get; set; }

    public int Id { get; set; }

    public Text NameTextMapHash { get; set; }

    public Text DescTextMapHash { get; set; }

    public string Icon { get; set; } = default!;

    public override int GetIndex()
    {
        return Id;
    }
}
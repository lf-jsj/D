namespace Snap.Data.Mapper.Model.ExcelBinOutput.Reliquary;

public class ReliquarySetExcelConfigData : DataObject
{
    public int SetId { get; set; }

    public string SetIcon { get; set; } = default!;

    public IList<int> SetNeedNum { get; set; } = default!;

    public int EquipAffixId { get; set; }

    public IList<int> ContainsList { get; set; } = default!;

    public int IACBJOIIOMG { get; set; }

    public int? DisableFilter { get; set; }
}
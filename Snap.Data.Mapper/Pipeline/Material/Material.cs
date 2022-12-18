using Snap.Data.Mapper.Model.ExcelBinOutput;

namespace Snap.Data.Mapper.Pipeline.Material;

public class Material
{
    public int Id { get; set; }
    public int RankLevel { get; set; }
    public ItemType ItemType { get; set; }
    public string Name { get; set; } = default!;
    public string Description { get; set; } = default!;
    public string TypeDescription { get; set; } = default!;
    public string Icon { get; set; } = default!;
}
namespace Snap.Data.Mapper.Model.ExcelBinOutput.Material;

public class UseOpUseParam : DataObject
{
    public IList<string> UseParam { get; set; } = default!;

    public string? UseOp { get; set; }
}

namespace Snap.Data.Mapper.Model.ExcelBinOutput;

public class ParamListTriggerConfig : DataObject
{
    public string TriggerType { get; set; } = default!;

    public IList<string> ParamList { get; set; } = default!;
}

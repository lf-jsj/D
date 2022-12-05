namespace Snap.Data.Mapper.Model.Common.Param;

public class CondTypeParamList : DataObject
{
    public IList<int> ParamList { get; set; } = default!;

    public int CondType { get; set; } = default!;
}

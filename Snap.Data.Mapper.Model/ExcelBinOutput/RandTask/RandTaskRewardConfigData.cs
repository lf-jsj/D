namespace Snap.Data.Mapper.Model.ExcelBinOutput.RandTask;

public class RandTaskRewardConfigData : DataObject
{
    [JsonPropertyName("ID")]
    public int ID { get; set; }

    [JsonPropertyName("dropVec")]
    public IList<DropVec> DropVec { get; set; } = default!;
}
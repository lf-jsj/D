namespace Snap.Data.Mapper.Model.ExcelBinOutput.BattlePass;

public class Guide : DataObject
{
    [JsonPropertyName("param")]
    public IList<string> Param { get; set; } = default!;
}

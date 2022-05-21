using Snap.Data.Mapper.Model.Common;

namespace Snap.Data.Mapper.Model.ExcelBinOutput.RandomQuest;

public class RandomQuestTemplateExcelConfigData : DataObject
{
    [JsonPropertyName("mainId")]
    public int MainId { get; set; }

    [JsonPropertyName("elemList")]
    public IList<PoolIdName> ElemList { get; set; } = default!;
}
namespace Snap.Data.Mapper.Model.ExcelBinOutput.Quest;

public class QuestGlobalVarConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("defaultValue")]
    public int? DefaultValue { get; set; }
}
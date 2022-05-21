namespace Snap.Data.Mapper.Model.ExcelBinOutput.Quest;

public class QuestDialogDecoratorExcelConfigData : DataObject
{

    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("BILFFGHPFCK")]
    public string BILFFGHPFCK { get; set; } = default!;
}
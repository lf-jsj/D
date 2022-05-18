namespace Snap.Data.Mapper.Model.ExcelBinOutput.Tutorial;

public class TutorialExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("detailIdList")]
    public IList<int> DetailIdList { get; set; } = default!;

    [JsonPropertyName("pauseGame")]
    public bool? PauseGame { get; set; }
}
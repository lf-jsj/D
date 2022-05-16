namespace Snap.Data.Mapper.Model.ExcelBinOutput.Expedition;

public class ExpeditionActivityPreviewExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("questId")]
    public int QuestId { get; set; }

    [JsonPropertyName("OFCBJOPKNDA")]
    public int OFCBJOPKNDA { get; set; }

    [JsonPropertyName("CIAJGBMLICB")]
    public int CIAJGBMLICB { get; set; }
}


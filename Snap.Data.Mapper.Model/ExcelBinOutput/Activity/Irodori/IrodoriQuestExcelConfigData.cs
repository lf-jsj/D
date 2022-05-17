namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.Irodori;

public class IrodoriQuestExcelConfigData : DataObject
{
    [JsonPropertyName("Id")]
    public int Id { get; set; }

    [JsonPropertyName("questId")]
    public int QuestId { get; set; }

    [JsonPropertyName("PCFMCNAMKJG")]
    public IList<int> PCFMCNAMKJG { get; set; } = default!;

    [JsonPropertyName("openDay")]
    public int OpenDay { get; set; }

    [JsonPropertyName("KOBJNJBIKPC")]
    public Text KOBJNJBIKPC { get; set; }

    [JsonPropertyName("nameTextMapHash")]
    public Text NameTextMapHash { get; set; }

    [JsonPropertyName("descTextMapHash")]
    public Text DescTextMapHash { get; set; }

    [JsonPropertyName("ILBOKGOHBIH")]
    public IList<DataObject> ILBOKGOHBIH { get; set; } = default!;

    [JsonPropertyName("preQuestId")]
    public int? PreQuestId { get; set; }

    [JsonPropertyName("POELBNOOLMP")]
    public string POELBNOOLMP { get; set; } = default!;
}
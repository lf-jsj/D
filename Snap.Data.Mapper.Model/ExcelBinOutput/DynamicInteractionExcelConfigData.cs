namespace Snap.Data.Mapper.Model.ExcelBinOutput;

public class DynamicInteractionExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("PAEHKAANCFC")]
    public Text PAEHKAANCFC { get; set; }

    [JsonPropertyName("LBHHAMKFEFE")]
    public Text LBHHAMKFEFE { get; set; }

    [JsonPropertyName("OBFDKGPLNOA")]
    public string OBFDKGPLNOA { get; set; } = default!;

    [JsonPropertyName("EBOHJKNMBNG")]
    public Text EBOHJKNMBNG { get; set; }

    [JsonPropertyName("NABODAFIJAA")]
    public string NABODAFIJAA { get; set; } = default!;

    [JsonPropertyName("OMOJKAOKBBE")]
    public bool OMOJKAOKBBE { get; set; }
}

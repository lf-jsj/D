namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.BlessingScan;

public class BlessingScanTypeExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("typeId")]
    public int TypeId { get; set; }

    [JsonPropertyName("priority")]
    public int Priority { get; set; }

    [JsonPropertyName("upPoolId")]
    public IList<int> UpPoolId { get; set; } = default!;

    [JsonPropertyName("dailyScanLimit")]
    public int DailyScanLimit { get; set; }

    [JsonPropertyName("typeNameTextMapHash")]
    public Text TypeNameTextMapHash { get; set; }

    [JsonPropertyName("typeNameWithColorTextMapHash")]
    public Text TypeNameWithColorTextMapHash { get; set; }
}

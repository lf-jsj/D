namespace Snap.Data.Mapper.Model.ExcelBinOutput.Blossom;

public class BlossomChestExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("chestGadgetId")]
    public int ChestGadgetId { get; set; }

    [JsonPropertyName("worldResin")]
    public int WorldResin { get; set; }

    [JsonPropertyName("resin")]
    public int Resin { get; set; }

    [JsonPropertyName("refreshType")]
    public string RefreshType { get; set; } = default!;

    [JsonPropertyName("clientShowType")]
    public string ClientShowType { get; set; } = default!;
}

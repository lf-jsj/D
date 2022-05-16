namespace Snap.Data.Mapper.Model.ExcelBinOutput.City;

public class ConsumeItem : DataObject
{
    [JsonPropertyName("itemId")]
    public int? ItemId { get; set; }

    [JsonPropertyName("itemNum")]
    public int? ItemNum { get; set; }
}


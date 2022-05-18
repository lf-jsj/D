namespace Snap.Data.Mapper.Model.ExcelBinOutput.Product;

public class ContentVec : DataObject
{
    [JsonPropertyName("materialId")]
    public int MaterialId { get; set; }

    [JsonPropertyName("materialNum")]
    public int MaterialNum { get; set; }
}

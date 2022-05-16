namespace Snap.Data.Mapper.Model.ExcelBinOutput.Book;
public class BooksCodexExcelConfigData : DataObject
{
    [JsonPropertyName("Id")]
    public int Id { get; set; }

    [JsonPropertyName("materialId")]
    public int MaterialId { get; set; }

    [JsonPropertyName("SortOrder")]
    public int SortOrder { get; set; }

    [JsonPropertyName("isDisuse")]
    public bool? IsDisuse { get; set; }
}

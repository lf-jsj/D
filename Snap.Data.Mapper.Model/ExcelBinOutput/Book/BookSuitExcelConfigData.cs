namespace Snap.Data.Mapper.Model.ExcelBinOutput.Book;

public class BookSuitExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("suitNameTextMapHash")]
    public Text SuitNameTextMapHash { get; set; }
}
namespace Snap.Data.Mapper.Model.ExcelBinOutput.Book;

public class BookSuitExcelConfigData : IndexableDataObject, INamed
{
    [JsonPropertyName("id")]
    [PrimaryKey]
    public int Id { get; set; }

    [JsonPropertyName("suitNameTextMapHash")]
    public Text SuitNameTextMapHash { get; set; }

    public override int GetIndex()
    {
        return Id;
    }

    public string GetName()
    {
        return SuitNameTextMapHash.Value;
    }
}
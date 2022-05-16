namespace Snap.Data.Mapper.Model.ExcelBinOutput.Homeworld;

public class HomeworldNPCExcelDataData : DataObject
{
    [JsonPropertyName("AvatarID")]
    public int AvatarID { get; set; }

    [JsonPropertyName("ID")]
    public int ID { get; set; }

    [JsonPropertyName("FurnitureID")]
    public int FurnitureID { get; set; }

    [JsonPropertyName("PJAPBPDMLAE")]
    public int PJAPBPDMLAE { get; set; }

    [JsonPropertyName("MJJBGINPDEE")]
    public IList<int> MJJBGINPDEE { get; set; } = default!;
}
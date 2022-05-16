namespace Snap.Data.Mapper.Model.ExcelBinOutput.Bored;
public class MonsterConfigVec : DataObject
{
    [JsonPropertyName("weight")]
    public int Weight { get; set; }

    [JsonPropertyName("id")]
    public int Id { get; set; }
}
namespace Snap.Data.Mapper.Model.ExcelBinOutput.Avatar;

public class AvatarLevelExcelConfigData : DataObject
{
    [JsonPropertyName("level")]
    public int Level { get; set; }

    [JsonPropertyName("exp")]
    public int Exp { get; set; }
}
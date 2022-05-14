namespace Snap.Data.Mapper.Model.ExcelBinOutput.Avatar;

public class AvatarFettersLevelExcelConfigData : DataObject
{
    [JsonPropertyName("fetterLevel")]
    public int FetterLevel { get; set; }

    [JsonPropertyName("needExp")]
    public int NeedExp { get; set; }
}

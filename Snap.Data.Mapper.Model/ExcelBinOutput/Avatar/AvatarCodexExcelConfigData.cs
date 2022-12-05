namespace Snap.Data.Mapper.Model.ExcelBinOutput.Avatar;
public class AvatarCodexExcelConfigData : DataObject
{
    public int SortId { get; set; }

    public int SortFactor { get; set; }

    public int AvatarId { get; set; }

    [JsonConverter(typeof(ParsedDateTimeConverter))]
    public DateTime BeginTime { get; set; }

    public bool HideWhenDontHave { get; set; }
}
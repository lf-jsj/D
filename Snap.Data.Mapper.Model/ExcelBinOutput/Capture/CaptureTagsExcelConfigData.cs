namespace Snap.Data.Mapper.Model.ExcelBinOutput.Capture;

public class CaptureTagsExcelConfigData : DataObject
{
    [JsonPropertyName("ILNJGLHEEPJ")]
    public int ILNJGLHEEPJ { get; set; }

    [JsonPropertyName("GDMOONNPNGD")]
    public string GDMOONNPNGD { get; set; } = default!;

    [JsonPropertyName("itemLimitType")]
    public string ItemLimitType { get; set; } = default!;
}
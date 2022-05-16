namespace Snap.Data.Mapper.Model.ExcelBinOutput.FeatureTag;

public class FeatureTagGroupExcelConfigData : DataObject
{
    [JsonPropertyName("groupID")]
    public int GroupID { get; set; }

    [JsonPropertyName("tagIDs")]
    public IList<int> TagIDs { get; set; } = default!;
}
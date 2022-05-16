namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.DragonSpine;

public class DragonSpineEnhanceExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("descTextMapHash")]
    public Text DescTextMapHash { get; set; }

    [JsonPropertyName("activityAbilityGroupId")]
    public int? ActivityAbilityGroupId { get; set; }

    [JsonPropertyName("process")]
    public int? Process { get; set; }
}

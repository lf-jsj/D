namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.BuoyantCombat;
public class BuoyantCombatExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("activityId")]
    public int ActivityId { get; set; }

    [JsonPropertyName("rewardPreviewId")]
    public int RewardPreviewId { get; set; }

    [JsonPropertyName("pushTipsId")]
    public int PushTipsId { get; set; }

    [JsonPropertyName("HCEBDAPDFIH")]
    public IList<int> HCEBDAPDFIH { get; set; } = default!;
}

namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.TrialAvatar;

public class TrialAvatarTemplateExcelConfigData : DataObject
{
    [JsonPropertyName("TrialAvatarLevel")]
    public int TrialAvatarLevel { get; set; }

    [JsonPropertyName("TrialReliquaryList")]
    public IList<int> TrialReliquaryList { get; set; } = default!;

    [JsonPropertyName("TrialTalentList")]
    public IList<DataObject> TrialTalentList { get; set; } = default!;

    [JsonPropertyName("TrialAvatarSkillLevel")]
    public int TrialAvatarSkillLevel { get; set; }
}
namespace Snap.Data.Mapper.Model.ExcelBinOutput.Avatar;

public class InherentProudSkillOpen : DataObject
{
    [JsonPropertyName("proudSkillGroupId")]
    public int? ProudSkillGroupId { get; set; }

    [JsonPropertyName("needAvatarPromoteLevel")]
    public int? NeedAvatarPromoteLevel { get; set; }
}

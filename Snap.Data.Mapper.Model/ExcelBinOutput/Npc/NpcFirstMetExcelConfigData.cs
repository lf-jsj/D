namespace Snap.Data.Mapper.Model.ExcelBinOutput.Npc;

public class NpcFirstMetExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("subQuestIdList")]
    public IList<int> SubQuestIdList { get; set; } = default!;

    [JsonPropertyName("avatarID")]
    public int AvatarID { get; set; }

    [JsonPropertyName("avatarDescriptionTextMapHash")]
    public Text AvatarDescriptionTextMapHash { get; set; }
}

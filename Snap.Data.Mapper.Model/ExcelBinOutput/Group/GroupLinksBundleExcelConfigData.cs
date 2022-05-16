namespace Snap.Data.Mapper.Model.ExcelBinOutput.Group;
public class GroupLinksBundleExcelConfigData : DataObject
{
    [JsonPropertyName("Id")]
    public int Id { get; set; }

    [JsonPropertyName("groupList")]
    public IList<int> GroupList { get; set; } = default!;

    [JsonPropertyName("OMHBLDGPEBE")]
    public int OMHBLDGPEBE { get; set; }

    [JsonPropertyName("FNIHLGLMPGE")]
    public int FNIHLGLMPGE { get; set; }

    [JsonPropertyName("rewardType")]
    public string RewardType { get; set; } = default!;

    [JsonPropertyName("rewardId")]
    public int RewardId { get; set; }

    [JsonPropertyName("reviseLevel")]
    public int ReviseLevel { get; set; }

    [JsonPropertyName("icon")]
    public string Icon { get; set; } = default!;

    [JsonPropertyName("nameTextMapHash")]
    public Text NameTextMapHash { get; set; }

    [JsonPropertyName("NJGKLPKKDOC")]
    public Text NJGKLPKKDOC { get; set; }

    [JsonPropertyName("DONPLFEIJAO")]
    public int DONPLFEIJAO { get; set; }

    [JsonPropertyName("DEGLIECIIID")]
    public bool DEGLIECIIID { get; set; }

    [JsonPropertyName("LNEFHKNMJFH")]
    public bool LNEFHKNMJFH { get; set; }

    [JsonPropertyName("MMBAAODFKAE")]
    public int? MMBAAODFKAE { get; set; }

    [JsonPropertyName("playType")]
    public string PlayType { get; set; } = default!;
}

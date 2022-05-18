namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.Roguelike;

public class RoguelikeShikigamiExcelConfigData : DataObject
{
    [JsonPropertyName("PJEKPGKOJNA")]
    public int PJEKPGKOJNA { get; set; }

    [JsonPropertyName("groupId")]
    public int GroupId { get; set; }

    [JsonPropertyName("unlockCond")]
    public IList<ParamType> UnlockCond { get; set; } = default!;

    [JsonPropertyName("LKKFNMPFBEH")]
    public Text LKKFNMPFBEH { get; set; }

    [JsonPropertyName("PKFGFMJGMPB")]
    public Text PKFGFMJGMPB { get; set; }

    [JsonPropertyName("level")]
    public int? Level { get; set; }

    [JsonPropertyName("EBGCGKEMBLL")]
    public int? EBGCGKEMBLL { get; set; }

    [JsonPropertyName("HGOBNOICJNF")]
    public int? HGOBNOICJNF { get; set; }
}
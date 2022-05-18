namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.Michiae;

public class MichiaeBattleSkillExcelConfigData : DataObject
{
    [JsonPropertyName("FOKBDKFGFGF")]
    public int FOKBDKFGFGF { get; set; }

    [JsonPropertyName("HJAAOLIHCMD")]
    public Text HJAAOLIHCMD { get; set; }

    [JsonPropertyName("PINPKNAJILI")]
    public Text PINPKNAJILI { get; set; }

    [JsonPropertyName("PILMMPGIMEJ")]
    public IList<string> PILMMPGIMEJ { get; set; } = default!;

    [JsonPropertyName("iconPath")]
    public string IconPath { get; set; } = default!;

    [JsonPropertyName("materialId")]
    public int MaterialId { get; set; }

    [JsonPropertyName("materialNum")]
    public int MaterialNum { get; set; }

    [JsonPropertyName("HDKGACJNFMH")]
    public string HDKGACJNFMH { get; set; } = default!;
}
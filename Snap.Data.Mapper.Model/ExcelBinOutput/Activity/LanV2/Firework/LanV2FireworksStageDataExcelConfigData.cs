namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.LanV2.Firework;

public class LanV2FireworksStageDataExcelConfigData : DataObject
{
    [JsonPropertyName("stageId")]
    public int StageId { get; set; }

    [JsonPropertyName("openDay")]
    public int OpenDay { get; set; }

    [JsonPropertyName("challengeIdList")]
    public IList<int> ChallengeIdList { get; set; } = default!;

    [JsonPropertyName("tabNameTextMapHash")]
    public Text TabNameTextMapHash { get; set; }

    [JsonPropertyName("JBMDLNOPANB")]
    public Text JBMDLNOPANB { get; set; }

    [JsonPropertyName("OEAAPEIFHAM")]
    public IList<int> OEAAPEIFHAM { get; set; } = default!;

    [JsonPropertyName("EGHENKKAICP")]
    public int EGHENKKAICP { get; set; }
}
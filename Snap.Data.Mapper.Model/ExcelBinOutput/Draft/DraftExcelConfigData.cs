namespace Snap.Data.Mapper.Model.ExcelBinOutput.Draft;

public class DraftExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("transferConfig")]
    public IList<GroupIdConfigId> TransferConfig { get; set; } = default!;

    [JsonPropertyName("sceneId")]
    public int SceneId { get; set; }

    [JsonPropertyName("exec")]
    public string Exec { get; set; } = default!;

    [JsonPropertyName("param")]
    public int Param { get; set; }

    [JsonPropertyName("enableMp")]
    public bool EnableMp { get; set; }

    [JsonPropertyName("isNeedAllAgree")]
    public bool IsNeedAllAgree { get; set; }

    [JsonPropertyName("confirmCountDown")]
    public int ConfirmCountDown { get; set; }

    [JsonPropertyName("minPlayerCount")]
    public int MinPlayerCount { get; set; }

    [JsonPropertyName("isNeedTwiceConfirm")]
    public bool IsNeedTwiceConfirm { get; set; }

    [JsonPropertyName("twiceConfirmCountDown")]
    public int TwiceConfirmCountDown { get; set; }
}

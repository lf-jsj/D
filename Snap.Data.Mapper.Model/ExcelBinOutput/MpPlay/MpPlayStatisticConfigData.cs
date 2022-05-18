namespace Snap.Data.Mapper.Model.ExcelBinOutput.MpPlay;

public class MpPlayStatisticConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("MpPlayId")]
    public int MpPlayId { get; set; }

    [JsonPropertyName("settleType")]
    public string SettleType { get; set; } = default!;

    [JsonPropertyName("settleParam")]
    public IList<string> SettleParam { get; set; } = default!;

    [JsonPropertyName("clientSyncType")]
    public string ClientSyncType { get; set; } = default!;

    [JsonPropertyName("clientSyncParam")]
    public string ClientSyncParam { get; set; } = default!;

    [JsonPropertyName("mpchallengetitleTextMapHash")]
    public Text MpchallengetitleTextMapHash { get; set; }

    [JsonPropertyName("mpchallengeTextMapHash")]
    public Text MpchallengeTextMapHash { get; set; }

    [JsonPropertyName("mpchallengestyleTextMapHash")]
    public Text MpchallengestyleTextMapHash { get; set; }

    [JsonPropertyName("image")]
    public string Image { get; set; } = default!;

    [JsonPropertyName("priority")]
    public int Priority { get; set; }
}
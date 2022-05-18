namespace Snap.Data.Mapper.Model.ExcelBinOutput.MpPlay;

public class MpPlayMatchExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("playType")]
    public string PlayType { get; set; } = default!;

    [JsonPropertyName("playNameTextMapHash")]
    public Text PlayNameTextMapHash { get; set; }

    [JsonPropertyName("playDescTextMapHash")]
    public Text PlayDescTextMapHash { get; set; }

    [JsonPropertyName("isAutoMatch")]
    public bool IsAutoMatch { get; set; }

    [JsonPropertyName("minPlayers")]
    public int MinPlayers { get; set; }

    [JsonPropertyName("maxPlayers")]
    public int MaxPlayers { get; set; }

    [JsonPropertyName("isAllowInAnyTime")]
    public bool IsAllowInAnyTime { get; set; }

    [JsonPropertyName("isMatchNecessary")]
    public bool IsMatchNecessary { get; set; }

    [JsonPropertyName("settleType")]
    public string SettleType { get; set; } = default!;

    [JsonPropertyName("buffList")]
    public IList<int> BuffList { get; set; } = default!;

    [JsonPropertyName("pushTipsId")]
    public int PushTipsId { get; set; }

    [JsonPropertyName("bgImage")]
    public string BgImage { get; set; } = default!;

    [JsonPropertyName("ICHLLMNAPOK")]
    public bool? ICHLLMNAPOK { get; set; }

    [JsonPropertyName("GNMHKLNMPIP")]
    public int? GNMHKLNMPIP { get; set; }
}
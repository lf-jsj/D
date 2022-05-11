namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.Sumo;

public class ActivitySumoSwitchSkillExcelConfigData : DataObject
{

    [JsonPropertyName("Id")]
    public int Id { get; set; }

    [JsonPropertyName("FGJONOJPIBD")]
    public string FGJONOJPIBD { get; set; } = default!;

    [JsonPropertyName("titleTextMapHash")]
    public Text TitleTextMapHash { get; set; }

    [JsonPropertyName("descTextMapHash")]
    public Text DescTextMapHash { get; set; }

    [JsonPropertyName("descParam")]
    [DataArray(Length = 8)]
    public IList<string> DescParam { get; set; } = default!;

    [JsonPropertyName("AKDJKMBLKEA")]
    public Text AKDJKMBLKEA { get; set; }

    [JsonPropertyName("CKIDKHOIEOP")]
    public int CKIDKHOIEOP { get; set; }
}
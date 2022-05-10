using Snap.Data.Mapper.Converter.ObjectModel;

namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.CrystalLink;

public class ActivityCrystalLinkDifficultyExcelConfigData : DataObject
{
    [JsonPropertyName("difficultyId")]
    public int DifficultyId { get; set; }

    [JsonPropertyName("scheduleId")]
    public int ScheduleId { get; set; }

    [JsonPropertyName("EAANBLBBFEE")]
    public int EAANBLBBFEE { get; set; }

    [JsonPropertyName("scoreRatio")]
    public double ScoreRatio { get; set; }

    [JsonPropertyName("descTextMapHash")]
    public Text DescTextMapHash { get; set; }

    [JsonPropertyName("difficulty")]
    public string Difficulty { get; set; } = string.Empty;
}


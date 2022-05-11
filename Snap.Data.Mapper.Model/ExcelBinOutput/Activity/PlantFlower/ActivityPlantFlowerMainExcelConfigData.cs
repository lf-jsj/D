namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.PlantFlower;

public class ActivityPlantFlowerMainExcelConfigData : DataObject
{

    [JsonPropertyName("scheduleId")]
    public int ScheduleId { get; set; }

    [JsonPropertyName("PEMMIMJBBON")]
    public IList<int> PEMMIMJBBON { get; set; } = default!;

    [JsonPropertyName("CJMJHLNBFMF")]
    public IList<int> CJMJHLNBFMF { get; set; } = default!;

    [JsonPropertyName("MOCJELMKFFA")]
    public int MOCJELMKFFA { get; set; }

    [JsonPropertyName("rewardPreviewId")]
    public int RewardPreviewId { get; set; }

    [JsonPropertyName("IAPJACIHJOD")]
    public int IAPJACIHJOD { get; set; }

    [JsonPropertyName("KLHLGGDOMPN")]
    public IList<int> KLHLGGDOMPN { get; set; } = default!;

    [JsonPropertyName("openQuestId")]
    public int OpenQuestId { get; set; }

    [JsonPropertyName("JDMGBKCIILN")]
    public int JDMGBKCIILN { get; set; }

    [JsonPropertyName("dailyConfigIdList")]
    public IList<int> DailyConfigIdList { get; set; } = default!;
}
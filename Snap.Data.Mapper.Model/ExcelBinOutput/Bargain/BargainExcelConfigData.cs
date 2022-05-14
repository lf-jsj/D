namespace Snap.Data.Mapper.Model.ExcelBinOutput.Bargain;
public class BargainExcelConfigData : DataObject
{
    [JsonPropertyName("questId")]
    public int QuestId { get; set; }

    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("dialogId")]
    public IList<int> DialogId { get; set; } = default!;

    [JsonPropertyName("expectedValue")]
    public IList<int> ExpectedValue { get; set; } = default!;

    [JsonPropertyName("space")]
    public int Space { get; set; }

    [JsonPropertyName("successTalkId")]
    public IList<int> SuccessTalkId { get; set; } = default!;

    [JsonPropertyName("failTalkId")]
    public int FailTalkId { get; set; }

    [JsonPropertyName("moodNpcId")]
    public int MoodNpcId { get; set; }

    [JsonPropertyName("moodUpperLimit")]
    public int MoodUpperLimit { get; set; }

    [JsonPropertyName("randomMood")]
    public IList<int> RandomMood { get; set; } = default!;

    [JsonPropertyName("moodAlertLimit")]
    public int MoodAlertLimit { get; set; }

    [JsonPropertyName("moodLowLimit")]
    public int MoodLowLimit { get; set; }

    [JsonPropertyName("moodLowLimitTextTextMapHash")]
    public Text MoodLowLimitTextTextMapHash { get; set; }

    [JsonPropertyName("singleFailMoodDeduction")]
    public int SingleFailMoodDeduction { get; set; }

    [JsonPropertyName("singleFailTalkId")]
    public IList<int> SingleFailTalkId { get; set; } = default!;

    [JsonPropertyName("deleteItem")]
    public bool DeleteItem { get; set; }

    [JsonPropertyName("itemId")]
    public int ItemId { get; set; }

    [JsonPropertyName("titleTextTextMapHash")]
    public Text TitleTextTextMapHash { get; set; }

    [JsonPropertyName("affordTextTextMapHash")]
    public Text AffordTextTextMapHash { get; set; }

    [JsonPropertyName("storageTextTextMapHash")]
    public Text StorageTextTextMapHash { get; set; }

    [JsonPropertyName("moodHintTextTextMapHash")]
    public Text MoodHintTextTextMapHash { get; set; }

    [JsonPropertyName("moodDescTextTextMapHash")]
    public Text MoodDescTextTextMapHash { get; set; }
}

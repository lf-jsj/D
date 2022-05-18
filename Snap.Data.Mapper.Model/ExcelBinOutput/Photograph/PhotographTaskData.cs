namespace Snap.Data.Mapper.Model.ExcelBinOutput.Photograph;

public class PhotographTaskData : DataObject
{
    [JsonPropertyName("taskId")]
    public int TaskId { get; set; }

    [JsonPropertyName("sceneID")]
    public int SceneID { get; set; }

    [JsonPropertyName("centerX")]
    public double CenterX { get; set; }

    [JsonPropertyName("centerY")]
    public double CenterY { get; set; }

    [JsonPropertyName("centerZ")]
    public double CenterZ { get; set; }

    [JsonPropertyName("radius")]
    public double Radius { get; set; }

    [JsonPropertyName("targetGadgetID")]
    public IList<string> TargetGadgetID { get; set; } = default!;

    [JsonPropertyName("endTime")]
    public double EndTime { get; set; }

    [JsonPropertyName("questid")]
    public int Questid { get; set; }

    [JsonPropertyName("finishTipsTextMapHash")]
    public Text FinishTipsTextMapHash { get; set; }

    [JsonPropertyName("startTipsTextMapHash")]
    public Text StartTipsTextMapHash { get; set; }

    [JsonPropertyName("startTime")]
    public double? StartTime { get; set; }

    [JsonPropertyName("INDFHBBIJMB")]
    public string INDFHBBIJMB { get; set; } = default!;
}
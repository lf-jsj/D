using Snap.Data.Mapper.Model.Common.Param;

namespace Snap.Data.Mapper.Model.ExcelBinOutput.Photograph;

public class PhotographPosenameExcelConfigData : DataObject
{
    [JsonPropertyName("poseFile")]
    public string PoseFile { get; set; } = default!;

    [JsonPropertyName("poseIcon")]
    public string PoseIcon { get; set; } = default!;

    [JsonPropertyName("poseNameTextMapHash")]
    public Text PoseNameTextMapHash { get; set; }

    [JsonPropertyName("unlockDescTextMapHash")]
    public Text UnlockDescTextMapHash { get; set; }

    [JsonPropertyName("fetterId")]
    public int FetterId { get; set; }

    [JsonPropertyName("avatarId")]
    public int AvatarId { get; set; }

    [JsonPropertyName("openConds")]
    public IList<CondTypeParamList> OpenConds { get; set; } = default!;

    [JsonPropertyName("finishConds")]
    public IList<DataObject> FinishConds { get; set; } = default!;

    [JsonPropertyName("animatorstateId")]
    public int? AnimatorstateId { get; set; }
}
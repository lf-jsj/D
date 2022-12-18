namespace Snap.Data.Mapper.Model.ExcelBinOutput;

public class GalleryExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("type")]
    public string Type { get; set; } = default!;

    [JsonPropertyName("param")]
    public IList<string> Param { get; set; } = default!;

    [JsonPropertyName("canInterruptByClient")]
    public bool CanInterruptByClient { get; set; }

    [JsonPropertyName("groupId")]
    public IList<int> GroupId { get; set; } = default!;

    [JsonPropertyName("COBHGPOJNEP")]
    public int COBHGPOJNEP { get; set; }

    [JsonPropertyName("abilityGroup")]
    public string AbilityGroup { get; set; } = default!;

    [JsonPropertyName("abilityGroupList")]
    public IList<string> AbilityGroupList { get; set; } = default!;

    [JsonPropertyName("limitRegion")]
    public string LimitRegion { get; set; } = default!;

    [JsonPropertyName("centerPosList")]
    public IList<float> CenterPosList { get; set; } = default!;

    [JsonPropertyName("duration")]
    public int Duration { get; set; }

    [JsonPropertyName("nameTextMapHash")]
    public Text NameTextMapHash { get; set; }

    [JsonPropertyName("descTextMapHash")]
    public Text DescTextMapHash { get; set; }

    [JsonPropertyName("galleryNameTextMapHash")]
    public Text GalleryNameTextMapHash { get; set; }

    [JsonPropertyName("galleryMSGTextMapHash")]
    public Text GalleryMSGTextMapHash { get; set; }

    [JsonPropertyName("pic")]
    public string Pic { get; set; } = default!;

    [JsonPropertyName("targetTextMapHash")]
    public Text TargetTextMapHash { get; set; }

    [JsonPropertyName("startAudioValues")]
    public string StartAudioValues { get; set; } = default!;

    [JsonPropertyName("endAudioValues")]
    public string EndAudioValues { get; set; } = default!;

    [JsonPropertyName("selectableAbilityGroups")]
    public IList<string> SelectableAbilityGroups { get; set; } = default!;

    [JsonPropertyName("CIBDIABELKJ")]
    public IList<string> CIBDIABELKJ { get; set; } = default!;

    [JsonPropertyName("PBIGMHNDANO")]
    public IList<DataObject> PBIGMHNDANO { get; set; } = default!;

    [JsonPropertyName("isEnableSinglePrepare")]
    public bool? IsEnableSinglePrepare { get; set; }

    [JsonPropertyName("singlePrepareTime")]
    public int? SinglePrepareTime { get; set; }

    [JsonPropertyName("sceneId")]
    public int? SceneId { get; set; }

    [JsonPropertyName("controlGroupId")]
    public int? ControlGroupId { get; set; }

    [JsonPropertyName("revivePointGroupId")]
    public int? RevivePointGroupId { get; set; }

    [JsonPropertyName("revivePointConfigId")]
    public int? RevivePointConfigId { get; set; }

    [JsonPropertyName("centerRadius")]
    public int? CenterRadius { get; set; }

    [JsonPropertyName("PBBOAGFBFIL")]
    public int? PBBOAGFBFIL { get; set; }
}

namespace Snap.Data.Mapper.Model.ExcelBinOutput.Gadget;

public class GadgetExcelConfigData : DataObject
{
    [JsonPropertyName("type")]
    public string Type { get; set; } = default!;

    [JsonPropertyName("jsonName")]
    public string JsonName { get; set; } = default!;

    [JsonPropertyName("tags")]
    public IList<string> Tags { get; set; } = default!;

    [JsonPropertyName("itemJsonName")]
    public string ItemJsonName { get; set; } = default!;

    [JsonPropertyName("inteeIconName")]
    public string InteeIconName { get; set; } = default!;

    [JsonPropertyName("interactNameTextMapHash")]
    public Text InteractNameTextMapHash { get; set; }

    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("nameTextMapHash")]
    public Text NameTextMapHash { get; set; }

    [JsonPropertyName("prefabPathHashSuffix")]
    public HashSuffix PrefabPathHashSuffix { get; set; }

    [JsonPropertyName("prefabPathHashPre")]
    public HashPre PrefabPathHashPre { get; set; }

    [JsonPropertyName("campID")]
    public int CampID { get; set; }

    [JsonPropertyName("LODPatternName")]
    public string LODPatternName { get; set; } = default!;

    [JsonPropertyName("hasMove")]
    public bool? HasMove { get; set; }

    [JsonPropertyName("hasAudio")]
    public bool? HasAudio { get; set; }

    [JsonPropertyName("isInteractive")]
    public bool? IsInteractive { get; set; }

    [JsonPropertyName("visionLevel")]
    public string VisionLevel { get; set; } = default!;

    [JsonPropertyName("mpPropID")]
    public int? MpPropID { get; set; }

    [JsonPropertyName("isEquip")]
    public bool? IsEquip { get; set; }

    [JsonPropertyName("itemPrefabPathHashSuffix")]
    public HashSuffix? ItemPrefabPathHashSuffix { get; set; }

    [JsonPropertyName("itemPrefabPathHashPre")]
    public HashPre? ItemPrefabPathHashPre { get; set; }

    [JsonPropertyName("landSoundID")]
    public int? LandSoundID { get; set; }

    [JsonPropertyName("clientScriptHashSuffix")]
    public HashSuffix? ClientScriptHashSuffix { get; set; }

    [JsonPropertyName("clientScriptHashPre")]
    public HashPre? ClientScriptHashPre { get; set; }

    [JsonPropertyName("radarHintID")]
    public int? RadarHintID { get; set; }

    [JsonPropertyName("OKOBJFICINJ")]
    public bool? OKOBJFICINJ { get; set; }

    [JsonPropertyName("EOGKGKLLDAC")]
    public int? EOGKGKLLDAC { get; set; }

    [JsonPropertyName("prefabPathRemoteHashSuffix")]
    public HashSuffix? PrefabPathRemoteHashSuffix { get; set; }

    [JsonPropertyName("prefabPathRemoteHashPre")]
    public HashPre? PrefabPathRemoteHashPre { get; set; }

    [JsonPropertyName("controllerPathHashSuffix")]
    public HashSuffix? ControllerPathHashSuffix { get; set; }

    [JsonPropertyName("controllerPathHashPre")]
    public HashPre? ControllerPathHashPre { get; set; }
}



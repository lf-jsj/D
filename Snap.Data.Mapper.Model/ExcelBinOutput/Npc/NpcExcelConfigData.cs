namespace Snap.Data.Mapper.Model.ExcelBinOutput.Npc;

public class NpcExcelConfigData : DataObject
{

    [JsonPropertyName("jsonName")]
    public string JsonName { get; set; } = default!;

    [JsonPropertyName("alias")]
    public string Alias { get; set; } = default!;

    [JsonPropertyName("scriptDataPath")]
    public string ScriptDataPath { get; set; } = default!;

    [JsonPropertyName("luaDataPath")]
    public string LuaDataPath { get; set; } = default!;

    [JsonPropertyName("dyePart")]
    public string DyePart { get; set; } = default!;

    [JsonPropertyName("billboardIcon")]
    public string BillboardIcon { get; set; } = default!;

    [JsonPropertyName("templateEmotionPath")]
    public string TemplateEmotionPath { get; set; } = default!;

    [JsonPropertyName("HHCCFBDLLPJ")]
    public int HHCCFBDLLPJ { get; set; }

    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("nameTextMapHash")]
    public Text NameTextMapHash { get; set; }

    [JsonPropertyName("prefabPathHashSuffix")]
    public Text PrefabPathHashSuffix { get; set; }

    [JsonPropertyName("prefabPathHashPre")]
    public int PrefabPathHashPre { get; set; }

    [JsonPropertyName("campID")]
    public int CampID { get; set; }

    [JsonPropertyName("LODPatternName")]
    public string LODPatternName { get; set; } = default!;

    [JsonPropertyName("hasMove")]
    public bool? HasMove { get; set; }

    [JsonPropertyName("hasAudio")]
    public bool? HasAudio { get; set; }

    [JsonPropertyName("jsonPathHashSuffix")]
    public long? JsonPathHashSuffix { get; set; }

    [JsonPropertyName("jsonPathHashPre")]
    public int? JsonPathHashPre { get; set; }

    [JsonPropertyName("isDaily")]
    public bool? IsDaily { get; set; }

    [JsonPropertyName("coopPicNameHashSuffix")]
    public long? CoopPicNameHashSuffix { get; set; }

    [JsonPropertyName("coopPicNameHashPre")]
    public int? CoopPicNameHashPre { get; set; }

    [JsonPropertyName("invisiable")]
    public bool? Invisiable { get; set; }

    [JsonPropertyName("disableShowName")]
    public bool? DisableShowName { get; set; }

    [JsonPropertyName("bodyType")]
    public string BodyType { get; set; } = default!;

    [JsonPropertyName("firstMetId")]
    public int? FirstMetId { get; set; }

    [JsonPropertyName("FADNGIIBAIL")]
    public bool? FADNGIIBAIL { get; set; }

    [JsonPropertyName("billboardType")]
    public string BillboardType { get; set; } = default!;

    [JsonPropertyName("luaDataIndex")]
    public int? LuaDataIndex { get; set; }

    [JsonPropertyName("animatorConfigPathHashSuffix")]
    public bool? AnimatorConfigPathHashSuffix { get; set; }

    [JsonPropertyName("animatorConfigPathHashPre")]
    public bool? AnimatorConfigPathHashPre { get; set; }
}
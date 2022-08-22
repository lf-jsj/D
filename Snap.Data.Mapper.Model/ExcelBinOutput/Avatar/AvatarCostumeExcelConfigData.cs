namespace Snap.Data.Mapper.Model.ExcelBinOutput.Avatar;

public class AvatarCostumeExcelConfigData : DataObject
{
    /// <summary>
    /// GMECDCKBFJM
    /// BDFMGMADMGC
    /// EEFPIKPJIBC
    /// </summary>
    [JsonPropertyName("EEFPIKPJIBC")]
    public int Id { get; set; }

    [JsonPropertyName("nameTextMapHash")]
    public Text NameTextMapHash { get; set; }

    [JsonPropertyName("descTextMapHash")]
    public Text DescTextMapHash { get; set; }

    /// <summary>
    /// Important! used to linq with avatar
    /// FMAJGGBGKKN
    /// PDBPABLOMMA
    /// MJIEAHCHGFC
    /// </summary>
    [JsonPropertyName("MJIEAHCHGFC")]
    public int AvatarId { get; set; }

    [JsonPropertyName("itemId")]
    public int ItemId { get; set; }

    [JsonPropertyName("jsonName")]
    public string JsonName { get; set; } = default!;

    /// <summary>
    /// FOINIGFDKIP
    /// MKPEEANCLCO
    /// AEKONDDFAHF
    /// </summary>
    [JsonPropertyName("AEKONDDFAHF")]
    public string IconName { get; set; } = default!;

    [JsonPropertyName("sideIconName")]
    public string SideIconName { get; set; } = default!;

    [JsonPropertyName("hide")]
    public bool? Hide { get; set; }

    [JsonPropertyName("isDefault")]
    public bool IsDefault { get; set; }
}
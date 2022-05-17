namespace Snap.Data.Mapper.Model.ExcelBinOutput;

public class LocalizationExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("assetType")]
    public string AssetType { get; set; } = default!;

    [JsonPropertyName("defaultPath")]
    public string DefaultPath { get; set; } = default!;

    [JsonPropertyName("scPath")]
    public string ScPath { get; set; } = default!;

    [JsonPropertyName("tcPath")]
    public string TcPath { get; set; } = default!;

    [JsonPropertyName("enPath")]
    public string EnPath { get; set; } = default!;

    [JsonPropertyName("krPath")]
    public string KrPath { get; set; } = default!;

    [JsonPropertyName("jpPath")]
    public string JpPath { get; set; } = default!;

    [JsonPropertyName("esPath")]
    public string EsPath { get; set; } = default!;

    [JsonPropertyName("frPath")]
    public string FrPath { get; set; } = default!;

    [JsonPropertyName("idPath")]
    public string IdPath { get; set; } = default!;

    [JsonPropertyName("ptPath")]
    public string PtPath { get; set; } = default!;

    [JsonPropertyName("ruPath")]
    public string RuPath { get; set; } = default!;

    [JsonPropertyName("thPath")]
    public string ThPath { get; set; } = default!;

    [JsonPropertyName("viPath")]
    public string ViPath { get; set; } = default!;

    [JsonPropertyName("dePath")]
    public string DePath { get; set; } = default!;

    [JsonPropertyName("IDMHAKAICOD")]
    public string IDMHAKAICOD { get; set; } = default!;

    [JsonPropertyName("MFLNHFEPJEI")]
    public string MFLNHFEPJEI { get; set; } = default!;
}

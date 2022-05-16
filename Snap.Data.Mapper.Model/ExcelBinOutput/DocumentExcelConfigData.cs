namespace Snap.Data.Mapper.Model.ExcelBinOutput;

public class DocumentExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("titleTextMapHash")]
    public Text TitleTextMapHash { get; set; }

    [JsonPropertyName("contentLocalizedId")]
    public int ContentLocalizedId { get; set; }

    [JsonPropertyName("previewPath")]
    public string PreviewPath { get; set; } = default!;

    [JsonPropertyName("videoPath")]
    public string VideoPath { get; set; } = default!;

    [JsonPropertyName("documentType")]
    public string DocumentType { get; set; } = default!;

    [JsonPropertyName("subtitleID")]
    public int? SubtitleID { get; set; }
}

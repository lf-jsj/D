namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.MoonfinTrial;
public class MoonfinTrialExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("activityId")]
    public int ActivityId { get; set; }

    [JsonPropertyName("HCEBDAPDFIH")]
    public IList<int> HCEBDAPDFIH { get; set; } = default!;

    [JsonPropertyName("FABNODFFJHM")]
    public int FABNODFFJHM { get; set; }

    [JsonPropertyName("AFLIBEHCHJI")]
    public int AFLIBEHCHJI { get; set; }

    [JsonPropertyName("FDJKOIOHLHK")]
    public int FDJKOIOHLHK { get; set; }

    [JsonPropertyName("FGMNBCDDFMD")]
    public int FGMNBCDDFMD { get; set; }

    [JsonPropertyName("pushTipsId")]
    public int PushTipsId { get; set; }

    [JsonPropertyName("EBJDIJIILBH")]
    public IList<int> EBJDIJIILBH { get; set; } = default!;

    [JsonPropertyName("EJMFBGLDICD")]
    public IList<int> EJMFBGLDICD { get; set; } = default!;
}

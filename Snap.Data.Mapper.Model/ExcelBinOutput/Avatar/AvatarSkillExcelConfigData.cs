namespace Snap.Data.Mapper.Model.ExcelBinOutput.Avatar;

public class AvatarSkillExcelConfigData : DataObject
{
    public int Id { get; set; }

    public Text NameTextMapHash { get; set; }

    public string AbilityName { get; set; } = string.Empty;

    public Text DescTextMapHash { get; set; }

    public string SkillIcon { get; set; } = string.Empty;

    public bool IsRanged { get; set; }

    public double CdTime { get; set; }

    public bool IgnoreCDMinusRatio { get; set; }

    public double CostStamina { get; set; }

    public int CostElemType { get; set; }

    public double CostElemVal { get; set; }

    public int MaxChargeNum { get; set; }

    public int TriggerId { get; set; }

    public string LockShape { get; set; } = default!;

    public IList<double> LockWeightParams { get; set; } = default!;

    public bool IsAttackCameraLock { get; set; }

    public int DragType { get; set; }

    public bool ShowIconArrow { get; set; }

    public int NeedMonitor { get; set; }

    public bool DefaultLocked { get; set; }

    public string BuffIcon { get; set; } = string.Empty;

    public int ProudSkillGroupId { get; set; }

    public string GlobalValueKey { get; set; } = string.Empty;

    public double EnergyMin { get; set; }

    public bool ForceCanDoSkill { get; set; }

    public int CdSlot { get; set; }

    public bool NeedStore { get; set; }

    public int ShareCDId { get; set; }
}
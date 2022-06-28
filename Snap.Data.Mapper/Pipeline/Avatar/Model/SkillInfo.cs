namespace Snap.Data.Mapper.Pipeline.Avatar.Model;

public class SkillInfo
{
    public int Id { get; set; }
    public int GroupId { get; set; }
    public string Name { get; set; } = default!;
    public string Description { get; set; } = default!;
    public string Icon { get; set; } = default!;
    public DescParam Proud { get; set; } = default!;
}

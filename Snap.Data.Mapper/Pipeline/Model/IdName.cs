namespace Snap.Data.Mapper.Pipeline.Model;

internal class IdName
{
    public IdName(int id, string name)
    {
        Id = id;
        Name = name;
    }

    public int Id { get; set; }
    public string Name { get; set; }
}

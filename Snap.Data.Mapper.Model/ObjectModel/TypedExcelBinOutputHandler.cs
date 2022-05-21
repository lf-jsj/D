using Snap.Data.Mapper.Abstraction;
using System.IO;

namespace Snap.Data.Mapper.Model.ObjectModel;
internal class TypedExcelBinOutputHandler<TElement> : IExcelBinOutputHandler<TElement>
    where TElement : DataObject
{
    private readonly string output;
    private readonly IList<TElement> data;

    public TypedExcelBinOutputHandler(string rootPath)
    {
        using (Stream stream = File.OpenRead(Path.Combine(rootPath, $"{typeof(TElement).Name}.json")))
        {
            data = JsonContext.ToObject<IList<TElement>>(stream)!;
        }

        output = JsonContext.Stringify(data);
    }

    public string Name { get => typeof(TElement).Name; }
    public string Output { get => output; }
    public IList<TElement> OutputData { get => data; }
    public IDictionary<int,TElement> OutputDataMap { get => throw new NotImplementedException(); }
}

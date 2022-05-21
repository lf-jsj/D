using Snap.Data.Mapper.Abstraction;
using System.IO;
using System.Linq;

namespace Snap.Data.Mapper.Model.ObjectModel;

internal class TypedIndexableExcelBinOutputHandler<TElement> : IExcelBinOutputHandler<TElement>
    where TElement : IndexableDataObject
{
    private readonly string output;
    private readonly IList<TElement> data;
    private readonly IDictionary<int, TElement> outputDataMap;

    public TypedIndexableExcelBinOutputHandler(string rootPath)
    {
        using (Stream stream = File.OpenRead(Path.Combine(rootPath, $"{typeof(TElement).Name}.json")))
        {
            data = JsonContext.ToObject<IList<TElement>>(stream)!;
        }

        outputDataMap = data.ToDictionary(i => i.GetIndex(), item => item);
        output = JsonContext.Stringify(data);
    }

    public string Name { get => typeof(TElement).Name; }
    public string Output { get => output; }
    public IList<TElement> OutputData { get => data!; }
    public IDictionary<int, TElement> OutputDataMap { get => outputDataMap!; }
}
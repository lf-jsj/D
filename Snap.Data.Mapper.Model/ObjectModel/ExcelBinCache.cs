using Snap.Data.Mapper.Abstraction;
using System.Diagnostics;
using System.Linq;

namespace Snap.Data.Mapper.Model.ObjectModel;
public static partial class ExcelBin
{
    private static List<NamedValue<Lazy<IOutputHandler>>>? handlers;

    private static NamedValue<Lazy<IOutputHandler>> Register<TElement>(string targetFolder, string? name = default)
        where TElement : DataObject
    {
        return AsTyped<TypedExcelBinOutputHandler<TElement>, TElement>(targetFolder, name);
    }

    private static NamedValue<Lazy<IOutputHandler>> RegisterIndexable<TElement>(string targetFolder, string? name = default)
        where TElement : IndexableDataObject
    {
        return AsTyped<TypedIndexableExcelBinOutputHandler<TElement>, TElement>(targetFolder, name);
    }

    private static NamedValue<Lazy<IOutputHandler>> AsTyped<THandler, TElement>(string targetFolder, string? name)
        where THandler : IExcelBinOutputHandler<TElement>
    {
        return new(
            name ?? typeof(TElement).Name,
            new(() => (THandler)Activator.CreateInstance(typeof(THandler), targetFolder)!));
    }

    private static Dictionary<Type, IOutputHandler> Cache = new();

    public static IExcelBinOutputHandler<T> Get<T>()
    {
        if (!Cache.TryGetValue(typeof(T), out IOutputHandler? outputHandler))
        {
            outputHandler = handlers!
                .First(nv => nv.Name == typeof(T).Name)
                .Value.Value;
            Cache[typeof(T)] = outputHandler;
            Debug.WriteLine($"{typeof(T)} cached.");
        }

        return (IExcelBinOutputHandler<T>)outputHandler;
    }
}

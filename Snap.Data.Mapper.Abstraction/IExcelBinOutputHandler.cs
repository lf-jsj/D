// Copyright (c) DGP Studio. All rights reserved.
// Licensed under the MIT license.

namespace Snap.Data.Mapper.Abstraction;

public interface IExcelBinOutputHandler<TElement> : IOutputHandler
{
    public IList<TElement> OutputData { get; }

    public IDictionary<int, TElement> OutputDataMap { get; }
}
// Copyright (c) DGP Studio. All rights reserved.
// Licensed under the MIT license.

namespace Snap.Data.Mapper.Abstraction;

public interface IOutputHandler
{
    string Name { get; }

    string Output { get; }
}
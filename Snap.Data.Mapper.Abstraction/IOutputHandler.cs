// Copyright (c) DGP Studio. All rights reserved.
// Licensed under the MIT license.

namespace Snap.Data.Mapper.Abstraction;

public interface IOutputHandler
{
    string Name { get; }

    /// <summary>
    /// 仅用作实验Parse阶段的可能的枚举值的验证
    /// </summary>
    IList<KeyValuePair<string, IList<string>>> KeyEnumerations { get; }

    string Output { get; }
}

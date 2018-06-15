﻿// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Diagnostics.CodeAnalysis;

namespace Roslynator.Metadata
{
    [SuppressMessage("Performance", "CA1815:Override equals and operator equals on value types", Justification = "<Pending>")]
    public readonly struct SampleDescriptor
    {
        public SampleDescriptor(string before, string after)
        {
            Before = TextUtility.NormalizeNewLine(before);

            After = TextUtility.NormalizeNewLine(after);
        }

        public string Before { get; }

        public string After { get; }
    }
}

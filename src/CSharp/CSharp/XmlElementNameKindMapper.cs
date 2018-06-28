﻿// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;

namespace Roslynator.CSharp
{
    internal static class XmlElementNameKindMapper
    {
        private static readonly ImmutableDictionary<string, XmlElementKind> _map = CreateMap();

        private static ImmutableDictionary<string, XmlElementKind> CreateMap()
        {
            return ImmutableDictionary.CreateRange(
                StringComparer.OrdinalIgnoreCase,
                new KeyValuePair<string, XmlElementKind>[]
                {
                    //new KeyValuePair<string, XmlElementKind>("c", XmlElementKind.C),
                    new KeyValuePair<string, XmlElementKind>("code", XmlElementKind.Code),
                    new KeyValuePair<string, XmlElementKind>("example", XmlElementKind.Example),
                    new KeyValuePair<string, XmlElementKind>("exception", XmlElementKind.Exception),
                    new KeyValuePair<string, XmlElementKind>("exclude", XmlElementKind.Exclude),
                    new KeyValuePair<string, XmlElementKind>("include", XmlElementKind.Include),
                    new KeyValuePair<string, XmlElementKind>("inheritdoc", XmlElementKind.InheritDoc),
                    new KeyValuePair<string, XmlElementKind>("list", XmlElementKind.List),
                    new KeyValuePair<string, XmlElementKind>("para", XmlElementKind.Para),
                    new KeyValuePair<string, XmlElementKind>("param", XmlElementKind.Param),
                    //new KeyValuePair<string, XmlElementKind>("paramref", XmlElementKind.ParamRef),
                    //new KeyValuePair<string, XmlElementKind>("permission", XmlElementKind.Permission),
                    new KeyValuePair<string, XmlElementKind>("remarks", XmlElementKind.Remarks),
                    new KeyValuePair<string, XmlElementKind>("returns", XmlElementKind.Returns),
                    //new KeyValuePair<string, XmlElementKind>("see", XmlElementKind.See),
                    //new KeyValuePair<string, XmlElementKind>("seealso", XmlElementKind.SeeAlso),
                    new KeyValuePair<string, XmlElementKind>("summary", XmlElementKind.Summary),
                    new KeyValuePair<string, XmlElementKind>("typeparam", XmlElementKind.TypeParam),
                    //new KeyValuePair<string, XmlElementKind>("typeparamref", XmlElementKind.TypeParamRef),
                    new KeyValuePair<string, XmlElementKind>("value", XmlElementKind.Value),
                });
        }

        public static bool TryGetKind(string name, out XmlElementKind kind)
        {
            return _map.TryGetValue(name, out kind);
        }

        public static XmlElementKind GetKindOrDefault(string name)
        {
            if (_map.TryGetValue(name, out XmlElementKind kind))
                return kind;

            Debug.Fail(name);

            return XmlElementKind.None;
        }

        public static string GetName(XmlElementKind kind)
        {
            switch (kind)
            {
                case XmlElementKind.None:
                    return "";
                case XmlElementKind.Code:
                    return "code";
                case XmlElementKind.Example:
                    return "example";
                case XmlElementKind.Exception:
                    return "exception";
                case XmlElementKind.Exclude:
                    return "exclude";
                case XmlElementKind.Include:
                    return "include";
                case XmlElementKind.InheritDoc:
                    return "inheritdoc";
                case XmlElementKind.List:
                    return "list";
                case XmlElementKind.Para:
                    return "para";
                case XmlElementKind.Param:
                    return "param";
                case XmlElementKind.Remarks:
                    return "remarks";
                case XmlElementKind.Returns:
                    return "returns";
                case XmlElementKind.Summary:
                    return "summary";
                case XmlElementKind.TypeParam:
                    return "typeparam";
                case XmlElementKind.Value:
                    return "value";
                default:
                    throw new ArgumentException("", nameof(kind));
            }
        }
    }
}

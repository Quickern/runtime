﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

// Source files represent a source generated JsonSerializerContext as produced by the .NET 6 SDK.
// Used to validate correctness of contexts generated by previous SDKs against the current System.Text.Json runtime components.
// Unless absolutely necessary DO NOT MODIFY any of these files -- it would invalidate the purpose of the regression tests.

// <auto-generated/>
#nullable enable

// Suppress warnings about [Obsolete] member usage in generated code.
#pragma warning disable CS0618

namespace System.Text.Json.Tests.SourceGenRegressionTests.Net60
{
    public partial class Net60GeneratedContext
    {
        private global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.Text.Json.Tests.SourceGenRegressionTests.Net60.MyLinkedList>? _MyLinkedList;
        public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.Text.Json.Tests.SourceGenRegressionTests.Net60.MyLinkedList> MyLinkedList
        {
            get
            {
                if (_MyLinkedList == null)
                {
                    global::System.Text.Json.Serialization.JsonConverter? customConverter;
                    if (Options.Converters.Count > 0 && (customConverter = GetRuntimeProvidedCustomConverter(typeof(global::System.Text.Json.Tests.SourceGenRegressionTests.Net60.MyLinkedList))) != null)
                    {
                        _MyLinkedList = global::System.Text.Json.Serialization.Metadata.JsonMetadataServices.CreateValueInfo<global::System.Text.Json.Tests.SourceGenRegressionTests.Net60.MyLinkedList>(Options, customConverter);
                    }
                    else
                    {
                        global::System.Text.Json.Serialization.Metadata.JsonObjectInfoValues<global::System.Text.Json.Tests.SourceGenRegressionTests.Net60.MyLinkedList> objectInfo = new global::System.Text.Json.Serialization.Metadata.JsonObjectInfoValues<global::System.Text.Json.Tests.SourceGenRegressionTests.Net60.MyLinkedList>()
                        {
                            ObjectCreator = null,
                            ObjectWithParameterizedConstructorCreator = static (args) => new global::System.Text.Json.Tests.SourceGenRegressionTests.Net60.MyLinkedList((global::System.Int32)args[0], (global::System.Text.Json.Tests.SourceGenRegressionTests.Net60.MyLinkedList)args[1]),
                            PropertyMetadataInitializer = MyLinkedListPropInit,
                            ConstructorParameterMetadataInitializer = MyLinkedListCtorParamInit,
                            NumberHandling = default,
                            SerializeHandler = MyLinkedListSerializeHandler
                        };

                        _MyLinkedList = global::System.Text.Json.Serialization.Metadata.JsonMetadataServices.CreateObjectInfo<global::System.Text.Json.Tests.SourceGenRegressionTests.Net60.MyLinkedList>(Options, objectInfo);
                    }
                }

                return _MyLinkedList;
            }
        }

        private static global::System.Text.Json.Serialization.Metadata.JsonPropertyInfo[] MyLinkedListPropInit(global::System.Text.Json.Serialization.JsonSerializerContext context)
        {
            global::System.Text.Json.Tests.SourceGenRegressionTests.Net60.Net60GeneratedContext jsonContext = (global::System.Text.Json.Tests.SourceGenRegressionTests.Net60.Net60GeneratedContext)context;
            global::System.Text.Json.JsonSerializerOptions options = context.Options;

            global::System.Text.Json.Serialization.Metadata.JsonPropertyInfo[] properties = new global::System.Text.Json.Serialization.Metadata.JsonPropertyInfo[2];

            global::System.Text.Json.Serialization.Metadata.JsonPropertyInfoValues<global::System.Int32> info0 = new global::System.Text.Json.Serialization.Metadata.JsonPropertyInfoValues<global::System.Int32>()
            {
                IsProperty = true,
                IsPublic = true,
                IsVirtual = false,
                DeclaringType = typeof(global::System.Text.Json.Tests.SourceGenRegressionTests.Net60.MyLinkedList),
                PropertyTypeInfo = jsonContext.Int32,
                Converter = null,
                Getter = static (obj) => ((global::System.Text.Json.Tests.SourceGenRegressionTests.Net60.MyLinkedList)obj).Value,
                Setter = static (obj, value) => ((global::System.Text.Json.Tests.SourceGenRegressionTests.Net60.MyLinkedList)obj).Value = value!,
                IgnoreCondition = null,
                HasJsonInclude = false,
                IsExtensionData = false,
                NumberHandling = default,
                PropertyName = "Value",
                JsonPropertyName = null
            };

            properties[0] = global::System.Text.Json.Serialization.Metadata.JsonMetadataServices.CreatePropertyInfo<global::System.Int32>(options, info0);

            global::System.Text.Json.Serialization.Metadata.JsonPropertyInfoValues<global::System.Text.Json.Tests.SourceGenRegressionTests.Net60.MyLinkedList> info1 = new global::System.Text.Json.Serialization.Metadata.JsonPropertyInfoValues<global::System.Text.Json.Tests.SourceGenRegressionTests.Net60.MyLinkedList>()
            {
                IsProperty = true,
                IsPublic = true,
                IsVirtual = false,
                DeclaringType = typeof(global::System.Text.Json.Tests.SourceGenRegressionTests.Net60.MyLinkedList),
                PropertyTypeInfo = jsonContext.MyLinkedList,
                Converter = null,
                Getter = static (obj) => ((global::System.Text.Json.Tests.SourceGenRegressionTests.Net60.MyLinkedList)obj).Nested!,
                Setter = static (obj, value) => ((global::System.Text.Json.Tests.SourceGenRegressionTests.Net60.MyLinkedList)obj).Nested = value!,
                IgnoreCondition = null,
                HasJsonInclude = false,
                IsExtensionData = false,
                NumberHandling = default,
                PropertyName = "Nested",
                JsonPropertyName = null
            };

            properties[1] = global::System.Text.Json.Serialization.Metadata.JsonMetadataServices.CreatePropertyInfo<global::System.Text.Json.Tests.SourceGenRegressionTests.Net60.MyLinkedList>(options, info1);

            return properties;
        }

        private static void MyLinkedListSerializeHandler(global::System.Text.Json.Utf8JsonWriter writer, global::System.Text.Json.Tests.SourceGenRegressionTests.Net60.MyLinkedList? value)
        {
            if (value == null)
            {
                writer.WriteNullValue();
                return;
            }

            writer.WriteStartObject();
            writer.WriteNumber(PropName_Value, value.Value);
            writer.WritePropertyName(PropName_Nested);
            MyLinkedListSerializeHandler(writer, value.Nested!);

            writer.WriteEndObject();
        }

        private static global::System.Text.Json.Serialization.Metadata.JsonParameterInfoValues[] MyLinkedListCtorParamInit()
        {
            global::System.Text.Json.Serialization.Metadata.JsonParameterInfoValues[] parameters = new global::System.Text.Json.Serialization.Metadata.JsonParameterInfoValues[2];
            global::System.Text.Json.Serialization.Metadata.JsonParameterInfoValues info;

            info = new()
            {
                Name = "value",
                ParameterType = typeof(global::System.Int32),
                Position = 0,
                HasDefaultValue = false,
                DefaultValue = default(global::System.Int32)
            };
            parameters[0] = info;

            info = new()
            {
                Name = "nested",
                ParameterType = typeof(global::System.Text.Json.Tests.SourceGenRegressionTests.Net60.MyLinkedList),
                Position = 1,
                HasDefaultValue = false,
                DefaultValue = default(global::System.Text.Json.Tests.SourceGenRegressionTests.Net60.MyLinkedList)
            };
            parameters[1] = info;

            return parameters;
        }
    }
}
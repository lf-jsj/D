using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Text.Json;

namespace Snap.Data.Mapper.Pipeline.Reliquary.Model;

public class StringEnumDictionaryConverter<TKey, TValue> : JsonConverter<IDictionary<TKey, TValue>>
    where TKey : struct, Enum
{
    private readonly Type keyType;

    public StringEnumDictionaryConverter()
    {
        // Cache the key and value types.
        keyType = typeof(TKey);
    }

    public override IDictionary<TKey, TValue> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType != JsonTokenType.StartObject)
        {
            throw new JsonException();
        }

        Dictionary<TKey, TValue> dictionary = new();

        while (reader.Read())
        {
            if (reader.TokenType == JsonTokenType.EndObject)
            {
                return dictionary;
            }

            // Get the key.
            if (reader.TokenType != JsonTokenType.PropertyName)
            {
                throw new JsonException();
            }

            string? propertyName = reader.GetString();

            if (!Enum.TryParse(propertyName, ignoreCase: false, out TKey key) && !Enum.TryParse(propertyName, ignoreCase: true, out key))
            {
                throw new JsonException($"Unable to convert \"{propertyName}\" to Enum \"{keyType}\".");
            }

            // Get the value.
            TValue value = JsonSerializer.Deserialize<TValue>(ref reader, options)!;

            // Add to dictionary.
            dictionary.Add(key, value);
        }

        throw new JsonException();
    }

    public override void Write(Utf8JsonWriter writer, IDictionary<TKey, TValue> dictionary, JsonSerializerOptions options)
    {
        writer.WriteStartObject();

        foreach ((TKey key, TValue value) in dictionary)
        {
            string? propertyName = key.ToString();
            string? convertedName = options.PropertyNamingPolicy?.ConvertName(propertyName) ?? propertyName;

            writer.WritePropertyName(convertedName);
            JsonSerializer.Serialize(writer, value, options);
        }

        writer.WriteEndObject();
    }
}
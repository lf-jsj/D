using Snap.Data.Mapper.Abstraction;
using System.Text.Json;

namespace Snap.Data.Mapper.Model.ObjectModel.Converter
{
    public class TextMapHashConverter : JsonConverter<Text>
    {
        private readonly ITextMap textMap;

        public TextMapHashConverter(ITextMap textMap)
        {
            this.textMap = textMap;
        }

        public override Text Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            ulong hash = reader.GetUInt64();
            return new(hash, textMap[hash.ToString()]!);
        }

        public override void Write(Utf8JsonWriter writer, Text value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value.Value??value.Hash.ToString());
        }
    }
}
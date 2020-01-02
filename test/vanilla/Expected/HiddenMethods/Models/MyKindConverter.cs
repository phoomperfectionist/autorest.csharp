// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Fixtures.HiddenMethods.Models
{
    using Newtonsoft.Json;

    using System.Reflection;

    /// <summary>
    /// Defines values for MyKind.
    /// </summary>
    public sealed class MyKindConverter : JsonConverter
    {

        /// <summary>
        /// Returns if objectType can be converted to MyKind by the converter.
        /// </summary>
        public override bool CanConvert(System.Type objectType)
        {
            return typeof(MyKind).GetTypeInfo().IsAssignableFrom(objectType.GetTypeInfo());
        }

        /// <summary>
        /// Overrides ReadJson and converts token to MyKind.
        /// </summary>
        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == Newtonsoft.Json.JsonToken.Null)
            {
                return null;
            }
            return (MyKind)serializer.Deserialize<string>(reader);
        }

        /// <summary>
        /// Overriding WriteJson for MyKind for serialization.
        /// </summary>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteValue(value.ToString());
        }

    }
}

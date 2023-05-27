// <auto-generated>
/*
 * OpenAPI Petstore
 *
 * This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

#nullable enable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using OpenAPIClientUtils = Org.OpenAPITools.Client.ClientUtils;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// ArrayOfArrayOfNumberOnly
    /// </summary>
    public partial class ArrayOfArrayOfNumberOnly : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ArrayOfArrayOfNumberOnly" /> class.
        /// </summary>
        /// <param name="arrayArrayNumber">arrayArrayNumber</param>
        [JsonConstructor]
        public ArrayOfArrayOfNumberOnly(List<List<decimal>> arrayArrayNumber)
        {
            ArrayArrayNumber = arrayArrayNumber;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets ArrayArrayNumber
        /// </summary>
        [JsonPropertyName("ArrayArrayNumber")]
        public List<List<decimal>> ArrayArrayNumber { get; set; }

        /// <summary>
        /// Gets or Sets additional properties
        /// </summary>
        [JsonExtensionData]
        public Dictionary<string, JsonElement> AdditionalProperties { get; } = new Dictionary<string, JsonElement>();

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ArrayOfArrayOfNumberOnly {\n");
            sb.Append("  ArrayArrayNumber: ").Append(ArrayArrayNumber).Append("\n");
            sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

    /// <summary>
    /// A Json converter for type ArrayOfArrayOfNumberOnly
    /// </summary>
    public class ArrayOfArrayOfNumberOnlyJsonConverter : JsonConverter<ArrayOfArrayOfNumberOnly>
    {
        /// <summary>
        /// A Json reader.
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override ArrayOfArrayOfNumberOnly Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            List<List<decimal>>? arrayArrayNumber = default;

            while (utf8JsonReader.Read())
            {
                if (startingTokenType == JsonTokenType.StartObject && utf8JsonReader.TokenType == JsonTokenType.EndObject && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (startingTokenType == JsonTokenType.StartArray && utf8JsonReader.TokenType == JsonTokenType.EndArray && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (utf8JsonReader.TokenType == JsonTokenType.PropertyName && currentDepth == utf8JsonReader.CurrentDepth - 1)
                {
                    string? propertyName = utf8JsonReader.GetString();
                    utf8JsonReader.Read();

                    switch (propertyName)
                    {
                        case "ArrayArrayNumber":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                arrayArrayNumber = JsonSerializer.Deserialize<List<List<decimal>>>(ref utf8JsonReader, jsonSerializerOptions);
                            break;
                        default:
                            break;
                    }
                }
            }

#pragma warning disable CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
#pragma warning disable CS8073 // The result of the expression is always the same since a value of this type is never equal to 'null'

            if (arrayArrayNumber == null)
                throw new ArgumentNullException(nameof(arrayArrayNumber), "Property is required for class ArrayOfArrayOfNumberOnly.");

#pragma warning restore CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
#pragma warning restore CS8073 // The result of the expression is always the same since a value of this type is never equal to 'null'

            return new ArrayOfArrayOfNumberOnly(arrayArrayNumber);
        }

        /// <summary>
        /// A Json writer
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="arrayOfArrayOfNumberOnly"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, ArrayOfArrayOfNumberOnly arrayOfArrayOfNumberOnly, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            writer.WritePropertyName("ArrayArrayNumber");
            JsonSerializer.Serialize(writer, arrayOfArrayOfNumberOnly.ArrayArrayNumber, jsonSerializerOptions);

            writer.WriteEndObject();
        }
    }
}

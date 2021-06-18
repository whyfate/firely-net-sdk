// <auto-generated/>
// Contents of: hl7.fhir.r4.core version: 4.0.1

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

/*
  Copyright (c) 2011+, HL7, Inc.
  All rights reserved.
  
  Redistribution and use in source and binary forms, with or without modification, 
  are permitted provided that the following conditions are met:
  
   * Redistributions of source code must retain the above copyright notice, this 
     list of conditions and the following disclaimer.
   * Redistributions in binary form must reproduce the above copyright notice, 
     this list of conditions and the following disclaimer in the documentation 
     and/or other materials provided with the distribution.
   * Neither the name of HL7 nor the names of its contributors may be used to 
     endorse or promote products derived from this software without specific 
     prior written permission.
  
  THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND 
  ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED 
  WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. 
  IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, 
  INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT 
  NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR 
  PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, 
  WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) 
  ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE 
  POSSIBILITY OF SUCH DAMAGE.
  
*/

namespace Hl7.Fhir.Serialization.Poco
{
  /// <summary>
  /// JSON Serialization Extensions for TriggerDefinition
  /// </summary>
  public static class TriggerDefinitionSerializationExtensions
  {
    /// <summary>
    /// Serialize a FHIR TriggerDefinition into JSON
    /// </summary>
    public static void SerializeJson(this Hl7.Fhir.Model.TriggerDefinition current, Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject) { writer.WriteStartObject(); }
      // Complex: TriggerDefinition, Export: TriggerDefinition, Base: Element (Element)
      ((Hl7.Fhir.Model.Element)current).SerializeJson(writer, options, false);

      if (current.TypeElement != null)
      {
        if (current.TypeElement.Value != null)
        {
          writer.WriteString("type",Hl7.Fhir.Utility.EnumUtility.GetLiteral(current.TypeElement.Value));
        }
        if (current.TypeElement.HasExtensions() || (!string.IsNullOrEmpty(current.TypeElement.ElementId)))
        {
          JsonStreamUtilities.SerializeExtensionList(writer,options,"_type",false,current.TypeElement.Extension,current.TypeElement.ElementId);
        }
      }

      if (current.NameElement != null)
      {
        if (!string.IsNullOrEmpty(current.NameElement.Value))
        {
          writer.WriteString("name",current.NameElement.Value);
        }
        if (current.NameElement.HasExtensions() || (!string.IsNullOrEmpty(current.NameElement.ElementId)))
        {
          JsonStreamUtilities.SerializeExtensionList(writer,options,"_name",false,current.NameElement.Extension,current.NameElement.ElementId);
        }
      }

      if (current.Timing != null)
      {
        switch (current.Timing)
        {
          case Hl7.Fhir.Model.Timing v_Timing:
            writer.WritePropertyName("timingTiming");
            v_Timing.SerializeJson(writer, options);
            break;
          case Hl7.Fhir.Model.ResourceReference v_ResourceReference:
            writer.WritePropertyName("timingReference");
            v_ResourceReference.SerializeJson(writer, options);
            break;
          case Hl7.Fhir.Model.Date v_Date:
            if (v_Date != null)
            {
              if (!string.IsNullOrEmpty(v_Date.Value))
              {
                writer.WriteString("timingDate",v_Date.Value);
              }
              if (v_Date.HasExtensions() || (!string.IsNullOrEmpty(v_Date.ElementId)))
              {
                JsonStreamUtilities.SerializeExtensionList(writer,options,"_timingDate",false,v_Date.Extension,v_Date.ElementId);
              }
            }
            break;
          case Hl7.Fhir.Model.FhirDateTime v_FhirDateTime:
            if (v_FhirDateTime != null)
            {
              if (!string.IsNullOrEmpty(v_FhirDateTime.Value))
              {
                writer.WriteString("timingDateTime",v_FhirDateTime.Value);
              }
              if (v_FhirDateTime.HasExtensions() || (!string.IsNullOrEmpty(v_FhirDateTime.ElementId)))
              {
                JsonStreamUtilities.SerializeExtensionList(writer,options,"_timingDateTime",false,v_FhirDateTime.Extension,v_FhirDateTime.ElementId);
              }
            }
            break;
        }
      }
      if ((current.Data != null) && (current.Data.Count != 0))
      {
        writer.WritePropertyName("data");
        writer.WriteStartArray();
        foreach (DataRequirement val in current.Data)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if (current.Condition != null)
      {
        writer.WritePropertyName("condition");
        current.Condition.SerializeJson(writer, options);
      }

      if (includeStartObject) { writer.WriteEndObject(); }
    }

    /// <summary>
    /// Deserialize JSON into a FHIR TriggerDefinition
    /// </summary>
    public static void DeserializeJson(this Hl7.Fhir.Model.TriggerDefinition current, ref Utf8JsonReader reader, JsonSerializerOptions options)
    {
      string propertyName;

      while (reader.Read())
      {
        if (reader.TokenType == JsonTokenType.EndObject)
        {
          return;
        }

        if (reader.TokenType == JsonTokenType.PropertyName)
        {
          propertyName = reader.GetString();
          if (Hl7.Fhir.Serialization.FhirSerializerOptions.Debug) { Console.WriteLine($"TriggerDefinition >>> TriggerDefinition.{propertyName}, depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}"); }
          reader.Read();
          current.DeserializeJsonProperty(ref reader, options, propertyName);
        }
      }

      throw new JsonException($"TriggerDefinition: invalid state! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
    }

    /// <summary>
    /// Deserialize JSON into a FHIR TriggerDefinition
    /// </summary>
    public static void DeserializeJsonProperty(this Hl7.Fhir.Model.TriggerDefinition current, ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "type":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.TypeElement = new Code<Hl7.Fhir.Model.TriggerDefinition.TriggerType>();
            reader.Skip();
          }
          else
          {
            current.TypeElement = new Code<Hl7.Fhir.Model.TriggerDefinition.TriggerType>(Hl7.Fhir.Utility.EnumUtility.ParseLiteral<Hl7.Fhir.Model.TriggerDefinition.TriggerType>(reader.GetString()));
          }
          break;

        case "_type":
          if (current.TypeElement == null) { current.TypeElement = new Code<Hl7.Fhir.Model.TriggerDefinition.TriggerType>(); }
          ((Hl7.Fhir.Model.Element)current.TypeElement).DeserializeJson(ref reader, options);
          break;

        case "name":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.NameElement = new FhirString();
            reader.Skip();
          }
          else
          {
            current.NameElement = new FhirString(reader.GetString());
          }
          break;

        case "_name":
          if (current.NameElement == null) { current.NameElement = new FhirString(); }
          ((Hl7.Fhir.Model.Element)current.NameElement).DeserializeJson(ref reader, options);
          break;

        case "timingTiming":
          current.Timing = new Hl7.Fhir.Model.Timing();
          ((Hl7.Fhir.Model.Timing)current.Timing).DeserializeJson(ref reader, options);
          break;

        case "timingReference":
          current.Timing = new Hl7.Fhir.Model.ResourceReference();
          ((Hl7.Fhir.Model.ResourceReference)current.Timing).DeserializeJson(ref reader, options);
          break;

        case "timingDate":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.Timing = new Date();
            reader.Skip();
          }
          else
          {
            current.Timing = new Date(reader.GetString());
          }
          break;

        case "_timingDate":
          if (current.Timing == null) { current.Timing = new Date(); }
          ((Hl7.Fhir.Model.Element)current.Timing).DeserializeJson(ref reader, options);
          break;

        case "timingDateTime":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.Timing = new FhirDateTime();
            reader.Skip();
          }
          else
          {
            current.Timing = new FhirDateTime(reader.GetString());
          }
          break;

        case "_timingDateTime":
          if (current.Timing == null) { current.Timing = new FhirDateTime(); }
          ((Hl7.Fhir.Model.Element)current.Timing).DeserializeJson(ref reader, options);
          break;

        case "data":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"TriggerDefinition error reading 'data' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.Data = new List<DataRequirement>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.DataRequirement v_Data = new Hl7.Fhir.Model.DataRequirement();
            v_Data.DeserializeJson(ref reader, options);
            current.Data.Add(v_Data);

            if (!reader.Read())
            {
              throw new JsonException($"TriggerDefinition error reading 'data' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.Data.Count == 0)
          {
            current.Data = null;
          }
          break;

        case "condition":
          current.Condition = new Hl7.Fhir.Model.Expression();
          ((Hl7.Fhir.Model.Expression)current.Condition).DeserializeJson(ref reader, options);
          break;

        // Complex: TriggerDefinition, Export: TriggerDefinition, Base: Element
        default:
          ((Hl7.Fhir.Model.Element)current).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Resource converter to support Sytem.Text.Json interop.
    /// </summary>
    public class TriggerDefinitionJsonConverter : JsonConverter<Hl7.Fhir.Model.TriggerDefinition>
    {
      /// <summary>
      /// Writes a specified value as JSON.
      /// </summary>
      public override void Write(Utf8JsonWriter writer, Hl7.Fhir.Model.TriggerDefinition value, JsonSerializerOptions options)
      {
        value.SerializeJson(writer, options, true);
        writer.Flush();
      }
      /// <summary>
      /// Reads and converts the JSON to a typed object.
      /// </summary>
      public override Hl7.Fhir.Model.TriggerDefinition Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
      {
        var target = new Hl7.Fhir.Model.TriggerDefinition();
        target.DeserializeJson(ref reader, options);
        return target;
      }
    }
  }

}

// end of file

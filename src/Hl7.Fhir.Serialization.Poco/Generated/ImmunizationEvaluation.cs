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
  /// JSON Serialization Extensions for ImmunizationEvaluation
  /// </summary>
  public static class ImmunizationEvaluationSerializationExtensions
  {
    /// <summary>
    /// Serialize a FHIR ImmunizationEvaluation into JSON
    /// </summary>
    public static void SerializeJson(this Hl7.Fhir.Model.ImmunizationEvaluation current, Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject) { writer.WriteStartObject(); }
      writer.WriteString("resourceType","ImmunizationEvaluation");
      // Complex: ImmunizationEvaluation, Export: ImmunizationEvaluation, Base: DomainResource (DomainResource)
      ((Hl7.Fhir.Model.DomainResource)current).SerializeJson(writer, options, false);

      if ((current.Identifier != null) && (current.Identifier.Count != 0))
      {
        writer.WritePropertyName("identifier");
        writer.WriteStartArray();
        foreach (Identifier val in current.Identifier)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if (current.StatusElement != null)
      {
        if (current.StatusElement.Value != null)
        {
          writer.WriteString("status",Hl7.Fhir.Utility.EnumUtility.GetLiteral(current.StatusElement.Value));
        }
        if (current.StatusElement.HasExtensions() || (!string.IsNullOrEmpty(current.StatusElement.ElementId)))
        {
          JsonStreamUtilities.SerializeExtensionList(writer,options,"_status",false,current.StatusElement.Extension,current.StatusElement.ElementId);
        }
      }

      if (current.Patient != null)
      {
        writer.WritePropertyName("patient");
        current.Patient.SerializeJson(writer, options);
      }

      if (current.DateElement != null)
      {
        if (!string.IsNullOrEmpty(current.DateElement.Value))
        {
          writer.WriteString("date",current.DateElement.Value);
        }
        if (current.DateElement.HasExtensions() || (!string.IsNullOrEmpty(current.DateElement.ElementId)))
        {
          JsonStreamUtilities.SerializeExtensionList(writer,options,"_date",false,current.DateElement.Extension,current.DateElement.ElementId);
        }
      }

      if (current.Authority != null)
      {
        writer.WritePropertyName("authority");
        current.Authority.SerializeJson(writer, options);
      }

      if (current.TargetDisease != null)
      {
        writer.WritePropertyName("targetDisease");
        current.TargetDisease.SerializeJson(writer, options);
      }

      if (current.ImmunizationEvent != null)
      {
        writer.WritePropertyName("immunizationEvent");
        current.ImmunizationEvent.SerializeJson(writer, options);
      }

      if (current.DoseStatus != null)
      {
        writer.WritePropertyName("doseStatus");
        current.DoseStatus.SerializeJson(writer, options);
      }

      if ((current.DoseStatusReason != null) && (current.DoseStatusReason.Count != 0))
      {
        writer.WritePropertyName("doseStatusReason");
        writer.WriteStartArray();
        foreach (CodeableConcept val in current.DoseStatusReason)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if (current.DescriptionElement != null)
      {
        if (!string.IsNullOrEmpty(current.DescriptionElement.Value))
        {
          writer.WriteString("description",current.DescriptionElement.Value);
        }
        if (current.DescriptionElement.HasExtensions() || (!string.IsNullOrEmpty(current.DescriptionElement.ElementId)))
        {
          JsonStreamUtilities.SerializeExtensionList(writer,options,"_description",false,current.DescriptionElement.Extension,current.DescriptionElement.ElementId);
        }
      }

      if (current.SeriesElement != null)
      {
        if (!string.IsNullOrEmpty(current.SeriesElement.Value))
        {
          writer.WriteString("series",current.SeriesElement.Value);
        }
        if (current.SeriesElement.HasExtensions() || (!string.IsNullOrEmpty(current.SeriesElement.ElementId)))
        {
          JsonStreamUtilities.SerializeExtensionList(writer,options,"_series",false,current.SeriesElement.Extension,current.SeriesElement.ElementId);
        }
      }

      if (current.DoseNumber != null)
      {
        switch (current.DoseNumber)
        {
          case Hl7.Fhir.Model.PositiveInt v_PositiveInt:
            if (v_PositiveInt != null)
            {
              if (v_PositiveInt.Value != null)
              {
                writer.WriteNumber("doseNumberPositiveInt",(int)v_PositiveInt.Value);
              }
              if (v_PositiveInt.HasExtensions() || (!string.IsNullOrEmpty(v_PositiveInt.ElementId)))
              {
                JsonStreamUtilities.SerializeExtensionList(writer,options,"_doseNumberPositiveInt",false,v_PositiveInt.Extension,v_PositiveInt.ElementId);
              }
            }
            break;
          case Hl7.Fhir.Model.FhirString v_FhirString:
            if (v_FhirString != null)
            {
              if (!string.IsNullOrEmpty(v_FhirString.Value))
              {
                writer.WriteString("doseNumberString",v_FhirString.Value);
              }
              if (v_FhirString.HasExtensions() || (!string.IsNullOrEmpty(v_FhirString.ElementId)))
              {
                JsonStreamUtilities.SerializeExtensionList(writer,options,"_doseNumberString",false,v_FhirString.Extension,v_FhirString.ElementId);
              }
            }
            break;
        }
      }
      if (current.SeriesDoses != null)
      {
        switch (current.SeriesDoses)
        {
          case Hl7.Fhir.Model.PositiveInt v_PositiveInt:
            if (v_PositiveInt != null)
            {
              if (v_PositiveInt.Value != null)
              {
                writer.WriteNumber("seriesDosesPositiveInt",(int)v_PositiveInt.Value);
              }
              if (v_PositiveInt.HasExtensions() || (!string.IsNullOrEmpty(v_PositiveInt.ElementId)))
              {
                JsonStreamUtilities.SerializeExtensionList(writer,options,"_seriesDosesPositiveInt",false,v_PositiveInt.Extension,v_PositiveInt.ElementId);
              }
            }
            break;
          case Hl7.Fhir.Model.FhirString v_FhirString:
            if (v_FhirString != null)
            {
              if (!string.IsNullOrEmpty(v_FhirString.Value))
              {
                writer.WriteString("seriesDosesString",v_FhirString.Value);
              }
              if (v_FhirString.HasExtensions() || (!string.IsNullOrEmpty(v_FhirString.ElementId)))
              {
                JsonStreamUtilities.SerializeExtensionList(writer,options,"_seriesDosesString",false,v_FhirString.Extension,v_FhirString.ElementId);
              }
            }
            break;
        }
      }
      if (includeStartObject) { writer.WriteEndObject(); }
    }

    /// <summary>
    /// Deserialize JSON into a FHIR ImmunizationEvaluation
    /// </summary>
    public static void DeserializeJson(this Hl7.Fhir.Model.ImmunizationEvaluation current, ref Utf8JsonReader reader, JsonSerializerOptions options)
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
          if (Hl7.Fhir.Serialization.FhirSerializerOptions.Debug) { Console.WriteLine($"ImmunizationEvaluation >>> ImmunizationEvaluation.{propertyName}, depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}"); }
          reader.Read();
          current.DeserializeJsonProperty(ref reader, options, propertyName);
        }
      }

      throw new JsonException($"ImmunizationEvaluation: invalid state! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
    }

    /// <summary>
    /// Deserialize JSON into a FHIR ImmunizationEvaluation
    /// </summary>
    public static void DeserializeJsonProperty(this Hl7.Fhir.Model.ImmunizationEvaluation current, ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "identifier":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"ImmunizationEvaluation error reading 'identifier' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.Identifier = new List<Identifier>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.Identifier v_Identifier = new Hl7.Fhir.Model.Identifier();
            v_Identifier.DeserializeJson(ref reader, options);
            current.Identifier.Add(v_Identifier);

            if (!reader.Read())
            {
              throw new JsonException($"ImmunizationEvaluation error reading 'identifier' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.Identifier.Count == 0)
          {
            current.Identifier = null;
          }
          break;

        case "status":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.StatusElement = new Code<Hl7.Fhir.Model.ImmunizationEvaluation.ImmunizationEvaluationStatusCodes>();
            reader.Skip();
          }
          else
          {
            current.StatusElement = new Code<Hl7.Fhir.Model.ImmunizationEvaluation.ImmunizationEvaluationStatusCodes>(Hl7.Fhir.Utility.EnumUtility.ParseLiteral<Hl7.Fhir.Model.ImmunizationEvaluation.ImmunizationEvaluationStatusCodes>(reader.GetString()));
          }
          break;

        case "_status":
          if (current.StatusElement == null) { current.StatusElement = new Code<Hl7.Fhir.Model.ImmunizationEvaluation.ImmunizationEvaluationStatusCodes>(); }
          ((Hl7.Fhir.Model.Element)current.StatusElement).DeserializeJson(ref reader, options);
          break;

        case "patient":
          current.Patient = new Hl7.Fhir.Model.ResourceReference();
          ((Hl7.Fhir.Model.ResourceReference)current.Patient).DeserializeJson(ref reader, options);
          break;

        case "date":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.DateElement = new FhirDateTime();
            reader.Skip();
          }
          else
          {
            current.DateElement = new FhirDateTime(reader.GetString());
          }
          break;

        case "_date":
          if (current.DateElement == null) { current.DateElement = new FhirDateTime(); }
          ((Hl7.Fhir.Model.Element)current.DateElement).DeserializeJson(ref reader, options);
          break;

        case "authority":
          current.Authority = new Hl7.Fhir.Model.ResourceReference();
          ((Hl7.Fhir.Model.ResourceReference)current.Authority).DeserializeJson(ref reader, options);
          break;

        case "targetDisease":
          current.TargetDisease = new Hl7.Fhir.Model.CodeableConcept();
          ((Hl7.Fhir.Model.CodeableConcept)current.TargetDisease).DeserializeJson(ref reader, options);
          break;

        case "immunizationEvent":
          current.ImmunizationEvent = new Hl7.Fhir.Model.ResourceReference();
          ((Hl7.Fhir.Model.ResourceReference)current.ImmunizationEvent).DeserializeJson(ref reader, options);
          break;

        case "doseStatus":
          current.DoseStatus = new Hl7.Fhir.Model.CodeableConcept();
          ((Hl7.Fhir.Model.CodeableConcept)current.DoseStatus).DeserializeJson(ref reader, options);
          break;

        case "doseStatusReason":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"ImmunizationEvaluation error reading 'doseStatusReason' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.DoseStatusReason = new List<CodeableConcept>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.CodeableConcept v_DoseStatusReason = new Hl7.Fhir.Model.CodeableConcept();
            v_DoseStatusReason.DeserializeJson(ref reader, options);
            current.DoseStatusReason.Add(v_DoseStatusReason);

            if (!reader.Read())
            {
              throw new JsonException($"ImmunizationEvaluation error reading 'doseStatusReason' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.DoseStatusReason.Count == 0)
          {
            current.DoseStatusReason = null;
          }
          break;

        case "description":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.DescriptionElement = new FhirString();
            reader.Skip();
          }
          else
          {
            current.DescriptionElement = new FhirString(reader.GetString());
          }
          break;

        case "_description":
          if (current.DescriptionElement == null) { current.DescriptionElement = new FhirString(); }
          ((Hl7.Fhir.Model.Element)current.DescriptionElement).DeserializeJson(ref reader, options);
          break;

        case "series":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.SeriesElement = new FhirString();
            reader.Skip();
          }
          else
          {
            current.SeriesElement = new FhirString(reader.GetString());
          }
          break;

        case "_series":
          if (current.SeriesElement == null) { current.SeriesElement = new FhirString(); }
          ((Hl7.Fhir.Model.Element)current.SeriesElement).DeserializeJson(ref reader, options);
          break;

        case "doseNumberPositiveInt":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.DoseNumber = new PositiveInt();
            reader.Skip();
          }
          else
          {
            current.DoseNumber = new PositiveInt(reader.GetInt32());
          }
          break;

        case "_doseNumberPositiveInt":
          if (current.DoseNumber == null) { current.DoseNumber = new PositiveInt(); }
          ((Hl7.Fhir.Model.Element)current.DoseNumber).DeserializeJson(ref reader, options);
          break;

        case "doseNumberString":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.DoseNumber = new FhirString();
            reader.Skip();
          }
          else
          {
            current.DoseNumber = new FhirString(reader.GetString());
          }
          break;

        case "_doseNumberString":
          if (current.DoseNumber == null) { current.DoseNumber = new FhirString(); }
          ((Hl7.Fhir.Model.Element)current.DoseNumber).DeserializeJson(ref reader, options);
          break;

        case "seriesDosesPositiveInt":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.SeriesDoses = new PositiveInt();
            reader.Skip();
          }
          else
          {
            current.SeriesDoses = new PositiveInt(reader.GetInt32());
          }
          break;

        case "_seriesDosesPositiveInt":
          if (current.SeriesDoses == null) { current.SeriesDoses = new PositiveInt(); }
          ((Hl7.Fhir.Model.Element)current.SeriesDoses).DeserializeJson(ref reader, options);
          break;

        case "seriesDosesString":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.SeriesDoses = new FhirString();
            reader.Skip();
          }
          else
          {
            current.SeriesDoses = new FhirString(reader.GetString());
          }
          break;

        case "_seriesDosesString":
          if (current.SeriesDoses == null) { current.SeriesDoses = new FhirString(); }
          ((Hl7.Fhir.Model.Element)current.SeriesDoses).DeserializeJson(ref reader, options);
          break;

        // Complex: ImmunizationEvaluation, Export: ImmunizationEvaluation, Base: DomainResource
        default:
          ((Hl7.Fhir.Model.DomainResource)current).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Resource converter to support Sytem.Text.Json interop.
    /// </summary>
    public class ImmunizationEvaluationJsonConverter : JsonConverter<Hl7.Fhir.Model.ImmunizationEvaluation>
    {
      /// <summary>
      /// Writes a specified value as JSON.
      /// </summary>
      public override void Write(Utf8JsonWriter writer, Hl7.Fhir.Model.ImmunizationEvaluation value, JsonSerializerOptions options)
      {
        value.SerializeJson(writer, options, true);
        writer.Flush();
      }
      /// <summary>
      /// Reads and converts the JSON to a typed object.
      /// </summary>
      public override Hl7.Fhir.Model.ImmunizationEvaluation Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
      {
        var target = new Hl7.Fhir.Model.ImmunizationEvaluation();
        target.DeserializeJson(ref reader, options);
        return target;
      }
    }
  }

}

// end of file

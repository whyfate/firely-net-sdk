// <auto-generated/>
// Contents of: hl7.fhir.r4.core version: 4.0.1

using System.Collections.Generic;
using System.Text.Json;
using Hl7.Fhir.Model;

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
    /// Common utilties for JSON Stream functionality.
    /// </summary>
    public static class JsonStreamUtilities
  {
    /// <summary>
    /// Serialize an extension list.
    /// </summary>
    /// <param name="writer">      The writer.</param>
    /// <param name="options">     Options for controlling the operation.</param>
    /// <param name="propertyName">Name of the property.</param>
    /// <param name="isArray">     True if is array, false if not.</param>
    /// <param name="extensions">  The extensions.</param>
    /// <param name="elementId">   The element id.</param>
    public static void SerializeExtensionList(
      Utf8JsonWriter writer,
      JsonSerializerOptions options,
      string propertyName,
      bool isArray,
      List<Extension> extensions,
      string elementId)
    {
      if (((extensions == null) || (extensions.Count == 0)) && (string.IsNullOrEmpty(elementId)))
      {
        return;
      }

      if (!isArray) { writer.WritePropertyName(propertyName); }
      writer.WriteStartObject();
      if (!string.IsNullOrEmpty(elementId)) { writer.WriteString("id",elementId); }
      if ((extensions != null) && (extensions.Count > 0))
      {
        writer.WritePropertyName("extension");
        writer.WriteStartArray();

        foreach (Extension ext in extensions)
        {
          ext.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }
      writer.WriteEndObject();
    }
  }
}
// end of file

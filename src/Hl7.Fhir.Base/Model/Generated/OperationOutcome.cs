// <auto-generated/>
// Contents of: hl7.fhir.r5.core version: 5.0.0

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Hl7.Fhir.Introspection;
using Hl7.Fhir.Serialization;
using Hl7.Fhir.Specification;
using Hl7.Fhir.Utility;
using Hl7.Fhir.Validation;

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

namespace Hl7.Fhir.Model
{
  /// <summary>
  /// Information about the success/failure of an action
  /// </summary>
  [Serializable]
  [DataContract]
  [FhirType("OperationOutcome","http://hl7.org/fhir/StructureDefinition/OperationOutcome", IsResource=true)]
  public partial class OperationOutcome : Hl7.Fhir.Model.DomainResource
  {
    /// <summary>
    /// FHIR Type Name
    /// </summary>
    public override string TypeName { get { return "OperationOutcome"; } }

    /// <summary>
    /// How the issue affects the success of the action.
    /// (url: http://hl7.org/fhir/ValueSet/issue-severity)
    /// (system: http://hl7.org/fhir/issue-severity)
    /// </summary>
    [FhirEnumeration("IssueSeverity")]
    public enum IssueSeverity
    {
      /// <summary>
      /// The issue caused the action to fail and no further checking could be performed.
      /// (system: http://hl7.org/fhir/issue-severity)
      /// </summary>
      [EnumLiteral("fatal", "http://hl7.org/fhir/issue-severity"), Description("Fatal")]
      Fatal,
      /// <summary>
      /// The issue is sufficiently important to cause the action to fail.
      /// (system: http://hl7.org/fhir/issue-severity)
      /// </summary>
      [EnumLiteral("error", "http://hl7.org/fhir/issue-severity"), Description("Error")]
      Error,
      /// <summary>
      /// The issue is not important enough to cause the action to fail but may cause it to be performed suboptimally or in a way that is not as desired.
      /// (system: http://hl7.org/fhir/issue-severity)
      /// </summary>
      [EnumLiteral("warning", "http://hl7.org/fhir/issue-severity"), Description("Warning")]
      Warning,
      /// <summary>
      /// The issue has no relation to the degree of success of the action.
      /// (system: http://hl7.org/fhir/issue-severity)
      /// </summary>
      [EnumLiteral("information", "http://hl7.org/fhir/issue-severity"), Description("Information")]
      Information,
      /// <summary>
      /// The operation completed successfully.
      /// (system: http://hl7.org/fhir/issue-severity)
      /// </summary>
      [EnumLiteral("success", "http://hl7.org/fhir/issue-severity"), Description("Operation Successful")]
      Success,
    }

    /// <summary>
    /// A code that describes the type of issue.
    /// (url: http://hl7.org/fhir/ValueSet/issue-type)
    /// (system: http://hl7.org/fhir/issue-type)
    /// </summary>
    [FhirEnumeration("IssueType")]
    public enum IssueType
    {
      /// <summary>
      /// Content invalid against the specification or a profile.
      /// (system: http://hl7.org/fhir/issue-type)
      /// </summary>
      [EnumLiteral("invalid", "http://hl7.org/fhir/issue-type"), Description("Invalid Content")]
      Invalid,
      /// <summary>
      /// A structural issue in the content such as wrong namespace, unable to parse the content completely, invalid syntax, etc.
      /// (system: http://hl7.org/fhir/issue-type)
      /// </summary>
      [EnumLiteral("structure", "http://hl7.org/fhir/issue-type"), Description("Structural Issue")]
      Structure,
      /// <summary>
      /// A required element is missing.
      /// (system: http://hl7.org/fhir/issue-type)
      /// </summary>
      [EnumLiteral("required", "http://hl7.org/fhir/issue-type"), Description("Required element missing")]
      Required,
      /// <summary>
      /// An element or header value is invalid.
      /// (system: http://hl7.org/fhir/issue-type)
      /// </summary>
      [EnumLiteral("value", "http://hl7.org/fhir/issue-type"), Description("Element value invalid")]
      Value,
      /// <summary>
      /// A content validation rule failed - e.g. a schematron rule.
      /// (system: http://hl7.org/fhir/issue-type)
      /// </summary>
      [EnumLiteral("invariant", "http://hl7.org/fhir/issue-type"), Description("Validation rule failed")]
      Invariant,
      /// <summary>
      /// An authentication/authorization/permissions issue of some kind.
      /// (system: http://hl7.org/fhir/issue-type)
      /// </summary>
      [EnumLiteral("security", "http://hl7.org/fhir/issue-type"), Description("Security Problem")]
      Security,
      /// <summary>
      /// The client needs to initiate an authentication process.
      /// (system: http://hl7.org/fhir/issue-type)
      /// </summary>
      [EnumLiteral("login", "http://hl7.org/fhir/issue-type"), Description("Login Required")]
      Login,
      /// <summary>
      /// The user or system was not able to be authenticated (either there is no process, or the proferred token is unacceptable).
      /// (system: http://hl7.org/fhir/issue-type)
      /// </summary>
      [EnumLiteral("unknown", "http://hl7.org/fhir/issue-type"), Description("Unknown User")]
      Unknown,
      /// <summary>
      /// User session expired; a login may be required.
      /// (system: http://hl7.org/fhir/issue-type)
      /// </summary>
      [EnumLiteral("expired", "http://hl7.org/fhir/issue-type"), Description("Session Expired")]
      Expired,
      /// <summary>
      /// The user does not have the rights to perform this action.
      /// (system: http://hl7.org/fhir/issue-type)
      /// </summary>
      [EnumLiteral("forbidden", "http://hl7.org/fhir/issue-type"), Description("Forbidden")]
      Forbidden,
      /// <summary>
      /// Some information was not or might not have been returned due to business rules, consent or privacy rules, or access permission constraints.  This information may be accessible through alternate processes.
      /// (system: http://hl7.org/fhir/issue-type)
      /// </summary>
      [EnumLiteral("suppressed", "http://hl7.org/fhir/issue-type"), Description("Information  Suppressed")]
      Suppressed,
      /// <summary>
      /// Processing issues. These are expected to be final e.g. there is no point resubmitting the same content unchanged.
      /// (system: http://hl7.org/fhir/issue-type)
      /// </summary>
      [EnumLiteral("processing", "http://hl7.org/fhir/issue-type"), Description("Processing Failure")]
      Processing,
      /// <summary>
      /// The interaction, operation, resource or profile is not supported.
      /// (system: http://hl7.org/fhir/issue-type)
      /// </summary>
      [EnumLiteral("not-supported", "http://hl7.org/fhir/issue-type"), Description("Content not supported")]
      NotSupported,
      /// <summary>
      /// An attempt was made to create a duplicate record.
      /// (system: http://hl7.org/fhir/issue-type)
      /// </summary>
      [EnumLiteral("duplicate", "http://hl7.org/fhir/issue-type"), Description("Duplicate")]
      Duplicate,
      /// <summary>
      /// Multiple matching records were found when the operation required only one match.
      /// (system: http://hl7.org/fhir/issue-type)
      /// </summary>
      [EnumLiteral("multiple-matches", "http://hl7.org/fhir/issue-type"), Description("Multiple Matches")]
      MultipleMatches,
      /// <summary>
      /// The reference provided was not found. In a pure RESTful environment, this would be an HTTP 404 error, but this code may be used where the content is not found further into the application architecture.
      /// (system: http://hl7.org/fhir/issue-type)
      /// </summary>
      [EnumLiteral("not-found", "http://hl7.org/fhir/issue-type"), Description("Not Found")]
      NotFound,
      /// <summary>
      /// The reference pointed to content (usually a resource) that has been deleted.
      /// (system: http://hl7.org/fhir/issue-type)
      /// </summary>
      [EnumLiteral("deleted", "http://hl7.org/fhir/issue-type"), Description("Deleted")]
      Deleted,
      /// <summary>
      /// Provided content is too long (typically, this is a denial of service protection type of error).
      /// (system: http://hl7.org/fhir/issue-type)
      /// </summary>
      [EnumLiteral("too-long", "http://hl7.org/fhir/issue-type"), Description("Content Too Long")]
      TooLong,
      /// <summary>
      /// The code or system could not be understood, or it was not valid in the context of a particular ValueSet.code.
      /// (system: http://hl7.org/fhir/issue-type)
      /// </summary>
      [EnumLiteral("code-invalid", "http://hl7.org/fhir/issue-type"), Description("Invalid Code")]
      CodeInvalid,
      /// <summary>
      /// An extension was found that was not acceptable, could not be resolved, or a modifierExtension was not recognized.
      /// (system: http://hl7.org/fhir/issue-type)
      /// </summary>
      [EnumLiteral("extension", "http://hl7.org/fhir/issue-type"), Description("Unacceptable Extension")]
      Extension,
      /// <summary>
      /// The operation was stopped to protect server resources; e.g. a request for a value set expansion on all of SNOMED CT.
      /// (system: http://hl7.org/fhir/issue-type)
      /// </summary>
      [EnumLiteral("too-costly", "http://hl7.org/fhir/issue-type"), Description("Operation Too Costly")]
      TooCostly,
      /// <summary>
      /// The content/operation failed to pass some business rule and so could not proceed.
      /// (system: http://hl7.org/fhir/issue-type)
      /// </summary>
      [EnumLiteral("business-rule", "http://hl7.org/fhir/issue-type"), Description("Business Rule Violation")]
      BusinessRule,
      /// <summary>
      /// Content could not be accepted because of an edit conflict (i.e. version aware updates). (In a pure RESTful environment, this would be an HTTP 409 error, but this code may be used where the conflict is discovered further into the application architecture.).
      /// (system: http://hl7.org/fhir/issue-type)
      /// </summary>
      [EnumLiteral("conflict", "http://hl7.org/fhir/issue-type"), Description("Edit Version Conflict")]
      Conflict,
      /// <summary>
      /// Some search filters might not have applied on all results.  Data may have been included that does not meet all of the filters listed in the `self` `Bundle.link`.
      /// (system: http://hl7.org/fhir/issue-type)
      /// </summary>
      [EnumLiteral("limited-filter", "http://hl7.org/fhir/issue-type"), Description("Limited Filter Application")]
      LimitedFilter,
      /// <summary>
      /// Transient processing issues. The system receiving the message may be able to resubmit the same content once an underlying issue is resolved.
      /// (system: http://hl7.org/fhir/issue-type)
      /// </summary>
      [EnumLiteral("transient", "http://hl7.org/fhir/issue-type"), Description("Transient Issue")]
      Transient,
      /// <summary>
      /// A resource/record locking failure (usually in an underlying database).
      /// (system: http://hl7.org/fhir/issue-type)
      /// </summary>
      [EnumLiteral("lock-error", "http://hl7.org/fhir/issue-type"), Description("Lock Error")]
      LockError,
      /// <summary>
      /// The persistent store is unavailable; e.g. the database is down for maintenance or similar action, and the interaction or operation cannot be processed.
      /// (system: http://hl7.org/fhir/issue-type)
      /// </summary>
      [EnumLiteral("no-store", "http://hl7.org/fhir/issue-type"), Description("No Store Available")]
      NoStore,
      /// <summary>
      /// An unexpected internal error has occurred.
      /// (system: http://hl7.org/fhir/issue-type)
      /// </summary>
      [EnumLiteral("exception", "http://hl7.org/fhir/issue-type"), Description("Exception")]
      Exception,
      /// <summary>
      /// An internal timeout has occurred.
      /// (system: http://hl7.org/fhir/issue-type)
      /// </summary>
      [EnumLiteral("timeout", "http://hl7.org/fhir/issue-type"), Description("Timeout")]
      Timeout,
      /// <summary>
      /// Not all data sources typically accessed could be reached or responded in time, so the returned information might not be complete (applies to search interactions and some operations).
      /// (system: http://hl7.org/fhir/issue-type)
      /// </summary>
      [EnumLiteral("incomplete", "http://hl7.org/fhir/issue-type"), Description("Incomplete Results")]
      Incomplete,
      /// <summary>
      /// The system is not prepared to handle this request due to load management.
      /// (system: http://hl7.org/fhir/issue-type)
      /// </summary>
      [EnumLiteral("throttled", "http://hl7.org/fhir/issue-type"), Description("Throttled")]
      Throttled,
      /// <summary>
      /// A message unrelated to the processing success of the completed operation (examples of the latter include things like reminders of password expiry, system maintenance times, etc.).
      /// (system: http://hl7.org/fhir/issue-type)
      /// </summary>
      [EnumLiteral("informational", "http://hl7.org/fhir/issue-type"), Description("Informational Note")]
      Informational,
      /// <summary>
      /// The operation completed successfully.
      /// (system: http://hl7.org/fhir/issue-type)
      /// </summary>
      [EnumLiteral("success", "http://hl7.org/fhir/issue-type"), Description("Operation Successful")]
      Success,
    }

    /// <summary>
    /// A single issue associated with the action
    /// </summary>
    [Serializable]
    [DataContract]
    [FhirType("OperationOutcome#Issue", IsNestedType=true)]
    public partial class IssueComponent : Hl7.Fhir.Model.BackboneElement
    {
      /// <summary>
      /// FHIR Type Name
      /// </summary>
      public override string TypeName { get { return "OperationOutcome#Issue"; } }

      /// <summary>
      /// fatal | error | warning | information | success
      /// </summary>
      [FhirElement("severity", InSummary=true, IsModifier=true, Order=40)]
      [FhirElement("severity", InSummary=true, Order=40, Since=FhirRelease.R4)]
      [DeclaredType(Type = typeof(Code))]
      [Cardinality(Min=1,Max=1)]
      [DataMember]
      public Code<Hl7.Fhir.Model.OperationOutcome.IssueSeverity> SeverityElement
      {
        get { return _SeverityElement; }
        set { _SeverityElement = value; OnPropertyChanged("SeverityElement"); }
      }

      private Code<Hl7.Fhir.Model.OperationOutcome.IssueSeverity> _SeverityElement;

      /// <summary>
      /// fatal | error | warning | information | success
      /// </summary>
      /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
      [IgnoreDataMember]
      public Hl7.Fhir.Model.OperationOutcome.IssueSeverity? Severity
      {
        get { return SeverityElement != null ? SeverityElement.Value : null; }
        set
        {
          if (value == null)
            SeverityElement = null;
          else
            SeverityElement = new Code<Hl7.Fhir.Model.OperationOutcome.IssueSeverity>(value);
          OnPropertyChanged("Severity");
        }
      }

      /// <summary>
      /// Error or warning code
      /// </summary>
      [FhirElement("code", InSummary=true, Order=50)]
      [DeclaredType(Type = typeof(Code))]
      [Cardinality(Min=1,Max=1)]
      [DataMember]
      public Code<Hl7.Fhir.Model.OperationOutcome.IssueType> CodeElement
      {
        get { return _CodeElement; }
        set { _CodeElement = value; OnPropertyChanged("CodeElement"); }
      }

      private Code<Hl7.Fhir.Model.OperationOutcome.IssueType> _CodeElement;

      /// <summary>
      /// Error or warning code
      /// </summary>
      /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
      [IgnoreDataMember]
      public Hl7.Fhir.Model.OperationOutcome.IssueType? Code
      {
        get { return CodeElement != null ? CodeElement.Value : null; }
        set
        {
          if (value == null)
            CodeElement = null;
          else
            CodeElement = new Code<Hl7.Fhir.Model.OperationOutcome.IssueType>(value);
          OnPropertyChanged("Code");
        }
      }

      /// <summary>
      /// Additional details about the error
      /// </summary>
      [FhirElement("details", InSummary=true, Order=60)]
      [DataMember]
      public Hl7.Fhir.Model.CodeableConcept Details
      {
        get { return _Details; }
        set { _Details = value; OnPropertyChanged("Details"); }
      }

      private Hl7.Fhir.Model.CodeableConcept _Details;

      /// <summary>
      /// Additional diagnostic information about the issue
      /// </summary>
      [FhirElement("diagnostics", InSummary=true, Order=70)]
      [DataMember]
      public Hl7.Fhir.Model.FhirString DiagnosticsElement
      {
        get { return _DiagnosticsElement; }
        set { _DiagnosticsElement = value; OnPropertyChanged("DiagnosticsElement"); }
      }

      private Hl7.Fhir.Model.FhirString _DiagnosticsElement;

      /// <summary>
      /// Additional diagnostic information about the issue
      /// </summary>
      /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
      [IgnoreDataMember]
      public string Diagnostics
      {
        get { return DiagnosticsElement != null ? DiagnosticsElement.Value : null; }
        set
        {
          if (value == null)
            DiagnosticsElement = null;
          else
            DiagnosticsElement = new Hl7.Fhir.Model.FhirString(value);
          OnPropertyChanged("Diagnostics");
        }
      }

      /// <summary>
      /// Deprecated: Path of element(s) related to issue
      /// </summary>
      [FhirElement("location", InSummary=true, Order=80)]
      [Cardinality(Min=0,Max=-1)]
      [DataMember]
      public List<Hl7.Fhir.Model.FhirString> LocationElement
      {
        get { if(_LocationElement==null) _LocationElement = new List<Hl7.Fhir.Model.FhirString>(); return _LocationElement; }
        set { _LocationElement = value; OnPropertyChanged("LocationElement"); }
      }

      private List<Hl7.Fhir.Model.FhirString> _LocationElement;

      /// <summary>
      /// Deprecated: Path of element(s) related to issue
      /// </summary>
      /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
      [IgnoreDataMember]
      public IEnumerable<string> Location
      {
        get { return LocationElement != null ? LocationElement.Select(elem => elem.Value) : null; }
        set
        {
          if (value == null)
            LocationElement = null;
          else
            LocationElement = new List<Hl7.Fhir.Model.FhirString>(value.Select(elem=>new Hl7.Fhir.Model.FhirString(elem)));
          OnPropertyChanged("Location");
        }
      }

      /// <summary>
      /// FHIRPath of element(s) related to issue
      /// </summary>
      [FhirElement("expression", InSummary=true, Order=90)]
      [Cardinality(Min=0,Max=-1)]
      [DataMember]
      public List<Hl7.Fhir.Model.FhirString> ExpressionElement
      {
        get { if(_ExpressionElement==null) _ExpressionElement = new List<Hl7.Fhir.Model.FhirString>(); return _ExpressionElement; }
        set { _ExpressionElement = value; OnPropertyChanged("ExpressionElement"); }
      }

      private List<Hl7.Fhir.Model.FhirString> _ExpressionElement;

      /// <summary>
      /// FHIRPath of element(s) related to issue
      /// </summary>
      /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
      [IgnoreDataMember]
      public IEnumerable<string> Expression
      {
        get { return ExpressionElement != null ? ExpressionElement.Select(elem => elem.Value) : null; }
        set
        {
          if (value == null)
            ExpressionElement = null;
          else
            ExpressionElement = new List<Hl7.Fhir.Model.FhirString>(value.Select(elem=>new Hl7.Fhir.Model.FhirString(elem)));
          OnPropertyChanged("Expression");
        }
      }

      public override IDeepCopyable CopyTo(IDeepCopyable other)
      {
        var dest = other as IssueComponent;

        if (dest == null)
        {
          throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        base.CopyTo(dest);
        if(SeverityElement != null) dest.SeverityElement = (Code<Hl7.Fhir.Model.OperationOutcome.IssueSeverity>)SeverityElement.DeepCopy();
        if(CodeElement != null) dest.CodeElement = (Code<Hl7.Fhir.Model.OperationOutcome.IssueType>)CodeElement.DeepCopy();
        if(Details != null) dest.Details = (Hl7.Fhir.Model.CodeableConcept)Details.DeepCopy();
        if(DiagnosticsElement != null) dest.DiagnosticsElement = (Hl7.Fhir.Model.FhirString)DiagnosticsElement.DeepCopy();
        if(LocationElement != null) dest.LocationElement = new List<Hl7.Fhir.Model.FhirString>(LocationElement.DeepCopy());
        if(ExpressionElement != null) dest.ExpressionElement = new List<Hl7.Fhir.Model.FhirString>(ExpressionElement.DeepCopy());
        return dest;
      }

      public override IDeepCopyable DeepCopy()
      {
        return CopyTo(new IssueComponent());
      }

      ///<inheritdoc />
      public override bool Matches(IDeepComparable other)
      {
        var otherT = other as IssueComponent;
        if(otherT == null) return false;

        if(!base.Matches(otherT)) return false;
        if( !DeepComparable.Matches(SeverityElement, otherT.SeverityElement)) return false;
        if( !DeepComparable.Matches(CodeElement, otherT.CodeElement)) return false;
        if( !DeepComparable.Matches(Details, otherT.Details)) return false;
        if( !DeepComparable.Matches(DiagnosticsElement, otherT.DiagnosticsElement)) return false;
        if( !DeepComparable.Matches(LocationElement, otherT.LocationElement)) return false;
        if( !DeepComparable.Matches(ExpressionElement, otherT.ExpressionElement)) return false;

        return true;
      }

      public override bool IsExactly(IDeepComparable other)
      {
        var otherT = other as IssueComponent;
        if(otherT == null) return false;

        if(!base.IsExactly(otherT)) return false;
        if( !DeepComparable.IsExactly(SeverityElement, otherT.SeverityElement)) return false;
        if( !DeepComparable.IsExactly(CodeElement, otherT.CodeElement)) return false;
        if( !DeepComparable.IsExactly(Details, otherT.Details)) return false;
        if( !DeepComparable.IsExactly(DiagnosticsElement, otherT.DiagnosticsElement)) return false;
        if( !DeepComparable.IsExactly(LocationElement, otherT.LocationElement)) return false;
        if( !DeepComparable.IsExactly(ExpressionElement, otherT.ExpressionElement)) return false;

        return true;
      }

      [IgnoreDataMember]
      public override IEnumerable<Base> Children
      {
        get
        {
          foreach (var item in base.Children) yield return item;
          if (SeverityElement != null) yield return SeverityElement;
          if (CodeElement != null) yield return CodeElement;
          if (Details != null) yield return Details;
          if (DiagnosticsElement != null) yield return DiagnosticsElement;
          foreach (var elem in LocationElement) { if (elem != null) yield return elem; }
          foreach (var elem in ExpressionElement) { if (elem != null) yield return elem; }
        }
      }

      [IgnoreDataMember]
      public override IEnumerable<ElementValue> NamedChildren
      {
        get
        {
          foreach (var item in base.NamedChildren) yield return item;
          if (SeverityElement != null) yield return new ElementValue("severity", SeverityElement);
          if (CodeElement != null) yield return new ElementValue("code", CodeElement);
          if (Details != null) yield return new ElementValue("details", Details);
          if (DiagnosticsElement != null) yield return new ElementValue("diagnostics", DiagnosticsElement);
          foreach (var elem in LocationElement) { if (elem != null) yield return new ElementValue("location", elem); }
          foreach (var elem in ExpressionElement) { if (elem != null) yield return new ElementValue("expression", elem); }
        }
      }

      protected override bool TryGetValue(string key, out object value)
      {
        switch (key)
        {
          case "severity":
            value = SeverityElement;
            return SeverityElement is not null;
          case "code":
            value = CodeElement;
            return CodeElement is not null;
          case "details":
            value = Details;
            return Details is not null;
          case "diagnostics":
            value = DiagnosticsElement;
            return DiagnosticsElement is not null;
          case "location":
            value = LocationElement;
            return LocationElement?.Any() == true;
          case "expression":
            value = ExpressionElement;
            return ExpressionElement?.Any() == true;
          default:
            return base.TryGetValue(key, out value);
        }

      }

      protected override IEnumerable<KeyValuePair<string, object>> GetElementPairs()
      {
        foreach (var kvp in base.GetElementPairs()) yield return kvp;
        if (SeverityElement is not null) yield return new KeyValuePair<string,object>("severity",SeverityElement);
        if (CodeElement is not null) yield return new KeyValuePair<string,object>("code",CodeElement);
        if (Details is not null) yield return new KeyValuePair<string,object>("details",Details);
        if (DiagnosticsElement is not null) yield return new KeyValuePair<string,object>("diagnostics",DiagnosticsElement);
        if (LocationElement?.Any() == true) yield return new KeyValuePair<string,object>("location",LocationElement);
        if (ExpressionElement?.Any() == true) yield return new KeyValuePair<string,object>("expression",ExpressionElement);
      }

    }

    /// <summary>
    /// A single issue associated with the action
    /// </summary>
    [FhirElement("issue", InSummary=true, Order=90)]
    [Cardinality(Min=1,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.OperationOutcome.IssueComponent> Issue
    {
      get { if(_Issue==null) _Issue = new List<Hl7.Fhir.Model.OperationOutcome.IssueComponent>(); return _Issue; }
      set { _Issue = value; OnPropertyChanged("Issue"); }
    }

    private List<Hl7.Fhir.Model.OperationOutcome.IssueComponent> _Issue;

    public override IDeepCopyable CopyTo(IDeepCopyable other)
    {
      var dest = other as OperationOutcome;

      if (dest == null)
      {
        throw new ArgumentException("Can only copy to an object of the same type", "other");
      }

      base.CopyTo(dest);
      if(Issue != null) dest.Issue = new List<Hl7.Fhir.Model.OperationOutcome.IssueComponent>(Issue.DeepCopy());
      return dest;
    }

    public override IDeepCopyable DeepCopy()
    {
      return CopyTo(new OperationOutcome());
    }

    ///<inheritdoc />
    public override bool Matches(IDeepComparable other)
    {
      var otherT = other as OperationOutcome;
      if(otherT == null) return false;

      if(!base.Matches(otherT)) return false;
      if( !DeepComparable.Matches(Issue, otherT.Issue)) return false;

      return true;
    }

    public override bool IsExactly(IDeepComparable other)
    {
      var otherT = other as OperationOutcome;
      if(otherT == null) return false;

      if(!base.IsExactly(otherT)) return false;
      if( !DeepComparable.IsExactly(Issue, otherT.Issue)) return false;

      return true;
    }

    [IgnoreDataMember]
    public override IEnumerable<Base> Children
    {
      get
      {
        foreach (var item in base.Children) yield return item;
        foreach (var elem in Issue) { if (elem != null) yield return elem; }
      }
    }

    [IgnoreDataMember]
    public override IEnumerable<ElementValue> NamedChildren
    {
      get
      {
        foreach (var item in base.NamedChildren) yield return item;
        foreach (var elem in Issue) { if (elem != null) yield return new ElementValue("issue", elem); }
      }
    }

    protected override bool TryGetValue(string key, out object value)
    {
      switch (key)
      {
        case "issue":
          value = Issue;
          return Issue?.Any() == true;
        default:
          return base.TryGetValue(key, out value);
      }

    }

    protected override IEnumerable<KeyValuePair<string, object>> GetElementPairs()
    {
      foreach (var kvp in base.GetElementPairs()) yield return kvp;
      if (Issue?.Any() == true) yield return new KeyValuePair<string,object>("issue",Issue);
    }

  }

}

// end of file

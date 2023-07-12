// <auto-generated/>
// Contents of: hl7.fhir.r3.core version: 3.0.2

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
  /// ProcessResponse resource
  /// </summary>
  [Serializable]
  [DataContract]
  [FhirType("ProcessResponse","http://hl7.org/fhir/StructureDefinition/ProcessResponse", IsResource=true)]
  public partial class ProcessResponse : Hl7.Fhir.Model.DomainResource, IIdentifiable<List<Identifier>>
  {
    /// <summary>
    /// FHIR Type Name
    /// </summary>
    public override string TypeName { get { return "ProcessResponse"; } }

    /// <summary>
    /// Processing comments or additional requirements
    /// </summary>
    [Serializable]
    [DataContract]
    [FhirType("ProcessResponse#ProcessNote", IsNestedType=true)]
    [BackboneType("ProcessResponse.processNote")]
    public partial class ProcessNoteComponent : Hl7.Fhir.Model.BackboneElement
    {
      /// <summary>
      /// FHIR Type Name
      /// </summary>
      public override string TypeName { get { return "ProcessResponse#ProcessNote"; } }

      /// <summary>
      /// display | print | printoper
      /// </summary>
      [FhirElement("type", Order=40)]
      [DataMember]
      public Hl7.Fhir.Model.CodeableConcept Type
      {
        get { return _Type; }
        set { _Type = value; OnPropertyChanged("Type"); }
      }

      private Hl7.Fhir.Model.CodeableConcept _Type;

      /// <summary>
      /// Comment on the processing
      /// </summary>
      [FhirElement("text", Order=50)]
      [DataMember]
      public Hl7.Fhir.Model.FhirString TextElement
      {
        get { return _TextElement; }
        set { _TextElement = value; OnPropertyChanged("TextElement"); }
      }

      private Hl7.Fhir.Model.FhirString _TextElement;

      /// <summary>
      /// Comment on the processing
      /// </summary>
      /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
      [IgnoreDataMember]
      public string Text
      {
        get { return TextElement != null ? TextElement.Value : null; }
        set
        {
          if (value == null)
            TextElement = null;
          else
            TextElement = new Hl7.Fhir.Model.FhirString(value);
          OnPropertyChanged("Text");
        }
      }

      public override IDeepCopyable CopyTo(IDeepCopyable other)
      {
        var dest = other as ProcessNoteComponent;

        if (dest == null)
        {
          throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        base.CopyTo(dest);
        if(Type != null) dest.Type = (Hl7.Fhir.Model.CodeableConcept)Type.DeepCopy();
        if(TextElement != null) dest.TextElement = (Hl7.Fhir.Model.FhirString)TextElement.DeepCopy();
        return dest;
      }

      public override IDeepCopyable DeepCopy()
      {
        return CopyTo(new ProcessNoteComponent());
      }

      ///<inheritdoc />
      public override bool Matches(IDeepComparable other)
      {
        var otherT = other as ProcessNoteComponent;
        if(otherT == null) return false;

        if(!base.Matches(otherT)) return false;
        if( !DeepComparable.Matches(Type, otherT.Type)) return false;
        if( !DeepComparable.Matches(TextElement, otherT.TextElement)) return false;

        return true;
      }

      public override bool IsExactly(IDeepComparable other)
      {
        var otherT = other as ProcessNoteComponent;
        if(otherT == null) return false;

        if(!base.IsExactly(otherT)) return false;
        if( !DeepComparable.IsExactly(Type, otherT.Type)) return false;
        if( !DeepComparable.IsExactly(TextElement, otherT.TextElement)) return false;

        return true;
      }

      [IgnoreDataMember]
      public override IEnumerable<Base> Children
      {
        get
        {
          foreach (var item in base.Children) yield return item;
          if (Type != null) yield return Type;
          if (TextElement != null) yield return TextElement;
        }
      }

      [IgnoreDataMember]
      public override IEnumerable<ElementValue> NamedChildren
      {
        get
        {
          foreach (var item in base.NamedChildren) yield return item;
          if (Type != null) yield return new ElementValue("type", Type);
          if (TextElement != null) yield return new ElementValue("text", TextElement);
        }
      }

      protected override bool TryGetValue(string key, out object value)
      {
        switch (key)
        {
          case "type":
            value = Type;
            return Type is not null;
          case "text":
            value = TextElement;
            return TextElement is not null;
          default:
            return base.TryGetValue(key, out value);
        }

      }

      protected override IEnumerable<KeyValuePair<string, object>> GetElementPairs()
      {
        foreach (var kvp in base.GetElementPairs()) yield return kvp;
        if (Type is not null) yield return new KeyValuePair<string,object>("type",Type);
        if (TextElement is not null) yield return new KeyValuePair<string,object>("text",TextElement);
      }

    }

    /// <summary>
    /// Business Identifier
    /// </summary>
    [FhirElement("identifier", Order=90, FiveWs="id")]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.Identifier> Identifier
    {
      get { if(_Identifier==null) _Identifier = new List<Hl7.Fhir.Model.Identifier>(); return _Identifier; }
      set { _Identifier = value; OnPropertyChanged("Identifier"); }
    }

    private List<Hl7.Fhir.Model.Identifier> _Identifier;

    /// <summary>
    /// active | cancelled | draft | entered-in-error
    /// </summary>
    [FhirElement("status", InSummary=true, IsModifier=true, Order=100, FiveWs="status")]
    [DeclaredType(Type = typeof(Code))]
    [Binding("ProcessResponseStatus")]
    [DataMember]
    public Code<Hl7.Fhir.Model.FinancialResourceStatusCodes> StatusElement
    {
      get { return _StatusElement; }
      set { _StatusElement = value; OnPropertyChanged("StatusElement"); }
    }

    private Code<Hl7.Fhir.Model.FinancialResourceStatusCodes> _StatusElement;

    /// <summary>
    /// active | cancelled | draft | entered-in-error
    /// </summary>
    /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
    [IgnoreDataMember]
    public Hl7.Fhir.Model.FinancialResourceStatusCodes? Status
    {
      get { return StatusElement != null ? StatusElement.Value : null; }
      set
      {
        if (value == null)
          StatusElement = null;
        else
          StatusElement = new Code<Hl7.Fhir.Model.FinancialResourceStatusCodes>(value);
        OnPropertyChanged("Status");
      }
    }

    /// <summary>
    /// Creation date
    /// </summary>
    [FhirElement("created", Order=110, FiveWs="when.recorded")]
    [DataMember]
    public Hl7.Fhir.Model.FhirDateTime CreatedElement
    {
      get { return _CreatedElement; }
      set { _CreatedElement = value; OnPropertyChanged("CreatedElement"); }
    }

    private Hl7.Fhir.Model.FhirDateTime _CreatedElement;

    /// <summary>
    /// Creation date
    /// </summary>
    /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
    [IgnoreDataMember]
    public string Created
    {
      get { return CreatedElement != null ? CreatedElement.Value : null; }
      set
      {
        if (value == null)
          CreatedElement = null;
        else
          CreatedElement = new Hl7.Fhir.Model.FhirDateTime(value);
        OnPropertyChanged("Created");
      }
    }

    /// <summary>
    /// Authoring Organization
    /// </summary>
    [FhirElement("organization", Order=120, FiveWs="who.source")]
    [CLSCompliant(false)]
    [References("Organization")]
    [DataMember]
    public Hl7.Fhir.Model.ResourceReference Organization
    {
      get { return _Organization; }
      set { _Organization = value; OnPropertyChanged("Organization"); }
    }

    private Hl7.Fhir.Model.ResourceReference _Organization;

    /// <summary>
    /// Request reference
    /// </summary>
    [FhirElement("request", Order=130, FiveWs="why")]
    [CLSCompliant(false)]
    [References("Resource")]
    [DataMember]
    public Hl7.Fhir.Model.ResourceReference Request
    {
      get { return _Request; }
      set { _Request = value; OnPropertyChanged("Request"); }
    }

    private Hl7.Fhir.Model.ResourceReference _Request;

    /// <summary>
    /// Processing outcome
    /// </summary>
    [FhirElement("outcome", Order=140)]
    [DataMember]
    public Hl7.Fhir.Model.CodeableConcept Outcome
    {
      get { return _Outcome; }
      set { _Outcome = value; OnPropertyChanged("Outcome"); }
    }

    private Hl7.Fhir.Model.CodeableConcept _Outcome;

    /// <summary>
    /// Disposition Message
    /// </summary>
    [FhirElement("disposition", Order=150)]
    [DataMember]
    public Hl7.Fhir.Model.FhirString DispositionElement
    {
      get { return _DispositionElement; }
      set { _DispositionElement = value; OnPropertyChanged("DispositionElement"); }
    }

    private Hl7.Fhir.Model.FhirString _DispositionElement;

    /// <summary>
    /// Disposition Message
    /// </summary>
    /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
    [IgnoreDataMember]
    public string Disposition
    {
      get { return DispositionElement != null ? DispositionElement.Value : null; }
      set
      {
        if (value == null)
          DispositionElement = null;
        else
          DispositionElement = new Hl7.Fhir.Model.FhirString(value);
        OnPropertyChanged("Disposition");
      }
    }

    /// <summary>
    /// Responsible Practitioner
    /// </summary>
    [FhirElement("requestProvider", Order=160)]
    [CLSCompliant(false)]
    [References("Practitioner")]
    [DataMember]
    public Hl7.Fhir.Model.ResourceReference RequestProvider
    {
      get { return _RequestProvider; }
      set { _RequestProvider = value; OnPropertyChanged("RequestProvider"); }
    }

    private Hl7.Fhir.Model.ResourceReference _RequestProvider;

    /// <summary>
    /// Responsible organization
    /// </summary>
    [FhirElement("requestOrganization", Order=170)]
    [CLSCompliant(false)]
    [References("Organization")]
    [DataMember]
    public Hl7.Fhir.Model.ResourceReference RequestOrganization
    {
      get { return _RequestOrganization; }
      set { _RequestOrganization = value; OnPropertyChanged("RequestOrganization"); }
    }

    private Hl7.Fhir.Model.ResourceReference _RequestOrganization;

    /// <summary>
    /// Printed Form Identifier
    /// </summary>
    [FhirElement("form", Order=180)]
    [DataMember]
    public Hl7.Fhir.Model.CodeableConcept Form
    {
      get { return _Form; }
      set { _Form = value; OnPropertyChanged("Form"); }
    }

    private Hl7.Fhir.Model.CodeableConcept _Form;

    /// <summary>
    /// Processing comments or additional requirements
    /// </summary>
    [FhirElement("processNote", Order=190)]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.ProcessResponse.ProcessNoteComponent> ProcessNote
    {
      get { if(_ProcessNote==null) _ProcessNote = new List<Hl7.Fhir.Model.ProcessResponse.ProcessNoteComponent>(); return _ProcessNote; }
      set { _ProcessNote = value; OnPropertyChanged("ProcessNote"); }
    }

    private List<Hl7.Fhir.Model.ProcessResponse.ProcessNoteComponent> _ProcessNote;

    /// <summary>
    /// Error code
    /// </summary>
    [FhirElement("error", Order=200)]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.CodeableConcept> Error
    {
      get { if(_Error==null) _Error = new List<Hl7.Fhir.Model.CodeableConcept>(); return _Error; }
      set { _Error = value; OnPropertyChanged("Error"); }
    }

    private List<Hl7.Fhir.Model.CodeableConcept> _Error;

    /// <summary>
    /// Request for additional information
    /// </summary>
    [FhirElement("communicationRequest", Order=210)]
    [CLSCompliant(false)]
    [References("CommunicationRequest")]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.ResourceReference> CommunicationRequest
    {
      get { if(_CommunicationRequest==null) _CommunicationRequest = new List<Hl7.Fhir.Model.ResourceReference>(); return _CommunicationRequest; }
      set { _CommunicationRequest = value; OnPropertyChanged("CommunicationRequest"); }
    }

    private List<Hl7.Fhir.Model.ResourceReference> _CommunicationRequest;

    List<Identifier> IIdentifiable<List<Identifier>>.Identifier { get => Identifier; set => Identifier = value; }

    public override IDeepCopyable CopyTo(IDeepCopyable other)
    {
      var dest = other as ProcessResponse;

      if (dest == null)
      {
        throw new ArgumentException("Can only copy to an object of the same type", "other");
      }

      base.CopyTo(dest);
      if(Identifier != null) dest.Identifier = new List<Hl7.Fhir.Model.Identifier>(Identifier.DeepCopy());
      if(StatusElement != null) dest.StatusElement = (Code<Hl7.Fhir.Model.FinancialResourceStatusCodes>)StatusElement.DeepCopy();
      if(CreatedElement != null) dest.CreatedElement = (Hl7.Fhir.Model.FhirDateTime)CreatedElement.DeepCopy();
      if(Organization != null) dest.Organization = (Hl7.Fhir.Model.ResourceReference)Organization.DeepCopy();
      if(Request != null) dest.Request = (Hl7.Fhir.Model.ResourceReference)Request.DeepCopy();
      if(Outcome != null) dest.Outcome = (Hl7.Fhir.Model.CodeableConcept)Outcome.DeepCopy();
      if(DispositionElement != null) dest.DispositionElement = (Hl7.Fhir.Model.FhirString)DispositionElement.DeepCopy();
      if(RequestProvider != null) dest.RequestProvider = (Hl7.Fhir.Model.ResourceReference)RequestProvider.DeepCopy();
      if(RequestOrganization != null) dest.RequestOrganization = (Hl7.Fhir.Model.ResourceReference)RequestOrganization.DeepCopy();
      if(Form != null) dest.Form = (Hl7.Fhir.Model.CodeableConcept)Form.DeepCopy();
      if(ProcessNote != null) dest.ProcessNote = new List<Hl7.Fhir.Model.ProcessResponse.ProcessNoteComponent>(ProcessNote.DeepCopy());
      if(Error != null) dest.Error = new List<Hl7.Fhir.Model.CodeableConcept>(Error.DeepCopy());
      if(CommunicationRequest != null) dest.CommunicationRequest = new List<Hl7.Fhir.Model.ResourceReference>(CommunicationRequest.DeepCopy());
      return dest;
    }

    public override IDeepCopyable DeepCopy()
    {
      return CopyTo(new ProcessResponse());
    }

    ///<inheritdoc />
    public override bool Matches(IDeepComparable other)
    {
      var otherT = other as ProcessResponse;
      if(otherT == null) return false;

      if(!base.Matches(otherT)) return false;
      if( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
      if( !DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
      if( !DeepComparable.Matches(CreatedElement, otherT.CreatedElement)) return false;
      if( !DeepComparable.Matches(Organization, otherT.Organization)) return false;
      if( !DeepComparable.Matches(Request, otherT.Request)) return false;
      if( !DeepComparable.Matches(Outcome, otherT.Outcome)) return false;
      if( !DeepComparable.Matches(DispositionElement, otherT.DispositionElement)) return false;
      if( !DeepComparable.Matches(RequestProvider, otherT.RequestProvider)) return false;
      if( !DeepComparable.Matches(RequestOrganization, otherT.RequestOrganization)) return false;
      if( !DeepComparable.Matches(Form, otherT.Form)) return false;
      if( !DeepComparable.Matches(ProcessNote, otherT.ProcessNote)) return false;
      if( !DeepComparable.Matches(Error, otherT.Error)) return false;
      if( !DeepComparable.Matches(CommunicationRequest, otherT.CommunicationRequest)) return false;

      return true;
    }

    public override bool IsExactly(IDeepComparable other)
    {
      var otherT = other as ProcessResponse;
      if(otherT == null) return false;

      if(!base.IsExactly(otherT)) return false;
      if( !DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
      if( !DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
      if( !DeepComparable.IsExactly(CreatedElement, otherT.CreatedElement)) return false;
      if( !DeepComparable.IsExactly(Organization, otherT.Organization)) return false;
      if( !DeepComparable.IsExactly(Request, otherT.Request)) return false;
      if( !DeepComparable.IsExactly(Outcome, otherT.Outcome)) return false;
      if( !DeepComparable.IsExactly(DispositionElement, otherT.DispositionElement)) return false;
      if( !DeepComparable.IsExactly(RequestProvider, otherT.RequestProvider)) return false;
      if( !DeepComparable.IsExactly(RequestOrganization, otherT.RequestOrganization)) return false;
      if( !DeepComparable.IsExactly(Form, otherT.Form)) return false;
      if( !DeepComparable.IsExactly(ProcessNote, otherT.ProcessNote)) return false;
      if( !DeepComparable.IsExactly(Error, otherT.Error)) return false;
      if( !DeepComparable.IsExactly(CommunicationRequest, otherT.CommunicationRequest)) return false;

      return true;
    }

    [IgnoreDataMember]
    public override IEnumerable<Base> Children
    {
      get
      {
        foreach (var item in base.Children) yield return item;
        foreach (var elem in Identifier) { if (elem != null) yield return elem; }
        if (StatusElement != null) yield return StatusElement;
        if (CreatedElement != null) yield return CreatedElement;
        if (Organization != null) yield return Organization;
        if (Request != null) yield return Request;
        if (Outcome != null) yield return Outcome;
        if (DispositionElement != null) yield return DispositionElement;
        if (RequestProvider != null) yield return RequestProvider;
        if (RequestOrganization != null) yield return RequestOrganization;
        if (Form != null) yield return Form;
        foreach (var elem in ProcessNote) { if (elem != null) yield return elem; }
        foreach (var elem in Error) { if (elem != null) yield return elem; }
        foreach (var elem in CommunicationRequest) { if (elem != null) yield return elem; }
      }
    }

    [IgnoreDataMember]
    public override IEnumerable<ElementValue> NamedChildren
    {
      get
      {
        foreach (var item in base.NamedChildren) yield return item;
        foreach (var elem in Identifier) { if (elem != null) yield return new ElementValue("identifier", elem); }
        if (StatusElement != null) yield return new ElementValue("status", StatusElement);
        if (CreatedElement != null) yield return new ElementValue("created", CreatedElement);
        if (Organization != null) yield return new ElementValue("organization", Organization);
        if (Request != null) yield return new ElementValue("request", Request);
        if (Outcome != null) yield return new ElementValue("outcome", Outcome);
        if (DispositionElement != null) yield return new ElementValue("disposition", DispositionElement);
        if (RequestProvider != null) yield return new ElementValue("requestProvider", RequestProvider);
        if (RequestOrganization != null) yield return new ElementValue("requestOrganization", RequestOrganization);
        if (Form != null) yield return new ElementValue("form", Form);
        foreach (var elem in ProcessNote) { if (elem != null) yield return new ElementValue("processNote", elem); }
        foreach (var elem in Error) { if (elem != null) yield return new ElementValue("error", elem); }
        foreach (var elem in CommunicationRequest) { if (elem != null) yield return new ElementValue("communicationRequest", elem); }
      }
    }

    protected override bool TryGetValue(string key, out object value)
    {
      switch (key)
      {
        case "identifier":
          value = Identifier;
          return Identifier?.Any() == true;
        case "status":
          value = StatusElement;
          return StatusElement is not null;
        case "created":
          value = CreatedElement;
          return CreatedElement is not null;
        case "organization":
          value = Organization;
          return Organization is not null;
        case "request":
          value = Request;
          return Request is not null;
        case "outcome":
          value = Outcome;
          return Outcome is not null;
        case "disposition":
          value = DispositionElement;
          return DispositionElement is not null;
        case "requestProvider":
          value = RequestProvider;
          return RequestProvider is not null;
        case "requestOrganization":
          value = RequestOrganization;
          return RequestOrganization is not null;
        case "form":
          value = Form;
          return Form is not null;
        case "processNote":
          value = ProcessNote;
          return ProcessNote?.Any() == true;
        case "error":
          value = Error;
          return Error?.Any() == true;
        case "communicationRequest":
          value = CommunicationRequest;
          return CommunicationRequest?.Any() == true;
        default:
          return base.TryGetValue(key, out value);
      }

    }

    protected override IEnumerable<KeyValuePair<string, object>> GetElementPairs()
    {
      foreach (var kvp in base.GetElementPairs()) yield return kvp;
      if (Identifier?.Any() == true) yield return new KeyValuePair<string,object>("identifier",Identifier);
      if (StatusElement is not null) yield return new KeyValuePair<string,object>("status",StatusElement);
      if (CreatedElement is not null) yield return new KeyValuePair<string,object>("created",CreatedElement);
      if (Organization is not null) yield return new KeyValuePair<string,object>("organization",Organization);
      if (Request is not null) yield return new KeyValuePair<string,object>("request",Request);
      if (Outcome is not null) yield return new KeyValuePair<string,object>("outcome",Outcome);
      if (DispositionElement is not null) yield return new KeyValuePair<string,object>("disposition",DispositionElement);
      if (RequestProvider is not null) yield return new KeyValuePair<string,object>("requestProvider",RequestProvider);
      if (RequestOrganization is not null) yield return new KeyValuePair<string,object>("requestOrganization",RequestOrganization);
      if (Form is not null) yield return new KeyValuePair<string,object>("form",Form);
      if (ProcessNote?.Any() == true) yield return new KeyValuePair<string,object>("processNote",ProcessNote);
      if (Error?.Any() == true) yield return new KeyValuePair<string,object>("error",Error);
      if (CommunicationRequest?.Any() == true) yield return new KeyValuePair<string,object>("communicationRequest",CommunicationRequest);
    }

  }

}

// end of file

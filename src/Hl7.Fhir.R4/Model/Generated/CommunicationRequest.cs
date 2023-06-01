// <auto-generated/>
// Contents of: hl7.fhir.r4.core version: 4.0.1

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
  /// A request for information to be sent to a receiver
  /// </summary>
  [Serializable]
  [DataContract]
  [FhirType("CommunicationRequest","http://hl7.org/fhir/StructureDefinition/CommunicationRequest", IsResource=true)]
  public partial class CommunicationRequest : Hl7.Fhir.Model.DomainResource
  {
    /// <summary>
    /// FHIR Type Name
    /// </summary>
    public override string TypeName { get { return "CommunicationRequest"; } }

    /// <summary>
    /// Message payload
    /// </summary>
    [Serializable]
    [DataContract]
    [FhirType("CommunicationRequest#Payload", IsNestedType=true)]
    [CqlType("{http://hl7.org/fhir}CommunicationRequest.Payload")]
    public partial class PayloadComponent : Hl7.Fhir.Model.BackboneElement
    {
      /// <summary>
      /// FHIR Type Name
      /// </summary>
      public override string TypeName { get { return "CommunicationRequest#Payload"; } }

      /// <summary>
      /// Message part content
      /// </summary>
      [FhirElement("content", Order=40, Choice=ChoiceType.DatatypeChoice)]
      [CLSCompliant(false)]
      [References("Resource")]
      [AllowedTypes(typeof(Hl7.Fhir.Model.FhirString),typeof(Hl7.Fhir.Model.Attachment),typeof(Hl7.Fhir.Model.ResourceReference))]
      [Cardinality(Min=1,Max=1)]
      [DataMember]
      public Hl7.Fhir.Model.DataType Content
      {
        get { return _Content; }
        set { _Content = value; OnPropertyChanged("Content"); }
      }

      private Hl7.Fhir.Model.DataType _Content;

      public override IDeepCopyable CopyTo(IDeepCopyable other)
      {
        var dest = other as PayloadComponent;

        if (dest == null)
        {
          throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        base.CopyTo(dest);
        if(Content != null) dest.Content = (Hl7.Fhir.Model.DataType)Content.DeepCopy();
        return dest;
      }

      public override IDeepCopyable DeepCopy()
      {
        return CopyTo(new PayloadComponent());
      }

      ///<inheritdoc />
      public override bool Matches(IDeepComparable other)
      {
        var otherT = other as PayloadComponent;
        if(otherT == null) return false;

        if(!base.Matches(otherT)) return false;
        if( !DeepComparable.Matches(Content, otherT.Content)) return false;

        return true;
      }

      public override bool IsExactly(IDeepComparable other)
      {
        var otherT = other as PayloadComponent;
        if(otherT == null) return false;

        if(!base.IsExactly(otherT)) return false;
        if( !DeepComparable.IsExactly(Content, otherT.Content)) return false;

        return true;
      }

      [IgnoreDataMember]
      public override IEnumerable<Base> Children
      {
        get
        {
          foreach (var item in base.Children) yield return item;
          if (Content != null) yield return Content;
        }
      }

      [IgnoreDataMember]
      public override IEnumerable<ElementValue> NamedChildren
      {
        get
        {
          foreach (var item in base.NamedChildren) yield return item;
          if (Content != null) yield return new ElementValue("content", Content);
        }
      }

      protected override bool TryGetValue(string key, out object value)
      {
        switch (key)
        {
          case "content":
            value = Content;
            return Content is not null;
          default:
            return base.TryGetValue(key, out value);
        }

      }

      protected override IEnumerable<KeyValuePair<string, object>> GetElementPairs()
      {
        foreach (var kvp in base.GetElementPairs()) yield return kvp;
        if (Content is not null) yield return new KeyValuePair<string,object>("content",Content);
      }

    }

    /// <summary>
    /// Unique identifier
    /// </summary>
    [FhirElement("identifier", InSummary=true, Order=90, FiveWs="FiveWs.identifier")]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.Identifier> Identifier
    {
      get { if(_Identifier==null) _Identifier = new List<Hl7.Fhir.Model.Identifier>(); return _Identifier; }
      set { _Identifier = value; OnPropertyChanged("Identifier"); }
    }

    private List<Hl7.Fhir.Model.Identifier> _Identifier;

    /// <summary>
    /// Fulfills plan or proposal
    /// </summary>
    [FhirElement("basedOn", InSummary=true, Order=100)]
    [CLSCompliant(false)]
    [References("Resource")]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.ResourceReference> BasedOn
    {
      get { if(_BasedOn==null) _BasedOn = new List<Hl7.Fhir.Model.ResourceReference>(); return _BasedOn; }
      set { _BasedOn = value; OnPropertyChanged("BasedOn"); }
    }

    private List<Hl7.Fhir.Model.ResourceReference> _BasedOn;

    /// <summary>
    /// Request(s) replaced by this request
    /// </summary>
    [FhirElement("replaces", InSummary=true, Order=110)]
    [CLSCompliant(false)]
    [References("CommunicationRequest")]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.ResourceReference> Replaces
    {
      get { if(_Replaces==null) _Replaces = new List<Hl7.Fhir.Model.ResourceReference>(); return _Replaces; }
      set { _Replaces = value; OnPropertyChanged("Replaces"); }
    }

    private List<Hl7.Fhir.Model.ResourceReference> _Replaces;

    /// <summary>
    /// Composite request this is part of
    /// </summary>
    [FhirElement("groupIdentifier", InSummary=true, Order=120)]
    [DataMember]
    public Hl7.Fhir.Model.Identifier GroupIdentifier
    {
      get { return _GroupIdentifier; }
      set { _GroupIdentifier = value; OnPropertyChanged("GroupIdentifier"); }
    }

    private Hl7.Fhir.Model.Identifier _GroupIdentifier;

    /// <summary>
    /// draft | active | on-hold | revoked | completed | entered-in-error | unknown
    /// </summary>
    [FhirElement("status", InSummary=true, IsModifier=true, Order=130, FiveWs="FiveWs.status")]
    [DeclaredType(Type = typeof(Code))]
    [Cardinality(Min=1,Max=1)]
    [DataMember]
    public Code<Hl7.Fhir.Model.RequestStatus> StatusElement
    {
      get { return _StatusElement; }
      set { _StatusElement = value; OnPropertyChanged("StatusElement"); }
    }

    private Code<Hl7.Fhir.Model.RequestStatus> _StatusElement;

    /// <summary>
    /// draft | active | on-hold | revoked | completed | entered-in-error | unknown
    /// </summary>
    /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
    [IgnoreDataMember]
    public Hl7.Fhir.Model.RequestStatus? Status
    {
      get { return StatusElement != null ? StatusElement.Value : null; }
      set
      {
        if (value == null)
          StatusElement = null;
        else
          StatusElement = new Code<Hl7.Fhir.Model.RequestStatus>(value);
        OnPropertyChanged("Status");
      }
    }

    /// <summary>
    /// Reason for current status
    /// </summary>
    [FhirElement("statusReason", Order=140)]
    [DataMember]
    public Hl7.Fhir.Model.CodeableConcept StatusReason
    {
      get { return _StatusReason; }
      set { _StatusReason = value; OnPropertyChanged("StatusReason"); }
    }

    private Hl7.Fhir.Model.CodeableConcept _StatusReason;

    /// <summary>
    /// Message category
    /// </summary>
    [FhirElement("category", Order=150, FiveWs="FiveWs.class")]
    [CqlElement(IsPrimaryCodePath=true)]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.CodeableConcept> Category
    {
      get { if(_Category==null) _Category = new List<Hl7.Fhir.Model.CodeableConcept>(); return _Category; }
      set { _Category = value; OnPropertyChanged("Category"); }
    }

    private List<Hl7.Fhir.Model.CodeableConcept> _Category;

    /// <summary>
    /// routine | urgent | asap | stat
    /// </summary>
    [FhirElement("priority", InSummary=true, Order=160, FiveWs="FiveWs.grade")]
    [DeclaredType(Type = typeof(Code))]
    [DataMember]
    public Code<Hl7.Fhir.Model.RequestPriority> PriorityElement
    {
      get { return _PriorityElement; }
      set { _PriorityElement = value; OnPropertyChanged("PriorityElement"); }
    }

    private Code<Hl7.Fhir.Model.RequestPriority> _PriorityElement;

    /// <summary>
    /// routine | urgent | asap | stat
    /// </summary>
    /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
    [IgnoreDataMember]
    public Hl7.Fhir.Model.RequestPriority? Priority
    {
      get { return PriorityElement != null ? PriorityElement.Value : null; }
      set
      {
        if (value == null)
          PriorityElement = null;
        else
          PriorityElement = new Code<Hl7.Fhir.Model.RequestPriority>(value);
        OnPropertyChanged("Priority");
      }
    }

    /// <summary>
    /// True if request is prohibiting action
    /// </summary>
    [FhirElement("doNotPerform", InSummary=true, IsModifier=true, Order=170)]
    [DataMember]
    public Hl7.Fhir.Model.FhirBoolean DoNotPerformElement
    {
      get { return _DoNotPerformElement; }
      set { _DoNotPerformElement = value; OnPropertyChanged("DoNotPerformElement"); }
    }

    private Hl7.Fhir.Model.FhirBoolean _DoNotPerformElement;

    /// <summary>
    /// True if request is prohibiting action
    /// </summary>
    /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
    [IgnoreDataMember]
    public bool? DoNotPerform
    {
      get { return DoNotPerformElement != null ? DoNotPerformElement.Value : null; }
      set
      {
        if (value == null)
          DoNotPerformElement = null;
        else
          DoNotPerformElement = new Hl7.Fhir.Model.FhirBoolean(value);
        OnPropertyChanged("DoNotPerform");
      }
    }

    /// <summary>
    /// A channel of communication
    /// </summary>
    [FhirElement("medium", Order=180)]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.CodeableConcept> Medium
    {
      get { if(_Medium==null) _Medium = new List<Hl7.Fhir.Model.CodeableConcept>(); return _Medium; }
      set { _Medium = value; OnPropertyChanged("Medium"); }
    }

    private List<Hl7.Fhir.Model.CodeableConcept> _Medium;

    /// <summary>
    /// Focus of message
    /// </summary>
    [FhirElement("subject", Order=190, FiveWs="FiveWs.subject")]
    [CLSCompliant(false)]
    [References("Patient","Group")]
    [DataMember]
    public Hl7.Fhir.Model.ResourceReference Subject
    {
      get { return _Subject; }
      set { _Subject = value; OnPropertyChanged("Subject"); }
    }

    private Hl7.Fhir.Model.ResourceReference _Subject;

    /// <summary>
    /// Resources that pertain to this communication request
    /// </summary>
    [FhirElement("about", Order=200, FiveWs="FiveWs.context")]
    [CLSCompliant(false)]
    [References("Resource")]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.ResourceReference> About
    {
      get { if(_About==null) _About = new List<Hl7.Fhir.Model.ResourceReference>(); return _About; }
      set { _About = value; OnPropertyChanged("About"); }
    }

    private List<Hl7.Fhir.Model.ResourceReference> _About;

    /// <summary>
    /// Encounter created as part of
    /// </summary>
    [FhirElement("encounter", InSummary=true, Order=210, FiveWs="FiveWs.context")]
    [CLSCompliant(false)]
    [References("Encounter")]
    [DataMember]
    public Hl7.Fhir.Model.ResourceReference Encounter
    {
      get { return _Encounter; }
      set { _Encounter = value; OnPropertyChanged("Encounter"); }
    }

    private Hl7.Fhir.Model.ResourceReference _Encounter;

    /// <summary>
    /// Message payload
    /// </summary>
    [FhirElement("payload", Order=220)]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.CommunicationRequest.PayloadComponent> Payload
    {
      get { if(_Payload==null) _Payload = new List<Hl7.Fhir.Model.CommunicationRequest.PayloadComponent>(); return _Payload; }
      set { _Payload = value; OnPropertyChanged("Payload"); }
    }

    private List<Hl7.Fhir.Model.CommunicationRequest.PayloadComponent> _Payload;

    /// <summary>
    /// When scheduled
    /// </summary>
    [FhirElement("occurrence", InSummary=true, Order=230, Choice=ChoiceType.DatatypeChoice, FiveWs="FiveWs.planned")]
    [CLSCompliant(false)]
    [AllowedTypes(typeof(Hl7.Fhir.Model.FhirDateTime),typeof(Hl7.Fhir.Model.Period))]
    [DataMember]
    public Hl7.Fhir.Model.DataType Occurrence
    {
      get { return _Occurrence; }
      set { _Occurrence = value; OnPropertyChanged("Occurrence"); }
    }

    private Hl7.Fhir.Model.DataType _Occurrence;

    /// <summary>
    /// When request transitioned to being actionable
    /// </summary>
    [FhirElement("authoredOn", InSummary=true, Order=240, FiveWs="FiveWs.recorded")]
    [DataMember]
    public Hl7.Fhir.Model.FhirDateTime AuthoredOnElement
    {
      get { return _AuthoredOnElement; }
      set { _AuthoredOnElement = value; OnPropertyChanged("AuthoredOnElement"); }
    }

    private Hl7.Fhir.Model.FhirDateTime _AuthoredOnElement;

    /// <summary>
    /// When request transitioned to being actionable
    /// </summary>
    /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
    [IgnoreDataMember]
    public string AuthoredOn
    {
      get { return AuthoredOnElement != null ? AuthoredOnElement.Value : null; }
      set
      {
        if (value == null)
          AuthoredOnElement = null;
        else
          AuthoredOnElement = new Hl7.Fhir.Model.FhirDateTime(value);
        OnPropertyChanged("AuthoredOn");
      }
    }

    /// <summary>
    /// Who/what is requesting service
    /// </summary>
    [FhirElement("requester", InSummary=true, Order=250, FiveWs="FiveWs.author")]
    [CLSCompliant(false)]
    [References("Practitioner","PractitionerRole","Organization","Patient","RelatedPerson","Device")]
    [DataMember]
    public Hl7.Fhir.Model.ResourceReference Requester
    {
      get { return _Requester; }
      set { _Requester = value; OnPropertyChanged("Requester"); }
    }

    private Hl7.Fhir.Model.ResourceReference _Requester;

    /// <summary>
    /// Message recipient
    /// </summary>
    [FhirElement("recipient", Order=260, FiveWs="FiveWs.actor")]
    [CLSCompliant(false)]
    [References("Device","Organization","Patient","Practitioner","PractitionerRole","RelatedPerson","Group","CareTeam","HealthcareService")]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.ResourceReference> Recipient
    {
      get { if(_Recipient==null) _Recipient = new List<Hl7.Fhir.Model.ResourceReference>(); return _Recipient; }
      set { _Recipient = value; OnPropertyChanged("Recipient"); }
    }

    private List<Hl7.Fhir.Model.ResourceReference> _Recipient;

    /// <summary>
    /// Message sender
    /// </summary>
    [FhirElement("sender", InSummary=true, Order=270, FiveWs="FiveWs.actor")]
    [CLSCompliant(false)]
    [References("Device","Organization","Patient","Practitioner","PractitionerRole","RelatedPerson","HealthcareService")]
    [DataMember]
    public Hl7.Fhir.Model.ResourceReference Sender
    {
      get { return _Sender; }
      set { _Sender = value; OnPropertyChanged("Sender"); }
    }

    private Hl7.Fhir.Model.ResourceReference _Sender;

    /// <summary>
    /// Why is communication needed?
    /// </summary>
    [FhirElement("reasonCode", InSummary=true, Order=280, FiveWs="FiveWs.why[x]")]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.CodeableConcept> ReasonCode
    {
      get { if(_ReasonCode==null) _ReasonCode = new List<Hl7.Fhir.Model.CodeableConcept>(); return _ReasonCode; }
      set { _ReasonCode = value; OnPropertyChanged("ReasonCode"); }
    }

    private List<Hl7.Fhir.Model.CodeableConcept> _ReasonCode;

    /// <summary>
    /// Why is communication needed?
    /// </summary>
    [FhirElement("reasonReference", InSummary=true, Order=290, FiveWs="FiveWs.why[x]")]
    [CLSCompliant(false)]
    [References("Condition","Observation","DiagnosticReport","DocumentReference")]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.ResourceReference> ReasonReference
    {
      get { if(_ReasonReference==null) _ReasonReference = new List<Hl7.Fhir.Model.ResourceReference>(); return _ReasonReference; }
      set { _ReasonReference = value; OnPropertyChanged("ReasonReference"); }
    }

    private List<Hl7.Fhir.Model.ResourceReference> _ReasonReference;

    /// <summary>
    /// Comments made about communication request
    /// </summary>
    [FhirElement("note", Order=300)]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.Annotation> Note
    {
      get { if(_Note==null) _Note = new List<Hl7.Fhir.Model.Annotation>(); return _Note; }
      set { _Note = value; OnPropertyChanged("Note"); }
    }

    private List<Hl7.Fhir.Model.Annotation> _Note;

    public override IDeepCopyable CopyTo(IDeepCopyable other)
    {
      var dest = other as CommunicationRequest;

      if (dest == null)
      {
        throw new ArgumentException("Can only copy to an object of the same type", "other");
      }

      base.CopyTo(dest);
      if(Identifier != null) dest.Identifier = new List<Hl7.Fhir.Model.Identifier>(Identifier.DeepCopy());
      if(BasedOn != null) dest.BasedOn = new List<Hl7.Fhir.Model.ResourceReference>(BasedOn.DeepCopy());
      if(Replaces != null) dest.Replaces = new List<Hl7.Fhir.Model.ResourceReference>(Replaces.DeepCopy());
      if(GroupIdentifier != null) dest.GroupIdentifier = (Hl7.Fhir.Model.Identifier)GroupIdentifier.DeepCopy();
      if(StatusElement != null) dest.StatusElement = (Code<Hl7.Fhir.Model.RequestStatus>)StatusElement.DeepCopy();
      if(StatusReason != null) dest.StatusReason = (Hl7.Fhir.Model.CodeableConcept)StatusReason.DeepCopy();
      if(Category != null) dest.Category = new List<Hl7.Fhir.Model.CodeableConcept>(Category.DeepCopy());
      if(PriorityElement != null) dest.PriorityElement = (Code<Hl7.Fhir.Model.RequestPriority>)PriorityElement.DeepCopy();
      if(DoNotPerformElement != null) dest.DoNotPerformElement = (Hl7.Fhir.Model.FhirBoolean)DoNotPerformElement.DeepCopy();
      if(Medium != null) dest.Medium = new List<Hl7.Fhir.Model.CodeableConcept>(Medium.DeepCopy());
      if(Subject != null) dest.Subject = (Hl7.Fhir.Model.ResourceReference)Subject.DeepCopy();
      if(About != null) dest.About = new List<Hl7.Fhir.Model.ResourceReference>(About.DeepCopy());
      if(Encounter != null) dest.Encounter = (Hl7.Fhir.Model.ResourceReference)Encounter.DeepCopy();
      if(Payload != null) dest.Payload = new List<Hl7.Fhir.Model.CommunicationRequest.PayloadComponent>(Payload.DeepCopy());
      if(Occurrence != null) dest.Occurrence = (Hl7.Fhir.Model.DataType)Occurrence.DeepCopy();
      if(AuthoredOnElement != null) dest.AuthoredOnElement = (Hl7.Fhir.Model.FhirDateTime)AuthoredOnElement.DeepCopy();
      if(Requester != null) dest.Requester = (Hl7.Fhir.Model.ResourceReference)Requester.DeepCopy();
      if(Recipient != null) dest.Recipient = new List<Hl7.Fhir.Model.ResourceReference>(Recipient.DeepCopy());
      if(Sender != null) dest.Sender = (Hl7.Fhir.Model.ResourceReference)Sender.DeepCopy();
      if(ReasonCode != null) dest.ReasonCode = new List<Hl7.Fhir.Model.CodeableConcept>(ReasonCode.DeepCopy());
      if(ReasonReference != null) dest.ReasonReference = new List<Hl7.Fhir.Model.ResourceReference>(ReasonReference.DeepCopy());
      if(Note != null) dest.Note = new List<Hl7.Fhir.Model.Annotation>(Note.DeepCopy());
      return dest;
    }

    public override IDeepCopyable DeepCopy()
    {
      return CopyTo(new CommunicationRequest());
    }

    ///<inheritdoc />
    public override bool Matches(IDeepComparable other)
    {
      var otherT = other as CommunicationRequest;
      if(otherT == null) return false;

      if(!base.Matches(otherT)) return false;
      if( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
      if( !DeepComparable.Matches(BasedOn, otherT.BasedOn)) return false;
      if( !DeepComparable.Matches(Replaces, otherT.Replaces)) return false;
      if( !DeepComparable.Matches(GroupIdentifier, otherT.GroupIdentifier)) return false;
      if( !DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
      if( !DeepComparable.Matches(StatusReason, otherT.StatusReason)) return false;
      if( !DeepComparable.Matches(Category, otherT.Category)) return false;
      if( !DeepComparable.Matches(PriorityElement, otherT.PriorityElement)) return false;
      if( !DeepComparable.Matches(DoNotPerformElement, otherT.DoNotPerformElement)) return false;
      if( !DeepComparable.Matches(Medium, otherT.Medium)) return false;
      if( !DeepComparable.Matches(Subject, otherT.Subject)) return false;
      if( !DeepComparable.Matches(About, otherT.About)) return false;
      if( !DeepComparable.Matches(Encounter, otherT.Encounter)) return false;
      if( !DeepComparable.Matches(Payload, otherT.Payload)) return false;
      if( !DeepComparable.Matches(Occurrence, otherT.Occurrence)) return false;
      if( !DeepComparable.Matches(AuthoredOnElement, otherT.AuthoredOnElement)) return false;
      if( !DeepComparable.Matches(Requester, otherT.Requester)) return false;
      if( !DeepComparable.Matches(Recipient, otherT.Recipient)) return false;
      if( !DeepComparable.Matches(Sender, otherT.Sender)) return false;
      if( !DeepComparable.Matches(ReasonCode, otherT.ReasonCode)) return false;
      if( !DeepComparable.Matches(ReasonReference, otherT.ReasonReference)) return false;
      if( !DeepComparable.Matches(Note, otherT.Note)) return false;

      return true;
    }

    public override bool IsExactly(IDeepComparable other)
    {
      var otherT = other as CommunicationRequest;
      if(otherT == null) return false;

      if(!base.IsExactly(otherT)) return false;
      if( !DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
      if( !DeepComparable.IsExactly(BasedOn, otherT.BasedOn)) return false;
      if( !DeepComparable.IsExactly(Replaces, otherT.Replaces)) return false;
      if( !DeepComparable.IsExactly(GroupIdentifier, otherT.GroupIdentifier)) return false;
      if( !DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
      if( !DeepComparable.IsExactly(StatusReason, otherT.StatusReason)) return false;
      if( !DeepComparable.IsExactly(Category, otherT.Category)) return false;
      if( !DeepComparable.IsExactly(PriorityElement, otherT.PriorityElement)) return false;
      if( !DeepComparable.IsExactly(DoNotPerformElement, otherT.DoNotPerformElement)) return false;
      if( !DeepComparable.IsExactly(Medium, otherT.Medium)) return false;
      if( !DeepComparable.IsExactly(Subject, otherT.Subject)) return false;
      if( !DeepComparable.IsExactly(About, otherT.About)) return false;
      if( !DeepComparable.IsExactly(Encounter, otherT.Encounter)) return false;
      if( !DeepComparable.IsExactly(Payload, otherT.Payload)) return false;
      if( !DeepComparable.IsExactly(Occurrence, otherT.Occurrence)) return false;
      if( !DeepComparable.IsExactly(AuthoredOnElement, otherT.AuthoredOnElement)) return false;
      if( !DeepComparable.IsExactly(Requester, otherT.Requester)) return false;
      if( !DeepComparable.IsExactly(Recipient, otherT.Recipient)) return false;
      if( !DeepComparable.IsExactly(Sender, otherT.Sender)) return false;
      if( !DeepComparable.IsExactly(ReasonCode, otherT.ReasonCode)) return false;
      if( !DeepComparable.IsExactly(ReasonReference, otherT.ReasonReference)) return false;
      if( !DeepComparable.IsExactly(Note, otherT.Note)) return false;

      return true;
    }

    [IgnoreDataMember]
    public override IEnumerable<Base> Children
    {
      get
      {
        foreach (var item in base.Children) yield return item;
        foreach (var elem in Identifier) { if (elem != null) yield return elem; }
        foreach (var elem in BasedOn) { if (elem != null) yield return elem; }
        foreach (var elem in Replaces) { if (elem != null) yield return elem; }
        if (GroupIdentifier != null) yield return GroupIdentifier;
        if (StatusElement != null) yield return StatusElement;
        if (StatusReason != null) yield return StatusReason;
        foreach (var elem in Category) { if (elem != null) yield return elem; }
        if (PriorityElement != null) yield return PriorityElement;
        if (DoNotPerformElement != null) yield return DoNotPerformElement;
        foreach (var elem in Medium) { if (elem != null) yield return elem; }
        if (Subject != null) yield return Subject;
        foreach (var elem in About) { if (elem != null) yield return elem; }
        if (Encounter != null) yield return Encounter;
        foreach (var elem in Payload) { if (elem != null) yield return elem; }
        if (Occurrence != null) yield return Occurrence;
        if (AuthoredOnElement != null) yield return AuthoredOnElement;
        if (Requester != null) yield return Requester;
        foreach (var elem in Recipient) { if (elem != null) yield return elem; }
        if (Sender != null) yield return Sender;
        foreach (var elem in ReasonCode) { if (elem != null) yield return elem; }
        foreach (var elem in ReasonReference) { if (elem != null) yield return elem; }
        foreach (var elem in Note) { if (elem != null) yield return elem; }
      }
    }

    [IgnoreDataMember]
    public override IEnumerable<ElementValue> NamedChildren
    {
      get
      {
        foreach (var item in base.NamedChildren) yield return item;
        foreach (var elem in Identifier) { if (elem != null) yield return new ElementValue("identifier", elem); }
        foreach (var elem in BasedOn) { if (elem != null) yield return new ElementValue("basedOn", elem); }
        foreach (var elem in Replaces) { if (elem != null) yield return new ElementValue("replaces", elem); }
        if (GroupIdentifier != null) yield return new ElementValue("groupIdentifier", GroupIdentifier);
        if (StatusElement != null) yield return new ElementValue("status", StatusElement);
        if (StatusReason != null) yield return new ElementValue("statusReason", StatusReason);
        foreach (var elem in Category) { if (elem != null) yield return new ElementValue("category", elem); }
        if (PriorityElement != null) yield return new ElementValue("priority", PriorityElement);
        if (DoNotPerformElement != null) yield return new ElementValue("doNotPerform", DoNotPerformElement);
        foreach (var elem in Medium) { if (elem != null) yield return new ElementValue("medium", elem); }
        if (Subject != null) yield return new ElementValue("subject", Subject);
        foreach (var elem in About) { if (elem != null) yield return new ElementValue("about", elem); }
        if (Encounter != null) yield return new ElementValue("encounter", Encounter);
        foreach (var elem in Payload) { if (elem != null) yield return new ElementValue("payload", elem); }
        if (Occurrence != null) yield return new ElementValue("occurrence", Occurrence);
        if (AuthoredOnElement != null) yield return new ElementValue("authoredOn", AuthoredOnElement);
        if (Requester != null) yield return new ElementValue("requester", Requester);
        foreach (var elem in Recipient) { if (elem != null) yield return new ElementValue("recipient", elem); }
        if (Sender != null) yield return new ElementValue("sender", Sender);
        foreach (var elem in ReasonCode) { if (elem != null) yield return new ElementValue("reasonCode", elem); }
        foreach (var elem in ReasonReference) { if (elem != null) yield return new ElementValue("reasonReference", elem); }
        foreach (var elem in Note) { if (elem != null) yield return new ElementValue("note", elem); }
      }
    }

    protected override bool TryGetValue(string key, out object value)
    {
      switch (key)
      {
        case "identifier":
          value = Identifier;
          return Identifier?.Any() == true;
        case "basedOn":
          value = BasedOn;
          return BasedOn?.Any() == true;
        case "replaces":
          value = Replaces;
          return Replaces?.Any() == true;
        case "groupIdentifier":
          value = GroupIdentifier;
          return GroupIdentifier is not null;
        case "status":
          value = StatusElement;
          return StatusElement is not null;
        case "statusReason":
          value = StatusReason;
          return StatusReason is not null;
        case "category":
          value = Category;
          return Category?.Any() == true;
        case "priority":
          value = PriorityElement;
          return PriorityElement is not null;
        case "doNotPerform":
          value = DoNotPerformElement;
          return DoNotPerformElement is not null;
        case "medium":
          value = Medium;
          return Medium?.Any() == true;
        case "subject":
          value = Subject;
          return Subject is not null;
        case "about":
          value = About;
          return About?.Any() == true;
        case "encounter":
          value = Encounter;
          return Encounter is not null;
        case "payload":
          value = Payload;
          return Payload?.Any() == true;
        case "occurrence":
          value = Occurrence;
          return Occurrence is not null;
        case "authoredOn":
          value = AuthoredOnElement;
          return AuthoredOnElement is not null;
        case "requester":
          value = Requester;
          return Requester is not null;
        case "recipient":
          value = Recipient;
          return Recipient?.Any() == true;
        case "sender":
          value = Sender;
          return Sender is not null;
        case "reasonCode":
          value = ReasonCode;
          return ReasonCode?.Any() == true;
        case "reasonReference":
          value = ReasonReference;
          return ReasonReference?.Any() == true;
        case "note":
          value = Note;
          return Note?.Any() == true;
        default:
          return base.TryGetValue(key, out value);
      }

    }

    protected override IEnumerable<KeyValuePair<string, object>> GetElementPairs()
    {
      foreach (var kvp in base.GetElementPairs()) yield return kvp;
      if (Identifier?.Any() == true) yield return new KeyValuePair<string,object>("identifier",Identifier);
      if (BasedOn?.Any() == true) yield return new KeyValuePair<string,object>("basedOn",BasedOn);
      if (Replaces?.Any() == true) yield return new KeyValuePair<string,object>("replaces",Replaces);
      if (GroupIdentifier is not null) yield return new KeyValuePair<string,object>("groupIdentifier",GroupIdentifier);
      if (StatusElement is not null) yield return new KeyValuePair<string,object>("status",StatusElement);
      if (StatusReason is not null) yield return new KeyValuePair<string,object>("statusReason",StatusReason);
      if (Category?.Any() == true) yield return new KeyValuePair<string,object>("category",Category);
      if (PriorityElement is not null) yield return new KeyValuePair<string,object>("priority",PriorityElement);
      if (DoNotPerformElement is not null) yield return new KeyValuePair<string,object>("doNotPerform",DoNotPerformElement);
      if (Medium?.Any() == true) yield return new KeyValuePair<string,object>("medium",Medium);
      if (Subject is not null) yield return new KeyValuePair<string,object>("subject",Subject);
      if (About?.Any() == true) yield return new KeyValuePair<string,object>("about",About);
      if (Encounter is not null) yield return new KeyValuePair<string,object>("encounter",Encounter);
      if (Payload?.Any() == true) yield return new KeyValuePair<string,object>("payload",Payload);
      if (Occurrence is not null) yield return new KeyValuePair<string,object>("occurrence",Occurrence);
      if (AuthoredOnElement is not null) yield return new KeyValuePair<string,object>("authoredOn",AuthoredOnElement);
      if (Requester is not null) yield return new KeyValuePair<string,object>("requester",Requester);
      if (Recipient?.Any() == true) yield return new KeyValuePair<string,object>("recipient",Recipient);
      if (Sender is not null) yield return new KeyValuePair<string,object>("sender",Sender);
      if (ReasonCode?.Any() == true) yield return new KeyValuePair<string,object>("reasonCode",ReasonCode);
      if (ReasonReference?.Any() == true) yield return new KeyValuePair<string,object>("reasonReference",ReasonReference);
      if (Note?.Any() == true) yield return new KeyValuePair<string,object>("note",Note);
    }

  }

}

// end of file

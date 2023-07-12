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
  /// Record of use of a device
  /// </summary>
  [Serializable]
  [DataContract]
  [FhirType("DeviceUsage","http://hl7.org/fhir/StructureDefinition/DeviceUsage", IsResource=true)]
  public partial class DeviceUsage : Hl7.Fhir.Model.DomainResource
  {
    /// <summary>
    /// FHIR Type Name
    /// </summary>
    public override string TypeName { get { return "DeviceUsage"; } }

    /// <summary>
    /// A coded concept indicating the current status of the Device Usage.
    /// (url: http://hl7.org/fhir/ValueSet/deviceusage-status)
    /// (system: http://hl7.org/fhir/deviceusage-status)
    /// </summary>
    [FhirEnumeration("DeviceUsageStatus", "http://hl7.org/fhir/ValueSet/deviceusage-status", "http://hl7.org/fhir/deviceusage-status")]
    public enum DeviceUsageStatus
    {
      /// <summary>
      /// The device is still being used.
      /// (system: http://hl7.org/fhir/deviceusage-status)
      /// </summary>
      [EnumLiteral("active"), Description("Active")]
      Active,
      /// <summary>
      /// The device is no longer being used.
      /// (system: http://hl7.org/fhir/deviceusage-status)
      /// </summary>
      [EnumLiteral("completed"), Description("Completed")]
      Completed,
      /// <summary>
      /// The device was not used.
      /// (system: http://hl7.org/fhir/deviceusage-status)
      /// </summary>
      [EnumLiteral("not-done"), Description("Not done")]
      NotDone,
      /// <summary>
      /// The statement was recorded incorrectly.
      /// (system: http://hl7.org/fhir/deviceusage-status)
      /// </summary>
      [EnumLiteral("entered-in-error"), Description("Entered in Error")]
      EnteredInError,
      /// <summary>
      /// The device may be used at some time in the future.
      /// (system: http://hl7.org/fhir/deviceusage-status)
      /// </summary>
      [EnumLiteral("intended"), Description("Intended")]
      Intended,
      /// <summary>
      /// Actions implied by the statement have been permanently halted, before all of them occurred.
      /// (system: http://hl7.org/fhir/deviceusage-status)
      /// </summary>
      [EnumLiteral("stopped"), Description("Stopped")]
      Stopped,
      /// <summary>
      /// Actions implied by the statement have been temporarily halted, but are expected to continue later. May also be called "suspended".
      /// (system: http://hl7.org/fhir/deviceusage-status)
      /// </summary>
      [EnumLiteral("on-hold"), Description("On Hold")]
      OnHold,
    }

    /// <summary>
    /// How device is being used
    /// </summary>
    [Serializable]
    [DataContract]
    [FhirType("DeviceUsage#Adherence", IsNestedType=true)]
    [BackboneType("DeviceUsage.adherence")]
    public partial class AdherenceComponent : Hl7.Fhir.Model.BackboneElement
    {
      /// <summary>
      /// FHIR Type Name
      /// </summary>
      public override string TypeName { get { return "DeviceUsage#Adherence"; } }

      /// <summary>
      /// always | never | sometimes
      /// </summary>
      [FhirElement("code", Order=40)]
      [Cardinality(Min=1,Max=1)]
      [DataMember]
      public Hl7.Fhir.Model.CodeableConcept Code
      {
        get { return _Code; }
        set { _Code = value; OnPropertyChanged("Code"); }
      }

      private Hl7.Fhir.Model.CodeableConcept _Code;

      /// <summary>
      /// lost | stolen | prescribed | broken | burned | forgot
      /// </summary>
      [FhirElement("reason", Order=50)]
      [Cardinality(Min=1,Max=-1)]
      [DataMember]
      public List<Hl7.Fhir.Model.CodeableConcept> Reason
      {
        get { if(_Reason==null) _Reason = new List<Hl7.Fhir.Model.CodeableConcept>(); return _Reason; }
        set { _Reason = value; OnPropertyChanged("Reason"); }
      }

      private List<Hl7.Fhir.Model.CodeableConcept> _Reason;

      public override IDeepCopyable CopyTo(IDeepCopyable other)
      {
        var dest = other as AdherenceComponent;

        if (dest == null)
        {
          throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        base.CopyTo(dest);
        if(Code != null) dest.Code = (Hl7.Fhir.Model.CodeableConcept)Code.DeepCopy();
        if(Reason != null) dest.Reason = new List<Hl7.Fhir.Model.CodeableConcept>(Reason.DeepCopy());
        return dest;
      }

      public override IDeepCopyable DeepCopy()
      {
        return CopyTo(new AdherenceComponent());
      }

      ///<inheritdoc />
      public override bool Matches(IDeepComparable other)
      {
        var otherT = other as AdherenceComponent;
        if(otherT == null) return false;

        if(!base.Matches(otherT)) return false;
        if( !DeepComparable.Matches(Code, otherT.Code)) return false;
        if( !DeepComparable.Matches(Reason, otherT.Reason)) return false;

        return true;
      }

      public override bool IsExactly(IDeepComparable other)
      {
        var otherT = other as AdherenceComponent;
        if(otherT == null) return false;

        if(!base.IsExactly(otherT)) return false;
        if( !DeepComparable.IsExactly(Code, otherT.Code)) return false;
        if( !DeepComparable.IsExactly(Reason, otherT.Reason)) return false;

        return true;
      }

      [IgnoreDataMember]
      public override IEnumerable<Base> Children
      {
        get
        {
          foreach (var item in base.Children) yield return item;
          if (Code != null) yield return Code;
          foreach (var elem in Reason) { if (elem != null) yield return elem; }
        }
      }

      [IgnoreDataMember]
      public override IEnumerable<ElementValue> NamedChildren
      {
        get
        {
          foreach (var item in base.NamedChildren) yield return item;
          if (Code != null) yield return new ElementValue("code", Code);
          foreach (var elem in Reason) { if (elem != null) yield return new ElementValue("reason", elem); }
        }
      }

      protected override bool TryGetValue(string key, out object value)
      {
        switch (key)
        {
          case "code":
            value = Code;
            return Code is not null;
          case "reason":
            value = Reason;
            return Reason?.Any() == true;
          default:
            return base.TryGetValue(key, out value);
        }

      }

      protected override IEnumerable<KeyValuePair<string, object>> GetElementPairs()
      {
        foreach (var kvp in base.GetElementPairs()) yield return kvp;
        if (Code is not null) yield return new KeyValuePair<string,object>("code",Code);
        if (Reason?.Any() == true) yield return new KeyValuePair<string,object>("reason",Reason);
      }

    }

    /// <summary>
    /// External identifier for this record
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
    /// Fulfills plan, proposal or order
    /// </summary>
    [FhirElement("basedOn", InSummary=true, Order=100)]
    [CLSCompliant(false)]
    [References("ServiceRequest")]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.ResourceReference> BasedOn
    {
      get { if(_BasedOn==null) _BasedOn = new List<Hl7.Fhir.Model.ResourceReference>(); return _BasedOn; }
      set { _BasedOn = value; OnPropertyChanged("BasedOn"); }
    }

    private List<Hl7.Fhir.Model.ResourceReference> _BasedOn;

    /// <summary>
    /// active | completed | not-done | entered-in-error +
    /// </summary>
    [FhirElement("status", InSummary=true, IsModifier=true, Order=110, FiveWs="FiveWs.status")]
    [DeclaredType(Type = typeof(Code))]
    [Binding("DeviceUsageStatus")]
    [Cardinality(Min=1,Max=1)]
    [DataMember]
    public Code<Hl7.Fhir.Model.DeviceUsage.DeviceUsageStatus> StatusElement
    {
      get { return _StatusElement; }
      set { _StatusElement = value; OnPropertyChanged("StatusElement"); }
    }

    private Code<Hl7.Fhir.Model.DeviceUsage.DeviceUsageStatus> _StatusElement;

    /// <summary>
    /// active | completed | not-done | entered-in-error +
    /// </summary>
    /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
    [IgnoreDataMember]
    public Hl7.Fhir.Model.DeviceUsage.DeviceUsageStatus? Status
    {
      get { return StatusElement != null ? StatusElement.Value : null; }
      set
      {
        if (value == null)
          StatusElement = null;
        else
          StatusElement = new Code<Hl7.Fhir.Model.DeviceUsage.DeviceUsageStatus>(value);
        OnPropertyChanged("Status");
      }
    }

    /// <summary>
    /// The category of the statement - classifying how the statement is made
    /// </summary>
    [FhirElement("category", Order=120)]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.CodeableConcept> Category
    {
      get { if(_Category==null) _Category = new List<Hl7.Fhir.Model.CodeableConcept>(); return _Category; }
      set { _Category = value; OnPropertyChanged("Category"); }
    }

    private List<Hl7.Fhir.Model.CodeableConcept> _Category;

    /// <summary>
    /// Patient using device
    /// </summary>
    [FhirElement("patient", InSummary=true, Order=130, FiveWs="FiveWs.subject[x]")]
    [CLSCompliant(false)]
    [References("Patient")]
    [Cardinality(Min=1,Max=1)]
    [DataMember]
    public Hl7.Fhir.Model.ResourceReference Patient
    {
      get { return _Patient; }
      set { _Patient = value; OnPropertyChanged("Patient"); }
    }

    private Hl7.Fhir.Model.ResourceReference _Patient;

    /// <summary>
    /// Supporting information
    /// </summary>
    [FhirElement("derivedFrom", InSummary=true, Order=140)]
    [CLSCompliant(false)]
    [References("ServiceRequest","Procedure","Claim","Observation","QuestionnaireResponse","DocumentReference")]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.ResourceReference> DerivedFrom
    {
      get { if(_DerivedFrom==null) _DerivedFrom = new List<Hl7.Fhir.Model.ResourceReference>(); return _DerivedFrom; }
      set { _DerivedFrom = value; OnPropertyChanged("DerivedFrom"); }
    }

    private List<Hl7.Fhir.Model.ResourceReference> _DerivedFrom;

    /// <summary>
    /// The encounter or episode of care that establishes the context for this device use statement
    /// </summary>
    [FhirElement("context", InSummary=true, Order=150)]
    [CLSCompliant(false)]
    [References("Encounter","EpisodeOfCare")]
    [DataMember]
    public Hl7.Fhir.Model.ResourceReference Context
    {
      get { return _Context; }
      set { _Context = value; OnPropertyChanged("Context"); }
    }

    private Hl7.Fhir.Model.ResourceReference _Context;

    /// <summary>
    /// How often  the device was used
    /// </summary>
    [FhirElement("timing", InSummary=true, Order=160, Choice=ChoiceType.DatatypeChoice, FiveWs="FiveWs.done[x]")]
    [CLSCompliant(false)]
    [AllowedTypes(typeof(Hl7.Fhir.Model.Timing),typeof(Hl7.Fhir.Model.Period),typeof(Hl7.Fhir.Model.FhirDateTime))]
    [DataMember]
    public Hl7.Fhir.Model.DataType Timing
    {
      get { return _Timing; }
      set { _Timing = value; OnPropertyChanged("Timing"); }
    }

    private Hl7.Fhir.Model.DataType _Timing;

    /// <summary>
    /// When the statement was made (and recorded)
    /// </summary>
    [FhirElement("dateAsserted", InSummary=true, Order=170, FiveWs="FiveWs.recorded")]
    [DataMember]
    public Hl7.Fhir.Model.FhirDateTime DateAssertedElement
    {
      get { return _DateAssertedElement; }
      set { _DateAssertedElement = value; OnPropertyChanged("DateAssertedElement"); }
    }

    private Hl7.Fhir.Model.FhirDateTime _DateAssertedElement;

    /// <summary>
    /// When the statement was made (and recorded)
    /// </summary>
    /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
    [IgnoreDataMember]
    public string DateAsserted
    {
      get { return DateAssertedElement != null ? DateAssertedElement.Value : null; }
      set
      {
        if (value == null)
          DateAssertedElement = null;
        else
          DateAssertedElement = new Hl7.Fhir.Model.FhirDateTime(value);
        OnPropertyChanged("DateAsserted");
      }
    }

    /// <summary>
    /// The status of the device usage, for example always, sometimes, never. This is not the same as the status of the statement
    /// </summary>
    [FhirElement("usageStatus", Order=180)]
    [DataMember]
    public Hl7.Fhir.Model.CodeableConcept UsageStatus
    {
      get { return _UsageStatus; }
      set { _UsageStatus = value; OnPropertyChanged("UsageStatus"); }
    }

    private Hl7.Fhir.Model.CodeableConcept _UsageStatus;

    /// <summary>
    /// The reason for asserting the usage status - for example forgot, lost, stolen, broken
    /// </summary>
    [FhirElement("usageReason", Order=190)]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.CodeableConcept> UsageReason
    {
      get { if(_UsageReason==null) _UsageReason = new List<Hl7.Fhir.Model.CodeableConcept>(); return _UsageReason; }
      set { _UsageReason = value; OnPropertyChanged("UsageReason"); }
    }

    private List<Hl7.Fhir.Model.CodeableConcept> _UsageReason;

    /// <summary>
    /// How device is being used
    /// </summary>
    [FhirElement("adherence", Order=200)]
    [DataMember]
    public Hl7.Fhir.Model.DeviceUsage.AdherenceComponent Adherence
    {
      get { return _Adherence; }
      set { _Adherence = value; OnPropertyChanged("Adherence"); }
    }

    private Hl7.Fhir.Model.DeviceUsage.AdherenceComponent _Adherence;

    /// <summary>
    /// Who made the statement
    /// </summary>
    [FhirElement("informationSource", InSummary=true, Order=210, FiveWs="FiveWs.actor")]
    [CLSCompliant(false)]
    [References("Patient","Practitioner","PractitionerRole","RelatedPerson","Organization")]
    [DataMember]
    public Hl7.Fhir.Model.ResourceReference InformationSource
    {
      get { return _InformationSource; }
      set { _InformationSource = value; OnPropertyChanged("InformationSource"); }
    }

    private Hl7.Fhir.Model.ResourceReference _InformationSource;

    /// <summary>
    /// Code or Reference to device used
    /// </summary>
    [FhirElement("device", InSummary=true, Order=220, FiveWs="FiveWs.actor")]
    [Cardinality(Min=1,Max=1)]
    [DataMember]
    public Hl7.Fhir.Model.CodeableReference Device
    {
      get { return _Device; }
      set { _Device = value; OnPropertyChanged("Device"); }
    }

    private Hl7.Fhir.Model.CodeableReference _Device;

    /// <summary>
    /// Why device was used
    /// </summary>
    [FhirElement("reason", InSummary=true, Order=230, FiveWs="FiveWs.why[x]")]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.CodeableReference> Reason
    {
      get { if(_Reason==null) _Reason = new List<Hl7.Fhir.Model.CodeableReference>(); return _Reason; }
      set { _Reason = value; OnPropertyChanged("Reason"); }
    }

    private List<Hl7.Fhir.Model.CodeableReference> _Reason;

    /// <summary>
    /// Target body site
    /// </summary>
    [FhirElement("bodySite", InSummary=true, Order=240)]
    [DataMember]
    public Hl7.Fhir.Model.CodeableReference BodySite
    {
      get { return _BodySite; }
      set { _BodySite = value; OnPropertyChanged("BodySite"); }
    }

    private Hl7.Fhir.Model.CodeableReference _BodySite;

    /// <summary>
    /// Addition details (comments, instructions)
    /// </summary>
    [FhirElement("note", Order=250)]
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
      var dest = other as DeviceUsage;

      if (dest == null)
      {
        throw new ArgumentException("Can only copy to an object of the same type", "other");
      }

      base.CopyTo(dest);
      if(Identifier != null) dest.Identifier = new List<Hl7.Fhir.Model.Identifier>(Identifier.DeepCopy());
      if(BasedOn != null) dest.BasedOn = new List<Hl7.Fhir.Model.ResourceReference>(BasedOn.DeepCopy());
      if(StatusElement != null) dest.StatusElement = (Code<Hl7.Fhir.Model.DeviceUsage.DeviceUsageStatus>)StatusElement.DeepCopy();
      if(Category != null) dest.Category = new List<Hl7.Fhir.Model.CodeableConcept>(Category.DeepCopy());
      if(Patient != null) dest.Patient = (Hl7.Fhir.Model.ResourceReference)Patient.DeepCopy();
      if(DerivedFrom != null) dest.DerivedFrom = new List<Hl7.Fhir.Model.ResourceReference>(DerivedFrom.DeepCopy());
      if(Context != null) dest.Context = (Hl7.Fhir.Model.ResourceReference)Context.DeepCopy();
      if(Timing != null) dest.Timing = (Hl7.Fhir.Model.DataType)Timing.DeepCopy();
      if(DateAssertedElement != null) dest.DateAssertedElement = (Hl7.Fhir.Model.FhirDateTime)DateAssertedElement.DeepCopy();
      if(UsageStatus != null) dest.UsageStatus = (Hl7.Fhir.Model.CodeableConcept)UsageStatus.DeepCopy();
      if(UsageReason != null) dest.UsageReason = new List<Hl7.Fhir.Model.CodeableConcept>(UsageReason.DeepCopy());
      if(Adherence != null) dest.Adherence = (Hl7.Fhir.Model.DeviceUsage.AdherenceComponent)Adherence.DeepCopy();
      if(InformationSource != null) dest.InformationSource = (Hl7.Fhir.Model.ResourceReference)InformationSource.DeepCopy();
      if(Device != null) dest.Device = (Hl7.Fhir.Model.CodeableReference)Device.DeepCopy();
      if(Reason != null) dest.Reason = new List<Hl7.Fhir.Model.CodeableReference>(Reason.DeepCopy());
      if(BodySite != null) dest.BodySite = (Hl7.Fhir.Model.CodeableReference)BodySite.DeepCopy();
      if(Note != null) dest.Note = new List<Hl7.Fhir.Model.Annotation>(Note.DeepCopy());
      return dest;
    }

    public override IDeepCopyable DeepCopy()
    {
      return CopyTo(new DeviceUsage());
    }

    ///<inheritdoc />
    public override bool Matches(IDeepComparable other)
    {
      var otherT = other as DeviceUsage;
      if(otherT == null) return false;

      if(!base.Matches(otherT)) return false;
      if( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
      if( !DeepComparable.Matches(BasedOn, otherT.BasedOn)) return false;
      if( !DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
      if( !DeepComparable.Matches(Category, otherT.Category)) return false;
      if( !DeepComparable.Matches(Patient, otherT.Patient)) return false;
      if( !DeepComparable.Matches(DerivedFrom, otherT.DerivedFrom)) return false;
      if( !DeepComparable.Matches(Context, otherT.Context)) return false;
      if( !DeepComparable.Matches(Timing, otherT.Timing)) return false;
      if( !DeepComparable.Matches(DateAssertedElement, otherT.DateAssertedElement)) return false;
      if( !DeepComparable.Matches(UsageStatus, otherT.UsageStatus)) return false;
      if( !DeepComparable.Matches(UsageReason, otherT.UsageReason)) return false;
      if( !DeepComparable.Matches(Adherence, otherT.Adherence)) return false;
      if( !DeepComparable.Matches(InformationSource, otherT.InformationSource)) return false;
      if( !DeepComparable.Matches(Device, otherT.Device)) return false;
      if( !DeepComparable.Matches(Reason, otherT.Reason)) return false;
      if( !DeepComparable.Matches(BodySite, otherT.BodySite)) return false;
      if( !DeepComparable.Matches(Note, otherT.Note)) return false;

      return true;
    }

    public override bool IsExactly(IDeepComparable other)
    {
      var otherT = other as DeviceUsage;
      if(otherT == null) return false;

      if(!base.IsExactly(otherT)) return false;
      if( !DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
      if( !DeepComparable.IsExactly(BasedOn, otherT.BasedOn)) return false;
      if( !DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
      if( !DeepComparable.IsExactly(Category, otherT.Category)) return false;
      if( !DeepComparable.IsExactly(Patient, otherT.Patient)) return false;
      if( !DeepComparable.IsExactly(DerivedFrom, otherT.DerivedFrom)) return false;
      if( !DeepComparable.IsExactly(Context, otherT.Context)) return false;
      if( !DeepComparable.IsExactly(Timing, otherT.Timing)) return false;
      if( !DeepComparable.IsExactly(DateAssertedElement, otherT.DateAssertedElement)) return false;
      if( !DeepComparable.IsExactly(UsageStatus, otherT.UsageStatus)) return false;
      if( !DeepComparable.IsExactly(UsageReason, otherT.UsageReason)) return false;
      if( !DeepComparable.IsExactly(Adherence, otherT.Adherence)) return false;
      if( !DeepComparable.IsExactly(InformationSource, otherT.InformationSource)) return false;
      if( !DeepComparable.IsExactly(Device, otherT.Device)) return false;
      if( !DeepComparable.IsExactly(Reason, otherT.Reason)) return false;
      if( !DeepComparable.IsExactly(BodySite, otherT.BodySite)) return false;
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
        if (StatusElement != null) yield return StatusElement;
        foreach (var elem in Category) { if (elem != null) yield return elem; }
        if (Patient != null) yield return Patient;
        foreach (var elem in DerivedFrom) { if (elem != null) yield return elem; }
        if (Context != null) yield return Context;
        if (Timing != null) yield return Timing;
        if (DateAssertedElement != null) yield return DateAssertedElement;
        if (UsageStatus != null) yield return UsageStatus;
        foreach (var elem in UsageReason) { if (elem != null) yield return elem; }
        if (Adherence != null) yield return Adherence;
        if (InformationSource != null) yield return InformationSource;
        if (Device != null) yield return Device;
        foreach (var elem in Reason) { if (elem != null) yield return elem; }
        if (BodySite != null) yield return BodySite;
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
        if (StatusElement != null) yield return new ElementValue("status", StatusElement);
        foreach (var elem in Category) { if (elem != null) yield return new ElementValue("category", elem); }
        if (Patient != null) yield return new ElementValue("patient", Patient);
        foreach (var elem in DerivedFrom) { if (elem != null) yield return new ElementValue("derivedFrom", elem); }
        if (Context != null) yield return new ElementValue("context", Context);
        if (Timing != null) yield return new ElementValue("timing", Timing);
        if (DateAssertedElement != null) yield return new ElementValue("dateAsserted", DateAssertedElement);
        if (UsageStatus != null) yield return new ElementValue("usageStatus", UsageStatus);
        foreach (var elem in UsageReason) { if (elem != null) yield return new ElementValue("usageReason", elem); }
        if (Adherence != null) yield return new ElementValue("adherence", Adherence);
        if (InformationSource != null) yield return new ElementValue("informationSource", InformationSource);
        if (Device != null) yield return new ElementValue("device", Device);
        foreach (var elem in Reason) { if (elem != null) yield return new ElementValue("reason", elem); }
        if (BodySite != null) yield return new ElementValue("bodySite", BodySite);
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
        case "status":
          value = StatusElement;
          return StatusElement is not null;
        case "category":
          value = Category;
          return Category?.Any() == true;
        case "patient":
          value = Patient;
          return Patient is not null;
        case "derivedFrom":
          value = DerivedFrom;
          return DerivedFrom?.Any() == true;
        case "context":
          value = Context;
          return Context is not null;
        case "timing":
          value = Timing;
          return Timing is not null;
        case "dateAsserted":
          value = DateAssertedElement;
          return DateAssertedElement is not null;
        case "usageStatus":
          value = UsageStatus;
          return UsageStatus is not null;
        case "usageReason":
          value = UsageReason;
          return UsageReason?.Any() == true;
        case "adherence":
          value = Adherence;
          return Adherence is not null;
        case "informationSource":
          value = InformationSource;
          return InformationSource is not null;
        case "device":
          value = Device;
          return Device is not null;
        case "reason":
          value = Reason;
          return Reason?.Any() == true;
        case "bodySite":
          value = BodySite;
          return BodySite is not null;
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
      if (StatusElement is not null) yield return new KeyValuePair<string,object>("status",StatusElement);
      if (Category?.Any() == true) yield return new KeyValuePair<string,object>("category",Category);
      if (Patient is not null) yield return new KeyValuePair<string,object>("patient",Patient);
      if (DerivedFrom?.Any() == true) yield return new KeyValuePair<string,object>("derivedFrom",DerivedFrom);
      if (Context is not null) yield return new KeyValuePair<string,object>("context",Context);
      if (Timing is not null) yield return new KeyValuePair<string,object>("timing",Timing);
      if (DateAssertedElement is not null) yield return new KeyValuePair<string,object>("dateAsserted",DateAssertedElement);
      if (UsageStatus is not null) yield return new KeyValuePair<string,object>("usageStatus",UsageStatus);
      if (UsageReason?.Any() == true) yield return new KeyValuePair<string,object>("usageReason",UsageReason);
      if (Adherence is not null) yield return new KeyValuePair<string,object>("adherence",Adherence);
      if (InformationSource is not null) yield return new KeyValuePair<string,object>("informationSource",InformationSource);
      if (Device is not null) yield return new KeyValuePair<string,object>("device",Device);
      if (Reason?.Any() == true) yield return new KeyValuePair<string,object>("reason",Reason);
      if (BodySite is not null) yield return new KeyValuePair<string,object>("bodySite",BodySite);
      if (Note?.Any() == true) yield return new KeyValuePair<string,object>("note",Note);
    }

  }

}

// end of file

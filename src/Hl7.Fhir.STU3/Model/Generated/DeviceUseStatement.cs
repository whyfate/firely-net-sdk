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
  /// Record of use of a device
  /// </summary>
  [Serializable]
  [DataContract]
  [FhirType("DeviceUseStatement","http://hl7.org/fhir/StructureDefinition/DeviceUseStatement", IsResource=true)]
  public partial class DeviceUseStatement : Hl7.Fhir.Model.DomainResource, IIdentifiable<List<Identifier>>
  {
    /// <summary>
    /// FHIR Type Name
    /// </summary>
    public override string TypeName { get { return "DeviceUseStatement"; } }

    /// <summary>
    /// A coded concept indicating the current status of a the Device Usage
    /// (url: http://hl7.org/fhir/ValueSet/device-statement-status)
    /// (system: http://hl7.org/fhir/device-statement-status)
    /// </summary>
    [FhirEnumeration("DeviceUseStatementStatus", "http://hl7.org/fhir/ValueSet/device-statement-status", "http://hl7.org/fhir/device-statement-status")]
    public enum DeviceUseStatementStatus
    {
      /// <summary>
      /// The device is still being used.
      /// (system: http://hl7.org/fhir/device-statement-status)
      /// </summary>
      [EnumLiteral("active"), Description("Active")]
      Active,
      /// <summary>
      /// The device is no longer being used.
      /// (system: http://hl7.org/fhir/device-statement-status)
      /// </summary>
      [EnumLiteral("completed"), Description("Completed")]
      Completed,
      /// <summary>
      /// The statement was recorded incorrectly.
      /// (system: http://hl7.org/fhir/device-statement-status)
      /// </summary>
      [EnumLiteral("entered-in-error"), Description("Entered in Error")]
      EnteredInError,
      /// <summary>
      /// The device may be used at some time in the future.
      /// (system: http://hl7.org/fhir/device-statement-status)
      /// </summary>
      [EnumLiteral("intended"), Description("Intended")]
      Intended,
      /// <summary>
      /// Actions implied by the statement have been permanently halted, before all of them occurred.
      /// (system: http://hl7.org/fhir/device-statement-status)
      /// </summary>
      [EnumLiteral("stopped"), Description("Stopped")]
      Stopped,
      /// <summary>
      /// Actions implied by the statement have been temporarily halted, but are expected to continue later. May also be called "suspended".
      /// (system: http://hl7.org/fhir/device-statement-status)
      /// </summary>
      [EnumLiteral("on-hold"), Description("On Hold")]
      OnHold,
    }

    /// <summary>
    /// External identifier for this record
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
    /// active | completed | entered-in-error +
    /// </summary>
    [FhirElement("status", InSummary=true, IsModifier=true, Order=100, FiveWs="status")]
    [DeclaredType(Type = typeof(Code))]
    [Binding("DeviceUseStatementStatus")]
    [Cardinality(Min=1,Max=1)]
    [DataMember]
    public Code<Hl7.Fhir.Model.DeviceUseStatement.DeviceUseStatementStatus> StatusElement
    {
      get { return _StatusElement; }
      set { _StatusElement = value; OnPropertyChanged("StatusElement"); }
    }

    private Code<Hl7.Fhir.Model.DeviceUseStatement.DeviceUseStatementStatus> _StatusElement;

    /// <summary>
    /// active | completed | entered-in-error +
    /// </summary>
    /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
    [IgnoreDataMember]
    public Hl7.Fhir.Model.DeviceUseStatement.DeviceUseStatementStatus? Status
    {
      get { return StatusElement != null ? StatusElement.Value : null; }
      set
      {
        if (value == null)
          StatusElement = null;
        else
          StatusElement = new Code<Hl7.Fhir.Model.DeviceUseStatement.DeviceUseStatementStatus>(value);
        OnPropertyChanged("Status");
      }
    }

    /// <summary>
    /// Patient using device
    /// </summary>
    [FhirElement("subject", Order=110, FiveWs="who.focus")]
    [CLSCompliant(false)]
    [References("Patient","Group")]
    [Cardinality(Min=1,Max=1)]
    [DataMember]
    public Hl7.Fhir.Model.ResourceReference Subject
    {
      get { return _Subject; }
      set { _Subject = value; OnPropertyChanged("Subject"); }
    }

    private Hl7.Fhir.Model.ResourceReference _Subject;

    /// <summary>
    /// Period device was used
    /// </summary>
    [FhirElement("whenUsed", Order=120, FiveWs="when.done")]
    [DataMember]
    public Hl7.Fhir.Model.Period WhenUsed
    {
      get { return _WhenUsed; }
      set { _WhenUsed = value; OnPropertyChanged("WhenUsed"); }
    }

    private Hl7.Fhir.Model.Period _WhenUsed;

    /// <summary>
    /// How often  the device was used
    /// </summary>
    [FhirElement("timing", Order=130, Choice=ChoiceType.DatatypeChoice, FiveWs="when.done")]
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
    /// When statement was recorded
    /// </summary>
    [FhirElement("recordedOn", Order=140, FiveWs="when.recorded")]
    [DataMember]
    public Hl7.Fhir.Model.FhirDateTime RecordedOnElement
    {
      get { return _RecordedOnElement; }
      set { _RecordedOnElement = value; OnPropertyChanged("RecordedOnElement"); }
    }

    private Hl7.Fhir.Model.FhirDateTime _RecordedOnElement;

    /// <summary>
    /// When statement was recorded
    /// </summary>
    /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
    [IgnoreDataMember]
    public string RecordedOn
    {
      get { return RecordedOnElement != null ? RecordedOnElement.Value : null; }
      set
      {
        if (value == null)
          RecordedOnElement = null;
        else
          RecordedOnElement = new Hl7.Fhir.Model.FhirDateTime(value);
        OnPropertyChanged("RecordedOn");
      }
    }

    /// <summary>
    /// Who made the statement
    /// </summary>
    [FhirElement("source", Order=150, FiveWs="who.actor")]
    [CLSCompliant(false)]
    [References("Patient","Practitioner","RelatedPerson")]
    [DataMember]
    public Hl7.Fhir.Model.ResourceReference Source
    {
      get { return _Source; }
      set { _Source = value; OnPropertyChanged("Source"); }
    }

    private Hl7.Fhir.Model.ResourceReference _Source;

    /// <summary>
    /// Reference to device used
    /// </summary>
    [FhirElement("device", Order=160, FiveWs="who.actor")]
    [CLSCompliant(false)]
    [References("Device")]
    [Cardinality(Min=1,Max=1)]
    [DataMember]
    public Hl7.Fhir.Model.ResourceReference Device
    {
      get { return _Device; }
      set { _Device = value; OnPropertyChanged("Device"); }
    }

    private Hl7.Fhir.Model.ResourceReference _Device;

    /// <summary>
    /// Why device was used
    /// </summary>
    [FhirElement("indication", Order=170, FiveWs="why")]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.CodeableConcept> Indication
    {
      get { if(_Indication==null) _Indication = new List<Hl7.Fhir.Model.CodeableConcept>(); return _Indication; }
      set { _Indication = value; OnPropertyChanged("Indication"); }
    }

    private List<Hl7.Fhir.Model.CodeableConcept> _Indication;

    /// <summary>
    /// Target body site
    /// </summary>
    [FhirElement("bodySite", Order=180)]
    [DataMember]
    public Hl7.Fhir.Model.CodeableConcept BodySite
    {
      get { return _BodySite; }
      set { _BodySite = value; OnPropertyChanged("BodySite"); }
    }

    private Hl7.Fhir.Model.CodeableConcept _BodySite;

    /// <summary>
    /// Addition details (comments, instructions)
    /// </summary>
    [FhirElement("note", Order=190)]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.Annotation> Note
    {
      get { if(_Note==null) _Note = new List<Hl7.Fhir.Model.Annotation>(); return _Note; }
      set { _Note = value; OnPropertyChanged("Note"); }
    }

    private List<Hl7.Fhir.Model.Annotation> _Note;

    List<Identifier> IIdentifiable<List<Identifier>>.Identifier { get => Identifier; set => Identifier = value; }

    public override IDeepCopyable CopyTo(IDeepCopyable other)
    {
      var dest = other as DeviceUseStatement;

      if (dest == null)
      {
        throw new ArgumentException("Can only copy to an object of the same type", "other");
      }

      base.CopyTo(dest);
      if(Identifier != null) dest.Identifier = new List<Hl7.Fhir.Model.Identifier>(Identifier.DeepCopy());
      if(StatusElement != null) dest.StatusElement = (Code<Hl7.Fhir.Model.DeviceUseStatement.DeviceUseStatementStatus>)StatusElement.DeepCopy();
      if(Subject != null) dest.Subject = (Hl7.Fhir.Model.ResourceReference)Subject.DeepCopy();
      if(WhenUsed != null) dest.WhenUsed = (Hl7.Fhir.Model.Period)WhenUsed.DeepCopy();
      if(Timing != null) dest.Timing = (Hl7.Fhir.Model.DataType)Timing.DeepCopy();
      if(RecordedOnElement != null) dest.RecordedOnElement = (Hl7.Fhir.Model.FhirDateTime)RecordedOnElement.DeepCopy();
      if(Source != null) dest.Source = (Hl7.Fhir.Model.ResourceReference)Source.DeepCopy();
      if(Device != null) dest.Device = (Hl7.Fhir.Model.ResourceReference)Device.DeepCopy();
      if(Indication != null) dest.Indication = new List<Hl7.Fhir.Model.CodeableConcept>(Indication.DeepCopy());
      if(BodySite != null) dest.BodySite = (Hl7.Fhir.Model.CodeableConcept)BodySite.DeepCopy();
      if(Note != null) dest.Note = new List<Hl7.Fhir.Model.Annotation>(Note.DeepCopy());
      return dest;
    }

    public override IDeepCopyable DeepCopy()
    {
      return CopyTo(new DeviceUseStatement());
    }

    ///<inheritdoc />
    public override bool Matches(IDeepComparable other)
    {
      var otherT = other as DeviceUseStatement;
      if(otherT == null) return false;

      if(!base.Matches(otherT)) return false;
      if( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
      if( !DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
      if( !DeepComparable.Matches(Subject, otherT.Subject)) return false;
      if( !DeepComparable.Matches(WhenUsed, otherT.WhenUsed)) return false;
      if( !DeepComparable.Matches(Timing, otherT.Timing)) return false;
      if( !DeepComparable.Matches(RecordedOnElement, otherT.RecordedOnElement)) return false;
      if( !DeepComparable.Matches(Source, otherT.Source)) return false;
      if( !DeepComparable.Matches(Device, otherT.Device)) return false;
      if( !DeepComparable.Matches(Indication, otherT.Indication)) return false;
      if( !DeepComparable.Matches(BodySite, otherT.BodySite)) return false;
      if( !DeepComparable.Matches(Note, otherT.Note)) return false;

      return true;
    }

    public override bool IsExactly(IDeepComparable other)
    {
      var otherT = other as DeviceUseStatement;
      if(otherT == null) return false;

      if(!base.IsExactly(otherT)) return false;
      if( !DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
      if( !DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
      if( !DeepComparable.IsExactly(Subject, otherT.Subject)) return false;
      if( !DeepComparable.IsExactly(WhenUsed, otherT.WhenUsed)) return false;
      if( !DeepComparable.IsExactly(Timing, otherT.Timing)) return false;
      if( !DeepComparable.IsExactly(RecordedOnElement, otherT.RecordedOnElement)) return false;
      if( !DeepComparable.IsExactly(Source, otherT.Source)) return false;
      if( !DeepComparable.IsExactly(Device, otherT.Device)) return false;
      if( !DeepComparable.IsExactly(Indication, otherT.Indication)) return false;
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
        if (StatusElement != null) yield return StatusElement;
        if (Subject != null) yield return Subject;
        if (WhenUsed != null) yield return WhenUsed;
        if (Timing != null) yield return Timing;
        if (RecordedOnElement != null) yield return RecordedOnElement;
        if (Source != null) yield return Source;
        if (Device != null) yield return Device;
        foreach (var elem in Indication) { if (elem != null) yield return elem; }
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
        if (StatusElement != null) yield return new ElementValue("status", StatusElement);
        if (Subject != null) yield return new ElementValue("subject", Subject);
        if (WhenUsed != null) yield return new ElementValue("whenUsed", WhenUsed);
        if (Timing != null) yield return new ElementValue("timing", Timing);
        if (RecordedOnElement != null) yield return new ElementValue("recordedOn", RecordedOnElement);
        if (Source != null) yield return new ElementValue("source", Source);
        if (Device != null) yield return new ElementValue("device", Device);
        foreach (var elem in Indication) { if (elem != null) yield return new ElementValue("indication", elem); }
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
        case "status":
          value = StatusElement;
          return StatusElement is not null;
        case "subject":
          value = Subject;
          return Subject is not null;
        case "whenUsed":
          value = WhenUsed;
          return WhenUsed is not null;
        case "timing":
          value = Timing;
          return Timing is not null;
        case "recordedOn":
          value = RecordedOnElement;
          return RecordedOnElement is not null;
        case "source":
          value = Source;
          return Source is not null;
        case "device":
          value = Device;
          return Device is not null;
        case "indication":
          value = Indication;
          return Indication?.Any() == true;
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
      if (StatusElement is not null) yield return new KeyValuePair<string,object>("status",StatusElement);
      if (Subject is not null) yield return new KeyValuePair<string,object>("subject",Subject);
      if (WhenUsed is not null) yield return new KeyValuePair<string,object>("whenUsed",WhenUsed);
      if (Timing is not null) yield return new KeyValuePair<string,object>("timing",Timing);
      if (RecordedOnElement is not null) yield return new KeyValuePair<string,object>("recordedOn",RecordedOnElement);
      if (Source is not null) yield return new KeyValuePair<string,object>("source",Source);
      if (Device is not null) yield return new KeyValuePair<string,object>("device",Device);
      if (Indication?.Any() == true) yield return new KeyValuePair<string,object>("indication",Indication);
      if (BodySite is not null) yield return new KeyValuePair<string,object>("bodySite",BodySite);
      if (Note?.Any() == true) yield return new KeyValuePair<string,object>("note",Note);
    }

  }

}

// end of file

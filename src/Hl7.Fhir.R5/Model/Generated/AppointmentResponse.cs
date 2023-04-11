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
  /// A reply to an appointment request for a patient and/or practitioner(s), such as a confirmation or rejection
  /// </summary>
  [Serializable]
  [DataContract]
  [FhirType("AppointmentResponse","http://hl7.org/fhir/StructureDefinition/AppointmentResponse", IsResource=true)]
  public partial class AppointmentResponse : Hl7.Fhir.Model.DomainResource
  {
    /// <summary>
    /// FHIR Type Name
    /// </summary>
    public override string TypeName { get { return "AppointmentResponse"; } }

    /// <summary>
    /// The Participation status for a participant in response to a request for an appointment.
    /// (url: http://hl7.org/fhir/ValueSet/appointmentresponse-status)
    /// (systems: 2)
    /// </summary>
    [FhirEnumeration("AppointmentResponseStatus")]
    public enum AppointmentResponseStatus
    {
      /// <summary>
      /// The participant has accepted the appointment.
      /// (system: http://hl7.org/fhir/participationstatus)
      /// </summary>
      [EnumLiteral("accepted", "http://hl7.org/fhir/participationstatus"), Description("Accepted")]
      Accepted,
      /// <summary>
      /// The participant has declined the appointment and will not participate in the appointment.
      /// (system: http://hl7.org/fhir/participationstatus)
      /// </summary>
      [EnumLiteral("declined", "http://hl7.org/fhir/participationstatus"), Description("Declined")]
      Declined,
      /// <summary>
      /// The participant has  tentatively accepted the appointment. This could be automatically created by a system and requires further processing before it can be accepted. There is no commitment that attendance will occur.
      /// (system: http://hl7.org/fhir/participationstatus)
      /// </summary>
      [EnumLiteral("tentative", "http://hl7.org/fhir/participationstatus"), Description("Tentative")]
      Tentative,
      /// <summary>
      /// The participant needs to indicate if they accept the appointment by changing this status to one of the other statuses.
      /// (system: http://hl7.org/fhir/participationstatus)
      /// </summary>
      [EnumLiteral("needs-action", "http://hl7.org/fhir/participationstatus"), Description("Needs Action")]
      NeedsAction,
      /// <summary>
      /// This instance should not have been part of this patient's medical record.
      /// (system: http://hl7.org/fhir/appointmentstatus)
      /// </summary>
      [EnumLiteral("entered-in-error", "http://hl7.org/fhir/appointmentstatus"), Description("Entered in error")]
      EnteredInError,
    }

    /// <summary>
    /// External Ids for this item
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
    /// Appointment this response relates to
    /// </summary>
    [FhirElement("appointment", InSummary=true, Order=100)]
    [CLSCompliant(false)]
    [References("Appointment")]
    [Cardinality(Min=1,Max=1)]
    [DataMember]
    public Hl7.Fhir.Model.ResourceReference Appointment
    {
      get { return _Appointment; }
      set { _Appointment = value; OnPropertyChanged("Appointment"); }
    }

    private Hl7.Fhir.Model.ResourceReference _Appointment;

    /// <summary>
    /// Indicator for a counter proposal
    /// </summary>
    [FhirElement("proposedNewTime", InSummary=true, Order=110)]
    [DataMember]
    public Hl7.Fhir.Model.FhirBoolean ProposedNewTimeElement
    {
      get { return _ProposedNewTimeElement; }
      set { _ProposedNewTimeElement = value; OnPropertyChanged("ProposedNewTimeElement"); }
    }

    private Hl7.Fhir.Model.FhirBoolean _ProposedNewTimeElement;

    /// <summary>
    /// Indicator for a counter proposal
    /// </summary>
    /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
    [IgnoreDataMember]
    public bool? ProposedNewTime
    {
      get { return ProposedNewTimeElement != null ? ProposedNewTimeElement.Value : null; }
      set
      {
        if (value == null)
          ProposedNewTimeElement = null;
        else
          ProposedNewTimeElement = new Hl7.Fhir.Model.FhirBoolean(value);
        OnPropertyChanged("ProposedNewTime");
      }
    }

    /// <summary>
    /// Time from appointment, or requested new start time
    /// </summary>
    [FhirElement("start", Order=120, FiveWs="FiveWs.init")]
    [DataMember]
    public Hl7.Fhir.Model.Instant StartElement
    {
      get { return _StartElement; }
      set { _StartElement = value; OnPropertyChanged("StartElement"); }
    }

    private Hl7.Fhir.Model.Instant _StartElement;

    /// <summary>
    /// Time from appointment, or requested new start time
    /// </summary>
    /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
    [IgnoreDataMember]
    public DateTimeOffset? Start
    {
      get { return StartElement != null ? StartElement.Value : null; }
      set
      {
        if (value == null)
          StartElement = null;
        else
          StartElement = new Hl7.Fhir.Model.Instant(value);
        OnPropertyChanged("Start");
      }
    }

    /// <summary>
    /// Time from appointment, or requested new end time
    /// </summary>
    [FhirElement("end", Order=130, FiveWs="FiveWs.done[x]")]
    [DataMember]
    public Hl7.Fhir.Model.Instant EndElement
    {
      get { return _EndElement; }
      set { _EndElement = value; OnPropertyChanged("EndElement"); }
    }

    private Hl7.Fhir.Model.Instant _EndElement;

    /// <summary>
    /// Time from appointment, or requested new end time
    /// </summary>
    /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
    [IgnoreDataMember]
    public DateTimeOffset? End
    {
      get { return EndElement != null ? EndElement.Value : null; }
      set
      {
        if (value == null)
          EndElement = null;
        else
          EndElement = new Hl7.Fhir.Model.Instant(value);
        OnPropertyChanged("End");
      }
    }

    /// <summary>
    /// Role of participant in the appointment
    /// </summary>
    [FhirElement("participantType", InSummary=true, Order=140)]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.CodeableConcept> ParticipantType
    {
      get { if(_ParticipantType==null) _ParticipantType = new List<Hl7.Fhir.Model.CodeableConcept>(); return _ParticipantType; }
      set { _ParticipantType = value; OnPropertyChanged("ParticipantType"); }
    }

    private List<Hl7.Fhir.Model.CodeableConcept> _ParticipantType;

    /// <summary>
    /// Person(s), Location, HealthcareService, or Device
    /// </summary>
    [FhirElement("actor", InSummary=true, Order=150, FiveWs="FiveWs.who")]
    [CLSCompliant(false)]
    [References("Patient","Group","Practitioner","PractitionerRole","RelatedPerson","Device","HealthcareService","Location")]
    [DataMember]
    public Hl7.Fhir.Model.ResourceReference Actor
    {
      get { return _Actor; }
      set { _Actor = value; OnPropertyChanged("Actor"); }
    }

    private Hl7.Fhir.Model.ResourceReference _Actor;

    /// <summary>
    /// accepted | declined | tentative | needs-action | entered-in-error
    /// </summary>
    [FhirElement("participantStatus", InSummary=true, IsModifier=true, Order=160)]
    [DeclaredType(Type = typeof(Code))]
    [Cardinality(Min=1,Max=1)]
    [DataMember]
    public Code<Hl7.Fhir.Model.AppointmentResponse.AppointmentResponseStatus> ParticipantStatusElement
    {
      get { return _ParticipantStatusElement; }
      set { _ParticipantStatusElement = value; OnPropertyChanged("ParticipantStatusElement"); }
    }

    private Code<Hl7.Fhir.Model.AppointmentResponse.AppointmentResponseStatus> _ParticipantStatusElement;

    /// <summary>
    /// accepted | declined | tentative | needs-action | entered-in-error
    /// </summary>
    /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
    [IgnoreDataMember]
    public Hl7.Fhir.Model.AppointmentResponse.AppointmentResponseStatus? ParticipantStatus
    {
      get { return ParticipantStatusElement != null ? ParticipantStatusElement.Value : null; }
      set
      {
        if (value == null)
          ParticipantStatusElement = null;
        else
          ParticipantStatusElement = new Code<Hl7.Fhir.Model.AppointmentResponse.AppointmentResponseStatus>(value);
        OnPropertyChanged("ParticipantStatus");
      }
    }

    /// <summary>
    /// Additional comments
    /// </summary>
    [FhirElement("comment", Order=170)]
    [DataMember]
    public Hl7.Fhir.Model.Markdown CommentElement
    {
      get { return _CommentElement; }
      set { _CommentElement = value; OnPropertyChanged("CommentElement"); }
    }

    private Hl7.Fhir.Model.Markdown _CommentElement;

    /// <summary>
    /// Additional comments
    /// </summary>
    /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
    [IgnoreDataMember]
    public string Comment
    {
      get { return CommentElement != null ? CommentElement.Value : null; }
      set
      {
        if (value == null)
          CommentElement = null;
        else
          CommentElement = new Hl7.Fhir.Model.Markdown(value);
        OnPropertyChanged("Comment");
      }
    }

    /// <summary>
    /// This response is for all occurrences in a recurring request
    /// </summary>
    [FhirElement("recurring", Order=180)]
    [DataMember]
    public Hl7.Fhir.Model.FhirBoolean RecurringElement
    {
      get { return _RecurringElement; }
      set { _RecurringElement = value; OnPropertyChanged("RecurringElement"); }
    }

    private Hl7.Fhir.Model.FhirBoolean _RecurringElement;

    /// <summary>
    /// This response is for all occurrences in a recurring request
    /// </summary>
    /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
    [IgnoreDataMember]
    public bool? Recurring
    {
      get { return RecurringElement != null ? RecurringElement.Value : null; }
      set
      {
        if (value == null)
          RecurringElement = null;
        else
          RecurringElement = new Hl7.Fhir.Model.FhirBoolean(value);
        OnPropertyChanged("Recurring");
      }
    }

    /// <summary>
    /// Original date within a recurring request
    /// </summary>
    [FhirElement("occurrenceDate", Order=190)]
    [DataMember]
    public Hl7.Fhir.Model.Date OccurrenceDateElement
    {
      get { return _OccurrenceDateElement; }
      set { _OccurrenceDateElement = value; OnPropertyChanged("OccurrenceDateElement"); }
    }

    private Hl7.Fhir.Model.Date _OccurrenceDateElement;

    /// <summary>
    /// Original date within a recurring request
    /// </summary>
    /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
    [IgnoreDataMember]
    public string OccurrenceDate
    {
      get { return OccurrenceDateElement != null ? OccurrenceDateElement.Value : null; }
      set
      {
        if (value == null)
          OccurrenceDateElement = null;
        else
          OccurrenceDateElement = new Hl7.Fhir.Model.Date(value);
        OnPropertyChanged("OccurrenceDate");
      }
    }

    /// <summary>
    /// The recurrence ID of the specific recurring request
    /// </summary>
    [FhirElement("recurrenceId", Order=200)]
    [DataMember]
    public Hl7.Fhir.Model.PositiveInt RecurrenceIdElement
    {
      get { return _RecurrenceIdElement; }
      set { _RecurrenceIdElement = value; OnPropertyChanged("RecurrenceIdElement"); }
    }

    private Hl7.Fhir.Model.PositiveInt _RecurrenceIdElement;

    /// <summary>
    /// The recurrence ID of the specific recurring request
    /// </summary>
    /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
    [IgnoreDataMember]
    public int? RecurrenceId
    {
      get { return RecurrenceIdElement != null ? RecurrenceIdElement.Value : null; }
      set
      {
        if (value == null)
          RecurrenceIdElement = null;
        else
          RecurrenceIdElement = new Hl7.Fhir.Model.PositiveInt(value);
        OnPropertyChanged("RecurrenceId");
      }
    }

    public override IDeepCopyable CopyTo(IDeepCopyable other)
    {
      var dest = other as AppointmentResponse;

      if (dest == null)
      {
        throw new ArgumentException("Can only copy to an object of the same type", "other");
      }

      base.CopyTo(dest);
      if(Identifier != null) dest.Identifier = new List<Hl7.Fhir.Model.Identifier>(Identifier.DeepCopy());
      if(Appointment != null) dest.Appointment = (Hl7.Fhir.Model.ResourceReference)Appointment.DeepCopy();
      if(ProposedNewTimeElement != null) dest.ProposedNewTimeElement = (Hl7.Fhir.Model.FhirBoolean)ProposedNewTimeElement.DeepCopy();
      if(StartElement != null) dest.StartElement = (Hl7.Fhir.Model.Instant)StartElement.DeepCopy();
      if(EndElement != null) dest.EndElement = (Hl7.Fhir.Model.Instant)EndElement.DeepCopy();
      if(ParticipantType != null) dest.ParticipantType = new List<Hl7.Fhir.Model.CodeableConcept>(ParticipantType.DeepCopy());
      if(Actor != null) dest.Actor = (Hl7.Fhir.Model.ResourceReference)Actor.DeepCopy();
      if(ParticipantStatusElement != null) dest.ParticipantStatusElement = (Code<Hl7.Fhir.Model.AppointmentResponse.AppointmentResponseStatus>)ParticipantStatusElement.DeepCopy();
      if(CommentElement != null) dest.CommentElement = (Hl7.Fhir.Model.Markdown)CommentElement.DeepCopy();
      if(RecurringElement != null) dest.RecurringElement = (Hl7.Fhir.Model.FhirBoolean)RecurringElement.DeepCopy();
      if(OccurrenceDateElement != null) dest.OccurrenceDateElement = (Hl7.Fhir.Model.Date)OccurrenceDateElement.DeepCopy();
      if(RecurrenceIdElement != null) dest.RecurrenceIdElement = (Hl7.Fhir.Model.PositiveInt)RecurrenceIdElement.DeepCopy();
      return dest;
    }

    public override IDeepCopyable DeepCopy()
    {
      return CopyTo(new AppointmentResponse());
    }

    ///<inheritdoc />
    public override bool Matches(IDeepComparable other)
    {
      var otherT = other as AppointmentResponse;
      if(otherT == null) return false;

      if(!base.Matches(otherT)) return false;
      if( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
      if( !DeepComparable.Matches(Appointment, otherT.Appointment)) return false;
      if( !DeepComparable.Matches(ProposedNewTimeElement, otherT.ProposedNewTimeElement)) return false;
      if( !DeepComparable.Matches(StartElement, otherT.StartElement)) return false;
      if( !DeepComparable.Matches(EndElement, otherT.EndElement)) return false;
      if( !DeepComparable.Matches(ParticipantType, otherT.ParticipantType)) return false;
      if( !DeepComparable.Matches(Actor, otherT.Actor)) return false;
      if( !DeepComparable.Matches(ParticipantStatusElement, otherT.ParticipantStatusElement)) return false;
      if( !DeepComparable.Matches(CommentElement, otherT.CommentElement)) return false;
      if( !DeepComparable.Matches(RecurringElement, otherT.RecurringElement)) return false;
      if( !DeepComparable.Matches(OccurrenceDateElement, otherT.OccurrenceDateElement)) return false;
      if( !DeepComparable.Matches(RecurrenceIdElement, otherT.RecurrenceIdElement)) return false;

      return true;
    }

    public override bool IsExactly(IDeepComparable other)
    {
      var otherT = other as AppointmentResponse;
      if(otherT == null) return false;

      if(!base.IsExactly(otherT)) return false;
      if( !DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
      if( !DeepComparable.IsExactly(Appointment, otherT.Appointment)) return false;
      if( !DeepComparable.IsExactly(ProposedNewTimeElement, otherT.ProposedNewTimeElement)) return false;
      if( !DeepComparable.IsExactly(StartElement, otherT.StartElement)) return false;
      if( !DeepComparable.IsExactly(EndElement, otherT.EndElement)) return false;
      if( !DeepComparable.IsExactly(ParticipantType, otherT.ParticipantType)) return false;
      if( !DeepComparable.IsExactly(Actor, otherT.Actor)) return false;
      if( !DeepComparable.IsExactly(ParticipantStatusElement, otherT.ParticipantStatusElement)) return false;
      if( !DeepComparable.IsExactly(CommentElement, otherT.CommentElement)) return false;
      if( !DeepComparable.IsExactly(RecurringElement, otherT.RecurringElement)) return false;
      if( !DeepComparable.IsExactly(OccurrenceDateElement, otherT.OccurrenceDateElement)) return false;
      if( !DeepComparable.IsExactly(RecurrenceIdElement, otherT.RecurrenceIdElement)) return false;

      return true;
    }

    [IgnoreDataMember]
    public override IEnumerable<Base> Children
    {
      get
      {
        foreach (var item in base.Children) yield return item;
        foreach (var elem in Identifier) { if (elem != null) yield return elem; }
        if (Appointment != null) yield return Appointment;
        if (ProposedNewTimeElement != null) yield return ProposedNewTimeElement;
        if (StartElement != null) yield return StartElement;
        if (EndElement != null) yield return EndElement;
        foreach (var elem in ParticipantType) { if (elem != null) yield return elem; }
        if (Actor != null) yield return Actor;
        if (ParticipantStatusElement != null) yield return ParticipantStatusElement;
        if (CommentElement != null) yield return CommentElement;
        if (RecurringElement != null) yield return RecurringElement;
        if (OccurrenceDateElement != null) yield return OccurrenceDateElement;
        if (RecurrenceIdElement != null) yield return RecurrenceIdElement;
      }
    }

    [IgnoreDataMember]
    public override IEnumerable<ElementValue> NamedChildren
    {
      get
      {
        foreach (var item in base.NamedChildren) yield return item;
        foreach (var elem in Identifier) { if (elem != null) yield return new ElementValue("identifier", elem); }
        if (Appointment != null) yield return new ElementValue("appointment", Appointment);
        if (ProposedNewTimeElement != null) yield return new ElementValue("proposedNewTime", ProposedNewTimeElement);
        if (StartElement != null) yield return new ElementValue("start", StartElement);
        if (EndElement != null) yield return new ElementValue("end", EndElement);
        foreach (var elem in ParticipantType) { if (elem != null) yield return new ElementValue("participantType", elem); }
        if (Actor != null) yield return new ElementValue("actor", Actor);
        if (ParticipantStatusElement != null) yield return new ElementValue("participantStatus", ParticipantStatusElement);
        if (CommentElement != null) yield return new ElementValue("comment", CommentElement);
        if (RecurringElement != null) yield return new ElementValue("recurring", RecurringElement);
        if (OccurrenceDateElement != null) yield return new ElementValue("occurrenceDate", OccurrenceDateElement);
        if (RecurrenceIdElement != null) yield return new ElementValue("recurrenceId", RecurrenceIdElement);
      }
    }

    protected override bool TryGetValue(string key, out object value)
    {
      switch (key)
      {
        case "identifier":
          value = Identifier;
          return Identifier?.Any() == true;
        case "appointment":
          value = Appointment;
          return Appointment is not null;
        case "proposedNewTime":
          value = ProposedNewTimeElement;
          return ProposedNewTimeElement is not null;
        case "start":
          value = StartElement;
          return StartElement is not null;
        case "end":
          value = EndElement;
          return EndElement is not null;
        case "participantType":
          value = ParticipantType;
          return ParticipantType?.Any() == true;
        case "actor":
          value = Actor;
          return Actor is not null;
        case "participantStatus":
          value = ParticipantStatusElement;
          return ParticipantStatusElement is not null;
        case "comment":
          value = CommentElement;
          return CommentElement is not null;
        case "recurring":
          value = RecurringElement;
          return RecurringElement is not null;
        case "occurrenceDate":
          value = OccurrenceDateElement;
          return OccurrenceDateElement is not null;
        case "recurrenceId":
          value = RecurrenceIdElement;
          return RecurrenceIdElement is not null;
        default:
          return base.TryGetValue(key, out value);
      }

    }

    protected override IEnumerable<KeyValuePair<string, object>> GetElementPairs()
    {
      foreach (var kvp in base.GetElementPairs()) yield return kvp;
      if (Identifier?.Any() == true) yield return new KeyValuePair<string,object>("identifier",Identifier);
      if (Appointment is not null) yield return new KeyValuePair<string,object>("appointment",Appointment);
      if (ProposedNewTimeElement is not null) yield return new KeyValuePair<string,object>("proposedNewTime",ProposedNewTimeElement);
      if (StartElement is not null) yield return new KeyValuePair<string,object>("start",StartElement);
      if (EndElement is not null) yield return new KeyValuePair<string,object>("end",EndElement);
      if (ParticipantType?.Any() == true) yield return new KeyValuePair<string,object>("participantType",ParticipantType);
      if (Actor is not null) yield return new KeyValuePair<string,object>("actor",Actor);
      if (ParticipantStatusElement is not null) yield return new KeyValuePair<string,object>("participantStatus",ParticipantStatusElement);
      if (CommentElement is not null) yield return new KeyValuePair<string,object>("comment",CommentElement);
      if (RecurringElement is not null) yield return new KeyValuePair<string,object>("recurring",RecurringElement);
      if (OccurrenceDateElement is not null) yield return new KeyValuePair<string,object>("occurrenceDate",OccurrenceDateElement);
      if (RecurrenceIdElement is not null) yield return new KeyValuePair<string,object>("recurrenceId",RecurrenceIdElement);
    }

  }

}

// end of file

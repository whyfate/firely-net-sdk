// <auto-generated/>
// Contents of: hl7.fhir.r6.expansions@6.0.0-ballot2, hl7.fhir.r6.core@6.0.0-ballot2

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Hl7.Fhir.Introspection;
using Hl7.Fhir.Serialization;
using Hl7.Fhir.Specification;
using Hl7.Fhir.Utility;
using Hl7.Fhir.Validation;
using SystemPrimitive = Hl7.Fhir.ElementModel.Types;

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
  /// Participant or object which is the recipient of investigative activities in a study
  /// </summary>
  /// <remarks>
  /// A ResearchSubject is a participant or object which is the recipient of investigative activities in a research study.
  /// Need to make sure we encompass public health studies.
  /// </remarks>
  [Serializable]
  [DataContract]
  [FhirType("ResearchSubject","http://hl7.org/fhir/StructureDefinition/ResearchSubject", IsResource=true)]
  public partial class ResearchSubject : Hl7.Fhir.Model.DomainResource, IIdentifiable<List<Identifier>>
  {
    /// <summary>
    /// FHIR Type Name
    /// </summary>
    public override string TypeName { get { return "ResearchSubject"; } }

    /// <summary>
    /// A duration in the lifecycle of the ResearchSubject within a ResearchStudy
    /// </summary>
    [Serializable]
    [DataContract]
    [FhirType("ResearchSubject#SubjectState", IsNestedType=true)]
    [BackboneType("ResearchSubject.subjectState")]
    public partial class SubjectStateComponent : Hl7.Fhir.Model.BackboneElement
    {
      /// <summary>
      /// FHIR Type Name
      /// </summary>
      public override string TypeName { get { return "ResearchSubject#SubjectState"; } }

      /// <summary>
      /// candidate | in-prescreening | in-screening | eligible | ineligible | on-study | on-study-intervention | in-follow-up | off-study
      /// </summary>
      [FhirElement("code", Order=40, FiveWs="FiveWs.status")]
      [Binding("ResearchSubjectState")]
      [Cardinality(Min=1,Max=1)]
      [DataMember]
      public Hl7.Fhir.Model.CodeableConcept Code
      {
        get { return _Code; }
        set { _Code = value; OnPropertyChanged("Code"); }
      }

      private Hl7.Fhir.Model.CodeableConcept _Code;

      /// <summary>
      /// The date a research subject entered the given state
      /// </summary>
      [FhirElement("startDate", Order=50)]
      [Cardinality(Min=1,Max=1)]
      [DataMember]
      public Hl7.Fhir.Model.FhirDateTime StartDateElement
      {
        get { return _StartDateElement; }
        set { _StartDateElement = value; OnPropertyChanged("StartDateElement"); }
      }

      private Hl7.Fhir.Model.FhirDateTime _StartDateElement;

      /// <summary>
      /// The date a research subject entered the given state
      /// </summary>
      /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
      [IgnoreDataMember]
      public string StartDate
      {
        get { return StartDateElement != null ? StartDateElement.Value : null; }
        set
        {
          if (value == null)
            StartDateElement = null;
          else
            StartDateElement = new Hl7.Fhir.Model.FhirDateTime(value);
          OnPropertyChanged("StartDate");
        }
      }

      /// <summary>
      /// The date a research subject exited or left the given state
      /// </summary>
      [FhirElement("endDate", Order=60)]
      [DataMember]
      public Hl7.Fhir.Model.FhirDateTime EndDateElement
      {
        get { return _EndDateElement; }
        set { _EndDateElement = value; OnPropertyChanged("EndDateElement"); }
      }

      private Hl7.Fhir.Model.FhirDateTime _EndDateElement;

      /// <summary>
      /// The date a research subject exited or left the given state
      /// </summary>
      /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
      [IgnoreDataMember]
      public string EndDate
      {
        get { return EndDateElement != null ? EndDateElement.Value : null; }
        set
        {
          if (value == null)
            EndDateElement = null;
          else
            EndDateElement = new Hl7.Fhir.Model.FhirDateTime(value);
          OnPropertyChanged("EndDate");
        }
      }

      /// <summary>
      /// State change reason
      /// </summary>
      [FhirElement("reason", Order=70)]
      [Binding("StateChangeReason")]
      [DataMember]
      public Hl7.Fhir.Model.CodeableConcept Reason
      {
        get { return _Reason; }
        set { _Reason = value; OnPropertyChanged("Reason"); }
      }

      private Hl7.Fhir.Model.CodeableConcept _Reason;

      public override IDeepCopyable CopyTo(IDeepCopyable other)
      {
        var dest = other as SubjectStateComponent;

        if (dest == null)
        {
          throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        base.CopyTo(dest);
        if(Code != null) dest.Code = (Hl7.Fhir.Model.CodeableConcept)Code.DeepCopy();
        if(StartDateElement != null) dest.StartDateElement = (Hl7.Fhir.Model.FhirDateTime)StartDateElement.DeepCopy();
        if(EndDateElement != null) dest.EndDateElement = (Hl7.Fhir.Model.FhirDateTime)EndDateElement.DeepCopy();
        if(Reason != null) dest.Reason = (Hl7.Fhir.Model.CodeableConcept)Reason.DeepCopy();
        return dest;
      }

      public override IDeepCopyable DeepCopy()
      {
        return CopyTo(new SubjectStateComponent());
      }

      ///<inheritdoc />
      public override bool Matches(IDeepComparable other)
      {
        var otherT = other as SubjectStateComponent;
        if(otherT == null) return false;

        if(!base.Matches(otherT)) return false;
        if( !DeepComparable.Matches(Code, otherT.Code)) return false;
        if( !DeepComparable.Matches(StartDateElement, otherT.StartDateElement)) return false;
        if( !DeepComparable.Matches(EndDateElement, otherT.EndDateElement)) return false;
        if( !DeepComparable.Matches(Reason, otherT.Reason)) return false;

        return true;
      }

      public override bool IsExactly(IDeepComparable other)
      {
        var otherT = other as SubjectStateComponent;
        if(otherT == null) return false;

        if(!base.IsExactly(otherT)) return false;
        if( !DeepComparable.IsExactly(Code, otherT.Code)) return false;
        if( !DeepComparable.IsExactly(StartDateElement, otherT.StartDateElement)) return false;
        if( !DeepComparable.IsExactly(EndDateElement, otherT.EndDateElement)) return false;
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
          if (StartDateElement != null) yield return StartDateElement;
          if (EndDateElement != null) yield return EndDateElement;
          if (Reason != null) yield return Reason;
        }
      }

      [IgnoreDataMember]
      public override IEnumerable<ElementValue> NamedChildren
      {
        get
        {
          foreach (var item in base.NamedChildren) yield return item;
          if (Code != null) yield return new ElementValue("code", Code);
          if (StartDateElement != null) yield return new ElementValue("startDate", StartDateElement);
          if (EndDateElement != null) yield return new ElementValue("endDate", EndDateElement);
          if (Reason != null) yield return new ElementValue("reason", Reason);
        }
      }

      protected override bool TryGetValue(string key, out object value)
      {
        switch (key)
        {
          case "code":
            value = Code;
            return Code is not null;
          case "startDate":
            value = StartDateElement;
            return StartDateElement is not null;
          case "endDate":
            value = EndDateElement;
            return EndDateElement is not null;
          case "reason":
            value = Reason;
            return Reason is not null;
          default:
            return base.TryGetValue(key, out value);
        }

      }

      protected override IEnumerable<KeyValuePair<string, object>> GetElementPairs()
      {
        foreach (var kvp in base.GetElementPairs()) yield return kvp;
        if (Code is not null) yield return new KeyValuePair<string,object>("code",Code);
        if (StartDateElement is not null) yield return new KeyValuePair<string,object>("startDate",StartDateElement);
        if (EndDateElement is not null) yield return new KeyValuePair<string,object>("endDate",EndDateElement);
        if (Reason is not null) yield return new KeyValuePair<string,object>("reason",Reason);
      }

    }

    /// <summary>
    /// A significant event in the progress of a ResearchSubject
    /// </summary>
    [Serializable]
    [DataContract]
    [FhirType("ResearchSubject#SubjectMilestone", IsNestedType=true)]
    [BackboneType("ResearchSubject.subjectMilestone")]
    public partial class SubjectMilestoneComponent : Hl7.Fhir.Model.BackboneElement
    {
      /// <summary>
      /// FHIR Type Name
      /// </summary>
      public override string TypeName { get { return "ResearchSubject#SubjectMilestone"; } }

      /// <summary>
      /// SignedUp | Screened | Randomized
      /// </summary>
      [FhirElement("milestone", Order=40)]
      [Binding("ResearchSubjectMilestone")]
      [Cardinality(Min=1,Max=-1)]
      [DataMember]
      public List<Hl7.Fhir.Model.CodeableConcept> Milestone
      {
        get { if(_Milestone==null) _Milestone = new List<Hl7.Fhir.Model.CodeableConcept>(); return _Milestone; }
        set { _Milestone = value; OnPropertyChanged("Milestone"); }
      }

      private List<Hl7.Fhir.Model.CodeableConcept> _Milestone;

      /// <summary>
      /// The date/time when this milestone event was completed
      /// </summary>
      [FhirElement("date", Order=50)]
      [DataMember]
      public Hl7.Fhir.Model.FhirDateTime DateElement
      {
        get { return _DateElement; }
        set { _DateElement = value; OnPropertyChanged("DateElement"); }
      }

      private Hl7.Fhir.Model.FhirDateTime _DateElement;

      /// <summary>
      /// The date/time when this milestone event was completed
      /// </summary>
      /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
      [IgnoreDataMember]
      public string Date
      {
        get { return DateElement != null ? DateElement.Value : null; }
        set
        {
          if (value == null)
            DateElement = null;
          else
            DateElement = new Hl7.Fhir.Model.FhirDateTime(value);
          OnPropertyChanged("Date");
        }
      }

      [FhirElement("reason", Order=60)]
      [DataMember]
      public Hl7.Fhir.Model.CodeableConcept Reason
      {
        get { return _Reason; }
        set { _Reason = value; OnPropertyChanged("Reason"); }
      }

      private Hl7.Fhir.Model.CodeableConcept _Reason;

      public override IDeepCopyable CopyTo(IDeepCopyable other)
      {
        var dest = other as SubjectMilestoneComponent;

        if (dest == null)
        {
          throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        base.CopyTo(dest);
        if(Milestone.Any()) dest.Milestone = new List<Hl7.Fhir.Model.CodeableConcept>(Milestone.DeepCopy());
        if(DateElement != null) dest.DateElement = (Hl7.Fhir.Model.FhirDateTime)DateElement.DeepCopy();
        if(Reason != null) dest.Reason = (Hl7.Fhir.Model.CodeableConcept)Reason.DeepCopy();
        return dest;
      }

      public override IDeepCopyable DeepCopy()
      {
        return CopyTo(new SubjectMilestoneComponent());
      }

      ///<inheritdoc />
      public override bool Matches(IDeepComparable other)
      {
        var otherT = other as SubjectMilestoneComponent;
        if(otherT == null) return false;

        if(!base.Matches(otherT)) return false;
        if( !DeepComparable.Matches(Milestone, otherT.Milestone)) return false;
        if( !DeepComparable.Matches(DateElement, otherT.DateElement)) return false;
        if( !DeepComparable.Matches(Reason, otherT.Reason)) return false;

        return true;
      }

      public override bool IsExactly(IDeepComparable other)
      {
        var otherT = other as SubjectMilestoneComponent;
        if(otherT == null) return false;

        if(!base.IsExactly(otherT)) return false;
        if( !DeepComparable.IsExactly(Milestone, otherT.Milestone)) return false;
        if( !DeepComparable.IsExactly(DateElement, otherT.DateElement)) return false;
        if( !DeepComparable.IsExactly(Reason, otherT.Reason)) return false;

        return true;
      }

      [IgnoreDataMember]
      public override IEnumerable<Base> Children
      {
        get
        {
          foreach (var item in base.Children) yield return item;
          foreach (var elem in Milestone) { if (elem != null) yield return elem; }
          if (DateElement != null) yield return DateElement;
          if (Reason != null) yield return Reason;
        }
      }

      [IgnoreDataMember]
      public override IEnumerable<ElementValue> NamedChildren
      {
        get
        {
          foreach (var item in base.NamedChildren) yield return item;
          foreach (var elem in Milestone) { if (elem != null) yield return new ElementValue("milestone", elem); }
          if (DateElement != null) yield return new ElementValue("date", DateElement);
          if (Reason != null) yield return new ElementValue("reason", Reason);
        }
      }

      protected override bool TryGetValue(string key, out object value)
      {
        switch (key)
        {
          case "milestone":
            value = Milestone;
            return Milestone?.Any() == true;
          case "date":
            value = DateElement;
            return DateElement is not null;
          case "reason":
            value = Reason;
            return Reason is not null;
          default:
            return base.TryGetValue(key, out value);
        }

      }

      protected override IEnumerable<KeyValuePair<string, object>> GetElementPairs()
      {
        foreach (var kvp in base.GetElementPairs()) yield return kvp;
        if (Milestone?.Any() == true) yield return new KeyValuePair<string,object>("milestone",Milestone);
        if (DateElement is not null) yield return new KeyValuePair<string,object>("date",DateElement);
        if (Reason is not null) yield return new KeyValuePair<string,object>("reason",Reason);
      }

    }

    /// <summary>
    /// Business Identifier for research subject in a study
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
    /// draft | active | retired | unknown
    /// </summary>
    [FhirElement("status", InSummary=true, IsModifier=true, Order=100, FiveWs="FiveWs.status")]
    [DeclaredType(Type = typeof(Code))]
    [Binding("PublicationStatus")]
    [Cardinality(Min=1,Max=1)]
    [DataMember]
    public Code<Hl7.Fhir.Model.PublicationStatus> StatusElement
    {
      get { return _StatusElement; }
      set { _StatusElement = value; OnPropertyChanged("StatusElement"); }
    }

    private Code<Hl7.Fhir.Model.PublicationStatus> _StatusElement;

    /// <summary>
    /// draft | active | retired | unknown
    /// </summary>
    /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
    [IgnoreDataMember]
    public Hl7.Fhir.Model.PublicationStatus? Status
    {
      get { return StatusElement != null ? StatusElement.Value : null; }
      set
      {
        if (value == null)
          StatusElement = null;
        else
          StatusElement = new Code<Hl7.Fhir.Model.PublicationStatus>(value);
        OnPropertyChanged("Status");
      }
    }

    /// <summary>
    /// Start and end of participation
    /// </summary>
    [FhirElement("period", InSummary=true, Order=110)]
    [DataMember]
    public Hl7.Fhir.Model.Period Period
    {
      get { return _Period; }
      set { _Period = value; OnPropertyChanged("Period"); }
    }

    private Hl7.Fhir.Model.Period _Period;

    /// <summary>
    /// Study subject is part of
    /// </summary>
    [FhirElement("study", InSummary=true, Order=120)]
    [CLSCompliant(false)]
    [References("ResearchStudy")]
    [Cardinality(Min=1,Max=1)]
    [DataMember]
    public Hl7.Fhir.Model.ResourceReference Study
    {
      get { return _Study; }
      set { _Study = value; OnPropertyChanged("Study"); }
    }

    private Hl7.Fhir.Model.ResourceReference _Study;

    /// <summary>
    /// Who or what is part of study
    /// </summary>
    [FhirElement("subject", InSummary=true, Order=130)]
    [CLSCompliant(false)]
    [References("Patient","Group","Specimen","Device","Medication","Substance","BiologicallyDerivedProduct")]
    [Cardinality(Min=1,Max=1)]
    [DataMember]
    public Hl7.Fhir.Model.ResourceReference Subject
    {
      get { return _Subject; }
      set { _Subject = value; OnPropertyChanged("Subject"); }
    }

    private Hl7.Fhir.Model.ResourceReference _Subject;

    /// <summary>
    /// A duration in the lifecycle of the ResearchSubject within a ResearchStudy
    /// </summary>
    [FhirElement("subjectState", Order=140)]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.ResearchSubject.SubjectStateComponent> SubjectState
    {
      get { if(_SubjectState==null) _SubjectState = new List<Hl7.Fhir.Model.ResearchSubject.SubjectStateComponent>(); return _SubjectState; }
      set { _SubjectState = value; OnPropertyChanged("SubjectState"); }
    }

    private List<Hl7.Fhir.Model.ResearchSubject.SubjectStateComponent> _SubjectState;

    /// <summary>
    /// A significant event in the progress of a ResearchSubject
    /// </summary>
    [FhirElement("subjectMilestone", Order=150)]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.ResearchSubject.SubjectMilestoneComponent> SubjectMilestone
    {
      get { if(_SubjectMilestone==null) _SubjectMilestone = new List<Hl7.Fhir.Model.ResearchSubject.SubjectMilestoneComponent>(); return _SubjectMilestone; }
      set { _SubjectMilestone = value; OnPropertyChanged("SubjectMilestone"); }
    }

    private List<Hl7.Fhir.Model.ResearchSubject.SubjectMilestoneComponent> _SubjectMilestone;

    /// <summary>
    /// What path should be followed
    /// </summary>
    [FhirElement("assignedComparisonGroup", Order=160)]
    [DataMember]
    public Hl7.Fhir.Model.Id AssignedComparisonGroupElement
    {
      get { return _AssignedComparisonGroupElement; }
      set { _AssignedComparisonGroupElement = value; OnPropertyChanged("AssignedComparisonGroupElement"); }
    }

    private Hl7.Fhir.Model.Id _AssignedComparisonGroupElement;

    /// <summary>
    /// What path should be followed
    /// </summary>
    /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
    [IgnoreDataMember]
    public string AssignedComparisonGroup
    {
      get { return AssignedComparisonGroupElement != null ? AssignedComparisonGroupElement.Value : null; }
      set
      {
        if (value == null)
          AssignedComparisonGroupElement = null;
        else
          AssignedComparisonGroupElement = new Hl7.Fhir.Model.Id(value);
        OnPropertyChanged("AssignedComparisonGroup");
      }
    }

    /// <summary>
    /// What path was followed
    /// </summary>
    [FhirElement("actualComparisonGroup", Order=170)]
    [DataMember]
    public Hl7.Fhir.Model.Id ActualComparisonGroupElement
    {
      get { return _ActualComparisonGroupElement; }
      set { _ActualComparisonGroupElement = value; OnPropertyChanged("ActualComparisonGroupElement"); }
    }

    private Hl7.Fhir.Model.Id _ActualComparisonGroupElement;

    /// <summary>
    /// What path was followed
    /// </summary>
    /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
    [IgnoreDataMember]
    public string ActualComparisonGroup
    {
      get { return ActualComparisonGroupElement != null ? ActualComparisonGroupElement.Value : null; }
      set
      {
        if (value == null)
          ActualComparisonGroupElement = null;
        else
          ActualComparisonGroupElement = new Hl7.Fhir.Model.Id(value);
        OnPropertyChanged("ActualComparisonGroup");
      }
    }

    /// <summary>
    /// Agreement to participate in study
    /// </summary>
    [FhirElement("consent", Order=180)]
    [CLSCompliant(false)]
    [References("Consent")]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.ResourceReference> Consent
    {
      get { if(_Consent==null) _Consent = new List<Hl7.Fhir.Model.ResourceReference>(); return _Consent; }
      set { _Consent = value; OnPropertyChanged("Consent"); }
    }

    private List<Hl7.Fhir.Model.ResourceReference> _Consent;

    List<Identifier> IIdentifiable<List<Identifier>>.Identifier { get => Identifier; set => Identifier = value; }

    public override IDeepCopyable CopyTo(IDeepCopyable other)
    {
      var dest = other as ResearchSubject;

      if (dest == null)
      {
        throw new ArgumentException("Can only copy to an object of the same type", "other");
      }

      base.CopyTo(dest);
      if(Identifier.Any()) dest.Identifier = new List<Hl7.Fhir.Model.Identifier>(Identifier.DeepCopy());
      if(StatusElement != null) dest.StatusElement = (Code<Hl7.Fhir.Model.PublicationStatus>)StatusElement.DeepCopy();
      if(Period != null) dest.Period = (Hl7.Fhir.Model.Period)Period.DeepCopy();
      if(Study != null) dest.Study = (Hl7.Fhir.Model.ResourceReference)Study.DeepCopy();
      if(Subject != null) dest.Subject = (Hl7.Fhir.Model.ResourceReference)Subject.DeepCopy();
      if(SubjectState.Any()) dest.SubjectState = new List<Hl7.Fhir.Model.ResearchSubject.SubjectStateComponent>(SubjectState.DeepCopy());
      if(SubjectMilestone.Any()) dest.SubjectMilestone = new List<Hl7.Fhir.Model.ResearchSubject.SubjectMilestoneComponent>(SubjectMilestone.DeepCopy());
      if(AssignedComparisonGroupElement != null) dest.AssignedComparisonGroupElement = (Hl7.Fhir.Model.Id)AssignedComparisonGroupElement.DeepCopy();
      if(ActualComparisonGroupElement != null) dest.ActualComparisonGroupElement = (Hl7.Fhir.Model.Id)ActualComparisonGroupElement.DeepCopy();
      if(Consent.Any()) dest.Consent = new List<Hl7.Fhir.Model.ResourceReference>(Consent.DeepCopy());
      return dest;
    }

    public override IDeepCopyable DeepCopy()
    {
      return CopyTo(new ResearchSubject());
    }

    ///<inheritdoc />
    public override bool Matches(IDeepComparable other)
    {
      var otherT = other as ResearchSubject;
      if(otherT == null) return false;

      if(!base.Matches(otherT)) return false;
      if( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
      if( !DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
      if( !DeepComparable.Matches(Period, otherT.Period)) return false;
      if( !DeepComparable.Matches(Study, otherT.Study)) return false;
      if( !DeepComparable.Matches(Subject, otherT.Subject)) return false;
      if( !DeepComparable.Matches(SubjectState, otherT.SubjectState)) return false;
      if( !DeepComparable.Matches(SubjectMilestone, otherT.SubjectMilestone)) return false;
      if( !DeepComparable.Matches(AssignedComparisonGroupElement, otherT.AssignedComparisonGroupElement)) return false;
      if( !DeepComparable.Matches(ActualComparisonGroupElement, otherT.ActualComparisonGroupElement)) return false;
      if( !DeepComparable.Matches(Consent, otherT.Consent)) return false;

      return true;
    }

    public override bool IsExactly(IDeepComparable other)
    {
      var otherT = other as ResearchSubject;
      if(otherT == null) return false;

      if(!base.IsExactly(otherT)) return false;
      if( !DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
      if( !DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
      if( !DeepComparable.IsExactly(Period, otherT.Period)) return false;
      if( !DeepComparable.IsExactly(Study, otherT.Study)) return false;
      if( !DeepComparable.IsExactly(Subject, otherT.Subject)) return false;
      if( !DeepComparable.IsExactly(SubjectState, otherT.SubjectState)) return false;
      if( !DeepComparable.IsExactly(SubjectMilestone, otherT.SubjectMilestone)) return false;
      if( !DeepComparable.IsExactly(AssignedComparisonGroupElement, otherT.AssignedComparisonGroupElement)) return false;
      if( !DeepComparable.IsExactly(ActualComparisonGroupElement, otherT.ActualComparisonGroupElement)) return false;
      if( !DeepComparable.IsExactly(Consent, otherT.Consent)) return false;

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
        if (Period != null) yield return Period;
        if (Study != null) yield return Study;
        if (Subject != null) yield return Subject;
        foreach (var elem in SubjectState) { if (elem != null) yield return elem; }
        foreach (var elem in SubjectMilestone) { if (elem != null) yield return elem; }
        if (AssignedComparisonGroupElement != null) yield return AssignedComparisonGroupElement;
        if (ActualComparisonGroupElement != null) yield return ActualComparisonGroupElement;
        foreach (var elem in Consent) { if (elem != null) yield return elem; }
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
        if (Period != null) yield return new ElementValue("period", Period);
        if (Study != null) yield return new ElementValue("study", Study);
        if (Subject != null) yield return new ElementValue("subject", Subject);
        foreach (var elem in SubjectState) { if (elem != null) yield return new ElementValue("subjectState", elem); }
        foreach (var elem in SubjectMilestone) { if (elem != null) yield return new ElementValue("subjectMilestone", elem); }
        if (AssignedComparisonGroupElement != null) yield return new ElementValue("assignedComparisonGroup", AssignedComparisonGroupElement);
        if (ActualComparisonGroupElement != null) yield return new ElementValue("actualComparisonGroup", ActualComparisonGroupElement);
        foreach (var elem in Consent) { if (elem != null) yield return new ElementValue("consent", elem); }
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
        case "period":
          value = Period;
          return Period is not null;
        case "study":
          value = Study;
          return Study is not null;
        case "subject":
          value = Subject;
          return Subject is not null;
        case "subjectState":
          value = SubjectState;
          return SubjectState?.Any() == true;
        case "subjectMilestone":
          value = SubjectMilestone;
          return SubjectMilestone?.Any() == true;
        case "assignedComparisonGroup":
          value = AssignedComparisonGroupElement;
          return AssignedComparisonGroupElement is not null;
        case "actualComparisonGroup":
          value = ActualComparisonGroupElement;
          return ActualComparisonGroupElement is not null;
        case "consent":
          value = Consent;
          return Consent?.Any() == true;
        default:
          return base.TryGetValue(key, out value);
      }

    }

    protected override IEnumerable<KeyValuePair<string, object>> GetElementPairs()
    {
      foreach (var kvp in base.GetElementPairs()) yield return kvp;
      if (Identifier?.Any() == true) yield return new KeyValuePair<string,object>("identifier",Identifier);
      if (StatusElement is not null) yield return new KeyValuePair<string,object>("status",StatusElement);
      if (Period is not null) yield return new KeyValuePair<string,object>("period",Period);
      if (Study is not null) yield return new KeyValuePair<string,object>("study",Study);
      if (Subject is not null) yield return new KeyValuePair<string,object>("subject",Subject);
      if (SubjectState?.Any() == true) yield return new KeyValuePair<string,object>("subjectState",SubjectState);
      if (SubjectMilestone?.Any() == true) yield return new KeyValuePair<string,object>("subjectMilestone",SubjectMilestone);
      if (AssignedComparisonGroupElement is not null) yield return new KeyValuePair<string,object>("assignedComparisonGroup",AssignedComparisonGroupElement);
      if (ActualComparisonGroupElement is not null) yield return new KeyValuePair<string,object>("actualComparisonGroup",ActualComparisonGroupElement);
      if (Consent?.Any() == true) yield return new KeyValuePair<string,object>("consent",Consent);
    }

  }

}

// end of file

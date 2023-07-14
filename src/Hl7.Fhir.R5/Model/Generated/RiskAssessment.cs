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
  /// Potential outcomes for a subject with likelihood
  /// </summary>
  [Serializable]
  [DataContract]
  [FhirType("RiskAssessment","http://hl7.org/fhir/StructureDefinition/RiskAssessment", IsResource=true)]
  public partial class RiskAssessment : Hl7.Fhir.Model.DomainResource, IIdentifiable<List<Identifier>>
  {
    /// <summary>
    /// FHIR Type Name
    /// </summary>
    public override string TypeName { get { return "RiskAssessment"; } }

    /// <summary>
    /// Outcome predicted
    /// </summary>
    [Serializable]
    [DataContract]
    [FhirType("RiskAssessment#Prediction", IsNestedType=true)]
    [BackboneType("RiskAssessment.prediction")]
    public partial class PredictionComponent : Hl7.Fhir.Model.BackboneElement
    {
      /// <summary>
      /// FHIR Type Name
      /// </summary>
      public override string TypeName { get { return "RiskAssessment#Prediction"; } }

      /// <summary>
      /// Possible outcome for the subject
      /// </summary>
      [FhirElement("outcome", Order=40)]
      [Binding("RiskAssessmentOutcome")]
      [DataMember]
      public Hl7.Fhir.Model.CodeableConcept Outcome
      {
        get { return _Outcome; }
        set { _Outcome = value; OnPropertyChanged("Outcome"); }
      }

      private Hl7.Fhir.Model.CodeableConcept _Outcome;

      /// <summary>
      /// Likelihood of specified outcome
      /// </summary>
      [FhirElement("probability", Order=50, Choice=ChoiceType.DatatypeChoice)]
      [CLSCompliant(false)]
      [AllowedTypes(typeof(Hl7.Fhir.Model.FhirDecimal),typeof(Hl7.Fhir.Model.Range))]
      [DataMember]
      public Hl7.Fhir.Model.DataType Probability
      {
        get { return _Probability; }
        set { _Probability = value; OnPropertyChanged("Probability"); }
      }

      private Hl7.Fhir.Model.DataType _Probability;

      /// <summary>
      /// Likelihood of specified outcome as a qualitative value
      /// </summary>
      [FhirElement("qualitativeRisk", Order=60)]
      [Binding("RiskAssessmentProbability")]
      [DataMember]
      public Hl7.Fhir.Model.CodeableConcept QualitativeRisk
      {
        get { return _QualitativeRisk; }
        set { _QualitativeRisk = value; OnPropertyChanged("QualitativeRisk"); }
      }

      private Hl7.Fhir.Model.CodeableConcept _QualitativeRisk;

      /// <summary>
      /// Relative likelihood
      /// </summary>
      [FhirElement("relativeRisk", Order=70)]
      [DataMember]
      public Hl7.Fhir.Model.FhirDecimal RelativeRiskElement
      {
        get { return _RelativeRiskElement; }
        set { _RelativeRiskElement = value; OnPropertyChanged("RelativeRiskElement"); }
      }

      private Hl7.Fhir.Model.FhirDecimal _RelativeRiskElement;

      /// <summary>
      /// Relative likelihood
      /// </summary>
      /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
      [IgnoreDataMember]
      public decimal? RelativeRisk
      {
        get { return RelativeRiskElement != null ? RelativeRiskElement.Value : null; }
        set
        {
          if (value == null)
            RelativeRiskElement = null;
          else
            RelativeRiskElement = new Hl7.Fhir.Model.FhirDecimal(value);
          OnPropertyChanged("RelativeRisk");
        }
      }

      /// <summary>
      /// Timeframe or age range
      /// </summary>
      [FhirElement("when", Order=80, Choice=ChoiceType.DatatypeChoice)]
      [CLSCompliant(false)]
      [AllowedTypes(typeof(Hl7.Fhir.Model.Period),typeof(Hl7.Fhir.Model.Range))]
      [DataMember]
      public Hl7.Fhir.Model.DataType When
      {
        get { return _When; }
        set { _When = value; OnPropertyChanged("When"); }
      }

      private Hl7.Fhir.Model.DataType _When;

      /// <summary>
      /// Explanation of prediction
      /// </summary>
      [FhirElement("rationale", Order=90)]
      [DataMember]
      public Hl7.Fhir.Model.FhirString RationaleElement
      {
        get { return _RationaleElement; }
        set { _RationaleElement = value; OnPropertyChanged("RationaleElement"); }
      }

      private Hl7.Fhir.Model.FhirString _RationaleElement;

      /// <summary>
      /// Explanation of prediction
      /// </summary>
      /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
      [IgnoreDataMember]
      public string Rationale
      {
        get { return RationaleElement != null ? RationaleElement.Value : null; }
        set
        {
          if (value == null)
            RationaleElement = null;
          else
            RationaleElement = new Hl7.Fhir.Model.FhirString(value);
          OnPropertyChanged("Rationale");
        }
      }

      public override IDeepCopyable CopyTo(IDeepCopyable other)
      {
        var dest = other as PredictionComponent;

        if (dest == null)
        {
          throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        base.CopyTo(dest);
        if(Outcome != null) dest.Outcome = (Hl7.Fhir.Model.CodeableConcept)Outcome.DeepCopy();
        if(Probability != null) dest.Probability = (Hl7.Fhir.Model.DataType)Probability.DeepCopy();
        if(QualitativeRisk != null) dest.QualitativeRisk = (Hl7.Fhir.Model.CodeableConcept)QualitativeRisk.DeepCopy();
        if(RelativeRiskElement != null) dest.RelativeRiskElement = (Hl7.Fhir.Model.FhirDecimal)RelativeRiskElement.DeepCopy();
        if(When != null) dest.When = (Hl7.Fhir.Model.DataType)When.DeepCopy();
        if(RationaleElement != null) dest.RationaleElement = (Hl7.Fhir.Model.FhirString)RationaleElement.DeepCopy();
        return dest;
      }

      public override IDeepCopyable DeepCopy()
      {
        return CopyTo(new PredictionComponent());
      }

      ///<inheritdoc />
      public override bool Matches(IDeepComparable other)
      {
        var otherT = other as PredictionComponent;
        if(otherT == null) return false;

        if(!base.Matches(otherT)) return false;
        if( !DeepComparable.Matches(Outcome, otherT.Outcome)) return false;
        if( !DeepComparable.Matches(Probability, otherT.Probability)) return false;
        if( !DeepComparable.Matches(QualitativeRisk, otherT.QualitativeRisk)) return false;
        if( !DeepComparable.Matches(RelativeRiskElement, otherT.RelativeRiskElement)) return false;
        if( !DeepComparable.Matches(When, otherT.When)) return false;
        if( !DeepComparable.Matches(RationaleElement, otherT.RationaleElement)) return false;

        return true;
      }

      public override bool IsExactly(IDeepComparable other)
      {
        var otherT = other as PredictionComponent;
        if(otherT == null) return false;

        if(!base.IsExactly(otherT)) return false;
        if( !DeepComparable.IsExactly(Outcome, otherT.Outcome)) return false;
        if( !DeepComparable.IsExactly(Probability, otherT.Probability)) return false;
        if( !DeepComparable.IsExactly(QualitativeRisk, otherT.QualitativeRisk)) return false;
        if( !DeepComparable.IsExactly(RelativeRiskElement, otherT.RelativeRiskElement)) return false;
        if( !DeepComparable.IsExactly(When, otherT.When)) return false;
        if( !DeepComparable.IsExactly(RationaleElement, otherT.RationaleElement)) return false;

        return true;
      }

      [IgnoreDataMember]
      public override IEnumerable<Base> Children
      {
        get
        {
          foreach (var item in base.Children) yield return item;
          if (Outcome != null) yield return Outcome;
          if (Probability != null) yield return Probability;
          if (QualitativeRisk != null) yield return QualitativeRisk;
          if (RelativeRiskElement != null) yield return RelativeRiskElement;
          if (When != null) yield return When;
          if (RationaleElement != null) yield return RationaleElement;
        }
      }

      [IgnoreDataMember]
      public override IEnumerable<ElementValue> NamedChildren
      {
        get
        {
          foreach (var item in base.NamedChildren) yield return item;
          if (Outcome != null) yield return new ElementValue("outcome", Outcome);
          if (Probability != null) yield return new ElementValue("probability", Probability);
          if (QualitativeRisk != null) yield return new ElementValue("qualitativeRisk", QualitativeRisk);
          if (RelativeRiskElement != null) yield return new ElementValue("relativeRisk", RelativeRiskElement);
          if (When != null) yield return new ElementValue("when", When);
          if (RationaleElement != null) yield return new ElementValue("rationale", RationaleElement);
        }
      }

      protected override bool TryGetValue(string key, out object value)
      {
        switch (key)
        {
          case "outcome":
            value = Outcome;
            return Outcome is not null;
          case "probability":
            value = Probability;
            return Probability is not null;
          case "qualitativeRisk":
            value = QualitativeRisk;
            return QualitativeRisk is not null;
          case "relativeRisk":
            value = RelativeRiskElement;
            return RelativeRiskElement is not null;
          case "when":
            value = When;
            return When is not null;
          case "rationale":
            value = RationaleElement;
            return RationaleElement is not null;
          default:
            return base.TryGetValue(key, out value);
        }

      }

      protected override IEnumerable<KeyValuePair<string, object>> GetElementPairs()
      {
        foreach (var kvp in base.GetElementPairs()) yield return kvp;
        if (Outcome is not null) yield return new KeyValuePair<string,object>("outcome",Outcome);
        if (Probability is not null) yield return new KeyValuePair<string,object>("probability",Probability);
        if (QualitativeRisk is not null) yield return new KeyValuePair<string,object>("qualitativeRisk",QualitativeRisk);
        if (RelativeRiskElement is not null) yield return new KeyValuePair<string,object>("relativeRisk",RelativeRiskElement);
        if (When is not null) yield return new KeyValuePair<string,object>("when",When);
        if (RationaleElement is not null) yield return new KeyValuePair<string,object>("rationale",RationaleElement);
      }

    }

    /// <summary>
    /// Unique identifier for the assessment
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
    /// Request fulfilled by this assessment
    /// </summary>
    [FhirElement("basedOn", Order=100)]
    [CLSCompliant(false)]
    [References("Resource")]
    [DataMember]
    public Hl7.Fhir.Model.ResourceReference BasedOn
    {
      get { return _BasedOn; }
      set { _BasedOn = value; OnPropertyChanged("BasedOn"); }
    }

    private Hl7.Fhir.Model.ResourceReference _BasedOn;

    /// <summary>
    /// Part of this occurrence
    /// </summary>
    [FhirElement("parent", Order=110)]
    [CLSCompliant(false)]
    [References("Resource")]
    [DataMember]
    public Hl7.Fhir.Model.ResourceReference Parent
    {
      get { return _Parent; }
      set { _Parent = value; OnPropertyChanged("Parent"); }
    }

    private Hl7.Fhir.Model.ResourceReference _Parent;

    /// <summary>
    /// registered | preliminary | final | amended +
    /// </summary>
    [FhirElement("status", InSummary=true, Order=120, FiveWs="FiveWs.status")]
    [DeclaredType(Type = typeof(Code))]
    [Binding("RiskAssessmentStatus")]
    [Cardinality(Min=1,Max=1)]
    [DataMember]
    public Code<Hl7.Fhir.Model.ObservationStatus> StatusElement
    {
      get { return _StatusElement; }
      set { _StatusElement = value; OnPropertyChanged("StatusElement"); }
    }

    private Code<Hl7.Fhir.Model.ObservationStatus> _StatusElement;

    /// <summary>
    /// registered | preliminary | final | amended +
    /// </summary>
    /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
    [IgnoreDataMember]
    public Hl7.Fhir.Model.ObservationStatus? Status
    {
      get { return StatusElement != null ? StatusElement.Value : null; }
      set
      {
        if (value == null)
          StatusElement = null;
        else
          StatusElement = new Code<Hl7.Fhir.Model.ObservationStatus>(value);
        OnPropertyChanged("Status");
      }
    }

    /// <summary>
    /// Evaluation mechanism
    /// </summary>
    [FhirElement("method", InSummary=true, Order=130, FiveWs="FiveWs.class")]
    [Binding("RiskAssessmentMethod")]
    [DataMember]
    public Hl7.Fhir.Model.CodeableConcept Method
    {
      get { return _Method; }
      set { _Method = value; OnPropertyChanged("Method"); }
    }

    private Hl7.Fhir.Model.CodeableConcept _Method;

    /// <summary>
    /// Type of assessment
    /// </summary>
    [FhirElement("code", InSummary=true, Order=140, FiveWs="FiveWs.what[x]")]
    [DataMember]
    public Hl7.Fhir.Model.CodeableConcept Code
    {
      get { return _Code; }
      set { _Code = value; OnPropertyChanged("Code"); }
    }

    private Hl7.Fhir.Model.CodeableConcept _Code;

    /// <summary>
    /// Who/what does assessment apply to?
    /// </summary>
    [FhirElement("subject", InSummary=true, Order=150, FiveWs="FiveWs.subject[x]")]
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
    /// Where was assessment performed?
    /// </summary>
    [FhirElement("encounter", InSummary=true, Order=160, FiveWs="FiveWs.context")]
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
    /// When was assessment made?
    /// </summary>
    [FhirElement("occurrence", InSummary=true, Order=170, Choice=ChoiceType.DatatypeChoice, FiveWs="FiveWs.done[x]")]
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
    /// Condition assessed
    /// </summary>
    [FhirElement("condition", InSummary=true, Order=180)]
    [CLSCompliant(false)]
    [References("Condition")]
    [DataMember]
    public Hl7.Fhir.Model.ResourceReference Condition
    {
      get { return _Condition; }
      set { _Condition = value; OnPropertyChanged("Condition"); }
    }

    private Hl7.Fhir.Model.ResourceReference _Condition;

    /// <summary>
    /// Who did assessment?
    /// </summary>
    [FhirElement("performer", InSummary=true, Order=190, FiveWs="FiveWs.actor")]
    [CLSCompliant(false)]
    [References("Patient","Practitioner","PractitionerRole","RelatedPerson","Device")]
    [DataMember]
    public Hl7.Fhir.Model.ResourceReference Performer
    {
      get { return _Performer; }
      set { _Performer = value; OnPropertyChanged("Performer"); }
    }

    private Hl7.Fhir.Model.ResourceReference _Performer;

    /// <summary>
    /// Why the assessment was necessary?
    /// </summary>
    [FhirElement("reason", Order=200, FiveWs="FiveWs.why[x]")]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.CodeableReference> Reason
    {
      get { if(_Reason==null) _Reason = new List<Hl7.Fhir.Model.CodeableReference>(); return _Reason; }
      set { _Reason = value; OnPropertyChanged("Reason"); }
    }

    private List<Hl7.Fhir.Model.CodeableReference> _Reason;

    /// <summary>
    /// Information used in assessment
    /// </summary>
    [FhirElement("basis", Order=210)]
    [CLSCompliant(false)]
    [References("Resource")]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.ResourceReference> Basis
    {
      get { if(_Basis==null) _Basis = new List<Hl7.Fhir.Model.ResourceReference>(); return _Basis; }
      set { _Basis = value; OnPropertyChanged("Basis"); }
    }

    private List<Hl7.Fhir.Model.ResourceReference> _Basis;

    /// <summary>
    /// Outcome predicted
    /// </summary>
    [FhirElement("prediction", Order=220)]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.RiskAssessment.PredictionComponent> Prediction
    {
      get { if(_Prediction==null) _Prediction = new List<Hl7.Fhir.Model.RiskAssessment.PredictionComponent>(); return _Prediction; }
      set { _Prediction = value; OnPropertyChanged("Prediction"); }
    }

    private List<Hl7.Fhir.Model.RiskAssessment.PredictionComponent> _Prediction;

    /// <summary>
    /// How to reduce risk
    /// </summary>
    [FhirElement("mitigation", Order=230)]
    [DataMember]
    public Hl7.Fhir.Model.FhirString MitigationElement
    {
      get { return _MitigationElement; }
      set { _MitigationElement = value; OnPropertyChanged("MitigationElement"); }
    }

    private Hl7.Fhir.Model.FhirString _MitigationElement;

    /// <summary>
    /// How to reduce risk
    /// </summary>
    /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
    [IgnoreDataMember]
    public string Mitigation
    {
      get { return MitigationElement != null ? MitigationElement.Value : null; }
      set
      {
        if (value == null)
          MitigationElement = null;
        else
          MitigationElement = new Hl7.Fhir.Model.FhirString(value);
        OnPropertyChanged("Mitigation");
      }
    }

    /// <summary>
    /// Comments on the risk assessment
    /// </summary>
    [FhirElement("note", Order=240)]
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
      var dest = other as RiskAssessment;

      if (dest == null)
      {
        throw new ArgumentException("Can only copy to an object of the same type", "other");
      }

      base.CopyTo(dest);
      if(Identifier != null) dest.Identifier = new List<Hl7.Fhir.Model.Identifier>(Identifier.DeepCopy());
      if(BasedOn != null) dest.BasedOn = (Hl7.Fhir.Model.ResourceReference)BasedOn.DeepCopy();
      if(Parent != null) dest.Parent = (Hl7.Fhir.Model.ResourceReference)Parent.DeepCopy();
      if(StatusElement != null) dest.StatusElement = (Code<Hl7.Fhir.Model.ObservationStatus>)StatusElement.DeepCopy();
      if(Method != null) dest.Method = (Hl7.Fhir.Model.CodeableConcept)Method.DeepCopy();
      if(Code != null) dest.Code = (Hl7.Fhir.Model.CodeableConcept)Code.DeepCopy();
      if(Subject != null) dest.Subject = (Hl7.Fhir.Model.ResourceReference)Subject.DeepCopy();
      if(Encounter != null) dest.Encounter = (Hl7.Fhir.Model.ResourceReference)Encounter.DeepCopy();
      if(Occurrence != null) dest.Occurrence = (Hl7.Fhir.Model.DataType)Occurrence.DeepCopy();
      if(Condition != null) dest.Condition = (Hl7.Fhir.Model.ResourceReference)Condition.DeepCopy();
      if(Performer != null) dest.Performer = (Hl7.Fhir.Model.ResourceReference)Performer.DeepCopy();
      if(Reason != null) dest.Reason = new List<Hl7.Fhir.Model.CodeableReference>(Reason.DeepCopy());
      if(Basis != null) dest.Basis = new List<Hl7.Fhir.Model.ResourceReference>(Basis.DeepCopy());
      if(Prediction != null) dest.Prediction = new List<Hl7.Fhir.Model.RiskAssessment.PredictionComponent>(Prediction.DeepCopy());
      if(MitigationElement != null) dest.MitigationElement = (Hl7.Fhir.Model.FhirString)MitigationElement.DeepCopy();
      if(Note != null) dest.Note = new List<Hl7.Fhir.Model.Annotation>(Note.DeepCopy());
      return dest;
    }

    public override IDeepCopyable DeepCopy()
    {
      return CopyTo(new RiskAssessment());
    }

    ///<inheritdoc />
    public override bool Matches(IDeepComparable other)
    {
      var otherT = other as RiskAssessment;
      if(otherT == null) return false;

      if(!base.Matches(otherT)) return false;
      if( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
      if( !DeepComparable.Matches(BasedOn, otherT.BasedOn)) return false;
      if( !DeepComparable.Matches(Parent, otherT.Parent)) return false;
      if( !DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
      if( !DeepComparable.Matches(Method, otherT.Method)) return false;
      if( !DeepComparable.Matches(Code, otherT.Code)) return false;
      if( !DeepComparable.Matches(Subject, otherT.Subject)) return false;
      if( !DeepComparable.Matches(Encounter, otherT.Encounter)) return false;
      if( !DeepComparable.Matches(Occurrence, otherT.Occurrence)) return false;
      if( !DeepComparable.Matches(Condition, otherT.Condition)) return false;
      if( !DeepComparable.Matches(Performer, otherT.Performer)) return false;
      if( !DeepComparable.Matches(Reason, otherT.Reason)) return false;
      if( !DeepComparable.Matches(Basis, otherT.Basis)) return false;
      if( !DeepComparable.Matches(Prediction, otherT.Prediction)) return false;
      if( !DeepComparable.Matches(MitigationElement, otherT.MitigationElement)) return false;
      if( !DeepComparable.Matches(Note, otherT.Note)) return false;

      return true;
    }

    public override bool IsExactly(IDeepComparable other)
    {
      var otherT = other as RiskAssessment;
      if(otherT == null) return false;

      if(!base.IsExactly(otherT)) return false;
      if( !DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
      if( !DeepComparable.IsExactly(BasedOn, otherT.BasedOn)) return false;
      if( !DeepComparable.IsExactly(Parent, otherT.Parent)) return false;
      if( !DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
      if( !DeepComparable.IsExactly(Method, otherT.Method)) return false;
      if( !DeepComparable.IsExactly(Code, otherT.Code)) return false;
      if( !DeepComparable.IsExactly(Subject, otherT.Subject)) return false;
      if( !DeepComparable.IsExactly(Encounter, otherT.Encounter)) return false;
      if( !DeepComparable.IsExactly(Occurrence, otherT.Occurrence)) return false;
      if( !DeepComparable.IsExactly(Condition, otherT.Condition)) return false;
      if( !DeepComparable.IsExactly(Performer, otherT.Performer)) return false;
      if( !DeepComparable.IsExactly(Reason, otherT.Reason)) return false;
      if( !DeepComparable.IsExactly(Basis, otherT.Basis)) return false;
      if( !DeepComparable.IsExactly(Prediction, otherT.Prediction)) return false;
      if( !DeepComparable.IsExactly(MitigationElement, otherT.MitigationElement)) return false;
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
        if (BasedOn != null) yield return BasedOn;
        if (Parent != null) yield return Parent;
        if (StatusElement != null) yield return StatusElement;
        if (Method != null) yield return Method;
        if (Code != null) yield return Code;
        if (Subject != null) yield return Subject;
        if (Encounter != null) yield return Encounter;
        if (Occurrence != null) yield return Occurrence;
        if (Condition != null) yield return Condition;
        if (Performer != null) yield return Performer;
        foreach (var elem in Reason) { if (elem != null) yield return elem; }
        foreach (var elem in Basis) { if (elem != null) yield return elem; }
        foreach (var elem in Prediction) { if (elem != null) yield return elem; }
        if (MitigationElement != null) yield return MitigationElement;
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
        if (BasedOn != null) yield return new ElementValue("basedOn", BasedOn);
        if (Parent != null) yield return new ElementValue("parent", Parent);
        if (StatusElement != null) yield return new ElementValue("status", StatusElement);
        if (Method != null) yield return new ElementValue("method", Method);
        if (Code != null) yield return new ElementValue("code", Code);
        if (Subject != null) yield return new ElementValue("subject", Subject);
        if (Encounter != null) yield return new ElementValue("encounter", Encounter);
        if (Occurrence != null) yield return new ElementValue("occurrence", Occurrence);
        if (Condition != null) yield return new ElementValue("condition", Condition);
        if (Performer != null) yield return new ElementValue("performer", Performer);
        foreach (var elem in Reason) { if (elem != null) yield return new ElementValue("reason", elem); }
        foreach (var elem in Basis) { if (elem != null) yield return new ElementValue("basis", elem); }
        foreach (var elem in Prediction) { if (elem != null) yield return new ElementValue("prediction", elem); }
        if (MitigationElement != null) yield return new ElementValue("mitigation", MitigationElement);
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
          return BasedOn is not null;
        case "parent":
          value = Parent;
          return Parent is not null;
        case "status":
          value = StatusElement;
          return StatusElement is not null;
        case "method":
          value = Method;
          return Method is not null;
        case "code":
          value = Code;
          return Code is not null;
        case "subject":
          value = Subject;
          return Subject is not null;
        case "encounter":
          value = Encounter;
          return Encounter is not null;
        case "occurrence":
          value = Occurrence;
          return Occurrence is not null;
        case "condition":
          value = Condition;
          return Condition is not null;
        case "performer":
          value = Performer;
          return Performer is not null;
        case "reason":
          value = Reason;
          return Reason?.Any() == true;
        case "basis":
          value = Basis;
          return Basis?.Any() == true;
        case "prediction":
          value = Prediction;
          return Prediction?.Any() == true;
        case "mitigation":
          value = MitigationElement;
          return MitigationElement is not null;
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
      if (BasedOn is not null) yield return new KeyValuePair<string,object>("basedOn",BasedOn);
      if (Parent is not null) yield return new KeyValuePair<string,object>("parent",Parent);
      if (StatusElement is not null) yield return new KeyValuePair<string,object>("status",StatusElement);
      if (Method is not null) yield return new KeyValuePair<string,object>("method",Method);
      if (Code is not null) yield return new KeyValuePair<string,object>("code",Code);
      if (Subject is not null) yield return new KeyValuePair<string,object>("subject",Subject);
      if (Encounter is not null) yield return new KeyValuePair<string,object>("encounter",Encounter);
      if (Occurrence is not null) yield return new KeyValuePair<string,object>("occurrence",Occurrence);
      if (Condition is not null) yield return new KeyValuePair<string,object>("condition",Condition);
      if (Performer is not null) yield return new KeyValuePair<string,object>("performer",Performer);
      if (Reason?.Any() == true) yield return new KeyValuePair<string,object>("reason",Reason);
      if (Basis?.Any() == true) yield return new KeyValuePair<string,object>("basis",Basis);
      if (Prediction?.Any() == true) yield return new KeyValuePair<string,object>("prediction",Prediction);
      if (MitigationElement is not null) yield return new KeyValuePair<string,object>("mitigation",MitigationElement);
      if (Note?.Any() == true) yield return new KeyValuePair<string,object>("note",Note);
    }

  }

}

// end of file

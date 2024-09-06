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
  /// How the medication is/was taken or should be taken
  /// </summary>
  /// <remarks>
  /// Indicates how the medication is/was taken or should be taken by the patient.
  /// </remarks>
  [Serializable]
  [DataContract]
  [FhirType("Dosage","http://hl7.org/fhir/StructureDefinition/Dosage")]
  public partial class Dosage : Hl7.Fhir.Model.BackboneType
  {
    /// <summary>
    /// FHIR Type Name
    /// </summary>
    public override string TypeName { get { return "Dosage"; } }

    /// <summary>
    /// Amount of medication administered, to be administered or typical amount to be administered
    /// </summary>
    /// <remarks>
    /// Depending on the resource,this is the amount of medication administered, to  be administered or typical amount to be administered.
    /// </remarks>
    [Serializable]
    [DataContract]
    [FhirType("Dosage#DoseAndRate", IsNestedType=true)]
    [BackboneType("Dosage.doseAndRate")]
    public partial class DoseAndRateComponent : Hl7.Fhir.Model.Element
    {
      /// <summary>
      /// FHIR Type Name
      /// </summary>
      public override string TypeName { get { return "Dosage#DoseAndRate"; } }

      /// <summary>
      /// The kind of dose or rate specified
      /// </summary>
      [FhirElement("type", Order=30)]
      [Binding("DoseAndRateType")]
      [DataMember]
      public Hl7.Fhir.Model.CodeableConcept Type
      {
        get { return _Type; }
        set { _Type = value; OnPropertyChanged("Type"); }
      }

      private Hl7.Fhir.Model.CodeableConcept _Type;

      /// <summary>
      /// Amount of medication per dose
      /// </summary>
      [FhirElement("dose", Order=40, Choice=ChoiceType.DatatypeChoice)]
      [CLSCompliant(false)]
      [AllowedTypes(typeof(Hl7.Fhir.Model.Range),typeof(Hl7.Fhir.Model.Quantity))]
      [DataMember]
      public Hl7.Fhir.Model.DataType Dose
      {
        get { return _Dose; }
        set { _Dose = value; OnPropertyChanged("Dose"); }
      }

      private Hl7.Fhir.Model.DataType _Dose;

      /// <summary>
      /// Amount of medication per unit of time
      /// </summary>
      [FhirElement("rate", Order=50, Choice=ChoiceType.DatatypeChoice)]
      [CLSCompliant(false)]
      [AllowedTypes(typeof(Hl7.Fhir.Model.Ratio),typeof(Hl7.Fhir.Model.Range),typeof(Hl7.Fhir.Model.Quantity))]
      [DataMember]
      public Hl7.Fhir.Model.DataType Rate
      {
        get { return _Rate; }
        set { _Rate = value; OnPropertyChanged("Rate"); }
      }

      private Hl7.Fhir.Model.DataType _Rate;

      public override IDeepCopyable CopyTo(IDeepCopyable other)
      {
        var dest = other as DoseAndRateComponent;

        if (dest == null)
        {
          throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        base.CopyTo(dest);
        if(Type != null) dest.Type = (Hl7.Fhir.Model.CodeableConcept)Type.DeepCopy();
        if(Dose != null) dest.Dose = (Hl7.Fhir.Model.DataType)Dose.DeepCopy();
        if(Rate != null) dest.Rate = (Hl7.Fhir.Model.DataType)Rate.DeepCopy();
        return dest;
      }

      public override IDeepCopyable DeepCopy()
      {
        return CopyTo(new DoseAndRateComponent());
      }

      ///<inheritdoc />
      public override bool Matches(IDeepComparable other)
      {
        var otherT = other as DoseAndRateComponent;
        if(otherT == null) return false;

        if(!base.Matches(otherT)) return false;
        if( !DeepComparable.Matches(Type, otherT.Type)) return false;
        if( !DeepComparable.Matches(Dose, otherT.Dose)) return false;
        if( !DeepComparable.Matches(Rate, otherT.Rate)) return false;

        return true;
      }

      public override bool IsExactly(IDeepComparable other)
      {
        var otherT = other as DoseAndRateComponent;
        if(otherT == null) return false;

        if(!base.IsExactly(otherT)) return false;
        if( !DeepComparable.IsExactly(Type, otherT.Type)) return false;
        if( !DeepComparable.IsExactly(Dose, otherT.Dose)) return false;
        if( !DeepComparable.IsExactly(Rate, otherT.Rate)) return false;

        return true;
      }

      [IgnoreDataMember]
      public override IEnumerable<Base> Children
      {
        get
        {
          foreach (var item in base.Children) yield return item;
          if (Type != null) yield return Type;
          if (Dose != null) yield return Dose;
          if (Rate != null) yield return Rate;
        }
      }

      [IgnoreDataMember]
      public override IEnumerable<ElementValue> NamedChildren
      {
        get
        {
          foreach (var item in base.NamedChildren) yield return item;
          if (Type != null) yield return new ElementValue("type", Type);
          if (Dose != null) yield return new ElementValue("dose", Dose);
          if (Rate != null) yield return new ElementValue("rate", Rate);
        }
      }

      protected override bool TryGetValue(string key, out object value)
      {
        switch (key)
        {
          case "type":
            value = Type;
            return Type is not null;
          case "dose":
            value = Dose;
            return Dose is not null;
          case "rate":
            value = Rate;
            return Rate is not null;
          default:
            return base.TryGetValue(key, out value);
        }

      }

      protected override IEnumerable<KeyValuePair<string, object>> GetElementPairs()
      {
        foreach (var kvp in base.GetElementPairs()) yield return kvp;
        if (Type is not null) yield return new KeyValuePair<string,object>("type",Type);
        if (Dose is not null) yield return new KeyValuePair<string,object>("dose",Dose);
        if (Rate is not null) yield return new KeyValuePair<string,object>("rate",Rate);
      }

    }

    /// <summary>
    /// The order of the dosage instructions
    /// </summary>
    [FhirElement("sequence", Order=40)]
    [DataMember]
    public Hl7.Fhir.Model.Integer SequenceElement
    {
      get { return _SequenceElement; }
      set { _SequenceElement = value; OnPropertyChanged("SequenceElement"); }
    }

    private Hl7.Fhir.Model.Integer _SequenceElement;

    /// <summary>
    /// The order of the dosage instructions
    /// </summary>
    /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
    [IgnoreDataMember]
    public int? Sequence
    {
      get { return SequenceElement != null ? SequenceElement.Value : null; }
      set
      {
        if (value == null)
          SequenceElement = null;
        else
          SequenceElement = new Hl7.Fhir.Model.Integer(value);
        OnPropertyChanged("Sequence");
      }
    }

    /// <summary>
    /// Free text dosage instructions e.g. SIG
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
    /// Free text dosage instructions e.g. SIG
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

    /// <summary>
    /// Supplemental instruction or warnings to the patient - e.g. "with meals", "may cause drowsiness"
    /// </summary>
    [FhirElement("additionalInstruction", Order=60)]
    [Binding("AdditionalInstruction")]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.CodeableConcept> AdditionalInstruction
    {
      get { if(_AdditionalInstruction==null) _AdditionalInstruction = new List<Hl7.Fhir.Model.CodeableConcept>(); return _AdditionalInstruction; }
      set { _AdditionalInstruction = value; OnPropertyChanged("AdditionalInstruction"); }
    }

    private List<Hl7.Fhir.Model.CodeableConcept> _AdditionalInstruction;

    /// <summary>
    /// Patient or consumer oriented instructions
    /// </summary>
    [FhirElement("patientInstruction", Order=70)]
    [DataMember]
    public Hl7.Fhir.Model.FhirString PatientInstructionElement
    {
      get { return _PatientInstructionElement; }
      set { _PatientInstructionElement = value; OnPropertyChanged("PatientInstructionElement"); }
    }

    private Hl7.Fhir.Model.FhirString _PatientInstructionElement;

    /// <summary>
    /// Patient or consumer oriented instructions
    /// </summary>
    /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
    [IgnoreDataMember]
    public string PatientInstruction
    {
      get { return PatientInstructionElement != null ? PatientInstructionElement.Value : null; }
      set
      {
        if (value == null)
          PatientInstructionElement = null;
        else
          PatientInstructionElement = new Hl7.Fhir.Model.FhirString(value);
        OnPropertyChanged("PatientInstruction");
      }
    }

    /// <summary>
    /// When medication should be administered
    /// </summary>
    [FhirElement("timing", Order=80)]
    [DataMember]
    public Hl7.Fhir.Model.Timing Timing
    {
      get { return _Timing; }
      set { _Timing = value; OnPropertyChanged("Timing"); }
    }

    private Hl7.Fhir.Model.Timing _Timing;

    /// <summary>
    /// Take "as needed"
    /// </summary>
    [FhirElement("asNeeded", Order=90)]
    [DataMember]
    public Hl7.Fhir.Model.FhirBoolean AsNeededElement
    {
      get { return _AsNeededElement; }
      set { _AsNeededElement = value; OnPropertyChanged("AsNeededElement"); }
    }

    private Hl7.Fhir.Model.FhirBoolean _AsNeededElement;

    /// <summary>
    /// Take "as needed"
    /// </summary>
    /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
    [IgnoreDataMember]
    public bool? AsNeeded
    {
      get { return AsNeededElement != null ? AsNeededElement.Value : null; }
      set
      {
        if (value == null)
          AsNeededElement = null;
        else
          AsNeededElement = new Hl7.Fhir.Model.FhirBoolean(value);
        OnPropertyChanged("AsNeeded");
      }
    }

    /// <summary>
    /// Take "as needed" (for x)
    /// </summary>
    [FhirElement("asNeededFor", Order=100)]
    [Binding("MedicationAsNeededReason")]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.CodeableConcept> AsNeededFor
    {
      get { if(_AsNeededFor==null) _AsNeededFor = new List<Hl7.Fhir.Model.CodeableConcept>(); return _AsNeededFor; }
      set { _AsNeededFor = value; OnPropertyChanged("AsNeededFor"); }
    }

    private List<Hl7.Fhir.Model.CodeableConcept> _AsNeededFor;

    /// <summary>
    /// Body site to administer to
    /// </summary>
    [FhirElement("site", Order=110)]
    [Binding("MedicationAdministrationSite")]
    [DataMember]
    public Hl7.Fhir.Model.CodeableConcept Site
    {
      get { return _Site; }
      set { _Site = value; OnPropertyChanged("Site"); }
    }

    private Hl7.Fhir.Model.CodeableConcept _Site;

    /// <summary>
    /// How drug should enter body
    /// </summary>
    [FhirElement("route", Order=120)]
    [Binding("RouteOfAdministration")]
    [DataMember]
    public Hl7.Fhir.Model.CodeableConcept Route
    {
      get { return _Route; }
      set { _Route = value; OnPropertyChanged("Route"); }
    }

    private Hl7.Fhir.Model.CodeableConcept _Route;

    /// <summary>
    /// Technique for administering medication
    /// </summary>
    [FhirElement("method", Order=130)]
    [Binding("MedicationAdministrationMethod")]
    [DataMember]
    public Hl7.Fhir.Model.CodeableConcept Method
    {
      get { return _Method; }
      set { _Method = value; OnPropertyChanged("Method"); }
    }

    private Hl7.Fhir.Model.CodeableConcept _Method;

    /// <summary>
    /// Amount of medication administered, to be administered or typical amount to be administered
    /// </summary>
    [FhirElement("doseAndRate", Order=140)]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.Dosage.DoseAndRateComponent> DoseAndRate
    {
      get { if(_DoseAndRate==null) _DoseAndRate = new List<Hl7.Fhir.Model.Dosage.DoseAndRateComponent>(); return _DoseAndRate; }
      set { _DoseAndRate = value; OnPropertyChanged("DoseAndRate"); }
    }

    private List<Hl7.Fhir.Model.Dosage.DoseAndRateComponent> _DoseAndRate;

    /// <summary>
    /// Upper limit on medication per unit of time
    /// </summary>
    [FhirElement("maxDosePerPeriod", Order=150)]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.Ratio> MaxDosePerPeriod
    {
      get { if(_MaxDosePerPeriod==null) _MaxDosePerPeriod = new List<Hl7.Fhir.Model.Ratio>(); return _MaxDosePerPeriod; }
      set { _MaxDosePerPeriod = value; OnPropertyChanged("MaxDosePerPeriod"); }
    }

    private List<Hl7.Fhir.Model.Ratio> _MaxDosePerPeriod;

    /// <summary>
    /// Upper limit on medication per administration
    /// </summary>
    [FhirElement("maxDosePerAdministration", Order=160)]
    [DataMember]
    public Hl7.Fhir.Model.Quantity MaxDosePerAdministration
    {
      get { return _MaxDosePerAdministration; }
      set { _MaxDosePerAdministration = value; OnPropertyChanged("MaxDosePerAdministration"); }
    }

    private Hl7.Fhir.Model.Quantity _MaxDosePerAdministration;

    /// <summary>
    /// Upper limit on medication per lifetime of the patient
    /// </summary>
    [FhirElement("maxDosePerLifetime", Order=170)]
    [DataMember]
    public Hl7.Fhir.Model.Quantity MaxDosePerLifetime
    {
      get { return _MaxDosePerLifetime; }
      set { _MaxDosePerLifetime = value; OnPropertyChanged("MaxDosePerLifetime"); }
    }

    private Hl7.Fhir.Model.Quantity _MaxDosePerLifetime;

    public override IDeepCopyable CopyTo(IDeepCopyable other)
    {
      var dest = other as Dosage;

      if (dest == null)
      {
        throw new ArgumentException("Can only copy to an object of the same type", "other");
      }

      base.CopyTo(dest);
      if(SequenceElement != null) dest.SequenceElement = (Hl7.Fhir.Model.Integer)SequenceElement.DeepCopy();
      if(TextElement != null) dest.TextElement = (Hl7.Fhir.Model.FhirString)TextElement.DeepCopy();
      if(AdditionalInstruction.Any()) dest.AdditionalInstruction = new List<Hl7.Fhir.Model.CodeableConcept>(AdditionalInstruction.DeepCopy());
      if(PatientInstructionElement != null) dest.PatientInstructionElement = (Hl7.Fhir.Model.FhirString)PatientInstructionElement.DeepCopy();
      if(Timing != null) dest.Timing = (Hl7.Fhir.Model.Timing)Timing.DeepCopy();
      if(AsNeededElement != null) dest.AsNeededElement = (Hl7.Fhir.Model.FhirBoolean)AsNeededElement.DeepCopy();
      if(AsNeededFor.Any()) dest.AsNeededFor = new List<Hl7.Fhir.Model.CodeableConcept>(AsNeededFor.DeepCopy());
      if(Site != null) dest.Site = (Hl7.Fhir.Model.CodeableConcept)Site.DeepCopy();
      if(Route != null) dest.Route = (Hl7.Fhir.Model.CodeableConcept)Route.DeepCopy();
      if(Method != null) dest.Method = (Hl7.Fhir.Model.CodeableConcept)Method.DeepCopy();
      if(DoseAndRate.Any()) dest.DoseAndRate = new List<Hl7.Fhir.Model.Dosage.DoseAndRateComponent>(DoseAndRate.DeepCopy());
      if(MaxDosePerPeriod.Any()) dest.MaxDosePerPeriod = new List<Hl7.Fhir.Model.Ratio>(MaxDosePerPeriod.DeepCopy());
      if(MaxDosePerAdministration != null) dest.MaxDosePerAdministration = (Hl7.Fhir.Model.Quantity)MaxDosePerAdministration.DeepCopy();
      if(MaxDosePerLifetime != null) dest.MaxDosePerLifetime = (Hl7.Fhir.Model.Quantity)MaxDosePerLifetime.DeepCopy();
      return dest;
    }

    public override IDeepCopyable DeepCopy()
    {
      return CopyTo(new Dosage());
    }

    ///<inheritdoc />
    public override bool Matches(IDeepComparable other)
    {
      var otherT = other as Dosage;
      if(otherT == null) return false;

      if(!base.Matches(otherT)) return false;
      if( !DeepComparable.Matches(SequenceElement, otherT.SequenceElement)) return false;
      if( !DeepComparable.Matches(TextElement, otherT.TextElement)) return false;
      if( !DeepComparable.Matches(AdditionalInstruction, otherT.AdditionalInstruction)) return false;
      if( !DeepComparable.Matches(PatientInstructionElement, otherT.PatientInstructionElement)) return false;
      if( !DeepComparable.Matches(Timing, otherT.Timing)) return false;
      if( !DeepComparable.Matches(AsNeededElement, otherT.AsNeededElement)) return false;
      if( !DeepComparable.Matches(AsNeededFor, otherT.AsNeededFor)) return false;
      if( !DeepComparable.Matches(Site, otherT.Site)) return false;
      if( !DeepComparable.Matches(Route, otherT.Route)) return false;
      if( !DeepComparable.Matches(Method, otherT.Method)) return false;
      if( !DeepComparable.Matches(DoseAndRate, otherT.DoseAndRate)) return false;
      if( !DeepComparable.Matches(MaxDosePerPeriod, otherT.MaxDosePerPeriod)) return false;
      if( !DeepComparable.Matches(MaxDosePerAdministration, otherT.MaxDosePerAdministration)) return false;
      if( !DeepComparable.Matches(MaxDosePerLifetime, otherT.MaxDosePerLifetime)) return false;

      return true;
    }

    public override bool IsExactly(IDeepComparable other)
    {
      var otherT = other as Dosage;
      if(otherT == null) return false;

      if(!base.IsExactly(otherT)) return false;
      if( !DeepComparable.IsExactly(SequenceElement, otherT.SequenceElement)) return false;
      if( !DeepComparable.IsExactly(TextElement, otherT.TextElement)) return false;
      if( !DeepComparable.IsExactly(AdditionalInstruction, otherT.AdditionalInstruction)) return false;
      if( !DeepComparable.IsExactly(PatientInstructionElement, otherT.PatientInstructionElement)) return false;
      if( !DeepComparable.IsExactly(Timing, otherT.Timing)) return false;
      if( !DeepComparable.IsExactly(AsNeededElement, otherT.AsNeededElement)) return false;
      if( !DeepComparable.IsExactly(AsNeededFor, otherT.AsNeededFor)) return false;
      if( !DeepComparable.IsExactly(Site, otherT.Site)) return false;
      if( !DeepComparable.IsExactly(Route, otherT.Route)) return false;
      if( !DeepComparable.IsExactly(Method, otherT.Method)) return false;
      if( !DeepComparable.IsExactly(DoseAndRate, otherT.DoseAndRate)) return false;
      if( !DeepComparable.IsExactly(MaxDosePerPeriod, otherT.MaxDosePerPeriod)) return false;
      if( !DeepComparable.IsExactly(MaxDosePerAdministration, otherT.MaxDosePerAdministration)) return false;
      if( !DeepComparable.IsExactly(MaxDosePerLifetime, otherT.MaxDosePerLifetime)) return false;

      return true;
    }

    [IgnoreDataMember]
    public override IEnumerable<Base> Children
    {
      get
      {
        foreach (var item in base.Children) yield return item;
        if (SequenceElement != null) yield return SequenceElement;
        if (TextElement != null) yield return TextElement;
        foreach (var elem in AdditionalInstruction) { if (elem != null) yield return elem; }
        if (PatientInstructionElement != null) yield return PatientInstructionElement;
        if (Timing != null) yield return Timing;
        if (AsNeededElement != null) yield return AsNeededElement;
        foreach (var elem in AsNeededFor) { if (elem != null) yield return elem; }
        if (Site != null) yield return Site;
        if (Route != null) yield return Route;
        if (Method != null) yield return Method;
        foreach (var elem in DoseAndRate) { if (elem != null) yield return elem; }
        foreach (var elem in MaxDosePerPeriod) { if (elem != null) yield return elem; }
        if (MaxDosePerAdministration != null) yield return MaxDosePerAdministration;
        if (MaxDosePerLifetime != null) yield return MaxDosePerLifetime;
      }
    }

    [IgnoreDataMember]
    public override IEnumerable<ElementValue> NamedChildren
    {
      get
      {
        foreach (var item in base.NamedChildren) yield return item;
        if (SequenceElement != null) yield return new ElementValue("sequence", SequenceElement);
        if (TextElement != null) yield return new ElementValue("text", TextElement);
        foreach (var elem in AdditionalInstruction) { if (elem != null) yield return new ElementValue("additionalInstruction", elem); }
        if (PatientInstructionElement != null) yield return new ElementValue("patientInstruction", PatientInstructionElement);
        if (Timing != null) yield return new ElementValue("timing", Timing);
        if (AsNeededElement != null) yield return new ElementValue("asNeeded", AsNeededElement);
        foreach (var elem in AsNeededFor) { if (elem != null) yield return new ElementValue("asNeededFor", elem); }
        if (Site != null) yield return new ElementValue("site", Site);
        if (Route != null) yield return new ElementValue("route", Route);
        if (Method != null) yield return new ElementValue("method", Method);
        foreach (var elem in DoseAndRate) { if (elem != null) yield return new ElementValue("doseAndRate", elem); }
        foreach (var elem in MaxDosePerPeriod) { if (elem != null) yield return new ElementValue("maxDosePerPeriod", elem); }
        if (MaxDosePerAdministration != null) yield return new ElementValue("maxDosePerAdministration", MaxDosePerAdministration);
        if (MaxDosePerLifetime != null) yield return new ElementValue("maxDosePerLifetime", MaxDosePerLifetime);
      }
    }

    protected override bool TryGetValue(string key, out object value)
    {
      switch (key)
      {
        case "sequence":
          value = SequenceElement;
          return SequenceElement is not null;
        case "text":
          value = TextElement;
          return TextElement is not null;
        case "additionalInstruction":
          value = AdditionalInstruction;
          return AdditionalInstruction?.Any() == true;
        case "patientInstruction":
          value = PatientInstructionElement;
          return PatientInstructionElement is not null;
        case "timing":
          value = Timing;
          return Timing is not null;
        case "asNeeded":
          value = AsNeededElement;
          return AsNeededElement is not null;
        case "asNeededFor":
          value = AsNeededFor;
          return AsNeededFor?.Any() == true;
        case "site":
          value = Site;
          return Site is not null;
        case "route":
          value = Route;
          return Route is not null;
        case "method":
          value = Method;
          return Method is not null;
        case "doseAndRate":
          value = DoseAndRate;
          return DoseAndRate?.Any() == true;
        case "maxDosePerPeriod":
          value = MaxDosePerPeriod;
          return MaxDosePerPeriod?.Any() == true;
        case "maxDosePerAdministration":
          value = MaxDosePerAdministration;
          return MaxDosePerAdministration is not null;
        case "maxDosePerLifetime":
          value = MaxDosePerLifetime;
          return MaxDosePerLifetime is not null;
        default:
          return base.TryGetValue(key, out value);
      }

    }

    protected override IEnumerable<KeyValuePair<string, object>> GetElementPairs()
    {
      foreach (var kvp in base.GetElementPairs()) yield return kvp;
      if (SequenceElement is not null) yield return new KeyValuePair<string,object>("sequence",SequenceElement);
      if (TextElement is not null) yield return new KeyValuePair<string,object>("text",TextElement);
      if (AdditionalInstruction?.Any() == true) yield return new KeyValuePair<string,object>("additionalInstruction",AdditionalInstruction);
      if (PatientInstructionElement is not null) yield return new KeyValuePair<string,object>("patientInstruction",PatientInstructionElement);
      if (Timing is not null) yield return new KeyValuePair<string,object>("timing",Timing);
      if (AsNeededElement is not null) yield return new KeyValuePair<string,object>("asNeeded",AsNeededElement);
      if (AsNeededFor?.Any() == true) yield return new KeyValuePair<string,object>("asNeededFor",AsNeededFor);
      if (Site is not null) yield return new KeyValuePair<string,object>("site",Site);
      if (Route is not null) yield return new KeyValuePair<string,object>("route",Route);
      if (Method is not null) yield return new KeyValuePair<string,object>("method",Method);
      if (DoseAndRate?.Any() == true) yield return new KeyValuePair<string,object>("doseAndRate",DoseAndRate);
      if (MaxDosePerPeriod?.Any() == true) yield return new KeyValuePair<string,object>("maxDosePerPeriod",MaxDosePerPeriod);
      if (MaxDosePerAdministration is not null) yield return new KeyValuePair<string,object>("maxDosePerAdministration",MaxDosePerAdministration);
      if (MaxDosePerLifetime is not null) yield return new KeyValuePair<string,object>("maxDosePerLifetime",MaxDosePerLifetime);
    }

  }

}

// end of file

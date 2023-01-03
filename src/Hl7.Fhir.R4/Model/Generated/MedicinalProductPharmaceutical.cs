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
  /// A pharmaceutical product described in terms of its composition and dose form
  /// </summary>
  [Serializable]
  [DataContract]
  [FhirType("MedicinalProductPharmaceutical","http://hl7.org/fhir/StructureDefinition/MedicinalProductPharmaceutical", IsResource=true)]
  public partial class MedicinalProductPharmaceutical : Hl7.Fhir.Model.DomainResource
  {
    /// <summary>
    /// FHIR Type Name
    /// </summary>
    public override string TypeName { get { return "MedicinalProductPharmaceutical"; } }

    /// <summary>
    /// Characteristics e.g. a products onset of action
    /// </summary>
    [Serializable]
    [DataContract]
    [FhirType("MedicinalProductPharmaceutical#Characteristics", IsNestedType=true)]
    public partial class CharacteristicsComponent : Hl7.Fhir.Model.BackboneElement
    {
      /// <summary>
      /// FHIR Type Name
      /// </summary>
      public override string TypeName { get { return "MedicinalProductPharmaceutical#Characteristics"; } }

      /// <summary>
      /// A coded characteristic
      /// </summary>
      [FhirElement("code", InSummary=true, Order=40)]
      [Cardinality(Min=1,Max=1)]
      [DataMember]
      public Hl7.Fhir.Model.CodeableConcept Code
      {
        get { return _Code; }
        set { _Code = value; OnPropertyChanged("Code"); }
      }

      private Hl7.Fhir.Model.CodeableConcept _Code;

      /// <summary>
      /// The status of characteristic e.g. assigned or pending
      /// </summary>
      [FhirElement("status", InSummary=true, Order=50)]
      [DataMember]
      public Hl7.Fhir.Model.CodeableConcept Status
      {
        get { return _Status; }
        set { _Status = value; OnPropertyChanged("Status"); }
      }

      private Hl7.Fhir.Model.CodeableConcept _Status;

      public override IDeepCopyable CopyTo(IDeepCopyable other)
      {
        var dest = other as CharacteristicsComponent;

        if (dest == null)
        {
          throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        base.CopyTo(dest);
        if(Code != null) dest.Code = (Hl7.Fhir.Model.CodeableConcept)Code.DeepCopy();
        if(Status != null) dest.Status = (Hl7.Fhir.Model.CodeableConcept)Status.DeepCopy();
        return dest;
      }

      public override IDeepCopyable DeepCopy()
      {
        return CopyTo(new CharacteristicsComponent());
      }

      ///<inheritdoc />
      public override bool Matches(IDeepComparable other)
      {
        var otherT = other as CharacteristicsComponent;
        if(otherT == null) return false;

        if(!base.Matches(otherT)) return false;
        if( !DeepComparable.Matches(Code, otherT.Code)) return false;
        if( !DeepComparable.Matches(Status, otherT.Status)) return false;

        return true;
      }

      public override bool IsExactly(IDeepComparable other)
      {
        var otherT = other as CharacteristicsComponent;
        if(otherT == null) return false;

        if(!base.IsExactly(otherT)) return false;
        if( !DeepComparable.IsExactly(Code, otherT.Code)) return false;
        if( !DeepComparable.IsExactly(Status, otherT.Status)) return false;

        return true;
      }

      [IgnoreDataMember]
      public override IEnumerable<Base> Children
      {
        get
        {
          foreach (var item in base.Children) yield return item;
          if (Code != null) yield return Code;
          if (Status != null) yield return Status;
        }
      }

      [IgnoreDataMember]
      public override IEnumerable<ElementValue> NamedChildren
      {
        get
        {
          foreach (var item in base.NamedChildren) yield return item;
          if (Code != null) yield return new ElementValue("code", Code);
          if (Status != null) yield return new ElementValue("status", Status);
        }
      }

      protected override bool TryGetValue(string key, out object value)
      {
        switch (key)
        {
          case "code":
            value = Code;
            return Code is not null;
          case "status":
            value = Status;
            return Status is not null;
          default:
            return base.TryGetValue(key, out value);
        }

      }

      protected override IEnumerable<KeyValuePair<string, object>> GetElementPairs()
      {
        foreach (var kvp in base.GetElementPairs()) yield return kvp;
        if (Code is not null) yield return new KeyValuePair<string,object>("code",Code);
        if (Status is not null) yield return new KeyValuePair<string,object>("status",Status);
      }

    }

    /// <summary>
    /// The path by which the pharmaceutical product is taken into or makes contact with the body
    /// </summary>
    [Serializable]
    [DataContract]
    [FhirType("MedicinalProductPharmaceutical#RouteOfAdministration", IsNestedType=true)]
    public partial class RouteOfAdministrationComponent : Hl7.Fhir.Model.BackboneElement
    {
      /// <summary>
      /// FHIR Type Name
      /// </summary>
      public override string TypeName { get { return "MedicinalProductPharmaceutical#RouteOfAdministration"; } }

      /// <summary>
      /// Coded expression for the route
      /// </summary>
      [FhirElement("code", InSummary=true, Order=40)]
      [Cardinality(Min=1,Max=1)]
      [DataMember]
      public Hl7.Fhir.Model.CodeableConcept Code
      {
        get { return _Code; }
        set { _Code = value; OnPropertyChanged("Code"); }
      }

      private Hl7.Fhir.Model.CodeableConcept _Code;

      /// <summary>
      /// The first dose (dose quantity) administered in humans can be specified, for a product under investigation, using a numerical value and its unit of measurement
      /// </summary>
      [FhirElement("firstDose", InSummary=true, Order=50)]
      [DataMember]
      public Hl7.Fhir.Model.Quantity FirstDose
      {
        get { return _FirstDose; }
        set { _FirstDose = value; OnPropertyChanged("FirstDose"); }
      }

      private Hl7.Fhir.Model.Quantity _FirstDose;

      /// <summary>
      /// The maximum single dose that can be administered as per the protocol of a clinical trial can be specified using a numerical value and its unit of measurement
      /// </summary>
      [FhirElement("maxSingleDose", InSummary=true, Order=60)]
      [DataMember]
      public Hl7.Fhir.Model.Quantity MaxSingleDose
      {
        get { return _MaxSingleDose; }
        set { _MaxSingleDose = value; OnPropertyChanged("MaxSingleDose"); }
      }

      private Hl7.Fhir.Model.Quantity _MaxSingleDose;

      /// <summary>
      /// The maximum dose per day (maximum dose quantity to be administered in any one 24-h period) that can be administered as per the protocol referenced in the clinical trial authorisation
      /// </summary>
      [FhirElement("maxDosePerDay", InSummary=true, Order=70)]
      [DataMember]
      public Hl7.Fhir.Model.Quantity MaxDosePerDay
      {
        get { return _MaxDosePerDay; }
        set { _MaxDosePerDay = value; OnPropertyChanged("MaxDosePerDay"); }
      }

      private Hl7.Fhir.Model.Quantity _MaxDosePerDay;

      /// <summary>
      /// The maximum dose per treatment period that can be administered as per the protocol referenced in the clinical trial authorisation
      /// </summary>
      [FhirElement("maxDosePerTreatmentPeriod", InSummary=true, Order=80)]
      [DataMember]
      public Hl7.Fhir.Model.Ratio MaxDosePerTreatmentPeriod
      {
        get { return _MaxDosePerTreatmentPeriod; }
        set { _MaxDosePerTreatmentPeriod = value; OnPropertyChanged("MaxDosePerTreatmentPeriod"); }
      }

      private Hl7.Fhir.Model.Ratio _MaxDosePerTreatmentPeriod;

      /// <summary>
      /// The maximum treatment period during which an Investigational Medicinal Product can be administered as per the protocol referenced in the clinical trial authorisation
      /// </summary>
      [FhirElement("maxTreatmentPeriod", InSummary=true, Order=90)]
      [DataMember]
      public Hl7.Fhir.Model.Duration MaxTreatmentPeriod
      {
        get { return _MaxTreatmentPeriod; }
        set { _MaxTreatmentPeriod = value; OnPropertyChanged("MaxTreatmentPeriod"); }
      }

      private Hl7.Fhir.Model.Duration _MaxTreatmentPeriod;

      /// <summary>
      /// A species for which this route applies
      /// </summary>
      [FhirElement("targetSpecies", InSummary=true, Order=100)]
      [Cardinality(Min=0,Max=-1)]
      [DataMember]
      public List<Hl7.Fhir.Model.MedicinalProductPharmaceutical.TargetSpeciesComponent> TargetSpecies
      {
        get { if(_TargetSpecies==null) _TargetSpecies = new List<Hl7.Fhir.Model.MedicinalProductPharmaceutical.TargetSpeciesComponent>(); return _TargetSpecies; }
        set { _TargetSpecies = value; OnPropertyChanged("TargetSpecies"); }
      }

      private List<Hl7.Fhir.Model.MedicinalProductPharmaceutical.TargetSpeciesComponent> _TargetSpecies;

      public override IDeepCopyable CopyTo(IDeepCopyable other)
      {
        var dest = other as RouteOfAdministrationComponent;

        if (dest == null)
        {
          throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        base.CopyTo(dest);
        if(Code != null) dest.Code = (Hl7.Fhir.Model.CodeableConcept)Code.DeepCopy();
        if(FirstDose != null) dest.FirstDose = (Hl7.Fhir.Model.Quantity)FirstDose.DeepCopy();
        if(MaxSingleDose != null) dest.MaxSingleDose = (Hl7.Fhir.Model.Quantity)MaxSingleDose.DeepCopy();
        if(MaxDosePerDay != null) dest.MaxDosePerDay = (Hl7.Fhir.Model.Quantity)MaxDosePerDay.DeepCopy();
        if(MaxDosePerTreatmentPeriod != null) dest.MaxDosePerTreatmentPeriod = (Hl7.Fhir.Model.Ratio)MaxDosePerTreatmentPeriod.DeepCopy();
        if(MaxTreatmentPeriod != null) dest.MaxTreatmentPeriod = (Hl7.Fhir.Model.Duration)MaxTreatmentPeriod.DeepCopy();
        if(TargetSpecies != null) dest.TargetSpecies = new List<Hl7.Fhir.Model.MedicinalProductPharmaceutical.TargetSpeciesComponent>(TargetSpecies.DeepCopy());
        return dest;
      }

      public override IDeepCopyable DeepCopy()
      {
        return CopyTo(new RouteOfAdministrationComponent());
      }

      ///<inheritdoc />
      public override bool Matches(IDeepComparable other)
      {
        var otherT = other as RouteOfAdministrationComponent;
        if(otherT == null) return false;

        if(!base.Matches(otherT)) return false;
        if( !DeepComparable.Matches(Code, otherT.Code)) return false;
        if( !DeepComparable.Matches(FirstDose, otherT.FirstDose)) return false;
        if( !DeepComparable.Matches(MaxSingleDose, otherT.MaxSingleDose)) return false;
        if( !DeepComparable.Matches(MaxDosePerDay, otherT.MaxDosePerDay)) return false;
        if( !DeepComparable.Matches(MaxDosePerTreatmentPeriod, otherT.MaxDosePerTreatmentPeriod)) return false;
        if( !DeepComparable.Matches(MaxTreatmentPeriod, otherT.MaxTreatmentPeriod)) return false;
        if( !DeepComparable.Matches(TargetSpecies, otherT.TargetSpecies)) return false;

        return true;
      }

      public override bool IsExactly(IDeepComparable other)
      {
        var otherT = other as RouteOfAdministrationComponent;
        if(otherT == null) return false;

        if(!base.IsExactly(otherT)) return false;
        if( !DeepComparable.IsExactly(Code, otherT.Code)) return false;
        if( !DeepComparable.IsExactly(FirstDose, otherT.FirstDose)) return false;
        if( !DeepComparable.IsExactly(MaxSingleDose, otherT.MaxSingleDose)) return false;
        if( !DeepComparable.IsExactly(MaxDosePerDay, otherT.MaxDosePerDay)) return false;
        if( !DeepComparable.IsExactly(MaxDosePerTreatmentPeriod, otherT.MaxDosePerTreatmentPeriod)) return false;
        if( !DeepComparable.IsExactly(MaxTreatmentPeriod, otherT.MaxTreatmentPeriod)) return false;
        if( !DeepComparable.IsExactly(TargetSpecies, otherT.TargetSpecies)) return false;

        return true;
      }

      [IgnoreDataMember]
      public override IEnumerable<Base> Children
      {
        get
        {
          foreach (var item in base.Children) yield return item;
          if (Code != null) yield return Code;
          if (FirstDose != null) yield return FirstDose;
          if (MaxSingleDose != null) yield return MaxSingleDose;
          if (MaxDosePerDay != null) yield return MaxDosePerDay;
          if (MaxDosePerTreatmentPeriod != null) yield return MaxDosePerTreatmentPeriod;
          if (MaxTreatmentPeriod != null) yield return MaxTreatmentPeriod;
          foreach (var elem in TargetSpecies) { if (elem != null) yield return elem; }
        }
      }

      [IgnoreDataMember]
      public override IEnumerable<ElementValue> NamedChildren
      {
        get
        {
          foreach (var item in base.NamedChildren) yield return item;
          if (Code != null) yield return new ElementValue("code", Code);
          if (FirstDose != null) yield return new ElementValue("firstDose", FirstDose);
          if (MaxSingleDose != null) yield return new ElementValue("maxSingleDose", MaxSingleDose);
          if (MaxDosePerDay != null) yield return new ElementValue("maxDosePerDay", MaxDosePerDay);
          if (MaxDosePerTreatmentPeriod != null) yield return new ElementValue("maxDosePerTreatmentPeriod", MaxDosePerTreatmentPeriod);
          if (MaxTreatmentPeriod != null) yield return new ElementValue("maxTreatmentPeriod", MaxTreatmentPeriod);
          foreach (var elem in TargetSpecies) { if (elem != null) yield return new ElementValue("targetSpecies", elem); }
        }
      }

      protected override bool TryGetValue(string key, out object value)
      {
        switch (key)
        {
          case "code":
            value = Code;
            return Code is not null;
          case "firstDose":
            value = FirstDose;
            return FirstDose is not null;
          case "maxSingleDose":
            value = MaxSingleDose;
            return MaxSingleDose is not null;
          case "maxDosePerDay":
            value = MaxDosePerDay;
            return MaxDosePerDay is not null;
          case "maxDosePerTreatmentPeriod":
            value = MaxDosePerTreatmentPeriod;
            return MaxDosePerTreatmentPeriod is not null;
          case "maxTreatmentPeriod":
            value = MaxTreatmentPeriod;
            return MaxTreatmentPeriod is not null;
          case "targetSpecies":
            value = TargetSpecies;
            return TargetSpecies?.Any() == true;
          default:
            return base.TryGetValue(key, out value);
        }

      }

      protected override IEnumerable<KeyValuePair<string, object>> GetElementPairs()
      {
        foreach (var kvp in base.GetElementPairs()) yield return kvp;
        if (Code is not null) yield return new KeyValuePair<string,object>("code",Code);
        if (FirstDose is not null) yield return new KeyValuePair<string,object>("firstDose",FirstDose);
        if (MaxSingleDose is not null) yield return new KeyValuePair<string,object>("maxSingleDose",MaxSingleDose);
        if (MaxDosePerDay is not null) yield return new KeyValuePair<string,object>("maxDosePerDay",MaxDosePerDay);
        if (MaxDosePerTreatmentPeriod is not null) yield return new KeyValuePair<string,object>("maxDosePerTreatmentPeriod",MaxDosePerTreatmentPeriod);
        if (MaxTreatmentPeriod is not null) yield return new KeyValuePair<string,object>("maxTreatmentPeriod",MaxTreatmentPeriod);
        if (TargetSpecies?.Any() == true) yield return new KeyValuePair<string,object>("targetSpecies",TargetSpecies);
      }

    }

    /// <summary>
    /// A species for which this route applies
    /// </summary>
    [Serializable]
    [DataContract]
    [FhirType("MedicinalProductPharmaceutical#TargetSpecies", IsNestedType=true)]
    public partial class TargetSpeciesComponent : Hl7.Fhir.Model.BackboneElement
    {
      /// <summary>
      /// FHIR Type Name
      /// </summary>
      public override string TypeName { get { return "MedicinalProductPharmaceutical#TargetSpecies"; } }

      /// <summary>
      /// Coded expression for the species
      /// </summary>
      [FhirElement("code", InSummary=true, Order=40)]
      [Cardinality(Min=1,Max=1)]
      [DataMember]
      public Hl7.Fhir.Model.CodeableConcept Code
      {
        get { return _Code; }
        set { _Code = value; OnPropertyChanged("Code"); }
      }

      private Hl7.Fhir.Model.CodeableConcept _Code;

      /// <summary>
      /// A species specific time during which consumption of animal product is not appropriate
      /// </summary>
      [FhirElement("withdrawalPeriod", InSummary=true, Order=50)]
      [Cardinality(Min=0,Max=-1)]
      [DataMember]
      public List<Hl7.Fhir.Model.MedicinalProductPharmaceutical.WithdrawalPeriodComponent> WithdrawalPeriod
      {
        get { if(_WithdrawalPeriod==null) _WithdrawalPeriod = new List<Hl7.Fhir.Model.MedicinalProductPharmaceutical.WithdrawalPeriodComponent>(); return _WithdrawalPeriod; }
        set { _WithdrawalPeriod = value; OnPropertyChanged("WithdrawalPeriod"); }
      }

      private List<Hl7.Fhir.Model.MedicinalProductPharmaceutical.WithdrawalPeriodComponent> _WithdrawalPeriod;

      public override IDeepCopyable CopyTo(IDeepCopyable other)
      {
        var dest = other as TargetSpeciesComponent;

        if (dest == null)
        {
          throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        base.CopyTo(dest);
        if(Code != null) dest.Code = (Hl7.Fhir.Model.CodeableConcept)Code.DeepCopy();
        if(WithdrawalPeriod != null) dest.WithdrawalPeriod = new List<Hl7.Fhir.Model.MedicinalProductPharmaceutical.WithdrawalPeriodComponent>(WithdrawalPeriod.DeepCopy());
        return dest;
      }

      public override IDeepCopyable DeepCopy()
      {
        return CopyTo(new TargetSpeciesComponent());
      }

      ///<inheritdoc />
      public override bool Matches(IDeepComparable other)
      {
        var otherT = other as TargetSpeciesComponent;
        if(otherT == null) return false;

        if(!base.Matches(otherT)) return false;
        if( !DeepComparable.Matches(Code, otherT.Code)) return false;
        if( !DeepComparable.Matches(WithdrawalPeriod, otherT.WithdrawalPeriod)) return false;

        return true;
      }

      public override bool IsExactly(IDeepComparable other)
      {
        var otherT = other as TargetSpeciesComponent;
        if(otherT == null) return false;

        if(!base.IsExactly(otherT)) return false;
        if( !DeepComparable.IsExactly(Code, otherT.Code)) return false;
        if( !DeepComparable.IsExactly(WithdrawalPeriod, otherT.WithdrawalPeriod)) return false;

        return true;
      }

      [IgnoreDataMember]
      public override IEnumerable<Base> Children
      {
        get
        {
          foreach (var item in base.Children) yield return item;
          if (Code != null) yield return Code;
          foreach (var elem in WithdrawalPeriod) { if (elem != null) yield return elem; }
        }
      }

      [IgnoreDataMember]
      public override IEnumerable<ElementValue> NamedChildren
      {
        get
        {
          foreach (var item in base.NamedChildren) yield return item;
          if (Code != null) yield return new ElementValue("code", Code);
          foreach (var elem in WithdrawalPeriod) { if (elem != null) yield return new ElementValue("withdrawalPeriod", elem); }
        }
      }

      protected override bool TryGetValue(string key, out object value)
      {
        switch (key)
        {
          case "code":
            value = Code;
            return Code is not null;
          case "withdrawalPeriod":
            value = WithdrawalPeriod;
            return WithdrawalPeriod?.Any() == true;
          default:
            return base.TryGetValue(key, out value);
        }

      }

      protected override IEnumerable<KeyValuePair<string, object>> GetElementPairs()
      {
        foreach (var kvp in base.GetElementPairs()) yield return kvp;
        if (Code is not null) yield return new KeyValuePair<string,object>("code",Code);
        if (WithdrawalPeriod?.Any() == true) yield return new KeyValuePair<string,object>("withdrawalPeriod",WithdrawalPeriod);
      }

    }

    /// <summary>
    /// A species specific time during which consumption of animal product is not appropriate
    /// </summary>
    [Serializable]
    [DataContract]
    [FhirType("MedicinalProductPharmaceutical#WithdrawalPeriod", IsNestedType=true)]
    public partial class WithdrawalPeriodComponent : Hl7.Fhir.Model.BackboneElement
    {
      /// <summary>
      /// FHIR Type Name
      /// </summary>
      public override string TypeName { get { return "MedicinalProductPharmaceutical#WithdrawalPeriod"; } }

      /// <summary>
      /// Coded expression for the type of tissue for which the withdrawal period applues, e.g. meat, milk
      /// </summary>
      [FhirElement("tissue", InSummary=true, Order=40)]
      [Cardinality(Min=1,Max=1)]
      [DataMember]
      public Hl7.Fhir.Model.CodeableConcept Tissue
      {
        get { return _Tissue; }
        set { _Tissue = value; OnPropertyChanged("Tissue"); }
      }

      private Hl7.Fhir.Model.CodeableConcept _Tissue;

      /// <summary>
      /// A value for the time
      /// </summary>
      [FhirElement("value", InSummary=true, Order=50)]
      [Cardinality(Min=1,Max=1)]
      [DataMember]
      public Hl7.Fhir.Model.Quantity Value
      {
        get { return _Value; }
        set { _Value = value; OnPropertyChanged("Value"); }
      }

      private Hl7.Fhir.Model.Quantity _Value;

      /// <summary>
      /// Extra information about the withdrawal period
      /// </summary>
      [FhirElement("supportingInformation", InSummary=true, Order=60)]
      [DataMember]
      public Hl7.Fhir.Model.FhirString SupportingInformationElement
      {
        get { return _SupportingInformationElement; }
        set { _SupportingInformationElement = value; OnPropertyChanged("SupportingInformationElement"); }
      }

      private Hl7.Fhir.Model.FhirString _SupportingInformationElement;

      /// <summary>
      /// Extra information about the withdrawal period
      /// </summary>
      /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
      [IgnoreDataMember]
      public string SupportingInformation
      {
        get { return SupportingInformationElement != null ? SupportingInformationElement.Value : null; }
        set
        {
          if (value == null)
            SupportingInformationElement = null;
          else
            SupportingInformationElement = new Hl7.Fhir.Model.FhirString(value);
          OnPropertyChanged("SupportingInformation");
        }
      }

      public override IDeepCopyable CopyTo(IDeepCopyable other)
      {
        var dest = other as WithdrawalPeriodComponent;

        if (dest == null)
        {
          throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        base.CopyTo(dest);
        if(Tissue != null) dest.Tissue = (Hl7.Fhir.Model.CodeableConcept)Tissue.DeepCopy();
        if(Value != null) dest.Value = (Hl7.Fhir.Model.Quantity)Value.DeepCopy();
        if(SupportingInformationElement != null) dest.SupportingInformationElement = (Hl7.Fhir.Model.FhirString)SupportingInformationElement.DeepCopy();
        return dest;
      }

      public override IDeepCopyable DeepCopy()
      {
        return CopyTo(new WithdrawalPeriodComponent());
      }

      ///<inheritdoc />
      public override bool Matches(IDeepComparable other)
      {
        var otherT = other as WithdrawalPeriodComponent;
        if(otherT == null) return false;

        if(!base.Matches(otherT)) return false;
        if( !DeepComparable.Matches(Tissue, otherT.Tissue)) return false;
        if( !DeepComparable.Matches(Value, otherT.Value)) return false;
        if( !DeepComparable.Matches(SupportingInformationElement, otherT.SupportingInformationElement)) return false;

        return true;
      }

      public override bool IsExactly(IDeepComparable other)
      {
        var otherT = other as WithdrawalPeriodComponent;
        if(otherT == null) return false;

        if(!base.IsExactly(otherT)) return false;
        if( !DeepComparable.IsExactly(Tissue, otherT.Tissue)) return false;
        if( !DeepComparable.IsExactly(Value, otherT.Value)) return false;
        if( !DeepComparable.IsExactly(SupportingInformationElement, otherT.SupportingInformationElement)) return false;

        return true;
      }

      [IgnoreDataMember]
      public override IEnumerable<Base> Children
      {
        get
        {
          foreach (var item in base.Children) yield return item;
          if (Tissue != null) yield return Tissue;
          if (Value != null) yield return Value;
          if (SupportingInformationElement != null) yield return SupportingInformationElement;
        }
      }

      [IgnoreDataMember]
      public override IEnumerable<ElementValue> NamedChildren
      {
        get
        {
          foreach (var item in base.NamedChildren) yield return item;
          if (Tissue != null) yield return new ElementValue("tissue", Tissue);
          if (Value != null) yield return new ElementValue("value", Value);
          if (SupportingInformationElement != null) yield return new ElementValue("supportingInformation", SupportingInformationElement);
        }
      }

      protected override bool TryGetValue(string key, out object value)
      {
        switch (key)
        {
          case "tissue":
            value = Tissue;
            return Tissue is not null;
          case "value":
            value = Value;
            return Value is not null;
          case "supportingInformation":
            value = SupportingInformationElement;
            return SupportingInformationElement is not null;
          default:
            return base.TryGetValue(key, out value);
        }

      }

      protected override IEnumerable<KeyValuePair<string, object>> GetElementPairs()
      {
        foreach (var kvp in base.GetElementPairs()) yield return kvp;
        if (Tissue is not null) yield return new KeyValuePair<string,object>("tissue",Tissue);
        if (Value is not null) yield return new KeyValuePair<string,object>("value",Value);
        if (SupportingInformationElement is not null) yield return new KeyValuePair<string,object>("supportingInformation",SupportingInformationElement);
      }

    }

    /// <summary>
    /// An identifier for the pharmaceutical medicinal product
    /// </summary>
    [FhirElement("identifier", InSummary=true, Order=90)]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.Identifier> Identifier
    {
      get { if(_Identifier==null) _Identifier = new List<Hl7.Fhir.Model.Identifier>(); return _Identifier; }
      set { _Identifier = value; OnPropertyChanged("Identifier"); }
    }

    private List<Hl7.Fhir.Model.Identifier> _Identifier;

    /// <summary>
    /// The administrable dose form, after necessary reconstitution
    /// </summary>
    [FhirElement("administrableDoseForm", InSummary=true, Order=100)]
    [Cardinality(Min=1,Max=1)]
    [DataMember]
    public Hl7.Fhir.Model.CodeableConcept AdministrableDoseForm
    {
      get { return _AdministrableDoseForm; }
      set { _AdministrableDoseForm = value; OnPropertyChanged("AdministrableDoseForm"); }
    }

    private Hl7.Fhir.Model.CodeableConcept _AdministrableDoseForm;

    /// <summary>
    /// Todo
    /// </summary>
    [FhirElement("unitOfPresentation", InSummary=true, Order=110)]
    [DataMember]
    public Hl7.Fhir.Model.CodeableConcept UnitOfPresentation
    {
      get { return _UnitOfPresentation; }
      set { _UnitOfPresentation = value; OnPropertyChanged("UnitOfPresentation"); }
    }

    private Hl7.Fhir.Model.CodeableConcept _UnitOfPresentation;

    /// <summary>
    /// Ingredient
    /// </summary>
    [FhirElement("ingredient", InSummary=true, Order=120)]
    [CLSCompliant(false)]
    [References("MedicinalProductIngredient")]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.ResourceReference> Ingredient
    {
      get { if(_Ingredient==null) _Ingredient = new List<Hl7.Fhir.Model.ResourceReference>(); return _Ingredient; }
      set { _Ingredient = value; OnPropertyChanged("Ingredient"); }
    }

    private List<Hl7.Fhir.Model.ResourceReference> _Ingredient;

    /// <summary>
    /// Accompanying device
    /// </summary>
    [FhirElement("device", InSummary=true, Order=130)]
    [CLSCompliant(false)]
    [References("DeviceDefinition")]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.ResourceReference> Device
    {
      get { if(_Device==null) _Device = new List<Hl7.Fhir.Model.ResourceReference>(); return _Device; }
      set { _Device = value; OnPropertyChanged("Device"); }
    }

    private List<Hl7.Fhir.Model.ResourceReference> _Device;

    /// <summary>
    /// Characteristics e.g. a products onset of action
    /// </summary>
    [FhirElement("characteristics", InSummary=true, Order=140)]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.MedicinalProductPharmaceutical.CharacteristicsComponent> Characteristics
    {
      get { if(_Characteristics==null) _Characteristics = new List<Hl7.Fhir.Model.MedicinalProductPharmaceutical.CharacteristicsComponent>(); return _Characteristics; }
      set { _Characteristics = value; OnPropertyChanged("Characteristics"); }
    }

    private List<Hl7.Fhir.Model.MedicinalProductPharmaceutical.CharacteristicsComponent> _Characteristics;

    /// <summary>
    /// The path by which the pharmaceutical product is taken into or makes contact with the body
    /// </summary>
    [FhirElement("routeOfAdministration", InSummary=true, Order=150)]
    [Cardinality(Min=1,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.MedicinalProductPharmaceutical.RouteOfAdministrationComponent> RouteOfAdministration
    {
      get { if(_RouteOfAdministration==null) _RouteOfAdministration = new List<Hl7.Fhir.Model.MedicinalProductPharmaceutical.RouteOfAdministrationComponent>(); return _RouteOfAdministration; }
      set { _RouteOfAdministration = value; OnPropertyChanged("RouteOfAdministration"); }
    }

    private List<Hl7.Fhir.Model.MedicinalProductPharmaceutical.RouteOfAdministrationComponent> _RouteOfAdministration;

    public override IDeepCopyable CopyTo(IDeepCopyable other)
    {
      var dest = other as MedicinalProductPharmaceutical;

      if (dest == null)
      {
        throw new ArgumentException("Can only copy to an object of the same type", "other");
      }

      base.CopyTo(dest);
      if(Identifier != null) dest.Identifier = new List<Hl7.Fhir.Model.Identifier>(Identifier.DeepCopy());
      if(AdministrableDoseForm != null) dest.AdministrableDoseForm = (Hl7.Fhir.Model.CodeableConcept)AdministrableDoseForm.DeepCopy();
      if(UnitOfPresentation != null) dest.UnitOfPresentation = (Hl7.Fhir.Model.CodeableConcept)UnitOfPresentation.DeepCopy();
      if(Ingredient != null) dest.Ingredient = new List<Hl7.Fhir.Model.ResourceReference>(Ingredient.DeepCopy());
      if(Device != null) dest.Device = new List<Hl7.Fhir.Model.ResourceReference>(Device.DeepCopy());
      if(Characteristics != null) dest.Characteristics = new List<Hl7.Fhir.Model.MedicinalProductPharmaceutical.CharacteristicsComponent>(Characteristics.DeepCopy());
      if(RouteOfAdministration != null) dest.RouteOfAdministration = new List<Hl7.Fhir.Model.MedicinalProductPharmaceutical.RouteOfAdministrationComponent>(RouteOfAdministration.DeepCopy());
      return dest;
    }

    public override IDeepCopyable DeepCopy()
    {
      return CopyTo(new MedicinalProductPharmaceutical());
    }

    ///<inheritdoc />
    public override bool Matches(IDeepComparable other)
    {
      var otherT = other as MedicinalProductPharmaceutical;
      if(otherT == null) return false;

      if(!base.Matches(otherT)) return false;
      if( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
      if( !DeepComparable.Matches(AdministrableDoseForm, otherT.AdministrableDoseForm)) return false;
      if( !DeepComparable.Matches(UnitOfPresentation, otherT.UnitOfPresentation)) return false;
      if( !DeepComparable.Matches(Ingredient, otherT.Ingredient)) return false;
      if( !DeepComparable.Matches(Device, otherT.Device)) return false;
      if( !DeepComparable.Matches(Characteristics, otherT.Characteristics)) return false;
      if( !DeepComparable.Matches(RouteOfAdministration, otherT.RouteOfAdministration)) return false;

      return true;
    }

    public override bool IsExactly(IDeepComparable other)
    {
      var otherT = other as MedicinalProductPharmaceutical;
      if(otherT == null) return false;

      if(!base.IsExactly(otherT)) return false;
      if( !DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
      if( !DeepComparable.IsExactly(AdministrableDoseForm, otherT.AdministrableDoseForm)) return false;
      if( !DeepComparable.IsExactly(UnitOfPresentation, otherT.UnitOfPresentation)) return false;
      if( !DeepComparable.IsExactly(Ingredient, otherT.Ingredient)) return false;
      if( !DeepComparable.IsExactly(Device, otherT.Device)) return false;
      if( !DeepComparable.IsExactly(Characteristics, otherT.Characteristics)) return false;
      if( !DeepComparable.IsExactly(RouteOfAdministration, otherT.RouteOfAdministration)) return false;

      return true;
    }

    [IgnoreDataMember]
    public override IEnumerable<Base> Children
    {
      get
      {
        foreach (var item in base.Children) yield return item;
        foreach (var elem in Identifier) { if (elem != null) yield return elem; }
        if (AdministrableDoseForm != null) yield return AdministrableDoseForm;
        if (UnitOfPresentation != null) yield return UnitOfPresentation;
        foreach (var elem in Ingredient) { if (elem != null) yield return elem; }
        foreach (var elem in Device) { if (elem != null) yield return elem; }
        foreach (var elem in Characteristics) { if (elem != null) yield return elem; }
        foreach (var elem in RouteOfAdministration) { if (elem != null) yield return elem; }
      }
    }

    [IgnoreDataMember]
    public override IEnumerable<ElementValue> NamedChildren
    {
      get
      {
        foreach (var item in base.NamedChildren) yield return item;
        foreach (var elem in Identifier) { if (elem != null) yield return new ElementValue("identifier", elem); }
        if (AdministrableDoseForm != null) yield return new ElementValue("administrableDoseForm", AdministrableDoseForm);
        if (UnitOfPresentation != null) yield return new ElementValue("unitOfPresentation", UnitOfPresentation);
        foreach (var elem in Ingredient) { if (elem != null) yield return new ElementValue("ingredient", elem); }
        foreach (var elem in Device) { if (elem != null) yield return new ElementValue("device", elem); }
        foreach (var elem in Characteristics) { if (elem != null) yield return new ElementValue("characteristics", elem); }
        foreach (var elem in RouteOfAdministration) { if (elem != null) yield return new ElementValue("routeOfAdministration", elem); }
      }
    }

    protected override bool TryGetValue(string key, out object value)
    {
      switch (key)
      {
        case "identifier":
          value = Identifier;
          return Identifier?.Any() == true;
        case "administrableDoseForm":
          value = AdministrableDoseForm;
          return AdministrableDoseForm is not null;
        case "unitOfPresentation":
          value = UnitOfPresentation;
          return UnitOfPresentation is not null;
        case "ingredient":
          value = Ingredient;
          return Ingredient?.Any() == true;
        case "device":
          value = Device;
          return Device?.Any() == true;
        case "characteristics":
          value = Characteristics;
          return Characteristics?.Any() == true;
        case "routeOfAdministration":
          value = RouteOfAdministration;
          return RouteOfAdministration?.Any() == true;
        default:
          return base.TryGetValue(key, out value);
      }

    }

    protected override IEnumerable<KeyValuePair<string, object>> GetElementPairs()
    {
      foreach (var kvp in base.GetElementPairs()) yield return kvp;
      if (Identifier?.Any() == true) yield return new KeyValuePair<string,object>("identifier",Identifier);
      if (AdministrableDoseForm is not null) yield return new KeyValuePair<string,object>("administrableDoseForm",AdministrableDoseForm);
      if (UnitOfPresentation is not null) yield return new KeyValuePair<string,object>("unitOfPresentation",UnitOfPresentation);
      if (Ingredient?.Any() == true) yield return new KeyValuePair<string,object>("ingredient",Ingredient);
      if (Device?.Any() == true) yield return new KeyValuePair<string,object>("device",Device);
      if (Characteristics?.Any() == true) yield return new KeyValuePair<string,object>("characteristics",Characteristics);
      if (RouteOfAdministration?.Any() == true) yield return new KeyValuePair<string,object>("routeOfAdministration",RouteOfAdministration);
    }

  }

}

// end of file

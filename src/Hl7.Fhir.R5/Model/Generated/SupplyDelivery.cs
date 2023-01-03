// <auto-generated/>
// Contents of: hl7.fhir.r5.core version: 5.0.0-snapshot1

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
  /// Delivery of bulk Supplies
  /// </summary>
  [Serializable]
  [DataContract]
  [FhirType("SupplyDelivery","http://hl7.org/fhir/StructureDefinition/SupplyDelivery", IsResource=true)]
  public partial class SupplyDelivery : Hl7.Fhir.Model.DomainResource
  {
    /// <summary>
    /// FHIR Type Name
    /// </summary>
    public override string TypeName { get { return "SupplyDelivery"; } }

    /// <summary>
    /// Status of the supply delivery.
    /// (url: http://hl7.org/fhir/ValueSet/supplydelivery-status)
    /// (system: http://hl7.org/fhir/supplydelivery-status)
    /// </summary>
    [FhirEnumeration("SupplyDeliveryStatus")]
    public enum SupplyDeliveryStatus
    {
      /// <summary>
      /// Supply has been requested, but not delivered.
      /// (system: http://hl7.org/fhir/supplydelivery-status)
      /// </summary>
      [EnumLiteral("in-progress", "http://hl7.org/fhir/supplydelivery-status"), Description("In Progress")]
      InProgress,
      /// <summary>
      /// Supply has been delivered ("completed").
      /// (system: http://hl7.org/fhir/supplydelivery-status)
      /// </summary>
      [EnumLiteral("completed", "http://hl7.org/fhir/supplydelivery-status"), Description("Delivered")]
      Completed,
      /// <summary>
      /// Delivery was not completed.
      /// (system: http://hl7.org/fhir/supplydelivery-status)
      /// </summary>
      [EnumLiteral("abandoned", "http://hl7.org/fhir/supplydelivery-status"), Description("Abandoned")]
      Abandoned,
      /// <summary>
      /// This electronic record should never have existed, though it is possible that real-world decisions were based on it. (If real-world activity has occurred, the status should be "abandoned" rather than "entered-in-error".).
      /// (system: http://hl7.org/fhir/supplydelivery-status)
      /// </summary>
      [EnumLiteral("entered-in-error", "http://hl7.org/fhir/supplydelivery-status"), Description("Entered In Error")]
      EnteredInError,
    }

    /// <summary>
    /// This value sets refers to a specific supply item.
    /// (url: http://hl7.org/fhir/ValueSet/supplydelivery-type)
    /// (systems: 0)
    /// </summary>
    [FhirEnumeration("SupplyItemType")]
    public enum SupplyItemType
    {
      /// <summary>
      /// MISSING DESCRIPTION
      /// (system: http://terminology.hl7.org/CodeSystem/supply-item-type)
      /// </summary>
      [EnumLiteral("medication", "http://terminology.hl7.org/CodeSystem/supply-item-type"), Description("Medication")]
      Medication,
      /// <summary>
      /// MISSING DESCRIPTION
      /// (system: http://terminology.hl7.org/CodeSystem/supply-item-type)
      /// </summary>
      [EnumLiteral("device", "http://terminology.hl7.org/CodeSystem/supply-item-type"), Description("Device")]
      Device,
    }

    /// <summary>
    /// The item that is delivered or supplied
    /// </summary>
    [Serializable]
    [DataContract]
    [FhirType("SupplyDelivery#SuppliedItem", IsNestedType=true)]
    public partial class SuppliedItemComponent : Hl7.Fhir.Model.BackboneElement
    {
      /// <summary>
      /// FHIR Type Name
      /// </summary>
      public override string TypeName { get { return "SupplyDelivery#SuppliedItem"; } }

      /// <summary>
      /// Amount dispensed
      /// </summary>
      [FhirElement("quantity", Order=40)]
      [DataMember]
      public Hl7.Fhir.Model.Quantity Quantity
      {
        get { return _Quantity; }
        set { _Quantity = value; OnPropertyChanged("Quantity"); }
      }

      private Hl7.Fhir.Model.Quantity _Quantity;

      /// <summary>
      /// Medication, Substance, or Device supplied
      /// </summary>
      [FhirElement("item", Order=50, Choice=ChoiceType.DatatypeChoice)]
      [CLSCompliant(false)]
      [References("Medication","Substance","Device")]
      [AllowedTypes(typeof(Hl7.Fhir.Model.CodeableConcept),typeof(Hl7.Fhir.Model.ResourceReference))]
      [DataMember]
      public Hl7.Fhir.Model.DataType Item
      {
        get { return _Item; }
        set { _Item = value; OnPropertyChanged("Item"); }
      }

      private Hl7.Fhir.Model.DataType _Item;

      public override IDeepCopyable CopyTo(IDeepCopyable other)
      {
        var dest = other as SuppliedItemComponent;

        if (dest == null)
        {
          throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        base.CopyTo(dest);
        if(Quantity != null) dest.Quantity = (Hl7.Fhir.Model.Quantity)Quantity.DeepCopy();
        if(Item != null) dest.Item = (Hl7.Fhir.Model.DataType)Item.DeepCopy();
        return dest;
      }

      public override IDeepCopyable DeepCopy()
      {
        return CopyTo(new SuppliedItemComponent());
      }

      ///<inheritdoc />
      public override bool Matches(IDeepComparable other)
      {
        var otherT = other as SuppliedItemComponent;
        if(otherT == null) return false;

        if(!base.Matches(otherT)) return false;
        if( !DeepComparable.Matches(Quantity, otherT.Quantity)) return false;
        if( !DeepComparable.Matches(Item, otherT.Item)) return false;

        return true;
      }

      public override bool IsExactly(IDeepComparable other)
      {
        var otherT = other as SuppliedItemComponent;
        if(otherT == null) return false;

        if(!base.IsExactly(otherT)) return false;
        if( !DeepComparable.IsExactly(Quantity, otherT.Quantity)) return false;
        if( !DeepComparable.IsExactly(Item, otherT.Item)) return false;

        return true;
      }

      [IgnoreDataMember]
      public override IEnumerable<Base> Children
      {
        get
        {
          foreach (var item in base.Children) yield return item;
          if (Quantity != null) yield return Quantity;
          if (Item != null) yield return Item;
        }
      }

      [IgnoreDataMember]
      public override IEnumerable<ElementValue> NamedChildren
      {
        get
        {
          foreach (var item in base.NamedChildren) yield return item;
          if (Quantity != null) yield return new ElementValue("quantity", Quantity);
          if (Item != null) yield return new ElementValue("item", Item);
        }
      }

      protected override bool TryGetValue(string key, out object value)
      {
        switch (key)
        {
          case "quantity":
            value = Quantity;
            return Quantity is not null;
          case "item":
            value = Item;
            return Item is not null;
          default:
            return base.TryGetValue(key, out value);
        }

      }

      protected override IEnumerable<KeyValuePair<string, object>> GetElementPairs()
      {
        foreach (var kvp in base.GetElementPairs()) yield return kvp;
        if (Quantity is not null) yield return new KeyValuePair<string,object>("quantity",Quantity);
        if (Item is not null) yield return new KeyValuePair<string,object>("item",Item);
      }

    }

    /// <summary>
    /// External identifier
    /// </summary>
    [FhirElement("identifier", Order=90)]
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
    [References("SupplyRequest")]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.ResourceReference> BasedOn
    {
      get { if(_BasedOn==null) _BasedOn = new List<Hl7.Fhir.Model.ResourceReference>(); return _BasedOn; }
      set { _BasedOn = value; OnPropertyChanged("BasedOn"); }
    }

    private List<Hl7.Fhir.Model.ResourceReference> _BasedOn;

    /// <summary>
    /// Part of referenced event
    /// </summary>
    [FhirElement("partOf", InSummary=true, Order=110)]
    [CLSCompliant(false)]
    [References("SupplyDelivery","Contract")]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.ResourceReference> PartOf
    {
      get { if(_PartOf==null) _PartOf = new List<Hl7.Fhir.Model.ResourceReference>(); return _PartOf; }
      set { _PartOf = value; OnPropertyChanged("PartOf"); }
    }

    private List<Hl7.Fhir.Model.ResourceReference> _PartOf;

    /// <summary>
    /// in-progress | completed | abandoned | entered-in-error
    /// </summary>
    [FhirElement("status", InSummary=true, IsModifier=true, Order=120)]
    [DeclaredType(Type = typeof(Code))]
    [DataMember]
    public Code<Hl7.Fhir.Model.SupplyDelivery.SupplyDeliveryStatus> StatusElement
    {
      get { return _StatusElement; }
      set { _StatusElement = value; OnPropertyChanged("StatusElement"); }
    }

    private Code<Hl7.Fhir.Model.SupplyDelivery.SupplyDeliveryStatus> _StatusElement;

    /// <summary>
    /// in-progress | completed | abandoned | entered-in-error
    /// </summary>
    /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
    [IgnoreDataMember]
    public Hl7.Fhir.Model.SupplyDelivery.SupplyDeliveryStatus? Status
    {
      get { return StatusElement != null ? StatusElement.Value : null; }
      set
      {
        if (value == null)
          StatusElement = null;
        else
          StatusElement = new Code<Hl7.Fhir.Model.SupplyDelivery.SupplyDeliveryStatus>(value);
        OnPropertyChanged("Status");
      }
    }

    /// <summary>
    /// Patient for whom the item is supplied
    /// </summary>
    [FhirElement("patient", Order=130)]
    [CLSCompliant(false)]
    [References("Patient")]
    [DataMember]
    public Hl7.Fhir.Model.ResourceReference Patient
    {
      get { return _Patient; }
      set { _Patient = value; OnPropertyChanged("Patient"); }
    }

    private Hl7.Fhir.Model.ResourceReference _Patient;

    /// <summary>
    /// Category of dispense event
    /// </summary>
    [FhirElement("type", Order=140)]
    [DataMember]
    public Hl7.Fhir.Model.CodeableConcept Type
    {
      get { return _Type; }
      set { _Type = value; OnPropertyChanged("Type"); }
    }

    private Hl7.Fhir.Model.CodeableConcept _Type;

    /// <summary>
    /// The item that is delivered or supplied
    /// </summary>
    [FhirElement("suppliedItem", Order=150)]
    [DataMember]
    public Hl7.Fhir.Model.SupplyDelivery.SuppliedItemComponent SuppliedItem
    {
      get { return _SuppliedItem; }
      set { _SuppliedItem = value; OnPropertyChanged("SuppliedItem"); }
    }

    private Hl7.Fhir.Model.SupplyDelivery.SuppliedItemComponent _SuppliedItem;

    /// <summary>
    /// When event occurred
    /// </summary>
    [FhirElement("occurrence", InSummary=true, Order=160, Choice=ChoiceType.DatatypeChoice, FiveWs="FiveWs.done[x]")]
    [CLSCompliant(false)]
    [AllowedTypes(typeof(Hl7.Fhir.Model.FhirDateTime),typeof(Hl7.Fhir.Model.Period),typeof(Hl7.Fhir.Model.Timing))]
    [DataMember]
    public Hl7.Fhir.Model.DataType Occurrence
    {
      get { return _Occurrence; }
      set { _Occurrence = value; OnPropertyChanged("Occurrence"); }
    }

    private Hl7.Fhir.Model.DataType _Occurrence;

    /// <summary>
    /// Dispenser
    /// </summary>
    [FhirElement("supplier", Order=170)]
    [CLSCompliant(false)]
    [References("Practitioner","PractitionerRole","Organization")]
    [DataMember]
    public Hl7.Fhir.Model.ResourceReference Supplier
    {
      get { return _Supplier; }
      set { _Supplier = value; OnPropertyChanged("Supplier"); }
    }

    private Hl7.Fhir.Model.ResourceReference _Supplier;

    /// <summary>
    /// Where the Supply was sent
    /// </summary>
    [FhirElement("destination", Order=180)]
    [CLSCompliant(false)]
    [References("Location")]
    [DataMember]
    public Hl7.Fhir.Model.ResourceReference Destination
    {
      get { return _Destination; }
      set { _Destination = value; OnPropertyChanged("Destination"); }
    }

    private Hl7.Fhir.Model.ResourceReference _Destination;

    /// <summary>
    /// Who collected the Supply
    /// </summary>
    [FhirElement("receiver", Order=190)]
    [CLSCompliant(false)]
    [References("Practitioner","PractitionerRole")]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.ResourceReference> Receiver
    {
      get { if(_Receiver==null) _Receiver = new List<Hl7.Fhir.Model.ResourceReference>(); return _Receiver; }
      set { _Receiver = value; OnPropertyChanged("Receiver"); }
    }

    private List<Hl7.Fhir.Model.ResourceReference> _Receiver;

    public override IDeepCopyable CopyTo(IDeepCopyable other)
    {
      var dest = other as SupplyDelivery;

      if (dest == null)
      {
        throw new ArgumentException("Can only copy to an object of the same type", "other");
      }

      base.CopyTo(dest);
      if(Identifier != null) dest.Identifier = new List<Hl7.Fhir.Model.Identifier>(Identifier.DeepCopy());
      if(BasedOn != null) dest.BasedOn = new List<Hl7.Fhir.Model.ResourceReference>(BasedOn.DeepCopy());
      if(PartOf != null) dest.PartOf = new List<Hl7.Fhir.Model.ResourceReference>(PartOf.DeepCopy());
      if(StatusElement != null) dest.StatusElement = (Code<Hl7.Fhir.Model.SupplyDelivery.SupplyDeliveryStatus>)StatusElement.DeepCopy();
      if(Patient != null) dest.Patient = (Hl7.Fhir.Model.ResourceReference)Patient.DeepCopy();
      if(Type != null) dest.Type = (Hl7.Fhir.Model.CodeableConcept)Type.DeepCopy();
      if(SuppliedItem != null) dest.SuppliedItem = (Hl7.Fhir.Model.SupplyDelivery.SuppliedItemComponent)SuppliedItem.DeepCopy();
      if(Occurrence != null) dest.Occurrence = (Hl7.Fhir.Model.DataType)Occurrence.DeepCopy();
      if(Supplier != null) dest.Supplier = (Hl7.Fhir.Model.ResourceReference)Supplier.DeepCopy();
      if(Destination != null) dest.Destination = (Hl7.Fhir.Model.ResourceReference)Destination.DeepCopy();
      if(Receiver != null) dest.Receiver = new List<Hl7.Fhir.Model.ResourceReference>(Receiver.DeepCopy());
      return dest;
    }

    public override IDeepCopyable DeepCopy()
    {
      return CopyTo(new SupplyDelivery());
    }

    ///<inheritdoc />
    public override bool Matches(IDeepComparable other)
    {
      var otherT = other as SupplyDelivery;
      if(otherT == null) return false;

      if(!base.Matches(otherT)) return false;
      if( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
      if( !DeepComparable.Matches(BasedOn, otherT.BasedOn)) return false;
      if( !DeepComparable.Matches(PartOf, otherT.PartOf)) return false;
      if( !DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
      if( !DeepComparable.Matches(Patient, otherT.Patient)) return false;
      if( !DeepComparable.Matches(Type, otherT.Type)) return false;
      if( !DeepComparable.Matches(SuppliedItem, otherT.SuppliedItem)) return false;
      if( !DeepComparable.Matches(Occurrence, otherT.Occurrence)) return false;
      if( !DeepComparable.Matches(Supplier, otherT.Supplier)) return false;
      if( !DeepComparable.Matches(Destination, otherT.Destination)) return false;
      if( !DeepComparable.Matches(Receiver, otherT.Receiver)) return false;

      return true;
    }

    public override bool IsExactly(IDeepComparable other)
    {
      var otherT = other as SupplyDelivery;
      if(otherT == null) return false;

      if(!base.IsExactly(otherT)) return false;
      if( !DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
      if( !DeepComparable.IsExactly(BasedOn, otherT.BasedOn)) return false;
      if( !DeepComparable.IsExactly(PartOf, otherT.PartOf)) return false;
      if( !DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
      if( !DeepComparable.IsExactly(Patient, otherT.Patient)) return false;
      if( !DeepComparable.IsExactly(Type, otherT.Type)) return false;
      if( !DeepComparable.IsExactly(SuppliedItem, otherT.SuppliedItem)) return false;
      if( !DeepComparable.IsExactly(Occurrence, otherT.Occurrence)) return false;
      if( !DeepComparable.IsExactly(Supplier, otherT.Supplier)) return false;
      if( !DeepComparable.IsExactly(Destination, otherT.Destination)) return false;
      if( !DeepComparable.IsExactly(Receiver, otherT.Receiver)) return false;

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
        foreach (var elem in PartOf) { if (elem != null) yield return elem; }
        if (StatusElement != null) yield return StatusElement;
        if (Patient != null) yield return Patient;
        if (Type != null) yield return Type;
        if (SuppliedItem != null) yield return SuppliedItem;
        if (Occurrence != null) yield return Occurrence;
        if (Supplier != null) yield return Supplier;
        if (Destination != null) yield return Destination;
        foreach (var elem in Receiver) { if (elem != null) yield return elem; }
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
        foreach (var elem in PartOf) { if (elem != null) yield return new ElementValue("partOf", elem); }
        if (StatusElement != null) yield return new ElementValue("status", StatusElement);
        if (Patient != null) yield return new ElementValue("patient", Patient);
        if (Type != null) yield return new ElementValue("type", Type);
        if (SuppliedItem != null) yield return new ElementValue("suppliedItem", SuppliedItem);
        if (Occurrence != null) yield return new ElementValue("occurrence", Occurrence);
        if (Supplier != null) yield return new ElementValue("supplier", Supplier);
        if (Destination != null) yield return new ElementValue("destination", Destination);
        foreach (var elem in Receiver) { if (elem != null) yield return new ElementValue("receiver", elem); }
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
        case "partOf":
          value = PartOf;
          return PartOf?.Any() == true;
        case "status":
          value = StatusElement;
          return StatusElement is not null;
        case "patient":
          value = Patient;
          return Patient is not null;
        case "type":
          value = Type;
          return Type is not null;
        case "suppliedItem":
          value = SuppliedItem;
          return SuppliedItem is not null;
        case "occurrence":
          value = Occurrence;
          return Occurrence is not null;
        case "supplier":
          value = Supplier;
          return Supplier is not null;
        case "destination":
          value = Destination;
          return Destination is not null;
        case "receiver":
          value = Receiver;
          return Receiver?.Any() == true;
        default:
          return base.TryGetValue(key, out value);
      }

    }

    protected override IEnumerable<KeyValuePair<string, object>> GetElementPairs()
    {
      foreach (var kvp in base.GetElementPairs()) yield return kvp;
      if (Identifier?.Any() == true) yield return new KeyValuePair<string,object>("identifier",Identifier);
      if (BasedOn?.Any() == true) yield return new KeyValuePair<string,object>("basedOn",BasedOn);
      if (PartOf?.Any() == true) yield return new KeyValuePair<string,object>("partOf",PartOf);
      if (StatusElement is not null) yield return new KeyValuePair<string,object>("status",StatusElement);
      if (Patient is not null) yield return new KeyValuePair<string,object>("patient",Patient);
      if (Type is not null) yield return new KeyValuePair<string,object>("type",Type);
      if (SuppliedItem is not null) yield return new KeyValuePair<string,object>("suppliedItem",SuppliedItem);
      if (Occurrence is not null) yield return new KeyValuePair<string,object>("occurrence",Occurrence);
      if (Supplier is not null) yield return new KeyValuePair<string,object>("supplier",Supplier);
      if (Destination is not null) yield return new KeyValuePair<string,object>("destination",Destination);
      if (Receiver?.Any() == true) yield return new KeyValuePair<string,object>("receiver",Receiver);
    }

  }

}

// end of file

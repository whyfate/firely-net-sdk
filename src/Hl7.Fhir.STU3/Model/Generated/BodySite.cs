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
  /// Specific and identified anatomical location
  /// </summary>
  [Serializable]
  [DataContract]
  [FhirType("BodySite","http://hl7.org/fhir/StructureDefinition/BodySite", IsResource=true)]
  public partial class BodySite : Hl7.Fhir.Model.DomainResource, IIdentifiable<List<Identifier>>
  {
    /// <summary>
    /// FHIR Type Name
    /// </summary>
    public override string TypeName { get { return "BodySite"; } }

    /// <summary>
    /// Bodysite identifier
    /// </summary>
    [FhirElement("identifier", InSummary=true, Order=90, FiveWs="id")]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.Identifier> Identifier
    {
      get { if(_Identifier==null) _Identifier = new List<Hl7.Fhir.Model.Identifier>(); return _Identifier; }
      set { _Identifier = value; OnPropertyChanged("Identifier"); }
    }

    private List<Hl7.Fhir.Model.Identifier> _Identifier;

    /// <summary>
    /// Whether this body site record is in active use
    /// </summary>
    [FhirElement("active", InSummary=true, IsModifier=true, Order=100, FiveWs="status")]
    [DataMember]
    public Hl7.Fhir.Model.FhirBoolean ActiveElement
    {
      get { return _ActiveElement; }
      set { _ActiveElement = value; OnPropertyChanged("ActiveElement"); }
    }

    private Hl7.Fhir.Model.FhirBoolean _ActiveElement;

    /// <summary>
    /// Whether this body site record is in active use
    /// </summary>
    /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
    [IgnoreDataMember]
    public bool? Active
    {
      get { return ActiveElement != null ? ActiveElement.Value : null; }
      set
      {
        if (value == null)
          ActiveElement = null;
        else
          ActiveElement = new Hl7.Fhir.Model.FhirBoolean(value);
        OnPropertyChanged("Active");
      }
    }

    /// <summary>
    /// Named anatomical location
    /// </summary>
    [FhirElement("code", InSummary=true, Order=110, FiveWs="what")]
    [DataMember]
    public Hl7.Fhir.Model.CodeableConcept Code
    {
      get { return _Code; }
      set { _Code = value; OnPropertyChanged("Code"); }
    }

    private Hl7.Fhir.Model.CodeableConcept _Code;

    /// <summary>
    /// Modification to location code
    /// </summary>
    [FhirElement("qualifier", Order=120, FiveWs="what")]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.CodeableConcept> Qualifier
    {
      get { if(_Qualifier==null) _Qualifier = new List<Hl7.Fhir.Model.CodeableConcept>(); return _Qualifier; }
      set { _Qualifier = value; OnPropertyChanged("Qualifier"); }
    }

    private List<Hl7.Fhir.Model.CodeableConcept> _Qualifier;

    /// <summary>
    /// Anatomical location description
    /// </summary>
    [FhirElement("description", InSummary=true, Order=130, FiveWs="what")]
    [DataMember]
    public Hl7.Fhir.Model.FhirString DescriptionElement
    {
      get { return _DescriptionElement; }
      set { _DescriptionElement = value; OnPropertyChanged("DescriptionElement"); }
    }

    private Hl7.Fhir.Model.FhirString _DescriptionElement;

    /// <summary>
    /// Anatomical location description
    /// </summary>
    /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
    [IgnoreDataMember]
    public string Description
    {
      get { return DescriptionElement != null ? DescriptionElement.Value : null; }
      set
      {
        if (value == null)
          DescriptionElement = null;
        else
          DescriptionElement = new Hl7.Fhir.Model.FhirString(value);
        OnPropertyChanged("Description");
      }
    }

    /// <summary>
    /// Attached images
    /// </summary>
    [FhirElement("image", Order=140, FiveWs="what")]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.Attachment> Image
    {
      get { if(_Image==null) _Image = new List<Hl7.Fhir.Model.Attachment>(); return _Image; }
      set { _Image = value; OnPropertyChanged("Image"); }
    }

    private List<Hl7.Fhir.Model.Attachment> _Image;

    /// <summary>
    /// Who this is about
    /// </summary>
    [FhirElement("patient", InSummary=true, Order=150, FiveWs="who.focus")]
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

    List<Identifier> IIdentifiable<List<Identifier>>.Identifier { get => Identifier; set => Identifier = value; }

    public override IDeepCopyable CopyTo(IDeepCopyable other)
    {
      var dest = other as BodySite;

      if (dest == null)
      {
        throw new ArgumentException("Can only copy to an object of the same type", "other");
      }

      base.CopyTo(dest);
      if(Identifier != null) dest.Identifier = new List<Hl7.Fhir.Model.Identifier>(Identifier.DeepCopy());
      if(ActiveElement != null) dest.ActiveElement = (Hl7.Fhir.Model.FhirBoolean)ActiveElement.DeepCopy();
      if(Code != null) dest.Code = (Hl7.Fhir.Model.CodeableConcept)Code.DeepCopy();
      if(Qualifier != null) dest.Qualifier = new List<Hl7.Fhir.Model.CodeableConcept>(Qualifier.DeepCopy());
      if(DescriptionElement != null) dest.DescriptionElement = (Hl7.Fhir.Model.FhirString)DescriptionElement.DeepCopy();
      if(Image != null) dest.Image = new List<Hl7.Fhir.Model.Attachment>(Image.DeepCopy());
      if(Patient != null) dest.Patient = (Hl7.Fhir.Model.ResourceReference)Patient.DeepCopy();
      return dest;
    }

    public override IDeepCopyable DeepCopy()
    {
      return CopyTo(new BodySite());
    }

    ///<inheritdoc />
    public override bool Matches(IDeepComparable other)
    {
      var otherT = other as BodySite;
      if(otherT == null) return false;

      if(!base.Matches(otherT)) return false;
      if( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
      if( !DeepComparable.Matches(ActiveElement, otherT.ActiveElement)) return false;
      if( !DeepComparable.Matches(Code, otherT.Code)) return false;
      if( !DeepComparable.Matches(Qualifier, otherT.Qualifier)) return false;
      if( !DeepComparable.Matches(DescriptionElement, otherT.DescriptionElement)) return false;
      if( !DeepComparable.Matches(Image, otherT.Image)) return false;
      if( !DeepComparable.Matches(Patient, otherT.Patient)) return false;

      return true;
    }

    public override bool IsExactly(IDeepComparable other)
    {
      var otherT = other as BodySite;
      if(otherT == null) return false;

      if(!base.IsExactly(otherT)) return false;
      if( !DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
      if( !DeepComparable.IsExactly(ActiveElement, otherT.ActiveElement)) return false;
      if( !DeepComparable.IsExactly(Code, otherT.Code)) return false;
      if( !DeepComparable.IsExactly(Qualifier, otherT.Qualifier)) return false;
      if( !DeepComparable.IsExactly(DescriptionElement, otherT.DescriptionElement)) return false;
      if( !DeepComparable.IsExactly(Image, otherT.Image)) return false;
      if( !DeepComparable.IsExactly(Patient, otherT.Patient)) return false;

      return true;
    }

    [IgnoreDataMember]
    public override IEnumerable<Base> Children
    {
      get
      {
        foreach (var item in base.Children) yield return item;
        foreach (var elem in Identifier) { if (elem != null) yield return elem; }
        if (ActiveElement != null) yield return ActiveElement;
        if (Code != null) yield return Code;
        foreach (var elem in Qualifier) { if (elem != null) yield return elem; }
        if (DescriptionElement != null) yield return DescriptionElement;
        foreach (var elem in Image) { if (elem != null) yield return elem; }
        if (Patient != null) yield return Patient;
      }
    }

    [IgnoreDataMember]
    public override IEnumerable<ElementValue> NamedChildren
    {
      get
      {
        foreach (var item in base.NamedChildren) yield return item;
        foreach (var elem in Identifier) { if (elem != null) yield return new ElementValue("identifier", elem); }
        if (ActiveElement != null) yield return new ElementValue("active", ActiveElement);
        if (Code != null) yield return new ElementValue("code", Code);
        foreach (var elem in Qualifier) { if (elem != null) yield return new ElementValue("qualifier", elem); }
        if (DescriptionElement != null) yield return new ElementValue("description", DescriptionElement);
        foreach (var elem in Image) { if (elem != null) yield return new ElementValue("image", elem); }
        if (Patient != null) yield return new ElementValue("patient", Patient);
      }
    }

    protected override bool TryGetValue(string key, out object value)
    {
      switch (key)
      {
        case "identifier":
          value = Identifier;
          return Identifier?.Any() == true;
        case "active":
          value = ActiveElement;
          return ActiveElement is not null;
        case "code":
          value = Code;
          return Code is not null;
        case "qualifier":
          value = Qualifier;
          return Qualifier?.Any() == true;
        case "description":
          value = DescriptionElement;
          return DescriptionElement is not null;
        case "image":
          value = Image;
          return Image?.Any() == true;
        case "patient":
          value = Patient;
          return Patient is not null;
        default:
          return base.TryGetValue(key, out value);
      }

    }

    protected override IEnumerable<KeyValuePair<string, object>> GetElementPairs()
    {
      foreach (var kvp in base.GetElementPairs()) yield return kvp;
      if (Identifier?.Any() == true) yield return new KeyValuePair<string,object>("identifier",Identifier);
      if (ActiveElement is not null) yield return new KeyValuePair<string,object>("active",ActiveElement);
      if (Code is not null) yield return new KeyValuePair<string,object>("code",Code);
      if (Qualifier?.Any() == true) yield return new KeyValuePair<string,object>("qualifier",Qualifier);
      if (DescriptionElement is not null) yield return new KeyValuePair<string,object>("description",DescriptionElement);
      if (Image?.Any() == true) yield return new KeyValuePair<string,object>("image",Image);
      if (Patient is not null) yield return new KeyValuePair<string,object>("patient",Patient);
    }

  }

}

// end of file

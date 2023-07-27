// <auto-generated/>
// Contents of: hl7.fhir.r4b.core version: 4.3.0

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
  /// System of unique identification
  /// </summary>
  [Serializable]
  [DataContract]
  [FhirType("NamingSystem","http://hl7.org/fhir/StructureDefinition/NamingSystem", IsResource=true)]
  public partial class NamingSystem : Hl7.Fhir.Model.DomainResource
  {
    /// <summary>
    /// FHIR Type Name
    /// </summary>
    public override string TypeName { get { return "NamingSystem"; } }

    /// <summary>
    /// Identifies the purpose of the naming system.
    /// (url: http://hl7.org/fhir/ValueSet/namingsystem-type)
    /// (system: http://hl7.org/fhir/namingsystem-type)
    /// </summary>
    [FhirEnumeration("NamingSystemType", "http://hl7.org/fhir/ValueSet/namingsystem-type", "http://hl7.org/fhir/namingsystem-type")]
    public enum NamingSystemType
    {
      /// <summary>
      /// The naming system is used to define concepts and symbols to represent those concepts; e.g. UCUM, LOINC, NDC code, local lab codes, etc.
      /// (system: http://hl7.org/fhir/namingsystem-type)
      /// </summary>
      [EnumLiteral("codesystem"), Description("Code System")]
      Codesystem,
      /// <summary>
      /// The naming system is used to manage identifiers (e.g. license numbers, order numbers, etc.).
      /// (system: http://hl7.org/fhir/namingsystem-type)
      /// </summary>
      [EnumLiteral("identifier"), Description("Identifier")]
      Identifier,
      /// <summary>
      /// The naming system is used as the root for other identifiers and naming systems.
      /// (system: http://hl7.org/fhir/namingsystem-type)
      /// </summary>
      [EnumLiteral("root"), Description("Root")]
      Root,
    }

    /// <summary>
    /// Identifies the style of unique identifier used to identify a namespace.
    /// (url: http://hl7.org/fhir/ValueSet/namingsystem-identifier-type)
    /// (system: http://hl7.org/fhir/namingsystem-identifier-type)
    /// </summary>
    [FhirEnumeration("NamingSystemIdentifierType", "http://hl7.org/fhir/ValueSet/namingsystem-identifier-type", "http://hl7.org/fhir/namingsystem-identifier-type")]
    public enum NamingSystemIdentifierType
    {
      /// <summary>
      /// An ISO object identifier; e.g. 1.2.3.4.5.
      /// (system: http://hl7.org/fhir/namingsystem-identifier-type)
      /// </summary>
      [EnumLiteral("oid"), Description("OID")]
      Oid,
      /// <summary>
      /// A universally unique identifier of the form a5afddf4-e880-459b-876e-e4591b0acc11.
      /// (system: http://hl7.org/fhir/namingsystem-identifier-type)
      /// </summary>
      [EnumLiteral("uuid"), Description("UUID")]
      Uuid,
      /// <summary>
      /// A uniform resource identifier (ideally a URL - uniform resource locator); e.g. http://unitsofmeasure.org.
      /// (system: http://hl7.org/fhir/namingsystem-identifier-type)
      /// </summary>
      [EnumLiteral("uri"), Description("URI")]
      Uri,
      /// <summary>
      /// Some other type of unique identifier; e.g. HL7-assigned reserved string such as LN for LOINC.
      /// (system: http://hl7.org/fhir/namingsystem-identifier-type)
      /// </summary>
      [EnumLiteral("other"), Description("Other")]
      Other,
    }

    /// <summary>
    /// Unique identifiers used for system
    /// </summary>
    [Serializable]
    [DataContract]
    [FhirType("NamingSystem#UniqueId", IsNestedType=true)]
    [BackboneType("NamingSystem.uniqueId")]
    public partial class UniqueIdComponent : Hl7.Fhir.Model.BackboneElement
    {
      /// <summary>
      /// FHIR Type Name
      /// </summary>
      public override string TypeName { get { return "NamingSystem#UniqueId"; } }

      /// <summary>
      /// oid | uuid | uri | other
      /// </summary>
      [FhirElement("type", InSummary=true, Order=40)]
      [DeclaredType(Type = typeof(Code))]
      [Binding("NamingSystemIdentifierType")]
      [Cardinality(Min=1,Max=1)]
      [DataMember]
      public Code<Hl7.Fhir.Model.NamingSystem.NamingSystemIdentifierType> TypeElement
      {
        get { return _TypeElement; }
        set { _TypeElement = value; OnPropertyChanged("TypeElement"); }
      }

      private Code<Hl7.Fhir.Model.NamingSystem.NamingSystemIdentifierType> _TypeElement;

      /// <summary>
      /// oid | uuid | uri | other
      /// </summary>
      /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
      [IgnoreDataMember]
      public Hl7.Fhir.Model.NamingSystem.NamingSystemIdentifierType? Type
      {
        get { return TypeElement != null ? TypeElement.Value : null; }
        set
        {
          if (value == null)
            TypeElement = null;
          else
            TypeElement = new Code<Hl7.Fhir.Model.NamingSystem.NamingSystemIdentifierType>(value);
          OnPropertyChanged("Type");
        }
      }

      /// <summary>
      /// The unique identifier
      /// </summary>
      [FhirElement("value", InSummary=true, Order=50, FiveWs="FiveWs.identifier")]
      [Cardinality(Min=1,Max=1)]
      [DataMember]
      public Hl7.Fhir.Model.FhirString ValueElement
      {
        get { return _ValueElement; }
        set { _ValueElement = value; OnPropertyChanged("ValueElement"); }
      }

      private Hl7.Fhir.Model.FhirString _ValueElement;

      /// <summary>
      /// The unique identifier
      /// </summary>
      /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
      [IgnoreDataMember]
      public string Value
      {
        get { return ValueElement != null ? ValueElement.Value : null; }
        set
        {
          if (value == null)
            ValueElement = null;
          else
            ValueElement = new Hl7.Fhir.Model.FhirString(value);
          OnPropertyChanged("Value");
        }
      }

      /// <summary>
      /// Is this the id that should be used for this type
      /// </summary>
      [FhirElement("preferred", Order=60)]
      [DataMember]
      public Hl7.Fhir.Model.FhirBoolean PreferredElement
      {
        get { return _PreferredElement; }
        set { _PreferredElement = value; OnPropertyChanged("PreferredElement"); }
      }

      private Hl7.Fhir.Model.FhirBoolean _PreferredElement;

      /// <summary>
      /// Is this the id that should be used for this type
      /// </summary>
      /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
      [IgnoreDataMember]
      public bool? Preferred
      {
        get { return PreferredElement != null ? PreferredElement.Value : null; }
        set
        {
          if (value == null)
            PreferredElement = null;
          else
            PreferredElement = new Hl7.Fhir.Model.FhirBoolean(value);
          OnPropertyChanged("Preferred");
        }
      }

      /// <summary>
      /// Notes about identifier usage
      /// </summary>
      [FhirElement("comment", Order=70)]
      [DataMember]
      public Hl7.Fhir.Model.FhirString CommentElement
      {
        get { return _CommentElement; }
        set { _CommentElement = value; OnPropertyChanged("CommentElement"); }
      }

      private Hl7.Fhir.Model.FhirString _CommentElement;

      /// <summary>
      /// Notes about identifier usage
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
            CommentElement = new Hl7.Fhir.Model.FhirString(value);
          OnPropertyChanged("Comment");
        }
      }

      /// <summary>
      /// When is identifier valid?
      /// </summary>
      [FhirElement("period", Order=80)]
      [DataMember]
      public Hl7.Fhir.Model.Period Period
      {
        get { return _Period; }
        set { _Period = value; OnPropertyChanged("Period"); }
      }

      private Hl7.Fhir.Model.Period _Period;

      public override IDeepCopyable CopyTo(IDeepCopyable other)
      {
        var dest = other as UniqueIdComponent;

        if (dest == null)
        {
          throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        base.CopyTo(dest);
        if(TypeElement != null) dest.TypeElement = (Code<Hl7.Fhir.Model.NamingSystem.NamingSystemIdentifierType>)TypeElement.DeepCopy();
        if(ValueElement != null) dest.ValueElement = (Hl7.Fhir.Model.FhirString)ValueElement.DeepCopy();
        if(PreferredElement != null) dest.PreferredElement = (Hl7.Fhir.Model.FhirBoolean)PreferredElement.DeepCopy();
        if(CommentElement != null) dest.CommentElement = (Hl7.Fhir.Model.FhirString)CommentElement.DeepCopy();
        if(Period != null) dest.Period = (Hl7.Fhir.Model.Period)Period.DeepCopy();
        return dest;
      }

      public override IDeepCopyable DeepCopy()
      {
        return CopyTo(new UniqueIdComponent());
      }

      ///<inheritdoc />
      public override bool Matches(IDeepComparable other)
      {
        var otherT = other as UniqueIdComponent;
        if(otherT == null) return false;

        if(!base.Matches(otherT)) return false;
        if( !DeepComparable.Matches(TypeElement, otherT.TypeElement)) return false;
        if( !DeepComparable.Matches(ValueElement, otherT.ValueElement)) return false;
        if( !DeepComparable.Matches(PreferredElement, otherT.PreferredElement)) return false;
        if( !DeepComparable.Matches(CommentElement, otherT.CommentElement)) return false;
        if( !DeepComparable.Matches(Period, otherT.Period)) return false;

        return true;
      }

      public override bool IsExactly(IDeepComparable other)
      {
        var otherT = other as UniqueIdComponent;
        if(otherT == null) return false;

        if(!base.IsExactly(otherT)) return false;
        if( !DeepComparable.IsExactly(TypeElement, otherT.TypeElement)) return false;
        if( !DeepComparable.IsExactly(ValueElement, otherT.ValueElement)) return false;
        if( !DeepComparable.IsExactly(PreferredElement, otherT.PreferredElement)) return false;
        if( !DeepComparable.IsExactly(CommentElement, otherT.CommentElement)) return false;
        if( !DeepComparable.IsExactly(Period, otherT.Period)) return false;

        return true;
      }

      [IgnoreDataMember]
      public override IEnumerable<Base> Children
      {
        get
        {
          foreach (var item in base.Children) yield return item;
          if (TypeElement != null) yield return TypeElement;
          if (ValueElement != null) yield return ValueElement;
          if (PreferredElement != null) yield return PreferredElement;
          if (CommentElement != null) yield return CommentElement;
          if (Period != null) yield return Period;
        }
      }

      [IgnoreDataMember]
      public override IEnumerable<ElementValue> NamedChildren
      {
        get
        {
          foreach (var item in base.NamedChildren) yield return item;
          if (TypeElement != null) yield return new ElementValue("type", TypeElement);
          if (ValueElement != null) yield return new ElementValue("value", ValueElement);
          if (PreferredElement != null) yield return new ElementValue("preferred", PreferredElement);
          if (CommentElement != null) yield return new ElementValue("comment", CommentElement);
          if (Period != null) yield return new ElementValue("period", Period);
        }
      }

      protected override bool TryGetValue(string key, out object value)
      {
        switch (key)
        {
          case "type":
            value = TypeElement;
            return TypeElement is not null;
          case "value":
            value = ValueElement;
            return ValueElement is not null;
          case "preferred":
            value = PreferredElement;
            return PreferredElement is not null;
          case "comment":
            value = CommentElement;
            return CommentElement is not null;
          case "period":
            value = Period;
            return Period is not null;
          default:
            return base.TryGetValue(key, out value);
        }

      }

      protected override IEnumerable<KeyValuePair<string, object>> GetElementPairs()
      {
        foreach (var kvp in base.GetElementPairs()) yield return kvp;
        if (TypeElement is not null) yield return new KeyValuePair<string,object>("type",TypeElement);
        if (ValueElement is not null) yield return new KeyValuePair<string,object>("value",ValueElement);
        if (PreferredElement is not null) yield return new KeyValuePair<string,object>("preferred",PreferredElement);
        if (CommentElement is not null) yield return new KeyValuePair<string,object>("comment",CommentElement);
        if (Period is not null) yield return new KeyValuePair<string,object>("period",Period);
      }

    }

    /// <summary>
    /// Name for this naming system (computer friendly)
    /// </summary>
    [FhirElement("name", InSummary=true, Order=90)]
    [Cardinality(Min=1,Max=1)]
    [DataMember]
    public Hl7.Fhir.Model.FhirString NameElement
    {
      get { return _NameElement; }
      set { _NameElement = value; OnPropertyChanged("NameElement"); }
    }

    private Hl7.Fhir.Model.FhirString _NameElement;

    /// <summary>
    /// Name for this naming system (computer friendly)
    /// </summary>
    /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
    [IgnoreDataMember]
    public string Name
    {
      get { return NameElement != null ? NameElement.Value : null; }
      set
      {
        if (value == null)
          NameElement = null;
        else
          NameElement = new Hl7.Fhir.Model.FhirString(value);
        OnPropertyChanged("Name");
      }
    }

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
    /// codesystem | identifier | root
    /// </summary>
    [FhirElement("kind", InSummary=true, Order=110, FiveWs="FiveWs.class")]
    [DeclaredType(Type = typeof(Code))]
    [Binding("NamingSystemType")]
    [Cardinality(Min=1,Max=1)]
    [DataMember]
    public Code<Hl7.Fhir.Model.NamingSystem.NamingSystemType> KindElement
    {
      get { return _KindElement; }
      set { _KindElement = value; OnPropertyChanged("KindElement"); }
    }

    private Code<Hl7.Fhir.Model.NamingSystem.NamingSystemType> _KindElement;

    /// <summary>
    /// codesystem | identifier | root
    /// </summary>
    /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
    [IgnoreDataMember]
    public Hl7.Fhir.Model.NamingSystem.NamingSystemType? Kind
    {
      get { return KindElement != null ? KindElement.Value : null; }
      set
      {
        if (value == null)
          KindElement = null;
        else
          KindElement = new Code<Hl7.Fhir.Model.NamingSystem.NamingSystemType>(value);
        OnPropertyChanged("Kind");
      }
    }

    /// <summary>
    /// Date last changed
    /// </summary>
    [FhirElement("date", InSummary=true, Order=120, FiveWs="FiveWs.recorded")]
    [Cardinality(Min=1,Max=1)]
    [DataMember]
    public Hl7.Fhir.Model.FhirDateTime DateElement
    {
      get { return _DateElement; }
      set { _DateElement = value; OnPropertyChanged("DateElement"); }
    }

    private Hl7.Fhir.Model.FhirDateTime _DateElement;

    /// <summary>
    /// Date last changed
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

    /// <summary>
    /// Name of the publisher (organization or individual)
    /// </summary>
    [FhirElement("publisher", InSummary=true, Order=130, FiveWs="FiveWs.witness")]
    [DataMember]
    public Hl7.Fhir.Model.FhirString PublisherElement
    {
      get { return _PublisherElement; }
      set { _PublisherElement = value; OnPropertyChanged("PublisherElement"); }
    }

    private Hl7.Fhir.Model.FhirString _PublisherElement;

    /// <summary>
    /// Name of the publisher (organization or individual)
    /// </summary>
    /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
    [IgnoreDataMember]
    public string Publisher
    {
      get { return PublisherElement != null ? PublisherElement.Value : null; }
      set
      {
        if (value == null)
          PublisherElement = null;
        else
          PublisherElement = new Hl7.Fhir.Model.FhirString(value);
        OnPropertyChanged("Publisher");
      }
    }

    /// <summary>
    /// Contact details for the publisher
    /// </summary>
    [FhirElement("contact", InSummary=true, Order=140)]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.ContactDetail> Contact
    {
      get { if(_Contact==null) _Contact = new List<Hl7.Fhir.Model.ContactDetail>(); return _Contact; }
      set { _Contact = value; OnPropertyChanged("Contact"); }
    }

    private List<Hl7.Fhir.Model.ContactDetail> _Contact;

    /// <summary>
    /// Who maintains system namespace?
    /// </summary>
    [FhirElement("responsible", Order=150, FiveWs="FiveWs.witness")]
    [DataMember]
    public Hl7.Fhir.Model.FhirString ResponsibleElement
    {
      get { return _ResponsibleElement; }
      set { _ResponsibleElement = value; OnPropertyChanged("ResponsibleElement"); }
    }

    private Hl7.Fhir.Model.FhirString _ResponsibleElement;

    /// <summary>
    /// Who maintains system namespace?
    /// </summary>
    /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
    [IgnoreDataMember]
    public string Responsible
    {
      get { return ResponsibleElement != null ? ResponsibleElement.Value : null; }
      set
      {
        if (value == null)
          ResponsibleElement = null;
        else
          ResponsibleElement = new Hl7.Fhir.Model.FhirString(value);
        OnPropertyChanged("Responsible");
      }
    }

    /// <summary>
    /// e.g. driver,  provider,  patient, bank etc.
    /// </summary>
    [FhirElement("type", Order=160)]
    [Binding("IdentifierType")]
    [DataMember]
    public Hl7.Fhir.Model.CodeableConcept Type
    {
      get { return _Type; }
      set { _Type = value; OnPropertyChanged("Type"); }
    }

    private Hl7.Fhir.Model.CodeableConcept _Type;

    /// <summary>
    /// Natural language description of the naming system
    /// </summary>
    [FhirElement("description", Order=170)]
    [DataMember]
    public Hl7.Fhir.Model.Markdown DescriptionElement
    {
      get { return _DescriptionElement; }
      set { _DescriptionElement = value; OnPropertyChanged("DescriptionElement"); }
    }

    private Hl7.Fhir.Model.Markdown _DescriptionElement;

    /// <summary>
    /// Natural language description of the naming system
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
          DescriptionElement = new Hl7.Fhir.Model.Markdown(value);
        OnPropertyChanged("Description");
      }
    }

    /// <summary>
    /// The context that the content is intended to support
    /// </summary>
    [FhirElement("useContext", InSummary=true, Order=180)]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.UsageContext> UseContext
    {
      get { if(_UseContext==null) _UseContext = new List<Hl7.Fhir.Model.UsageContext>(); return _UseContext; }
      set { _UseContext = value; OnPropertyChanged("UseContext"); }
    }

    private List<Hl7.Fhir.Model.UsageContext> _UseContext;

    /// <summary>
    /// Intended jurisdiction for naming system (if applicable)
    /// </summary>
    [FhirElement("jurisdiction", InSummary=true, Order=190)]
    [Binding("Jurisdiction")]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.CodeableConcept> Jurisdiction
    {
      get { if(_Jurisdiction==null) _Jurisdiction = new List<Hl7.Fhir.Model.CodeableConcept>(); return _Jurisdiction; }
      set { _Jurisdiction = value; OnPropertyChanged("Jurisdiction"); }
    }

    private List<Hl7.Fhir.Model.CodeableConcept> _Jurisdiction;

    /// <summary>
    /// How/where is it used
    /// </summary>
    [FhirElement("usage", Order=200)]
    [DataMember]
    public Hl7.Fhir.Model.FhirString UsageElement
    {
      get { return _UsageElement; }
      set { _UsageElement = value; OnPropertyChanged("UsageElement"); }
    }

    private Hl7.Fhir.Model.FhirString _UsageElement;

    /// <summary>
    /// How/where is it used
    /// </summary>
    /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
    [IgnoreDataMember]
    public string Usage
    {
      get { return UsageElement != null ? UsageElement.Value : null; }
      set
      {
        if (value == null)
          UsageElement = null;
        else
          UsageElement = new Hl7.Fhir.Model.FhirString(value);
        OnPropertyChanged("Usage");
      }
    }

    /// <summary>
    /// Unique identifiers used for system
    /// </summary>
    [FhirElement("uniqueId", InSummary=true, Order=210)]
    [Cardinality(Min=1,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.NamingSystem.UniqueIdComponent> UniqueId
    {
      get { if(_UniqueId==null) _UniqueId = new List<Hl7.Fhir.Model.NamingSystem.UniqueIdComponent>(); return _UniqueId; }
      set { _UniqueId = value; OnPropertyChanged("UniqueId"); }
    }

    private List<Hl7.Fhir.Model.NamingSystem.UniqueIdComponent> _UniqueId;

    public override IDeepCopyable CopyTo(IDeepCopyable other)
    {
      var dest = other as NamingSystem;

      if (dest == null)
      {
        throw new ArgumentException("Can only copy to an object of the same type", "other");
      }

      base.CopyTo(dest);
      if(NameElement != null) dest.NameElement = (Hl7.Fhir.Model.FhirString)NameElement.DeepCopy();
      if(StatusElement != null) dest.StatusElement = (Code<Hl7.Fhir.Model.PublicationStatus>)StatusElement.DeepCopy();
      if(KindElement != null) dest.KindElement = (Code<Hl7.Fhir.Model.NamingSystem.NamingSystemType>)KindElement.DeepCopy();
      if(DateElement != null) dest.DateElement = (Hl7.Fhir.Model.FhirDateTime)DateElement.DeepCopy();
      if(PublisherElement != null) dest.PublisherElement = (Hl7.Fhir.Model.FhirString)PublisherElement.DeepCopy();
      if(Contact != null) dest.Contact = new List<Hl7.Fhir.Model.ContactDetail>(Contact.DeepCopy());
      if(ResponsibleElement != null) dest.ResponsibleElement = (Hl7.Fhir.Model.FhirString)ResponsibleElement.DeepCopy();
      if(Type != null) dest.Type = (Hl7.Fhir.Model.CodeableConcept)Type.DeepCopy();
      if(DescriptionElement != null) dest.DescriptionElement = (Hl7.Fhir.Model.Markdown)DescriptionElement.DeepCopy();
      if(UseContext != null) dest.UseContext = new List<Hl7.Fhir.Model.UsageContext>(UseContext.DeepCopy());
      if(Jurisdiction != null) dest.Jurisdiction = new List<Hl7.Fhir.Model.CodeableConcept>(Jurisdiction.DeepCopy());
      if(UsageElement != null) dest.UsageElement = (Hl7.Fhir.Model.FhirString)UsageElement.DeepCopy();
      if(UniqueId != null) dest.UniqueId = new List<Hl7.Fhir.Model.NamingSystem.UniqueIdComponent>(UniqueId.DeepCopy());
      return dest;
    }

    public override IDeepCopyable DeepCopy()
    {
      return CopyTo(new NamingSystem());
    }

    ///<inheritdoc />
    public override bool Matches(IDeepComparable other)
    {
      var otherT = other as NamingSystem;
      if(otherT == null) return false;

      if(!base.Matches(otherT)) return false;
      if( !DeepComparable.Matches(NameElement, otherT.NameElement)) return false;
      if( !DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
      if( !DeepComparable.Matches(KindElement, otherT.KindElement)) return false;
      if( !DeepComparable.Matches(DateElement, otherT.DateElement)) return false;
      if( !DeepComparable.Matches(PublisherElement, otherT.PublisherElement)) return false;
      if( !DeepComparable.Matches(Contact, otherT.Contact)) return false;
      if( !DeepComparable.Matches(ResponsibleElement, otherT.ResponsibleElement)) return false;
      if( !DeepComparable.Matches(Type, otherT.Type)) return false;
      if( !DeepComparable.Matches(DescriptionElement, otherT.DescriptionElement)) return false;
      if( !DeepComparable.Matches(UseContext, otherT.UseContext)) return false;
      if( !DeepComparable.Matches(Jurisdiction, otherT.Jurisdiction)) return false;
      if( !DeepComparable.Matches(UsageElement, otherT.UsageElement)) return false;
      if( !DeepComparable.Matches(UniqueId, otherT.UniqueId)) return false;

      return true;
    }

    public override bool IsExactly(IDeepComparable other)
    {
      var otherT = other as NamingSystem;
      if(otherT == null) return false;

      if(!base.IsExactly(otherT)) return false;
      if( !DeepComparable.IsExactly(NameElement, otherT.NameElement)) return false;
      if( !DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
      if( !DeepComparable.IsExactly(KindElement, otherT.KindElement)) return false;
      if( !DeepComparable.IsExactly(DateElement, otherT.DateElement)) return false;
      if( !DeepComparable.IsExactly(PublisherElement, otherT.PublisherElement)) return false;
      if( !DeepComparable.IsExactly(Contact, otherT.Contact)) return false;
      if( !DeepComparable.IsExactly(ResponsibleElement, otherT.ResponsibleElement)) return false;
      if( !DeepComparable.IsExactly(Type, otherT.Type)) return false;
      if( !DeepComparable.IsExactly(DescriptionElement, otherT.DescriptionElement)) return false;
      if( !DeepComparable.IsExactly(UseContext, otherT.UseContext)) return false;
      if( !DeepComparable.IsExactly(Jurisdiction, otherT.Jurisdiction)) return false;
      if( !DeepComparable.IsExactly(UsageElement, otherT.UsageElement)) return false;
      if( !DeepComparable.IsExactly(UniqueId, otherT.UniqueId)) return false;

      return true;
    }

    [IgnoreDataMember]
    public override IEnumerable<Base> Children
    {
      get
      {
        foreach (var item in base.Children) yield return item;
        if (NameElement != null) yield return NameElement;
        if (StatusElement != null) yield return StatusElement;
        if (KindElement != null) yield return KindElement;
        if (DateElement != null) yield return DateElement;
        if (PublisherElement != null) yield return PublisherElement;
        foreach (var elem in Contact) { if (elem != null) yield return elem; }
        if (ResponsibleElement != null) yield return ResponsibleElement;
        if (Type != null) yield return Type;
        if (DescriptionElement != null) yield return DescriptionElement;
        foreach (var elem in UseContext) { if (elem != null) yield return elem; }
        foreach (var elem in Jurisdiction) { if (elem != null) yield return elem; }
        if (UsageElement != null) yield return UsageElement;
        foreach (var elem in UniqueId) { if (elem != null) yield return elem; }
      }
    }

    [IgnoreDataMember]
    public override IEnumerable<ElementValue> NamedChildren
    {
      get
      {
        foreach (var item in base.NamedChildren) yield return item;
        if (NameElement != null) yield return new ElementValue("name", NameElement);
        if (StatusElement != null) yield return new ElementValue("status", StatusElement);
        if (KindElement != null) yield return new ElementValue("kind", KindElement);
        if (DateElement != null) yield return new ElementValue("date", DateElement);
        if (PublisherElement != null) yield return new ElementValue("publisher", PublisherElement);
        foreach (var elem in Contact) { if (elem != null) yield return new ElementValue("contact", elem); }
        if (ResponsibleElement != null) yield return new ElementValue("responsible", ResponsibleElement);
        if (Type != null) yield return new ElementValue("type", Type);
        if (DescriptionElement != null) yield return new ElementValue("description", DescriptionElement);
        foreach (var elem in UseContext) { if (elem != null) yield return new ElementValue("useContext", elem); }
        foreach (var elem in Jurisdiction) { if (elem != null) yield return new ElementValue("jurisdiction", elem); }
        if (UsageElement != null) yield return new ElementValue("usage", UsageElement);
        foreach (var elem in UniqueId) { if (elem != null) yield return new ElementValue("uniqueId", elem); }
      }
    }

    protected override bool TryGetValue(string key, out object value)
    {
      switch (key)
      {
        case "name":
          value = NameElement;
          return NameElement is not null;
        case "status":
          value = StatusElement;
          return StatusElement is not null;
        case "kind":
          value = KindElement;
          return KindElement is not null;
        case "date":
          value = DateElement;
          return DateElement is not null;
        case "publisher":
          value = PublisherElement;
          return PublisherElement is not null;
        case "contact":
          value = Contact;
          return Contact?.Any() == true;
        case "responsible":
          value = ResponsibleElement;
          return ResponsibleElement is not null;
        case "type":
          value = Type;
          return Type is not null;
        case "description":
          value = DescriptionElement;
          return DescriptionElement is not null;
        case "useContext":
          value = UseContext;
          return UseContext?.Any() == true;
        case "jurisdiction":
          value = Jurisdiction;
          return Jurisdiction?.Any() == true;
        case "usage":
          value = UsageElement;
          return UsageElement is not null;
        case "uniqueId":
          value = UniqueId;
          return UniqueId?.Any() == true;
        default:
          return base.TryGetValue(key, out value);
      }

    }

    protected override IEnumerable<KeyValuePair<string, object>> GetElementPairs()
    {
      foreach (var kvp in base.GetElementPairs()) yield return kvp;
      if (NameElement is not null) yield return new KeyValuePair<string,object>("name",NameElement);
      if (StatusElement is not null) yield return new KeyValuePair<string,object>("status",StatusElement);
      if (KindElement is not null) yield return new KeyValuePair<string,object>("kind",KindElement);
      if (DateElement is not null) yield return new KeyValuePair<string,object>("date",DateElement);
      if (PublisherElement is not null) yield return new KeyValuePair<string,object>("publisher",PublisherElement);
      if (Contact?.Any() == true) yield return new KeyValuePair<string,object>("contact",Contact);
      if (ResponsibleElement is not null) yield return new KeyValuePair<string,object>("responsible",ResponsibleElement);
      if (Type is not null) yield return new KeyValuePair<string,object>("type",Type);
      if (DescriptionElement is not null) yield return new KeyValuePair<string,object>("description",DescriptionElement);
      if (UseContext?.Any() == true) yield return new KeyValuePair<string,object>("useContext",UseContext);
      if (Jurisdiction?.Any() == true) yield return new KeyValuePair<string,object>("jurisdiction",Jurisdiction);
      if (UsageElement is not null) yield return new KeyValuePair<string,object>("usage",UsageElement);
      if (UniqueId?.Any() == true) yield return new KeyValuePair<string,object>("uniqueId",UniqueId);
    }

  }

}

// end of file

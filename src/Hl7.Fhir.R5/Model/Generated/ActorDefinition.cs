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
  /// An application that exchanges data
  /// </summary>
  [Serializable]
  [DataContract]
  [FhirType("ActorDefinition","http://hl7.org/fhir/StructureDefinition/ActorDefinition", IsResource=true)]
  public partial class ActorDefinition : Hl7.Fhir.Model.DomainResource, IIdentifiable<List<Identifier>>
  {
    /// <summary>
    /// FHIR Type Name
    /// </summary>
    public override string TypeName { get { return "ActorDefinition"; } }

    /// <summary>
    /// Canonical identifier for this actor definition, represented as a URI (globally unique)
    /// </summary>
    [FhirElement("url", InSummary=true, Order=90, FiveWs="FiveWs.identifier")]
    [DataMember]
    public Hl7.Fhir.Model.FhirUri UrlElement
    {
      get { return _UrlElement; }
      set { _UrlElement = value; OnPropertyChanged("UrlElement"); }
    }

    private Hl7.Fhir.Model.FhirUri _UrlElement;

    /// <summary>
    /// Canonical identifier for this actor definition, represented as a URI (globally unique)
    /// </summary>
    /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
    [IgnoreDataMember]
    public string Url
    {
      get { return UrlElement != null ? UrlElement.Value : null; }
      set
      {
        if (value == null)
          UrlElement = null;
        else
          UrlElement = new Hl7.Fhir.Model.FhirUri(value);
        OnPropertyChanged("Url");
      }
    }

    /// <summary>
    /// Additional identifier for the actor definition (business identifier)
    /// </summary>
    [FhirElement("identifier", InSummary=true, Order=100, FiveWs="FiveWs.identifier")]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.Identifier> Identifier
    {
      get { if(_Identifier==null) _Identifier = new List<Hl7.Fhir.Model.Identifier>(); return _Identifier; }
      set { _Identifier = value; OnPropertyChanged("Identifier"); }
    }

    private List<Hl7.Fhir.Model.Identifier> _Identifier;

    /// <summary>
    /// Business version of the actor definition
    /// </summary>
    [FhirElement("version", InSummary=true, Order=110, FiveWs="FiveWs.version")]
    [DataMember]
    public Hl7.Fhir.Model.FhirString VersionElement
    {
      get { return _VersionElement; }
      set { _VersionElement = value; OnPropertyChanged("VersionElement"); }
    }

    private Hl7.Fhir.Model.FhirString _VersionElement;

    /// <summary>
    /// Business version of the actor definition
    /// </summary>
    /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
    [IgnoreDataMember]
    public string Version
    {
      get { return VersionElement != null ? VersionElement.Value : null; }
      set
      {
        if (value == null)
          VersionElement = null;
        else
          VersionElement = new Hl7.Fhir.Model.FhirString(value);
        OnPropertyChanged("Version");
      }
    }

    /// <summary>
    /// How to compare versions
    /// </summary>
    [FhirElement("versionAlgorithm", InSummary=true, Order=120, Choice=ChoiceType.DatatypeChoice)]
    [Binding("??")]
    [CLSCompliant(false)]
    [AllowedTypes(typeof(Hl7.Fhir.Model.FhirString),typeof(Hl7.Fhir.Model.Coding))]
    [DataMember]
    public Hl7.Fhir.Model.DataType VersionAlgorithm
    {
      get { return _VersionAlgorithm; }
      set { _VersionAlgorithm = value; OnPropertyChanged("VersionAlgorithm"); }
    }

    private Hl7.Fhir.Model.DataType _VersionAlgorithm;

    /// <summary>
    /// Name for this actor definition (computer friendly)
    /// </summary>
    [FhirElement("name", InSummary=true, Order=130)]
    [DataMember]
    public Hl7.Fhir.Model.FhirString NameElement
    {
      get { return _NameElement; }
      set { _NameElement = value; OnPropertyChanged("NameElement"); }
    }

    private Hl7.Fhir.Model.FhirString _NameElement;

    /// <summary>
    /// Name for this actor definition (computer friendly)
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
    /// Name for this actor definition (human friendly)
    /// </summary>
    [FhirElement("title", InSummary=true, Order=140)]
    [DataMember]
    public Hl7.Fhir.Model.FhirString TitleElement
    {
      get { return _TitleElement; }
      set { _TitleElement = value; OnPropertyChanged("TitleElement"); }
    }

    private Hl7.Fhir.Model.FhirString _TitleElement;

    /// <summary>
    /// Name for this actor definition (human friendly)
    /// </summary>
    /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
    [IgnoreDataMember]
    public string Title
    {
      get { return TitleElement != null ? TitleElement.Value : null; }
      set
      {
        if (value == null)
          TitleElement = null;
        else
          TitleElement = new Hl7.Fhir.Model.FhirString(value);
        OnPropertyChanged("Title");
      }
    }

    /// <summary>
    /// draft | active | retired | unknown
    /// </summary>
    [FhirElement("status", InSummary=true, IsModifier=true, Order=150, FiveWs="FiveWs.status")]
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
    /// For testing purposes, not real usage
    /// </summary>
    [FhirElement("experimental", InSummary=true, Order=160, FiveWs="FiveWs.class")]
    [DataMember]
    public Hl7.Fhir.Model.FhirBoolean ExperimentalElement
    {
      get { return _ExperimentalElement; }
      set { _ExperimentalElement = value; OnPropertyChanged("ExperimentalElement"); }
    }

    private Hl7.Fhir.Model.FhirBoolean _ExperimentalElement;

    /// <summary>
    /// For testing purposes, not real usage
    /// </summary>
    /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
    [IgnoreDataMember]
    public bool? Experimental
    {
      get { return ExperimentalElement != null ? ExperimentalElement.Value : null; }
      set
      {
        if (value == null)
          ExperimentalElement = null;
        else
          ExperimentalElement = new Hl7.Fhir.Model.FhirBoolean(value);
        OnPropertyChanged("Experimental");
      }
    }

    /// <summary>
    /// Date last changed
    /// </summary>
    [FhirElement("date", InSummary=true, Order=170, FiveWs="FiveWs.recorded")]
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
    /// Name of the publisher/steward (organization or individual)
    /// </summary>
    [FhirElement("publisher", InSummary=true, Order=180, FiveWs="FiveWs.witness")]
    [DataMember]
    public Hl7.Fhir.Model.FhirString PublisherElement
    {
      get { return _PublisherElement; }
      set { _PublisherElement = value; OnPropertyChanged("PublisherElement"); }
    }

    private Hl7.Fhir.Model.FhirString _PublisherElement;

    /// <summary>
    /// Name of the publisher/steward (organization or individual)
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
    [FhirElement("contact", InSummary=true, Order=190)]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.ContactDetail> Contact
    {
      get { if(_Contact==null) _Contact = new List<Hl7.Fhir.Model.ContactDetail>(); return _Contact; }
      set { _Contact = value; OnPropertyChanged("Contact"); }
    }

    private List<Hl7.Fhir.Model.ContactDetail> _Contact;

    /// <summary>
    /// Natural language description of the actor
    /// </summary>
    [FhirElement("description", Order=200)]
    [DataMember]
    public Hl7.Fhir.Model.Markdown DescriptionElement
    {
      get { return _DescriptionElement; }
      set { _DescriptionElement = value; OnPropertyChanged("DescriptionElement"); }
    }

    private Hl7.Fhir.Model.Markdown _DescriptionElement;

    /// <summary>
    /// Natural language description of the actor
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
    [FhirElement("useContext", InSummary=true, Order=210)]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.UsageContext> UseContext
    {
      get { if(_UseContext==null) _UseContext = new List<Hl7.Fhir.Model.UsageContext>(); return _UseContext; }
      set { _UseContext = value; OnPropertyChanged("UseContext"); }
    }

    private List<Hl7.Fhir.Model.UsageContext> _UseContext;

    /// <summary>
    /// Intended jurisdiction for actor definition (if applicable)
    /// </summary>
    [FhirElement("jurisdiction", InSummary=true, Order=220)]
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
    /// Why this actor definition is defined
    /// </summary>
    [FhirElement("purpose", Order=230, FiveWs="FiveWs.why[x]")]
    [DataMember]
    public Hl7.Fhir.Model.Markdown PurposeElement
    {
      get { return _PurposeElement; }
      set { _PurposeElement = value; OnPropertyChanged("PurposeElement"); }
    }

    private Hl7.Fhir.Model.Markdown _PurposeElement;

    /// <summary>
    /// Why this actor definition is defined
    /// </summary>
    /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
    [IgnoreDataMember]
    public string Purpose
    {
      get { return PurposeElement != null ? PurposeElement.Value : null; }
      set
      {
        if (value == null)
          PurposeElement = null;
        else
          PurposeElement = new Hl7.Fhir.Model.Markdown(value);
        OnPropertyChanged("Purpose");
      }
    }

    /// <summary>
    /// Use and/or publishing restrictions
    /// </summary>
    [FhirElement("copyright", Order=240)]
    [DataMember]
    public Hl7.Fhir.Model.Markdown CopyrightElement
    {
      get { return _CopyrightElement; }
      set { _CopyrightElement = value; OnPropertyChanged("CopyrightElement"); }
    }

    private Hl7.Fhir.Model.Markdown _CopyrightElement;

    /// <summary>
    /// Use and/or publishing restrictions
    /// </summary>
    /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
    [IgnoreDataMember]
    public string Copyright
    {
      get { return CopyrightElement != null ? CopyrightElement.Value : null; }
      set
      {
        if (value == null)
          CopyrightElement = null;
        else
          CopyrightElement = new Hl7.Fhir.Model.Markdown(value);
        OnPropertyChanged("Copyright");
      }
    }

    /// <summary>
    /// Copyright holder and year(s)
    /// </summary>
    [FhirElement("copyrightLabel", Order=250)]
    [DataMember]
    public Hl7.Fhir.Model.FhirString CopyrightLabelElement
    {
      get { return _CopyrightLabelElement; }
      set { _CopyrightLabelElement = value; OnPropertyChanged("CopyrightLabelElement"); }
    }

    private Hl7.Fhir.Model.FhirString _CopyrightLabelElement;

    /// <summary>
    /// Copyright holder and year(s)
    /// </summary>
    /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
    [IgnoreDataMember]
    public string CopyrightLabel
    {
      get { return CopyrightLabelElement != null ? CopyrightLabelElement.Value : null; }
      set
      {
        if (value == null)
          CopyrightLabelElement = null;
        else
          CopyrightLabelElement = new Hl7.Fhir.Model.FhirString(value);
        OnPropertyChanged("CopyrightLabel");
      }
    }

    /// <summary>
    /// person | system
    /// </summary>
    [FhirElement("type", InSummary=true, Order=260)]
    [DeclaredType(Type = typeof(Code))]
    [Binding("ExampleScenarioActorType")]
    [Cardinality(Min=1,Max=1)]
    [DataMember]
    public Code<Hl7.Fhir.Model.ExampleScenarioActorType> TypeElement
    {
      get { return _TypeElement; }
      set { _TypeElement = value; OnPropertyChanged("TypeElement"); }
    }

    private Code<Hl7.Fhir.Model.ExampleScenarioActorType> _TypeElement;

    /// <summary>
    /// person | system
    /// </summary>
    /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
    [IgnoreDataMember]
    public Hl7.Fhir.Model.ExampleScenarioActorType? Type
    {
      get { return TypeElement != null ? TypeElement.Value : null; }
      set
      {
        if (value == null)
          TypeElement = null;
        else
          TypeElement = new Code<Hl7.Fhir.Model.ExampleScenarioActorType>(value);
        OnPropertyChanged("Type");
      }
    }

    /// <summary>
    /// Functionality associated with the actor
    /// </summary>
    [FhirElement("documentation", Order=270)]
    [DataMember]
    public Hl7.Fhir.Model.Markdown DocumentationElement
    {
      get { return _DocumentationElement; }
      set { _DocumentationElement = value; OnPropertyChanged("DocumentationElement"); }
    }

    private Hl7.Fhir.Model.Markdown _DocumentationElement;

    /// <summary>
    /// Functionality associated with the actor
    /// </summary>
    /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
    [IgnoreDataMember]
    public string Documentation
    {
      get { return DocumentationElement != null ? DocumentationElement.Value : null; }
      set
      {
        if (value == null)
          DocumentationElement = null;
        else
          DocumentationElement = new Hl7.Fhir.Model.Markdown(value);
        OnPropertyChanged("Documentation");
      }
    }

    /// <summary>
    /// Reference to more information about the actor
    /// </summary>
    [FhirElement("reference", Order=280)]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.FhirUrl> ReferenceElement
    {
      get { if(_ReferenceElement==null) _ReferenceElement = new List<Hl7.Fhir.Model.FhirUrl>(); return _ReferenceElement; }
      set { _ReferenceElement = value; OnPropertyChanged("ReferenceElement"); }
    }

    private List<Hl7.Fhir.Model.FhirUrl> _ReferenceElement;

    /// <summary>
    /// Reference to more information about the actor
    /// </summary>
    /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
    [IgnoreDataMember]
    public IEnumerable<string> Reference
    {
      get { return ReferenceElement != null ? ReferenceElement.Select(elem => elem.Value) : null; }
      set
      {
        if (value == null)
          ReferenceElement = null;
        else
          ReferenceElement = new List<Hl7.Fhir.Model.FhirUrl>(value.Select(elem=>new Hl7.Fhir.Model.FhirUrl(elem)));
        OnPropertyChanged("Reference");
      }
    }

    /// <summary>
    /// CapabilityStatement for the actor (if applicable)
    /// </summary>
    [FhirElement("capabilities", Order=290)]
    [DataMember]
    public Hl7.Fhir.Model.Canonical CapabilitiesElement
    {
      get { return _CapabilitiesElement; }
      set { _CapabilitiesElement = value; OnPropertyChanged("CapabilitiesElement"); }
    }

    private Hl7.Fhir.Model.Canonical _CapabilitiesElement;

    /// <summary>
    /// CapabilityStatement for the actor (if applicable)
    /// </summary>
    /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
    [IgnoreDataMember]
    public string Capabilities
    {
      get { return CapabilitiesElement != null ? CapabilitiesElement.Value : null; }
      set
      {
        if (value == null)
          CapabilitiesElement = null;
        else
          CapabilitiesElement = new Hl7.Fhir.Model.Canonical(value);
        OnPropertyChanged("Capabilities");
      }
    }

    /// <summary>
    /// Definition of this actor in another context / IG
    /// </summary>
    [FhirElement("derivedFrom", Order=300)]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.Canonical> DerivedFromElement
    {
      get { if(_DerivedFromElement==null) _DerivedFromElement = new List<Hl7.Fhir.Model.Canonical>(); return _DerivedFromElement; }
      set { _DerivedFromElement = value; OnPropertyChanged("DerivedFromElement"); }
    }

    private List<Hl7.Fhir.Model.Canonical> _DerivedFromElement;

    /// <summary>
    /// Definition of this actor in another context / IG
    /// </summary>
    /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
    [IgnoreDataMember]
    public IEnumerable<string> DerivedFrom
    {
      get { return DerivedFromElement != null ? DerivedFromElement.Select(elem => elem.Value) : null; }
      set
      {
        if (value == null)
          DerivedFromElement = null;
        else
          DerivedFromElement = new List<Hl7.Fhir.Model.Canonical>(value.Select(elem=>new Hl7.Fhir.Model.Canonical(elem)));
        OnPropertyChanged("DerivedFrom");
      }
    }

    List<Identifier> IIdentifiable<List<Identifier>>.Identifier { get => Identifier; set => Identifier = value; }

    public override IDeepCopyable CopyTo(IDeepCopyable other)
    {
      var dest = other as ActorDefinition;

      if (dest == null)
      {
        throw new ArgumentException("Can only copy to an object of the same type", "other");
      }

      base.CopyTo(dest);
      if(UrlElement != null) dest.UrlElement = (Hl7.Fhir.Model.FhirUri)UrlElement.DeepCopy();
      if(Identifier != null) dest.Identifier = new List<Hl7.Fhir.Model.Identifier>(Identifier.DeepCopy());
      if(VersionElement != null) dest.VersionElement = (Hl7.Fhir.Model.FhirString)VersionElement.DeepCopy();
      if(VersionAlgorithm != null) dest.VersionAlgorithm = (Hl7.Fhir.Model.DataType)VersionAlgorithm.DeepCopy();
      if(NameElement != null) dest.NameElement = (Hl7.Fhir.Model.FhirString)NameElement.DeepCopy();
      if(TitleElement != null) dest.TitleElement = (Hl7.Fhir.Model.FhirString)TitleElement.DeepCopy();
      if(StatusElement != null) dest.StatusElement = (Code<Hl7.Fhir.Model.PublicationStatus>)StatusElement.DeepCopy();
      if(ExperimentalElement != null) dest.ExperimentalElement = (Hl7.Fhir.Model.FhirBoolean)ExperimentalElement.DeepCopy();
      if(DateElement != null) dest.DateElement = (Hl7.Fhir.Model.FhirDateTime)DateElement.DeepCopy();
      if(PublisherElement != null) dest.PublisherElement = (Hl7.Fhir.Model.FhirString)PublisherElement.DeepCopy();
      if(Contact != null) dest.Contact = new List<Hl7.Fhir.Model.ContactDetail>(Contact.DeepCopy());
      if(DescriptionElement != null) dest.DescriptionElement = (Hl7.Fhir.Model.Markdown)DescriptionElement.DeepCopy();
      if(UseContext != null) dest.UseContext = new List<Hl7.Fhir.Model.UsageContext>(UseContext.DeepCopy());
      if(Jurisdiction != null) dest.Jurisdiction = new List<Hl7.Fhir.Model.CodeableConcept>(Jurisdiction.DeepCopy());
      if(PurposeElement != null) dest.PurposeElement = (Hl7.Fhir.Model.Markdown)PurposeElement.DeepCopy();
      if(CopyrightElement != null) dest.CopyrightElement = (Hl7.Fhir.Model.Markdown)CopyrightElement.DeepCopy();
      if(CopyrightLabelElement != null) dest.CopyrightLabelElement = (Hl7.Fhir.Model.FhirString)CopyrightLabelElement.DeepCopy();
      if(TypeElement != null) dest.TypeElement = (Code<Hl7.Fhir.Model.ExampleScenarioActorType>)TypeElement.DeepCopy();
      if(DocumentationElement != null) dest.DocumentationElement = (Hl7.Fhir.Model.Markdown)DocumentationElement.DeepCopy();
      if(ReferenceElement != null) dest.ReferenceElement = new List<Hl7.Fhir.Model.FhirUrl>(ReferenceElement.DeepCopy());
      if(CapabilitiesElement != null) dest.CapabilitiesElement = (Hl7.Fhir.Model.Canonical)CapabilitiesElement.DeepCopy();
      if(DerivedFromElement != null) dest.DerivedFromElement = new List<Hl7.Fhir.Model.Canonical>(DerivedFromElement.DeepCopy());
      return dest;
    }

    public override IDeepCopyable DeepCopy()
    {
      return CopyTo(new ActorDefinition());
    }

    ///<inheritdoc />
    public override bool Matches(IDeepComparable other)
    {
      var otherT = other as ActorDefinition;
      if(otherT == null) return false;

      if(!base.Matches(otherT)) return false;
      if( !DeepComparable.Matches(UrlElement, otherT.UrlElement)) return false;
      if( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
      if( !DeepComparable.Matches(VersionElement, otherT.VersionElement)) return false;
      if( !DeepComparable.Matches(VersionAlgorithm, otherT.VersionAlgorithm)) return false;
      if( !DeepComparable.Matches(NameElement, otherT.NameElement)) return false;
      if( !DeepComparable.Matches(TitleElement, otherT.TitleElement)) return false;
      if( !DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
      if( !DeepComparable.Matches(ExperimentalElement, otherT.ExperimentalElement)) return false;
      if( !DeepComparable.Matches(DateElement, otherT.DateElement)) return false;
      if( !DeepComparable.Matches(PublisherElement, otherT.PublisherElement)) return false;
      if( !DeepComparable.Matches(Contact, otherT.Contact)) return false;
      if( !DeepComparable.Matches(DescriptionElement, otherT.DescriptionElement)) return false;
      if( !DeepComparable.Matches(UseContext, otherT.UseContext)) return false;
      if( !DeepComparable.Matches(Jurisdiction, otherT.Jurisdiction)) return false;
      if( !DeepComparable.Matches(PurposeElement, otherT.PurposeElement)) return false;
      if( !DeepComparable.Matches(CopyrightElement, otherT.CopyrightElement)) return false;
      if( !DeepComparable.Matches(CopyrightLabelElement, otherT.CopyrightLabelElement)) return false;
      if( !DeepComparable.Matches(TypeElement, otherT.TypeElement)) return false;
      if( !DeepComparable.Matches(DocumentationElement, otherT.DocumentationElement)) return false;
      if( !DeepComparable.Matches(ReferenceElement, otherT.ReferenceElement)) return false;
      if( !DeepComparable.Matches(CapabilitiesElement, otherT.CapabilitiesElement)) return false;
      if( !DeepComparable.Matches(DerivedFromElement, otherT.DerivedFromElement)) return false;

      return true;
    }

    public override bool IsExactly(IDeepComparable other)
    {
      var otherT = other as ActorDefinition;
      if(otherT == null) return false;

      if(!base.IsExactly(otherT)) return false;
      if( !DeepComparable.IsExactly(UrlElement, otherT.UrlElement)) return false;
      if( !DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
      if( !DeepComparable.IsExactly(VersionElement, otherT.VersionElement)) return false;
      if( !DeepComparable.IsExactly(VersionAlgorithm, otherT.VersionAlgorithm)) return false;
      if( !DeepComparable.IsExactly(NameElement, otherT.NameElement)) return false;
      if( !DeepComparable.IsExactly(TitleElement, otherT.TitleElement)) return false;
      if( !DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
      if( !DeepComparable.IsExactly(ExperimentalElement, otherT.ExperimentalElement)) return false;
      if( !DeepComparable.IsExactly(DateElement, otherT.DateElement)) return false;
      if( !DeepComparable.IsExactly(PublisherElement, otherT.PublisherElement)) return false;
      if( !DeepComparable.IsExactly(Contact, otherT.Contact)) return false;
      if( !DeepComparable.IsExactly(DescriptionElement, otherT.DescriptionElement)) return false;
      if( !DeepComparable.IsExactly(UseContext, otherT.UseContext)) return false;
      if( !DeepComparable.IsExactly(Jurisdiction, otherT.Jurisdiction)) return false;
      if( !DeepComparable.IsExactly(PurposeElement, otherT.PurposeElement)) return false;
      if( !DeepComparable.IsExactly(CopyrightElement, otherT.CopyrightElement)) return false;
      if( !DeepComparable.IsExactly(CopyrightLabelElement, otherT.CopyrightLabelElement)) return false;
      if( !DeepComparable.IsExactly(TypeElement, otherT.TypeElement)) return false;
      if( !DeepComparable.IsExactly(DocumentationElement, otherT.DocumentationElement)) return false;
      if( !DeepComparable.IsExactly(ReferenceElement, otherT.ReferenceElement)) return false;
      if( !DeepComparable.IsExactly(CapabilitiesElement, otherT.CapabilitiesElement)) return false;
      if( !DeepComparable.IsExactly(DerivedFromElement, otherT.DerivedFromElement)) return false;

      return true;
    }

    [IgnoreDataMember]
    public override IEnumerable<Base> Children
    {
      get
      {
        foreach (var item in base.Children) yield return item;
        if (UrlElement != null) yield return UrlElement;
        foreach (var elem in Identifier) { if (elem != null) yield return elem; }
        if (VersionElement != null) yield return VersionElement;
        if (VersionAlgorithm != null) yield return VersionAlgorithm;
        if (NameElement != null) yield return NameElement;
        if (TitleElement != null) yield return TitleElement;
        if (StatusElement != null) yield return StatusElement;
        if (ExperimentalElement != null) yield return ExperimentalElement;
        if (DateElement != null) yield return DateElement;
        if (PublisherElement != null) yield return PublisherElement;
        foreach (var elem in Contact) { if (elem != null) yield return elem; }
        if (DescriptionElement != null) yield return DescriptionElement;
        foreach (var elem in UseContext) { if (elem != null) yield return elem; }
        foreach (var elem in Jurisdiction) { if (elem != null) yield return elem; }
        if (PurposeElement != null) yield return PurposeElement;
        if (CopyrightElement != null) yield return CopyrightElement;
        if (CopyrightLabelElement != null) yield return CopyrightLabelElement;
        if (TypeElement != null) yield return TypeElement;
        if (DocumentationElement != null) yield return DocumentationElement;
        foreach (var elem in ReferenceElement) { if (elem != null) yield return elem; }
        if (CapabilitiesElement != null) yield return CapabilitiesElement;
        foreach (var elem in DerivedFromElement) { if (elem != null) yield return elem; }
      }
    }

    [IgnoreDataMember]
    public override IEnumerable<ElementValue> NamedChildren
    {
      get
      {
        foreach (var item in base.NamedChildren) yield return item;
        if (UrlElement != null) yield return new ElementValue("url", UrlElement);
        foreach (var elem in Identifier) { if (elem != null) yield return new ElementValue("identifier", elem); }
        if (VersionElement != null) yield return new ElementValue("version", VersionElement);
        if (VersionAlgorithm != null) yield return new ElementValue("versionAlgorithm", VersionAlgorithm);
        if (NameElement != null) yield return new ElementValue("name", NameElement);
        if (TitleElement != null) yield return new ElementValue("title", TitleElement);
        if (StatusElement != null) yield return new ElementValue("status", StatusElement);
        if (ExperimentalElement != null) yield return new ElementValue("experimental", ExperimentalElement);
        if (DateElement != null) yield return new ElementValue("date", DateElement);
        if (PublisherElement != null) yield return new ElementValue("publisher", PublisherElement);
        foreach (var elem in Contact) { if (elem != null) yield return new ElementValue("contact", elem); }
        if (DescriptionElement != null) yield return new ElementValue("description", DescriptionElement);
        foreach (var elem in UseContext) { if (elem != null) yield return new ElementValue("useContext", elem); }
        foreach (var elem in Jurisdiction) { if (elem != null) yield return new ElementValue("jurisdiction", elem); }
        if (PurposeElement != null) yield return new ElementValue("purpose", PurposeElement);
        if (CopyrightElement != null) yield return new ElementValue("copyright", CopyrightElement);
        if (CopyrightLabelElement != null) yield return new ElementValue("copyrightLabel", CopyrightLabelElement);
        if (TypeElement != null) yield return new ElementValue("type", TypeElement);
        if (DocumentationElement != null) yield return new ElementValue("documentation", DocumentationElement);
        foreach (var elem in ReferenceElement) { if (elem != null) yield return new ElementValue("reference", elem); }
        if (CapabilitiesElement != null) yield return new ElementValue("capabilities", CapabilitiesElement);
        foreach (var elem in DerivedFromElement) { if (elem != null) yield return new ElementValue("derivedFrom", elem); }
      }
    }

    protected override bool TryGetValue(string key, out object value)
    {
      switch (key)
      {
        case "url":
          value = UrlElement;
          return UrlElement is not null;
        case "identifier":
          value = Identifier;
          return Identifier?.Any() == true;
        case "version":
          value = VersionElement;
          return VersionElement is not null;
        case "versionAlgorithm":
          value = VersionAlgorithm;
          return VersionAlgorithm is not null;
        case "name":
          value = NameElement;
          return NameElement is not null;
        case "title":
          value = TitleElement;
          return TitleElement is not null;
        case "status":
          value = StatusElement;
          return StatusElement is not null;
        case "experimental":
          value = ExperimentalElement;
          return ExperimentalElement is not null;
        case "date":
          value = DateElement;
          return DateElement is not null;
        case "publisher":
          value = PublisherElement;
          return PublisherElement is not null;
        case "contact":
          value = Contact;
          return Contact?.Any() == true;
        case "description":
          value = DescriptionElement;
          return DescriptionElement is not null;
        case "useContext":
          value = UseContext;
          return UseContext?.Any() == true;
        case "jurisdiction":
          value = Jurisdiction;
          return Jurisdiction?.Any() == true;
        case "purpose":
          value = PurposeElement;
          return PurposeElement is not null;
        case "copyright":
          value = CopyrightElement;
          return CopyrightElement is not null;
        case "copyrightLabel":
          value = CopyrightLabelElement;
          return CopyrightLabelElement is not null;
        case "type":
          value = TypeElement;
          return TypeElement is not null;
        case "documentation":
          value = DocumentationElement;
          return DocumentationElement is not null;
        case "reference":
          value = ReferenceElement;
          return ReferenceElement?.Any() == true;
        case "capabilities":
          value = CapabilitiesElement;
          return CapabilitiesElement is not null;
        case "derivedFrom":
          value = DerivedFromElement;
          return DerivedFromElement?.Any() == true;
        default:
          return base.TryGetValue(key, out value);
      }

    }

    protected override IEnumerable<KeyValuePair<string, object>> GetElementPairs()
    {
      foreach (var kvp in base.GetElementPairs()) yield return kvp;
      if (UrlElement is not null) yield return new KeyValuePair<string,object>("url",UrlElement);
      if (Identifier?.Any() == true) yield return new KeyValuePair<string,object>("identifier",Identifier);
      if (VersionElement is not null) yield return new KeyValuePair<string,object>("version",VersionElement);
      if (VersionAlgorithm is not null) yield return new KeyValuePair<string,object>("versionAlgorithm",VersionAlgorithm);
      if (NameElement is not null) yield return new KeyValuePair<string,object>("name",NameElement);
      if (TitleElement is not null) yield return new KeyValuePair<string,object>("title",TitleElement);
      if (StatusElement is not null) yield return new KeyValuePair<string,object>("status",StatusElement);
      if (ExperimentalElement is not null) yield return new KeyValuePair<string,object>("experimental",ExperimentalElement);
      if (DateElement is not null) yield return new KeyValuePair<string,object>("date",DateElement);
      if (PublisherElement is not null) yield return new KeyValuePair<string,object>("publisher",PublisherElement);
      if (Contact?.Any() == true) yield return new KeyValuePair<string,object>("contact",Contact);
      if (DescriptionElement is not null) yield return new KeyValuePair<string,object>("description",DescriptionElement);
      if (UseContext?.Any() == true) yield return new KeyValuePair<string,object>("useContext",UseContext);
      if (Jurisdiction?.Any() == true) yield return new KeyValuePair<string,object>("jurisdiction",Jurisdiction);
      if (PurposeElement is not null) yield return new KeyValuePair<string,object>("purpose",PurposeElement);
      if (CopyrightElement is not null) yield return new KeyValuePair<string,object>("copyright",CopyrightElement);
      if (CopyrightLabelElement is not null) yield return new KeyValuePair<string,object>("copyrightLabel",CopyrightLabelElement);
      if (TypeElement is not null) yield return new KeyValuePair<string,object>("type",TypeElement);
      if (DocumentationElement is not null) yield return new KeyValuePair<string,object>("documentation",DocumentationElement);
      if (ReferenceElement?.Any() == true) yield return new KeyValuePair<string,object>("reference",ReferenceElement);
      if (CapabilitiesElement is not null) yield return new KeyValuePair<string,object>("capabilities",CapabilitiesElement);
      if (DerivedFromElement?.Any() == true) yield return new KeyValuePair<string,object>("derivedFrom",DerivedFromElement);
    }

  }

}

// end of file

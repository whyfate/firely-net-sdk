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
  /// The details of a healthcare service available at a location
  /// </summary>
  [Serializable]
  [DataContract]
  [FhirType("HealthcareService","http://hl7.org/fhir/StructureDefinition/HealthcareService", IsResource=true)]
  public partial class HealthcareService : Hl7.Fhir.Model.DomainResource, IIdentifiable<List<Identifier>>
  {
    /// <summary>
    /// FHIR Type Name
    /// </summary>
    public override string TypeName { get { return "HealthcareService"; } }

    /// <summary>
    /// Specific eligibility requirements required to use the service
    /// </summary>
    [Serializable]
    [DataContract]
    [FhirType("HealthcareService#Eligibility", IsNestedType=true)]
    [BackboneType("HealthcareService.eligibility")]
    public partial class EligibilityComponent : Hl7.Fhir.Model.BackboneElement
    {
      /// <summary>
      /// FHIR Type Name
      /// </summary>
      public override string TypeName { get { return "HealthcareService#Eligibility"; } }

      /// <summary>
      /// Coded value for the eligibility
      /// </summary>
      [FhirElement("code", Order=40)]
      [Binding("ServiceEligibility")]
      [DataMember]
      public Hl7.Fhir.Model.CodeableConcept Code
      {
        get { return _Code; }
        set { _Code = value; OnPropertyChanged("Code"); }
      }

      private Hl7.Fhir.Model.CodeableConcept _Code;

      /// <summary>
      /// Describes the eligibility conditions for the service
      /// </summary>
      [FhirElement("comment", Order=50)]
      [DataMember]
      public Hl7.Fhir.Model.Markdown CommentElement
      {
        get { return _CommentElement; }
        set { _CommentElement = value; OnPropertyChanged("CommentElement"); }
      }

      private Hl7.Fhir.Model.Markdown _CommentElement;

      /// <summary>
      /// Describes the eligibility conditions for the service
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

      public override IDeepCopyable CopyTo(IDeepCopyable other)
      {
        var dest = other as EligibilityComponent;

        if (dest == null)
        {
          throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        base.CopyTo(dest);
        if(Code != null) dest.Code = (Hl7.Fhir.Model.CodeableConcept)Code.DeepCopy();
        if(CommentElement != null) dest.CommentElement = (Hl7.Fhir.Model.Markdown)CommentElement.DeepCopy();
        return dest;
      }

      public override IDeepCopyable DeepCopy()
      {
        return CopyTo(new EligibilityComponent());
      }

      ///<inheritdoc />
      public override bool Matches(IDeepComparable other)
      {
        var otherT = other as EligibilityComponent;
        if(otherT == null) return false;

        if(!base.Matches(otherT)) return false;
        if( !DeepComparable.Matches(Code, otherT.Code)) return false;
        if( !DeepComparable.Matches(CommentElement, otherT.CommentElement)) return false;

        return true;
      }

      public override bool IsExactly(IDeepComparable other)
      {
        var otherT = other as EligibilityComponent;
        if(otherT == null) return false;

        if(!base.IsExactly(otherT)) return false;
        if( !DeepComparable.IsExactly(Code, otherT.Code)) return false;
        if( !DeepComparable.IsExactly(CommentElement, otherT.CommentElement)) return false;

        return true;
      }

      [IgnoreDataMember]
      public override IEnumerable<Base> Children
      {
        get
        {
          foreach (var item in base.Children) yield return item;
          if (Code != null) yield return Code;
          if (CommentElement != null) yield return CommentElement;
        }
      }

      [IgnoreDataMember]
      public override IEnumerable<ElementValue> NamedChildren
      {
        get
        {
          foreach (var item in base.NamedChildren) yield return item;
          if (Code != null) yield return new ElementValue("code", Code);
          if (CommentElement != null) yield return new ElementValue("comment", CommentElement);
        }
      }

      protected override bool TryGetValue(string key, out object value)
      {
        switch (key)
        {
          case "code":
            value = Code;
            return Code is not null;
          case "comment":
            value = CommentElement;
            return CommentElement is not null;
          default:
            return base.TryGetValue(key, out value);
        }

      }

      protected override IEnumerable<KeyValuePair<string, object>> GetElementPairs()
      {
        foreach (var kvp in base.GetElementPairs()) yield return kvp;
        if (Code is not null) yield return new KeyValuePair<string,object>("code",Code);
        if (CommentElement is not null) yield return new KeyValuePair<string,object>("comment",CommentElement);
      }

    }

    /// <summary>
    /// External identifiers for this item
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
    /// Whether this HealthcareService record is in active use
    /// </summary>
    [FhirElement("active", InSummary=true, IsModifier=true, Order=100, FiveWs="FiveWs.status")]
    [DataMember]
    public Hl7.Fhir.Model.FhirBoolean ActiveElement
    {
      get { return _ActiveElement; }
      set { _ActiveElement = value; OnPropertyChanged("ActiveElement"); }
    }

    private Hl7.Fhir.Model.FhirBoolean _ActiveElement;

    /// <summary>
    /// Whether this HealthcareService record is in active use
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
    /// Organization that provides this service
    /// </summary>
    [FhirElement("providedBy", InSummary=true, Order=110)]
    [CLSCompliant(false)]
    [References("Organization")]
    [DataMember]
    public Hl7.Fhir.Model.ResourceReference ProvidedBy
    {
      get { return _ProvidedBy; }
      set { _ProvidedBy = value; OnPropertyChanged("ProvidedBy"); }
    }

    private Hl7.Fhir.Model.ResourceReference _ProvidedBy;

    /// <summary>
    /// The service within which this service is offered
    /// </summary>
    [FhirElement("offeredIn", Order=120)]
    [CLSCompliant(false)]
    [References("HealthcareService")]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.ResourceReference> OfferedIn
    {
      get { if(_OfferedIn==null) _OfferedIn = new List<Hl7.Fhir.Model.ResourceReference>(); return _OfferedIn; }
      set { _OfferedIn = value; OnPropertyChanged("OfferedIn"); }
    }

    private List<Hl7.Fhir.Model.ResourceReference> _OfferedIn;

    /// <summary>
    /// Broad category of service being performed or delivered
    /// </summary>
    [FhirElement("category", InSummary=true, Order=130, FiveWs="FiveWs.class")]
    [Binding("service-category")]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.CodeableConcept> Category
    {
      get { if(_Category==null) _Category = new List<Hl7.Fhir.Model.CodeableConcept>(); return _Category; }
      set { _Category = value; OnPropertyChanged("Category"); }
    }

    private List<Hl7.Fhir.Model.CodeableConcept> _Category;

    /// <summary>
    /// Type of service that may be delivered or performed
    /// </summary>
    [FhirElement("type", InSummary=true, Order=140)]
    [Binding("service-type")]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.CodeableConcept> Type
    {
      get { if(_Type==null) _Type = new List<Hl7.Fhir.Model.CodeableConcept>(); return _Type; }
      set { _Type = value; OnPropertyChanged("Type"); }
    }

    private List<Hl7.Fhir.Model.CodeableConcept> _Type;

    /// <summary>
    /// Specialties handled by the HealthcareService
    /// </summary>
    [FhirElement("specialty", InSummary=true, Order=150)]
    [Binding("service-specialty")]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.CodeableConcept> Specialty
    {
      get { if(_Specialty==null) _Specialty = new List<Hl7.Fhir.Model.CodeableConcept>(); return _Specialty; }
      set { _Specialty = value; OnPropertyChanged("Specialty"); }
    }

    private List<Hl7.Fhir.Model.CodeableConcept> _Specialty;

    /// <summary>
    /// Location(s) where service may be provided
    /// </summary>
    [FhirElement("location", InSummary=true, Order=160, FiveWs="FiveWs.where[x]")]
    [CLSCompliant(false)]
    [References("Location")]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.ResourceReference> Location
    {
      get { if(_Location==null) _Location = new List<Hl7.Fhir.Model.ResourceReference>(); return _Location; }
      set { _Location = value; OnPropertyChanged("Location"); }
    }

    private List<Hl7.Fhir.Model.ResourceReference> _Location;

    /// <summary>
    /// Description of service as presented to a consumer while searching
    /// </summary>
    [FhirElement("name", InSummary=true, Order=170)]
    [DataMember]
    public Hl7.Fhir.Model.FhirString NameElement
    {
      get { return _NameElement; }
      set { _NameElement = value; OnPropertyChanged("NameElement"); }
    }

    private Hl7.Fhir.Model.FhirString _NameElement;

    /// <summary>
    /// Description of service as presented to a consumer while searching
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
    /// Additional description and/or any specific issues not covered elsewhere
    /// </summary>
    [FhirElement("comment", InSummary=true, Order=180)]
    [DataMember]
    public Hl7.Fhir.Model.Markdown CommentElement
    {
      get { return _CommentElement; }
      set { _CommentElement = value; OnPropertyChanged("CommentElement"); }
    }

    private Hl7.Fhir.Model.Markdown _CommentElement;

    /// <summary>
    /// Additional description and/or any specific issues not covered elsewhere
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
    /// Extra details about the service that can't be placed in the other fields
    /// </summary>
    [FhirElement("extraDetails", Order=190)]
    [DataMember]
    public Hl7.Fhir.Model.Markdown ExtraDetailsElement
    {
      get { return _ExtraDetailsElement; }
      set { _ExtraDetailsElement = value; OnPropertyChanged("ExtraDetailsElement"); }
    }

    private Hl7.Fhir.Model.Markdown _ExtraDetailsElement;

    /// <summary>
    /// Extra details about the service that can't be placed in the other fields
    /// </summary>
    /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
    [IgnoreDataMember]
    public string ExtraDetails
    {
      get { return ExtraDetailsElement != null ? ExtraDetailsElement.Value : null; }
      set
      {
        if (value == null)
          ExtraDetailsElement = null;
        else
          ExtraDetailsElement = new Hl7.Fhir.Model.Markdown(value);
        OnPropertyChanged("ExtraDetails");
      }
    }

    /// <summary>
    /// Facilitates quick identification of the service
    /// </summary>
    [FhirElement("photo", InSummary=true, Order=200)]
    [DataMember]
    public Hl7.Fhir.Model.Attachment Photo
    {
      get { return _Photo; }
      set { _Photo = value; OnPropertyChanged("Photo"); }
    }

    private Hl7.Fhir.Model.Attachment _Photo;

    /// <summary>
    /// Official contact details for the HealthcareService
    /// </summary>
    [FhirElement("contact", Order=210)]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.ExtendedContactDetail> Contact
    {
      get { if(_Contact==null) _Contact = new List<Hl7.Fhir.Model.ExtendedContactDetail>(); return _Contact; }
      set { _Contact = value; OnPropertyChanged("Contact"); }
    }

    private List<Hl7.Fhir.Model.ExtendedContactDetail> _Contact;

    /// <summary>
    /// Location(s) service is intended for/available to
    /// </summary>
    [FhirElement("coverageArea", Order=220)]
    [CLSCompliant(false)]
    [References("Location")]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.ResourceReference> CoverageArea
    {
      get { if(_CoverageArea==null) _CoverageArea = new List<Hl7.Fhir.Model.ResourceReference>(); return _CoverageArea; }
      set { _CoverageArea = value; OnPropertyChanged("CoverageArea"); }
    }

    private List<Hl7.Fhir.Model.ResourceReference> _CoverageArea;

    /// <summary>
    /// Conditions under which service is available/offered
    /// </summary>
    [FhirElement("serviceProvisionCode", Order=230)]
    [Binding("ServiceProvisionConditions")]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.CodeableConcept> ServiceProvisionCode
    {
      get { if(_ServiceProvisionCode==null) _ServiceProvisionCode = new List<Hl7.Fhir.Model.CodeableConcept>(); return _ServiceProvisionCode; }
      set { _ServiceProvisionCode = value; OnPropertyChanged("ServiceProvisionCode"); }
    }

    private List<Hl7.Fhir.Model.CodeableConcept> _ServiceProvisionCode;

    /// <summary>
    /// Specific eligibility requirements required to use the service
    /// </summary>
    [FhirElement("eligibility", Order=240)]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.HealthcareService.EligibilityComponent> Eligibility
    {
      get { if(_Eligibility==null) _Eligibility = new List<Hl7.Fhir.Model.HealthcareService.EligibilityComponent>(); return _Eligibility; }
      set { _Eligibility = value; OnPropertyChanged("Eligibility"); }
    }

    private List<Hl7.Fhir.Model.HealthcareService.EligibilityComponent> _Eligibility;

    /// <summary>
    /// Programs that this service is applicable to
    /// </summary>
    [FhirElement("program", Order=250)]
    [Binding("Program")]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.CodeableConcept> Program
    {
      get { if(_Program==null) _Program = new List<Hl7.Fhir.Model.CodeableConcept>(); return _Program; }
      set { _Program = value; OnPropertyChanged("Program"); }
    }

    private List<Hl7.Fhir.Model.CodeableConcept> _Program;

    /// <summary>
    /// Collection of characteristics (attributes)
    /// </summary>
    [FhirElement("characteristic", Order=260)]
    [Binding("ServiceCharacteristic")]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.CodeableConcept> Characteristic
    {
      get { if(_Characteristic==null) _Characteristic = new List<Hl7.Fhir.Model.CodeableConcept>(); return _Characteristic; }
      set { _Characteristic = value; OnPropertyChanged("Characteristic"); }
    }

    private List<Hl7.Fhir.Model.CodeableConcept> _Characteristic;

    /// <summary>
    /// The language that this service is offered in
    /// </summary>
    [FhirElement("communication", Order=270)]
    [Binding("Language")]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.CodeableConcept> Communication
    {
      get { if(_Communication==null) _Communication = new List<Hl7.Fhir.Model.CodeableConcept>(); return _Communication; }
      set { _Communication = value; OnPropertyChanged("Communication"); }
    }

    private List<Hl7.Fhir.Model.CodeableConcept> _Communication;

    /// <summary>
    /// Ways that the service accepts referrals
    /// </summary>
    [FhirElement("referralMethod", Order=280)]
    [Binding("ReferralMethod")]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.CodeableConcept> ReferralMethod
    {
      get { if(_ReferralMethod==null) _ReferralMethod = new List<Hl7.Fhir.Model.CodeableConcept>(); return _ReferralMethod; }
      set { _ReferralMethod = value; OnPropertyChanged("ReferralMethod"); }
    }

    private List<Hl7.Fhir.Model.CodeableConcept> _ReferralMethod;

    /// <summary>
    /// If an appointment is required for access to this service
    /// </summary>
    [FhirElement("appointmentRequired", Order=290)]
    [DataMember]
    public Hl7.Fhir.Model.FhirBoolean AppointmentRequiredElement
    {
      get { return _AppointmentRequiredElement; }
      set { _AppointmentRequiredElement = value; OnPropertyChanged("AppointmentRequiredElement"); }
    }

    private Hl7.Fhir.Model.FhirBoolean _AppointmentRequiredElement;

    /// <summary>
    /// If an appointment is required for access to this service
    /// </summary>
    /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
    [IgnoreDataMember]
    public bool? AppointmentRequired
    {
      get { return AppointmentRequiredElement != null ? AppointmentRequiredElement.Value : null; }
      set
      {
        if (value == null)
          AppointmentRequiredElement = null;
        else
          AppointmentRequiredElement = new Hl7.Fhir.Model.FhirBoolean(value);
        OnPropertyChanged("AppointmentRequired");
      }
    }

    /// <summary>
    /// Times the healthcare service is available (including exceptions)
    /// </summary>
    [FhirElement("availability", Order=300)]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.Availability> Availability
    {
      get { if(_Availability==null) _Availability = new List<Hl7.Fhir.Model.Availability>(); return _Availability; }
      set { _Availability = value; OnPropertyChanged("Availability"); }
    }

    private List<Hl7.Fhir.Model.Availability> _Availability;

    /// <summary>
    /// Technical endpoints providing access to electronic services operated for the healthcare service
    /// </summary>
    [FhirElement("endpoint", Order=310)]
    [CLSCompliant(false)]
    [References("Endpoint")]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.ResourceReference> Endpoint
    {
      get { if(_Endpoint==null) _Endpoint = new List<Hl7.Fhir.Model.ResourceReference>(); return _Endpoint; }
      set { _Endpoint = value; OnPropertyChanged("Endpoint"); }
    }

    private List<Hl7.Fhir.Model.ResourceReference> _Endpoint;

    List<Identifier> IIdentifiable<List<Identifier>>.Identifier { get => Identifier; set => Identifier = value; }

    public override IDeepCopyable CopyTo(IDeepCopyable other)
    {
      var dest = other as HealthcareService;

      if (dest == null)
      {
        throw new ArgumentException("Can only copy to an object of the same type", "other");
      }

      base.CopyTo(dest);
      if(Identifier != null) dest.Identifier = new List<Hl7.Fhir.Model.Identifier>(Identifier.DeepCopy());
      if(ActiveElement != null) dest.ActiveElement = (Hl7.Fhir.Model.FhirBoolean)ActiveElement.DeepCopy();
      if(ProvidedBy != null) dest.ProvidedBy = (Hl7.Fhir.Model.ResourceReference)ProvidedBy.DeepCopy();
      if(OfferedIn != null) dest.OfferedIn = new List<Hl7.Fhir.Model.ResourceReference>(OfferedIn.DeepCopy());
      if(Category != null) dest.Category = new List<Hl7.Fhir.Model.CodeableConcept>(Category.DeepCopy());
      if(Type != null) dest.Type = new List<Hl7.Fhir.Model.CodeableConcept>(Type.DeepCopy());
      if(Specialty != null) dest.Specialty = new List<Hl7.Fhir.Model.CodeableConcept>(Specialty.DeepCopy());
      if(Location != null) dest.Location = new List<Hl7.Fhir.Model.ResourceReference>(Location.DeepCopy());
      if(NameElement != null) dest.NameElement = (Hl7.Fhir.Model.FhirString)NameElement.DeepCopy();
      if(CommentElement != null) dest.CommentElement = (Hl7.Fhir.Model.Markdown)CommentElement.DeepCopy();
      if(ExtraDetailsElement != null) dest.ExtraDetailsElement = (Hl7.Fhir.Model.Markdown)ExtraDetailsElement.DeepCopy();
      if(Photo != null) dest.Photo = (Hl7.Fhir.Model.Attachment)Photo.DeepCopy();
      if(Contact != null) dest.Contact = new List<Hl7.Fhir.Model.ExtendedContactDetail>(Contact.DeepCopy());
      if(CoverageArea != null) dest.CoverageArea = new List<Hl7.Fhir.Model.ResourceReference>(CoverageArea.DeepCopy());
      if(ServiceProvisionCode != null) dest.ServiceProvisionCode = new List<Hl7.Fhir.Model.CodeableConcept>(ServiceProvisionCode.DeepCopy());
      if(Eligibility != null) dest.Eligibility = new List<Hl7.Fhir.Model.HealthcareService.EligibilityComponent>(Eligibility.DeepCopy());
      if(Program != null) dest.Program = new List<Hl7.Fhir.Model.CodeableConcept>(Program.DeepCopy());
      if(Characteristic != null) dest.Characteristic = new List<Hl7.Fhir.Model.CodeableConcept>(Characteristic.DeepCopy());
      if(Communication != null) dest.Communication = new List<Hl7.Fhir.Model.CodeableConcept>(Communication.DeepCopy());
      if(ReferralMethod != null) dest.ReferralMethod = new List<Hl7.Fhir.Model.CodeableConcept>(ReferralMethod.DeepCopy());
      if(AppointmentRequiredElement != null) dest.AppointmentRequiredElement = (Hl7.Fhir.Model.FhirBoolean)AppointmentRequiredElement.DeepCopy();
      if(Availability != null) dest.Availability = new List<Hl7.Fhir.Model.Availability>(Availability.DeepCopy());
      if(Endpoint != null) dest.Endpoint = new List<Hl7.Fhir.Model.ResourceReference>(Endpoint.DeepCopy());
      return dest;
    }

    public override IDeepCopyable DeepCopy()
    {
      return CopyTo(new HealthcareService());
    }

    ///<inheritdoc />
    public override bool Matches(IDeepComparable other)
    {
      var otherT = other as HealthcareService;
      if(otherT == null) return false;

      if(!base.Matches(otherT)) return false;
      if( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
      if( !DeepComparable.Matches(ActiveElement, otherT.ActiveElement)) return false;
      if( !DeepComparable.Matches(ProvidedBy, otherT.ProvidedBy)) return false;
      if( !DeepComparable.Matches(OfferedIn, otherT.OfferedIn)) return false;
      if( !DeepComparable.Matches(Category, otherT.Category)) return false;
      if( !DeepComparable.Matches(Type, otherT.Type)) return false;
      if( !DeepComparable.Matches(Specialty, otherT.Specialty)) return false;
      if( !DeepComparable.Matches(Location, otherT.Location)) return false;
      if( !DeepComparable.Matches(NameElement, otherT.NameElement)) return false;
      if( !DeepComparable.Matches(CommentElement, otherT.CommentElement)) return false;
      if( !DeepComparable.Matches(ExtraDetailsElement, otherT.ExtraDetailsElement)) return false;
      if( !DeepComparable.Matches(Photo, otherT.Photo)) return false;
      if( !DeepComparable.Matches(Contact, otherT.Contact)) return false;
      if( !DeepComparable.Matches(CoverageArea, otherT.CoverageArea)) return false;
      if( !DeepComparable.Matches(ServiceProvisionCode, otherT.ServiceProvisionCode)) return false;
      if( !DeepComparable.Matches(Eligibility, otherT.Eligibility)) return false;
      if( !DeepComparable.Matches(Program, otherT.Program)) return false;
      if( !DeepComparable.Matches(Characteristic, otherT.Characteristic)) return false;
      if( !DeepComparable.Matches(Communication, otherT.Communication)) return false;
      if( !DeepComparable.Matches(ReferralMethod, otherT.ReferralMethod)) return false;
      if( !DeepComparable.Matches(AppointmentRequiredElement, otherT.AppointmentRequiredElement)) return false;
      if( !DeepComparable.Matches(Availability, otherT.Availability)) return false;
      if( !DeepComparable.Matches(Endpoint, otherT.Endpoint)) return false;

      return true;
    }

    public override bool IsExactly(IDeepComparable other)
    {
      var otherT = other as HealthcareService;
      if(otherT == null) return false;

      if(!base.IsExactly(otherT)) return false;
      if( !DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
      if( !DeepComparable.IsExactly(ActiveElement, otherT.ActiveElement)) return false;
      if( !DeepComparable.IsExactly(ProvidedBy, otherT.ProvidedBy)) return false;
      if( !DeepComparable.IsExactly(OfferedIn, otherT.OfferedIn)) return false;
      if( !DeepComparable.IsExactly(Category, otherT.Category)) return false;
      if( !DeepComparable.IsExactly(Type, otherT.Type)) return false;
      if( !DeepComparable.IsExactly(Specialty, otherT.Specialty)) return false;
      if( !DeepComparable.IsExactly(Location, otherT.Location)) return false;
      if( !DeepComparable.IsExactly(NameElement, otherT.NameElement)) return false;
      if( !DeepComparable.IsExactly(CommentElement, otherT.CommentElement)) return false;
      if( !DeepComparable.IsExactly(ExtraDetailsElement, otherT.ExtraDetailsElement)) return false;
      if( !DeepComparable.IsExactly(Photo, otherT.Photo)) return false;
      if( !DeepComparable.IsExactly(Contact, otherT.Contact)) return false;
      if( !DeepComparable.IsExactly(CoverageArea, otherT.CoverageArea)) return false;
      if( !DeepComparable.IsExactly(ServiceProvisionCode, otherT.ServiceProvisionCode)) return false;
      if( !DeepComparable.IsExactly(Eligibility, otherT.Eligibility)) return false;
      if( !DeepComparable.IsExactly(Program, otherT.Program)) return false;
      if( !DeepComparable.IsExactly(Characteristic, otherT.Characteristic)) return false;
      if( !DeepComparable.IsExactly(Communication, otherT.Communication)) return false;
      if( !DeepComparable.IsExactly(ReferralMethod, otherT.ReferralMethod)) return false;
      if( !DeepComparable.IsExactly(AppointmentRequiredElement, otherT.AppointmentRequiredElement)) return false;
      if( !DeepComparable.IsExactly(Availability, otherT.Availability)) return false;
      if( !DeepComparable.IsExactly(Endpoint, otherT.Endpoint)) return false;

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
        if (ProvidedBy != null) yield return ProvidedBy;
        foreach (var elem in OfferedIn) { if (elem != null) yield return elem; }
        foreach (var elem in Category) { if (elem != null) yield return elem; }
        foreach (var elem in Type) { if (elem != null) yield return elem; }
        foreach (var elem in Specialty) { if (elem != null) yield return elem; }
        foreach (var elem in Location) { if (elem != null) yield return elem; }
        if (NameElement != null) yield return NameElement;
        if (CommentElement != null) yield return CommentElement;
        if (ExtraDetailsElement != null) yield return ExtraDetailsElement;
        if (Photo != null) yield return Photo;
        foreach (var elem in Contact) { if (elem != null) yield return elem; }
        foreach (var elem in CoverageArea) { if (elem != null) yield return elem; }
        foreach (var elem in ServiceProvisionCode) { if (elem != null) yield return elem; }
        foreach (var elem in Eligibility) { if (elem != null) yield return elem; }
        foreach (var elem in Program) { if (elem != null) yield return elem; }
        foreach (var elem in Characteristic) { if (elem != null) yield return elem; }
        foreach (var elem in Communication) { if (elem != null) yield return elem; }
        foreach (var elem in ReferralMethod) { if (elem != null) yield return elem; }
        if (AppointmentRequiredElement != null) yield return AppointmentRequiredElement;
        foreach (var elem in Availability) { if (elem != null) yield return elem; }
        foreach (var elem in Endpoint) { if (elem != null) yield return elem; }
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
        if (ProvidedBy != null) yield return new ElementValue("providedBy", ProvidedBy);
        foreach (var elem in OfferedIn) { if (elem != null) yield return new ElementValue("offeredIn", elem); }
        foreach (var elem in Category) { if (elem != null) yield return new ElementValue("category", elem); }
        foreach (var elem in Type) { if (elem != null) yield return new ElementValue("type", elem); }
        foreach (var elem in Specialty) { if (elem != null) yield return new ElementValue("specialty", elem); }
        foreach (var elem in Location) { if (elem != null) yield return new ElementValue("location", elem); }
        if (NameElement != null) yield return new ElementValue("name", NameElement);
        if (CommentElement != null) yield return new ElementValue("comment", CommentElement);
        if (ExtraDetailsElement != null) yield return new ElementValue("extraDetails", ExtraDetailsElement);
        if (Photo != null) yield return new ElementValue("photo", Photo);
        foreach (var elem in Contact) { if (elem != null) yield return new ElementValue("contact", elem); }
        foreach (var elem in CoverageArea) { if (elem != null) yield return new ElementValue("coverageArea", elem); }
        foreach (var elem in ServiceProvisionCode) { if (elem != null) yield return new ElementValue("serviceProvisionCode", elem); }
        foreach (var elem in Eligibility) { if (elem != null) yield return new ElementValue("eligibility", elem); }
        foreach (var elem in Program) { if (elem != null) yield return new ElementValue("program", elem); }
        foreach (var elem in Characteristic) { if (elem != null) yield return new ElementValue("characteristic", elem); }
        foreach (var elem in Communication) { if (elem != null) yield return new ElementValue("communication", elem); }
        foreach (var elem in ReferralMethod) { if (elem != null) yield return new ElementValue("referralMethod", elem); }
        if (AppointmentRequiredElement != null) yield return new ElementValue("appointmentRequired", AppointmentRequiredElement);
        foreach (var elem in Availability) { if (elem != null) yield return new ElementValue("availability", elem); }
        foreach (var elem in Endpoint) { if (elem != null) yield return new ElementValue("endpoint", elem); }
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
        case "providedBy":
          value = ProvidedBy;
          return ProvidedBy is not null;
        case "offeredIn":
          value = OfferedIn;
          return OfferedIn?.Any() == true;
        case "category":
          value = Category;
          return Category?.Any() == true;
        case "type":
          value = Type;
          return Type?.Any() == true;
        case "specialty":
          value = Specialty;
          return Specialty?.Any() == true;
        case "location":
          value = Location;
          return Location?.Any() == true;
        case "name":
          value = NameElement;
          return NameElement is not null;
        case "comment":
          value = CommentElement;
          return CommentElement is not null;
        case "extraDetails":
          value = ExtraDetailsElement;
          return ExtraDetailsElement is not null;
        case "photo":
          value = Photo;
          return Photo is not null;
        case "contact":
          value = Contact;
          return Contact?.Any() == true;
        case "coverageArea":
          value = CoverageArea;
          return CoverageArea?.Any() == true;
        case "serviceProvisionCode":
          value = ServiceProvisionCode;
          return ServiceProvisionCode?.Any() == true;
        case "eligibility":
          value = Eligibility;
          return Eligibility?.Any() == true;
        case "program":
          value = Program;
          return Program?.Any() == true;
        case "characteristic":
          value = Characteristic;
          return Characteristic?.Any() == true;
        case "communication":
          value = Communication;
          return Communication?.Any() == true;
        case "referralMethod":
          value = ReferralMethod;
          return ReferralMethod?.Any() == true;
        case "appointmentRequired":
          value = AppointmentRequiredElement;
          return AppointmentRequiredElement is not null;
        case "availability":
          value = Availability;
          return Availability?.Any() == true;
        case "endpoint":
          value = Endpoint;
          return Endpoint?.Any() == true;
        default:
          return base.TryGetValue(key, out value);
      }

    }

    protected override IEnumerable<KeyValuePair<string, object>> GetElementPairs()
    {
      foreach (var kvp in base.GetElementPairs()) yield return kvp;
      if (Identifier?.Any() == true) yield return new KeyValuePair<string,object>("identifier",Identifier);
      if (ActiveElement is not null) yield return new KeyValuePair<string,object>("active",ActiveElement);
      if (ProvidedBy is not null) yield return new KeyValuePair<string,object>("providedBy",ProvidedBy);
      if (OfferedIn?.Any() == true) yield return new KeyValuePair<string,object>("offeredIn",OfferedIn);
      if (Category?.Any() == true) yield return new KeyValuePair<string,object>("category",Category);
      if (Type?.Any() == true) yield return new KeyValuePair<string,object>("type",Type);
      if (Specialty?.Any() == true) yield return new KeyValuePair<string,object>("specialty",Specialty);
      if (Location?.Any() == true) yield return new KeyValuePair<string,object>("location",Location);
      if (NameElement is not null) yield return new KeyValuePair<string,object>("name",NameElement);
      if (CommentElement is not null) yield return new KeyValuePair<string,object>("comment",CommentElement);
      if (ExtraDetailsElement is not null) yield return new KeyValuePair<string,object>("extraDetails",ExtraDetailsElement);
      if (Photo is not null) yield return new KeyValuePair<string,object>("photo",Photo);
      if (Contact?.Any() == true) yield return new KeyValuePair<string,object>("contact",Contact);
      if (CoverageArea?.Any() == true) yield return new KeyValuePair<string,object>("coverageArea",CoverageArea);
      if (ServiceProvisionCode?.Any() == true) yield return new KeyValuePair<string,object>("serviceProvisionCode",ServiceProvisionCode);
      if (Eligibility?.Any() == true) yield return new KeyValuePair<string,object>("eligibility",Eligibility);
      if (Program?.Any() == true) yield return new KeyValuePair<string,object>("program",Program);
      if (Characteristic?.Any() == true) yield return new KeyValuePair<string,object>("characteristic",Characteristic);
      if (Communication?.Any() == true) yield return new KeyValuePair<string,object>("communication",Communication);
      if (ReferralMethod?.Any() == true) yield return new KeyValuePair<string,object>("referralMethod",ReferralMethod);
      if (AppointmentRequiredElement is not null) yield return new KeyValuePair<string,object>("appointmentRequired",AppointmentRequiredElement);
      if (Availability?.Any() == true) yield return new KeyValuePair<string,object>("availability",Availability);
      if (Endpoint?.Any() == true) yield return new KeyValuePair<string,object>("endpoint",Endpoint);
    }

  }

}

// end of file

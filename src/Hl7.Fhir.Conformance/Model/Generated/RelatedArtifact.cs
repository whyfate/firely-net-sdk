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
  /// Related artifacts for a knowledge resource
  /// </summary>
  [Serializable]
  [DataContract]
  [FhirType("RelatedArtifact","http://hl7.org/fhir/StructureDefinition/RelatedArtifact")]
  public partial class RelatedArtifact : Hl7.Fhir.Model.DataType
  {
    /// <summary>
    /// FHIR Type Name
    /// </summary>
    public override string TypeName { get { return "RelatedArtifact"; } }

    /// <summary>
    /// The type of relationship to the related artifact.
    /// (url: http://hl7.org/fhir/ValueSet/related-artifact-type)
    /// (system: http://hl7.org/fhir/related-artifact-type)
    /// </summary>
    [FhirEnumeration("RelatedArtifactType", "http://hl7.org/fhir/ValueSet/related-artifact-type", "http://hl7.org/fhir/related-artifact-type")]
    public enum RelatedArtifactType
    {
      /// <summary>
      /// Additional documentation for the knowledge resource. This would include additional instructions on usage as well as additional information on clinical context or appropriateness.
      /// (system: http://hl7.org/fhir/related-artifact-type)
      /// </summary>
      [EnumLiteral("documentation"), Description("Documentation")]
      Documentation,
      /// <summary>
      /// The target artifact is a summary of the justification for the knowledge resource including supporting evidence, relevant guidelines, or other clinically important information. This information is intended to provide a way to make the justification for the knowledge resource available to the consumer of interventions or results produced by the knowledge resource.
      /// (system: http://hl7.org/fhir/related-artifact-type)
      /// </summary>
      [EnumLiteral("justification"), Description("Justification")]
      Justification,
      /// <summary>
      /// Bibliographic citation for papers, references, or other relevant material for the knowledge resource. This is intended to allow for citation of related material, but that was not necessarily specifically prepared in connection with this knowledge resource.
      /// (system: http://hl7.org/fhir/related-artifact-type)
      /// </summary>
      [EnumLiteral("citation"), Description("Citation")]
      Citation,
      /// <summary>
      /// The previous version of the knowledge artifact, used to establish an ordering of versions of an artifact, independent of the status of each version.
      /// (system: http://hl7.org/fhir/related-artifact-type)
      /// </summary>
      [EnumLiteral("predecessor"), Description("Predecessor")]
      Predecessor,
      /// <summary>
      /// The subsequent version of the knowledge artfact, used to establish an ordering of versions of an artifact, independent of the status of each version.
      /// (system: http://hl7.org/fhir/related-artifact-type)
      /// </summary>
      [EnumLiteral("successor"), Description("Successor")]
      Successor,
      /// <summary>
      /// This artifact is derived from the target artifact. This is intended to capture the relationship in which a particular knowledge resource is based on the content of another artifact, but is modified to capture either a different set of overall requirements, or a more specific set of requirements such as those involved in a particular institution or clinical setting. The artifact may be derived from one or more target artifacts.
      /// (system: http://hl7.org/fhir/related-artifact-type)
      /// </summary>
      [EnumLiteral("derived-from"), Description("Derived From")]
      DerivedFrom,
      /// <summary>
      /// This artifact depends on the target artifact. There is a requirement to use the target artifact in the creation or interpretation of this artifact.
      /// (system: http://hl7.org/fhir/related-artifact-type)
      /// </summary>
      [EnumLiteral("depends-on"), Description("Depends On")]
      DependsOn,
      /// <summary>
      /// This artifact is composed of the target artifact. This artifact is constructed with the target artifact as a component. The target artifact is a part of this artifact. (A dataset is composed of data.).
      /// (system: http://hl7.org/fhir/related-artifact-type)
      /// </summary>
      [EnumLiteral("composed-of"), Description("Composed Of")]
      ComposedOf,
      /// <summary>
      /// This artifact is a part of the target artifact. The target artifact is composed of this artifact (and possibly other artifacts).
      /// (system: http://hl7.org/fhir/related-artifact-type)
      /// </summary>
      [EnumLiteral("part-of"), Description("Part Of")]
      PartOf,
      /// <summary>
      /// This artifact amends or changes the target artifact. This artifact adds additional information that is functionally expected to replace information in the target artifact. This artifact replaces a part but not all of the target artifact.
      /// (system: http://hl7.org/fhir/related-artifact-type)
      /// </summary>
      [EnumLiteral("amends"), Description("Amends")]
      Amends,
      /// <summary>
      /// This artifact is amended with or changed by the target artifact. There is information in this artifact that should be functionally replaced with information in the target artifact.
      /// (system: http://hl7.org/fhir/related-artifact-type)
      /// </summary>
      [EnumLiteral("amended-with"), Description("Amended With")]
      AmendedWith,
      /// <summary>
      /// This artifact adds additional information to the target artifact. The additional information does not replace or change information in the target artifact.
      /// (system: http://hl7.org/fhir/related-artifact-type)
      /// </summary>
      [EnumLiteral("appends"), Description("Appends")]
      Appends,
      /// <summary>
      /// This artifact has additional information in the target artifact.
      /// (system: http://hl7.org/fhir/related-artifact-type)
      /// </summary>
      [EnumLiteral("appended-with"), Description("Appended With")]
      AppendedWith,
      /// <summary>
      /// This artifact cites the target artifact. This may be a bibliographic citation for papers, references, or other relevant material for the knowledge resource. This is intended to allow for citation of related material, but that was not necessarily specifically prepared in connection with this knowledge resource.
      /// (system: http://hl7.org/fhir/related-artifact-type)
      /// </summary>
      [EnumLiteral("cites"), Description("Cites")]
      Cites,
      /// <summary>
      /// This artifact is cited by the target artifact.
      /// (system: http://hl7.org/fhir/related-artifact-type)
      /// </summary>
      [EnumLiteral("cited-by"), Description("Cited By")]
      CitedBy,
      /// <summary>
      /// This artifact contains comments about the target artifact.
      /// (system: http://hl7.org/fhir/related-artifact-type)
      /// </summary>
      [EnumLiteral("comments-on"), Description("Is Comment On")]
      CommentsOn,
      /// <summary>
      /// This artifact has comments about it in the target artifact.  The type of comments may be expressed in the targetClassifier element such as reply, review, editorial, feedback, solicited, unsolicited, structured, unstructured.
      /// (system: http://hl7.org/fhir/related-artifact-type)
      /// </summary>
      [EnumLiteral("comment-in"), Description("Has Comment In")]
      CommentIn,
      /// <summary>
      /// This artifact is a container in which the target artifact is contained. A container is a data structure whose instances are collections of other objects. (A database contains the dataset.).
      /// (system: http://hl7.org/fhir/related-artifact-type)
      /// </summary>
      [EnumLiteral("contains"), Description("Contains")]
      Contains,
      /// <summary>
      /// This artifact is contained in the target artifact. The target artifact is a data structure whose instances are collections of other objects.
      /// (system: http://hl7.org/fhir/related-artifact-type)
      /// </summary>
      [EnumLiteral("contained-in"), Description("Contained In")]
      ContainedIn,
      /// <summary>
      /// This artifact identifies errors and replacement content for the target artifact.
      /// (system: http://hl7.org/fhir/related-artifact-type)
      /// </summary>
      [EnumLiteral("corrects"), Description("Corrects")]
      Corrects,
      /// <summary>
      /// This artifact has corrections to it in the target artifact. The target artifact identifies errors and replacement content for this artifact.
      /// (system: http://hl7.org/fhir/related-artifact-type)
      /// </summary>
      [EnumLiteral("correction-in"), Description("Correction In")]
      CorrectionIn,
      /// <summary>
      /// This artifact replaces or supersedes the target artifact. The target artifact may be considered deprecated.
      /// (system: http://hl7.org/fhir/related-artifact-type)
      /// </summary>
      [EnumLiteral("replaces"), Description("Replaces")]
      Replaces,
      /// <summary>
      /// This artifact is replaced with or superseded by the target artifact. This artifact may be considered deprecated.
      /// (system: http://hl7.org/fhir/related-artifact-type)
      /// </summary>
      [EnumLiteral("replaced-with"), Description("Replaced With")]
      ReplacedWith,
      /// <summary>
      /// This artifact retracts the target artifact. The content that was published in the target artifact should be considered removed from publication and should no longer be considered part of the public record.
      /// (system: http://hl7.org/fhir/related-artifact-type)
      /// </summary>
      [EnumLiteral("retracts"), Description("Retracts")]
      Retracts,
      /// <summary>
      /// This artifact is retracted by the target artifact. The content that was published in this artifact should be considered removed from publication and should no longer be considered part of the public record.
      /// (system: http://hl7.org/fhir/related-artifact-type)
      /// </summary>
      [EnumLiteral("retracted-by"), Description("Retracted By")]
      RetractedBy,
      /// <summary>
      /// This artifact is a signature of the target artifact.
      /// (system: http://hl7.org/fhir/related-artifact-type)
      /// </summary>
      [EnumLiteral("signs"), Description("Signs")]
      Signs,
      /// <summary>
      /// This artifact has characteristics in common with the target artifact. This relationship may be used in systems to “deduplicate” knowledge artifacts from different sources, or in systems to show “similar items”.
      /// (system: http://hl7.org/fhir/related-artifact-type)
      /// </summary>
      [EnumLiteral("similar-to"), Description("Similar To")]
      SimilarTo,
      /// <summary>
      /// This artifact provides additional support for the target artifact. The type of support  is not documentation as it does not describe, explain, or instruct regarding the target artifact.
      /// (system: http://hl7.org/fhir/related-artifact-type)
      /// </summary>
      [EnumLiteral("supports"), Description("Supports")]
      Supports,
      /// <summary>
      /// The target artifact contains additional information related to the knowledge artifact but is not documentation as the additional information does not describe, explain, or instruct regarding the knowledge artifact content or application. This could include an associated dataset.
      /// (system: http://hl7.org/fhir/related-artifact-type)
      /// </summary>
      [EnumLiteral("supported-with"), Description("Supported With")]
      SupportedWith,
      /// <summary>
      /// This artifact was generated by transforming the target artifact (e.g., format or language conversion). This is intended to capture the relationship in which a particular knowledge resource is based on the content of another artifact, but changes are only apparent in form and there is only one target artifact with the “transforms” relationship type.
      /// (system: http://hl7.org/fhir/related-artifact-type)
      /// </summary>
      [EnumLiteral("transforms"), Description("Transforms")]
      Transforms,
      /// <summary>
      /// This artifact was transformed into the target artifact (e.g., by format or language conversion).
      /// (system: http://hl7.org/fhir/related-artifact-type)
      /// </summary>
      [EnumLiteral("transformed-into"), Description("Transformed Into")]
      TransformedInto,
      /// <summary>
      /// This artifact was generated by transforming a related artifact (e.g., format or language conversion), noted separately with the “transforms” relationship type. This transformation used the target artifact to inform the transformation. The target artifact may be a conversion script or translation guide.
      /// (system: http://hl7.org/fhir/related-artifact-type)
      /// </summary>
      [EnumLiteral("transformed-with"), Description("Transformed With")]
      TransformedWith,
      /// <summary>
      /// This artifact provides additional documentation for the target artifact. This could include additional instructions on usage as well as additional information on clinical context or appropriateness.
      /// (system: http://hl7.org/fhir/related-artifact-type)
      /// </summary>
      [EnumLiteral("documents"), Description("Documents")]
      Documents,
      /// <summary>
      /// The target artifact is a precise description of a concept in this artifact. This may be used when the RelatedArtifact datatype is used in elements contained in this artifact.
      /// (system: http://hl7.org/fhir/related-artifact-type)
      /// </summary>
      [EnumLiteral("specification-of"), Description("Specification Of")]
      SpecificationOf,
      /// <summary>
      /// This artifact was created with the target artifact. The target artifact is a tool or support material used in the creation of the artifact, and not content that the artifact was derived from.
      /// (system: http://hl7.org/fhir/related-artifact-type)
      /// </summary>
      [EnumLiteral("created-with"), Description("Created With")]
      CreatedWith,
      /// <summary>
      /// The related artifact is the citation for this artifact.
      /// (system: http://hl7.org/fhir/related-artifact-type)
      /// </summary>
      [EnumLiteral("cite-as"), Description("Cite As")]
      CiteAs,
    }

    /// <summary>
    /// documentation | justification | citation | predecessor | successor | derived-from | depends-on | composed-of | part-of | amends | amended-with | appends | appended-with | cites | cited-by | comments-on | comment-in | contains | contained-in | corrects | correction-in | replaces | replaced-with | retracts | retracted-by | signs | similar-to | supports | supported-with | transforms | transformed-into | transformed-with | documents | specification-of | created-with | cite-as
    /// </summary>
    [FhirElement("type", InSummary=true, Order=30)]
    [DeclaredType(Type = typeof(Code))]
    [Binding("RelatedArtifactType")]
    [Cardinality(Min=1,Max=1)]
    [DataMember]
    public Code<Hl7.Fhir.Model.RelatedArtifact.RelatedArtifactType> TypeElement
    {
      get { return _TypeElement; }
      set { _TypeElement = value; OnPropertyChanged("TypeElement"); }
    }

    private Code<Hl7.Fhir.Model.RelatedArtifact.RelatedArtifactType> _TypeElement;

    /// <summary>
    /// documentation | justification | citation | predecessor | successor | derived-from | depends-on | composed-of | part-of | amends | amended-with | appends | appended-with | cites | cited-by | comments-on | comment-in | contains | contained-in | corrects | correction-in | replaces | replaced-with | retracts | retracted-by | signs | similar-to | supports | supported-with | transforms | transformed-into | transformed-with | documents | specification-of | created-with | cite-as
    /// </summary>
    /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
    [IgnoreDataMember]
    public Hl7.Fhir.Model.RelatedArtifact.RelatedArtifactType? Type
    {
      get { return TypeElement != null ? TypeElement.Value : null; }
      set
      {
        if (value == null)
          TypeElement = null;
        else
          TypeElement = new Code<Hl7.Fhir.Model.RelatedArtifact.RelatedArtifactType>(value);
        OnPropertyChanged("Type");
      }
    }

    /// <summary>
    /// Additional classifiers. Note: Element was introduced in R5, do not use when working with older releases.
    /// </summary>
    [FhirElement("classifier", InSummary=true, Order=40, Since=FhirRelease.R5)]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.CodeableConcept> Classifier
    {
      get { if(_Classifier==null) _Classifier = new List<Hl7.Fhir.Model.CodeableConcept>(); return _Classifier; }
      set { _Classifier = value; OnPropertyChanged("Classifier"); }
    }

    private List<Hl7.Fhir.Model.CodeableConcept> _Classifier;

    /// <summary>
    /// Short label
    /// </summary>
    [FhirElement("label", InSummary=true, Order=50)]
    [DataMember]
    public Hl7.Fhir.Model.FhirString LabelElement
    {
      get { return _LabelElement; }
      set { _LabelElement = value; OnPropertyChanged("LabelElement"); }
    }

    private Hl7.Fhir.Model.FhirString _LabelElement;

    /// <summary>
    /// Short label
    /// </summary>
    /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
    [IgnoreDataMember]
    public string Label
    {
      get { return LabelElement != null ? LabelElement.Value : null; }
      set
      {
        if (value == null)
          LabelElement = null;
        else
          LabelElement = new Hl7.Fhir.Model.FhirString(value);
        OnPropertyChanged("Label");
      }
    }

    /// <summary>
    /// Brief description of the related artifact
    /// </summary>
    [FhirElement("display", InSummary=true, Order=60)]
    [DataMember]
    public Hl7.Fhir.Model.FhirString DisplayElement
    {
      get { return _DisplayElement; }
      set { _DisplayElement = value; OnPropertyChanged("DisplayElement"); }
    }

    private Hl7.Fhir.Model.FhirString _DisplayElement;

    /// <summary>
    /// Brief description of the related artifact
    /// </summary>
    /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
    [IgnoreDataMember]
    public string Display
    {
      get { return DisplayElement != null ? DisplayElement.Value : null; }
      set
      {
        if (value == null)
          DisplayElement = null;
        else
          DisplayElement = new Hl7.Fhir.Model.FhirString(value);
        OnPropertyChanged("Display");
      }
    }

    /// <summary>
    /// Bibliographic citation for the artifact
    /// </summary>
    [FhirElement("citation", InSummary=true, Order=70)]
    [DataMember]
    public Hl7.Fhir.Model.Markdown CitationElement
    {
      get { return _CitationElement; }
      set { _CitationElement = value; OnPropertyChanged("CitationElement"); }
    }

    private Hl7.Fhir.Model.Markdown _CitationElement;

    /// <summary>
    /// Bibliographic citation for the artifact
    /// </summary>
    /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
    [IgnoreDataMember]
    public string Citation
    {
      get { return CitationElement != null ? CitationElement.Value : null; }
      set
      {
        if (value == null)
          CitationElement = null;
        else
          CitationElement = new Hl7.Fhir.Model.Markdown(value);
        OnPropertyChanged("Citation");
      }
    }

    /// <summary>
    /// Where the artifact can be accessed. Note: Element is deprecated since R5, do not use with R5 and newer releases.
    /// </summary>
    [FhirElement("url", InSummary=true, Order=70)]
    [NotMapped(Since=FhirRelease.R5)]
    [DataMember]
    public Hl7.Fhir.Model.FhirUrl UrlElement
    {
      get { return _UrlElement; }
      set { _UrlElement = value; OnPropertyChanged("UrlElement"); }
    }

    private Hl7.Fhir.Model.FhirUrl _UrlElement;

    /// <summary>
    /// Where the artifact can be accessed
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
          UrlElement = new Hl7.Fhir.Model.FhirUrl(value);
        OnPropertyChanged("Url");
      }
    }

    /// <summary>
    /// What document is being referenced
    /// </summary>
    [FhirElement("document", InSummary=true, Order=80)]
    [DataMember]
    public Hl7.Fhir.Model.Attachment Document
    {
      get { return _Document; }
      set { _Document = value; OnPropertyChanged("Document"); }
    }

    private Hl7.Fhir.Model.Attachment _Document;

    /// <summary>
    /// What artifact is being referenced
    /// </summary>
    [FhirElement("resource", InSummary=true, Order=90)]
    [DataMember]
    public Hl7.Fhir.Model.Canonical ResourceElement
    {
      get { return _ResourceElement; }
      set { _ResourceElement = value; OnPropertyChanged("ResourceElement"); }
    }

    private Hl7.Fhir.Model.Canonical _ResourceElement;

    /// <summary>
    /// What artifact is being referenced
    /// </summary>
    /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
    [IgnoreDataMember]
    public string Resource
    {
      get { return ResourceElement != null ? ResourceElement.Value : null; }
      set
      {
        if (value == null)
          ResourceElement = null;
        else
          ResourceElement = new Hl7.Fhir.Model.Canonical(value);
        OnPropertyChanged("Resource");
      }
    }

    /// <summary>
    /// What artifact, if not a conformance resource. Note: Element was introduced in R5, do not use when working with older releases.
    /// </summary>
    [FhirElement("resourceReference", InSummary=true, Order=100, Since=FhirRelease.R5)]
    [CLSCompliant(false)]
    [References("Resource")]
    [DataMember]
    public Hl7.Fhir.Model.ResourceReference ResourceReference
    {
      get { return _ResourceReference; }
      set { _ResourceReference = value; OnPropertyChanged("ResourceReference"); }
    }

    private Hl7.Fhir.Model.ResourceReference _ResourceReference;

    /// <summary>
    /// draft | active | retired | unknown. Note: Element was introduced in R5, do not use when working with older releases.
    /// </summary>
    [FhirElement("publicationStatus", InSummary=true, Order=110, Since=FhirRelease.R5)]
    [DeclaredType(Type = typeof(Code))]
    [Binding("RelatedArtifactPublicationStatus")]
    [DataMember]
    public Code<Hl7.Fhir.Model.PublicationStatus> PublicationStatusElement
    {
      get { return _PublicationStatusElement; }
      set { _PublicationStatusElement = value; OnPropertyChanged("PublicationStatusElement"); }
    }

    private Code<Hl7.Fhir.Model.PublicationStatus> _PublicationStatusElement;

    /// <summary>
    /// draft | active | retired | unknown
    /// </summary>
    /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
    [IgnoreDataMember]
    public Hl7.Fhir.Model.PublicationStatus? PublicationStatus
    {
      get { return PublicationStatusElement != null ? PublicationStatusElement.Value : null; }
      set
      {
        if (value == null)
          PublicationStatusElement = null;
        else
          PublicationStatusElement = new Code<Hl7.Fhir.Model.PublicationStatus>(value);
        OnPropertyChanged("PublicationStatus");
      }
    }

    /// <summary>
    /// Date of publication of the artifact being referred to. Note: Element was introduced in R5, do not use when working with older releases.
    /// </summary>
    [FhirElement("publicationDate", InSummary=true, Order=120, Since=FhirRelease.R5)]
    [DataMember]
    public Hl7.Fhir.Model.Date PublicationDateElement
    {
      get { return _PublicationDateElement; }
      set { _PublicationDateElement = value; OnPropertyChanged("PublicationDateElement"); }
    }

    private Hl7.Fhir.Model.Date _PublicationDateElement;

    /// <summary>
    /// Date of publication of the artifact being referred to
    /// </summary>
    /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
    [IgnoreDataMember]
    public string PublicationDate
    {
      get { return PublicationDateElement != null ? PublicationDateElement.Value : null; }
      set
      {
        if (value == null)
          PublicationDateElement = null;
        else
          PublicationDateElement = new Hl7.Fhir.Model.Date(value);
        OnPropertyChanged("PublicationDate");
      }
    }

    public override IDeepCopyable CopyTo(IDeepCopyable other)
    {
      var dest = other as RelatedArtifact;

      if (dest == null)
      {
        throw new ArgumentException("Can only copy to an object of the same type", "other");
      }

      base.CopyTo(dest);
      if(TypeElement != null) dest.TypeElement = (Code<Hl7.Fhir.Model.RelatedArtifact.RelatedArtifactType>)TypeElement.DeepCopy();
      if(Classifier != null) dest.Classifier = new List<Hl7.Fhir.Model.CodeableConcept>(Classifier.DeepCopy());
      if(LabelElement != null) dest.LabelElement = (Hl7.Fhir.Model.FhirString)LabelElement.DeepCopy();
      if(DisplayElement != null) dest.DisplayElement = (Hl7.Fhir.Model.FhirString)DisplayElement.DeepCopy();
      if(CitationElement != null) dest.CitationElement = (Hl7.Fhir.Model.Markdown)CitationElement.DeepCopy();
      if(UrlElement != null) dest.UrlElement = (Hl7.Fhir.Model.FhirUrl)UrlElement.DeepCopy();
      if(Document != null) dest.Document = (Hl7.Fhir.Model.Attachment)Document.DeepCopy();
      if(ResourceElement != null) dest.ResourceElement = (Hl7.Fhir.Model.Canonical)ResourceElement.DeepCopy();
      if(ResourceReference != null) dest.ResourceReference = (Hl7.Fhir.Model.ResourceReference)ResourceReference.DeepCopy();
      if(PublicationStatusElement != null) dest.PublicationStatusElement = (Code<Hl7.Fhir.Model.PublicationStatus>)PublicationStatusElement.DeepCopy();
      if(PublicationDateElement != null) dest.PublicationDateElement = (Hl7.Fhir.Model.Date)PublicationDateElement.DeepCopy();
      return dest;
    }

    public override IDeepCopyable DeepCopy()
    {
      return CopyTo(new RelatedArtifact());
    }

    ///<inheritdoc />
    public override bool Matches(IDeepComparable other)
    {
      var otherT = other as RelatedArtifact;
      if(otherT == null) return false;

      if(!base.Matches(otherT)) return false;
      if( !DeepComparable.Matches(TypeElement, otherT.TypeElement)) return false;
      if( !DeepComparable.Matches(Classifier, otherT.Classifier)) return false;
      if( !DeepComparable.Matches(LabelElement, otherT.LabelElement)) return false;
      if( !DeepComparable.Matches(DisplayElement, otherT.DisplayElement)) return false;
      if( !DeepComparable.Matches(CitationElement, otherT.CitationElement)) return false;
      if( !DeepComparable.Matches(UrlElement, otherT.UrlElement)) return false;
      if( !DeepComparable.Matches(Document, otherT.Document)) return false;
      if( !DeepComparable.Matches(ResourceElement, otherT.ResourceElement)) return false;
      if( !DeepComparable.Matches(ResourceReference, otherT.ResourceReference)) return false;
      if( !DeepComparable.Matches(PublicationStatusElement, otherT.PublicationStatusElement)) return false;
      if( !DeepComparable.Matches(PublicationDateElement, otherT.PublicationDateElement)) return false;

      return true;
    }

    public override bool IsExactly(IDeepComparable other)
    {
      var otherT = other as RelatedArtifact;
      if(otherT == null) return false;

      if(!base.IsExactly(otherT)) return false;
      if( !DeepComparable.IsExactly(TypeElement, otherT.TypeElement)) return false;
      if( !DeepComparable.IsExactly(Classifier, otherT.Classifier)) return false;
      if( !DeepComparable.IsExactly(LabelElement, otherT.LabelElement)) return false;
      if( !DeepComparable.IsExactly(DisplayElement, otherT.DisplayElement)) return false;
      if( !DeepComparable.IsExactly(CitationElement, otherT.CitationElement)) return false;
      if( !DeepComparable.IsExactly(UrlElement, otherT.UrlElement)) return false;
      if( !DeepComparable.IsExactly(Document, otherT.Document)) return false;
      if( !DeepComparable.IsExactly(ResourceElement, otherT.ResourceElement)) return false;
      if( !DeepComparable.IsExactly(ResourceReference, otherT.ResourceReference)) return false;
      if( !DeepComparable.IsExactly(PublicationStatusElement, otherT.PublicationStatusElement)) return false;
      if( !DeepComparable.IsExactly(PublicationDateElement, otherT.PublicationDateElement)) return false;

      return true;
    }

    [IgnoreDataMember]
    public override IEnumerable<Base> Children
    {
      get
      {
        foreach (var item in base.Children) yield return item;
        if (TypeElement != null) yield return TypeElement;
        foreach (var elem in Classifier) { if (elem != null) yield return elem; }
        if (LabelElement != null) yield return LabelElement;
        if (DisplayElement != null) yield return DisplayElement;
        if (CitationElement != null) yield return CitationElement;
        if (UrlElement != null) yield return UrlElement;
        if (Document != null) yield return Document;
        if (ResourceElement != null) yield return ResourceElement;
        if (ResourceReference != null) yield return ResourceReference;
        if (PublicationStatusElement != null) yield return PublicationStatusElement;
        if (PublicationDateElement != null) yield return PublicationDateElement;
      }
    }

    [IgnoreDataMember]
    public override IEnumerable<ElementValue> NamedChildren
    {
      get
      {
        foreach (var item in base.NamedChildren) yield return item;
        if (TypeElement != null) yield return new ElementValue("type", TypeElement);
        foreach (var elem in Classifier) { if (elem != null) yield return new ElementValue("classifier", elem); }
        if (LabelElement != null) yield return new ElementValue("label", LabelElement);
        if (DisplayElement != null) yield return new ElementValue("display", DisplayElement);
        if (CitationElement != null) yield return new ElementValue("citation", CitationElement);
        if (UrlElement != null) yield return new ElementValue("url", UrlElement);
        if (Document != null) yield return new ElementValue("document", Document);
        if (ResourceElement != null) yield return new ElementValue("resource", ResourceElement);
        if (ResourceReference != null) yield return new ElementValue("resourceReference", ResourceReference);
        if (PublicationStatusElement != null) yield return new ElementValue("publicationStatus", PublicationStatusElement);
        if (PublicationDateElement != null) yield return new ElementValue("publicationDate", PublicationDateElement);
      }
    }

    protected override bool TryGetValue(string key, out object value)
    {
      switch (key)
      {
        case "type":
          value = TypeElement;
          return TypeElement is not null;
        case "classifier":
          value = Classifier;
          return Classifier?.Any() == true;
        case "label":
          value = LabelElement;
          return LabelElement is not null;
        case "display":
          value = DisplayElement;
          return DisplayElement is not null;
        case "citation":
          value = CitationElement;
          return CitationElement is not null;
        case "url":
          value = UrlElement;
          return UrlElement is not null;
        case "document":
          value = Document;
          return Document is not null;
        case "resource":
          value = ResourceElement;
          return ResourceElement is not null;
        case "resourceReference":
          value = ResourceReference;
          return ResourceReference is not null;
        case "publicationStatus":
          value = PublicationStatusElement;
          return PublicationStatusElement is not null;
        case "publicationDate":
          value = PublicationDateElement;
          return PublicationDateElement is not null;
        default:
          return base.TryGetValue(key, out value);
      }

    }

    protected override IEnumerable<KeyValuePair<string, object>> GetElementPairs()
    {
      foreach (var kvp in base.GetElementPairs()) yield return kvp;
      if (TypeElement is not null) yield return new KeyValuePair<string,object>("type",TypeElement);
      if (Classifier?.Any() == true) yield return new KeyValuePair<string,object>("classifier",Classifier);
      if (LabelElement is not null) yield return new KeyValuePair<string,object>("label",LabelElement);
      if (DisplayElement is not null) yield return new KeyValuePair<string,object>("display",DisplayElement);
      if (CitationElement is not null) yield return new KeyValuePair<string,object>("citation",CitationElement);
      if (UrlElement is not null) yield return new KeyValuePair<string,object>("url",UrlElement);
      if (Document is not null) yield return new KeyValuePair<string,object>("document",Document);
      if (ResourceElement is not null) yield return new KeyValuePair<string,object>("resource",ResourceElement);
      if (ResourceReference is not null) yield return new KeyValuePair<string,object>("resourceReference",ResourceReference);
      if (PublicationStatusElement is not null) yield return new KeyValuePair<string,object>("publicationStatus",PublicationStatusElement);
      if (PublicationDateElement is not null) yield return new KeyValuePair<string,object>("publicationDate",PublicationDateElement);
    }

  }

}

// end of file

﻿/*
 * Copyright (c) 2023, Firely (info@fire.ly) and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-net-sdk/master/LICENSE
 */


#nullable enable

using Hl7.Fhir.ElementModel;
using Hl7.Fhir.Introspection;
using Hl7.Fhir.Model;
using Hl7.Fhir.Utility;
using System;
using System.Linq;

namespace Hl7.Fhir.Serialization
{
    /// <summary>
    /// This is an implementation of <see cref="IFhirSerializationEngine"/> which uses the
    /// "old" TypedElement-based parser and serializer. It is used as a switchable serialization
    /// in the <c>BaseFhirClient</c>.
    /// </summary>
    internal class ElementModelSerializationEngine : IFhirSerializationEngine
    {
        private readonly ModelInspector _inspector;
        private readonly ParserSettings? _settings;

        public ElementModelSerializationEngine(ModelInspector inspector, ParserSettings? settings)
        {
            _inspector = inspector;
            _settings = settings;
        }

        public static bool TryUnpackElementModelException(DeserializationFailedException dfe, out FormatException? fe)
        {
            if (dfe.Exceptions.Count == 1 && dfe.Exceptions.Single() is ElementModelParserException empe)
            {
                fe = (FormatException)empe.InnerException!;
                return true;
            }
            else
            {
                fe = null;
                return false;
            }
        }

        public Resource? DeserializeFromXml(string data) => deserialize(() => FhirXmlNode.Parse(data));

        public Resource? DeserializeFromJson(string data) => deserialize(() => FhirJsonNode.Parse(data));

        private Resource? deserialize(Func<ISourceNode> deserializer)
        {
            var settings = BaseFhirParser.BuildPocoBuilderSettings(_settings ?? ParserSettings.CreateDefault());

            try
            {
                return deserializer().ToPoco(_inspector, null, settings) as Resource;
            }
            catch (FormatException fe)
            {
                throw new DeserializationFailedException(null, new ElementModelParserException(fe));
            }
            catch (InvalidOperationException ioe)
            {
                // Unfortunately, our ElementModel parsers treats resources without a type indicator with an InvalidOperationException.
                // This should have been a parsing error, so let's turn it into one.
                var fmt = new FormatException(ioe.Message);
                throw new DeserializationFailedException(null, new ElementModelParserException(fmt));
            }
        }


        public string SerializeToXml(Resource instance) => new CommonFhirXmlSerializer(_inspector).SerializeToString(instance);

        public string SerializeToJson(Resource instance) => new CommonFhirJsonSerializer(_inspector).SerializeToString(instance);

        internal class ElementModelParserException : CodedException
        {
            public const string ELEMENTMODEL_PARSER_EXCEPTION = "EMP001";

            public ElementModelParserException(FormatException fe) : base(ELEMENTMODEL_PARSER_EXCEPTION, fe.Message, fe)
            {
                // Nothing
            }
        }
    }
}

#nullable restore
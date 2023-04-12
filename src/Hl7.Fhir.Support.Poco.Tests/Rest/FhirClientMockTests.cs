﻿using FluentAssertions;
using Hl7.Fhir.ElementModel;
using Hl7.Fhir.Introspection;
using Hl7.Fhir.Model;
using Hl7.Fhir.Rest;
using Hl7.Fhir.Serialization;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Moq.Protected;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using T=System.Threading.Tasks;

namespace Hl7.Fhir.Core.Tests.Rest
{
    [TestClass]
    public class FhirClientMockTest
    {
        private static readonly ModelInspector TESTINSPECTOR = ModelInspector.ForType(typeof(TestPatient));
        private static readonly string TESTVERSION = "3.0.1";
        private static readonly IFhirSerializationEngine ELEMENTENGINE = FhirSerializationEngine.ElementModel(TESTINSPECTOR, new());
        private static readonly IFhirSerializationEngine POCOENGINE = FhirSerializationEngine.Poco(TESTINSPECTOR);

        private static async T.Task mockVersionResponse(string capabilityStatementResponseJson, string patientResponseJson, bool verifyFhirVersion = true)
        {
            var mock = new Mock<HttpMessageHandler>();
            var response = new HttpResponseMessage
            {
                StatusCode = HttpStatusCode.OK,
                Content = new StringContent(capabilityStatementResponseJson, Encoding.UTF8, "application/json"),
                RequestMessage = new HttpRequestMessage(HttpMethod.Get, "http://example.com"),
            };

            var patientResponse = new HttpResponseMessage
            {
                StatusCode = HttpStatusCode.OK,
                Content = new StringContent(patientResponseJson, Encoding.UTF8, "application/json"),
                RequestMessage = new HttpRequestMessage(HttpMethod.Get, "http://example.com/Patient/1"),
            };

            //Two mocks, since response messages get disposed after each "SendAsync()", and the test required two rest calls.
            mock
               .Protected()
                       .As<IHttpResponseMessage>()
                       .Setup(m => m.SendAsync(
                          It.Is<HttpRequestMessage>(h => h.RequestUri == new Uri("http://example.com/metadata?_summary=true")), //the call to check capabilitystatement
                          It.IsAny<CancellationToken>()))
                       .ReturnsAsync(response);


            mock
               .Protected()
                       .As<IHttpResponseMessage>()
                       .Setup(m => m.SendAsync(
                          It.Is<HttpRequestMessage>(h => h.RequestUri == new Uri("http://example.com/Patient/1")),  //the GET Patient
                          It.IsAny<CancellationToken>()))
                       .ReturnsAsync(patientResponse);

            using var client = new BaseFhirClient(new Uri("http://example.com"), mock.Object, TESTINSPECTOR, new FhirClientSettings { ExplicitFhirVersion = TESTVERSION, VerifyFhirVersion = verifyFhirVersion });
            await client.ReadAsync<TestPatient>("Patient/1");
        }

        [TestMethod]
        public async T.Task VerifyFhirVersionTest()
        {
            // the usual use case
            var capabilityStatementJson = @"{""resourceType"": ""CapabilityStatement"",  ""id"": ""example:"", ""fhirVersion"": """ + TESTVERSION + @"""}";
            var patientResponseJson = @"{""resourceType"": ""Patient"",  ""id"": ""example:""}";
            Func<System.Threading.Tasks.Task> act = () => mockVersionResponse(capabilityStatementJson, patientResponseJson);

            await act
               .Should().NotThrowAsync();
        }

        [TestMethod]
        public async T.Task VerifyFhirVersionTestUnknownVersion()
        {
            // Verify server version with an unknow version
            var capabilityStatementJson = @"{""resourceType"": ""CapabilityStatement"",  ""id"": ""example:"", ""fhirVersion"": ""0.0.0""}";
            var patientResponseJson = @"{""resourceType"": ""Patient"",  ""id"": ""example:""}";
            Func<System.Threading.Tasks.Task> act = () => mockVersionResponse(capabilityStatementJson, patientResponseJson);
            await act
                .Should().ThrowAsync<NotSupportedException>()
                .WithMessage($"This client supports FHIR version {TESTVERSION} but the server uses version 0.0.0");
        }

        [TestMethod]
        public async T.Task VerifyFhirVersionTestNoVersion()
        {
            // Verify server version with no version returned
            var capabilityStatementJson = @"{""resourceType"": ""CapabilityStatement"",  ""id"": ""example:""}";
            var patientResponseJson = @"{""resourceType"": ""Patient"",  ""id"": ""example:""}";
            Func<System.Threading.Tasks.Task> act = () => mockVersionResponse(capabilityStatementJson, patientResponseJson);
            await act
                .Should().ThrowAsync<NotSupportedException>()
                .WithMessage("This CapabilityStatement of the server doesn't state its FHIR version");
        }

        [TestMethod]
        public async T.Task NoVerifyFhirVersionWithIncorrectPatient()
        {
            // No server version check, but incorrect patient. This could be a wrong FHIR version. So we check the extra appended message
            var capabilityStatementJson = @"{""resourceType"": ""CapabilityStatement"",  ""id"": ""example:"", ""fhirVersion"": """ + TESTVERSION + @"""}";
            var patientResponseJson = @"{""resourceType"": ""Patient"",  ""id"": ""example:"", ""unknownMember"": ""value""}";
            Func<Task> act = () => mockVersionResponse(capabilityStatementJson, patientResponseJson, false);
            await act
                .Should().ThrowAsync<StructuralTypeException>()
                .Where(e => e.Message.EndsWith("FHIR server with the correct FHIR version."));
        }

        [TestMethod]
        public async T.Task VerifyFhirVersionWithIncorrectPatient()
        {
            // Server version check with an incorrect patient. So the error is legit
            var capabilityStatementJson = @"{""resourceType"": ""CapabilityStatement"",  ""id"": ""example:"", ""fhirVersion"": """ + TESTVERSION + @"""}";
            var patientResponseJson = @"{""resourceType"": ""Patient"",  ""id"": ""example:"", ""unknownMember"": ""value""}";
            Func<System.Threading.Tasks.Task> act = () => mockVersionResponse(capabilityStatementJson, patientResponseJson, true);
            await act
                .Should().ThrowAsync<StructuralTypeException>()
                .Where(e => !e.Message.EndsWith("FHIR server with the correct FHIR version."));
        }


        [TestMethod]
        public async T.Task LocationHeaderTest()
        {
            var mock = new Mock<HttpMessageHandler>();
            var response = new HttpResponseMessage
            {
                StatusCode = HttpStatusCode.OK,
                Content = new StringContent(@"{""resourceType"": ""Bundle"",  ""id"": ""example:""}", Encoding.UTF8, "application/json"),
                RequestMessage = new HttpRequestMessage(HttpMethod.Get, "http://example.com/Patient?name=henry"),
            };

            response.Headers.Add("Location", "/fhir/*/Bundle/example");

            mock
             .Protected()
                     .As<IHttpResponseMessage>()
                     .Setup(m => m.SendAsync(
                        It.Is<HttpRequestMessage>(h => h.RequestUri == new Uri("http://example.com/Patient?name=henry")),
                        It.IsAny<CancellationToken>()))
                     .ReturnsAsync(response);

            using var client = new BaseFhirClient(new("http://example.com"), mock.Object, TESTINSPECTOR, new FhirClientSettings { ExplicitFhirVersion = TESTVERSION, VerifyFhirVersion = false });

            var patient = await client.SearchAsync<TestPatient>(new string[] { "name=henry" });

            Assert.AreEqual("/fhir/*/Bundle/example", client.LastResult.Location);
        }


        [DataTestMethod]
        [DataRow(true, DisplayName = "Use FhirVersion in Accept header")]
        [DataRow(false, DisplayName = "Don't use FhirVersion in Accept header")]
        public async T.Task AcceptHeaderTest(bool useFhirVersionHeader)
        {
            var mock = new Mock<HttpMessageHandler>();
            var response = new HttpResponseMessage
            {
                StatusCode = HttpStatusCode.OK,
                Content = new StringContent(@"{""resourceType"": ""Bundle"",  ""id"": ""example:""}", Encoding.UTF8, "application/json"),
                RequestMessage = new HttpRequestMessage(HttpMethod.Get, "http://example.com/Patient?name=henry"),
            };

            mock
             .Protected()
                         .As<IHttpResponseMessage>()
                         .Setup(m => m.SendAsync(
                            It.Is<HttpRequestMessage>(h => h.RequestUri == new Uri("http://example.com/Patient?name=henry")),
                            It.IsAny<CancellationToken>()))
                         .ReturnsAsync(response);

            using var client = new BaseFhirClient(new("http://example.com"), mock.Object, TESTINSPECTOR, new FhirClientSettings
            {
                ExplicitFhirVersion = TESTVERSION,
                VerifyFhirVersion = false,
                UseFhirVersionInAcceptHeader = useFhirVersionHeader
            });

            var patient = await client.SearchAsync<TestPatient>(new string[] { "name=henry" });

            mock
                .Protected()
                .As<IHttpResponseMessage>()
                .Verify(m => m.SendAsync(
                    It.Is<HttpRequestMessage>(h => findInAcceptHeader(h.Headers.Accept, "fhirVersion", useFhirVersionHeader)),
                    It.IsAny<CancellationToken>()));
        }

        private static bool findInAcceptHeader(HttpHeaderValueCollection<MediaTypeWithQualityHeaderValue> acceptHeader, string headerName, bool exists)
            => acceptHeader.SelectMany(a => a.Parameters).Any(p => p.Name == headerName) == exists;

        public static IEnumerable<object[]> GetData()
        {
            yield return new object[] { "http://example.com/Patient/example/_history", "HistoryAsync", "Patient/example" };
            yield return new object[] { "http://example.com/Patient/example/_history", "HistoryAsync", new Uri("http://example.com/Patient/example") };
            yield return new object[] { "http://example.com/Patient/example/_history", "History", "Patient/example" };
            yield return new object[] { "http://example.com/Patient/example/_history", "History", new Uri("http://example.com/Patient/example") };
            yield return new object[] { "http://example.com/Patient/_history", "TypeHistory", "Patient" };
            yield return new object[] { "http://example.com/Patient/_history", "TypeHistoryAsync", "Patient" };
            yield return new object[] { "http://example.com/_history", "WholeSystemHistory", null };
            yield return new object[] { "http://example.com/_history", "WholeSystemHistoryAsync", null };
        }

        [DataTestMethod]
        [DynamicData(nameof(GetData), DynamicDataSourceType.Method)]
        public void HistoryContainsNoSummaryParameter(string expectedRequest, string methodName, object parameter)
        {
            Uri expectedRequestUri = new(expectedRequest);
            var requests = new List<HttpRequestMessage>();

            var client = setupClient();

            var methods = typeof(BaseFhirClient).GetMethods(BindingFlags.Instance | BindingFlags.Public);
            var method = parameter is null
                ? methods.SingleOrDefault(m => m.Name == methodName)
                : methods.SingleOrDefault(m => m.Name == methodName && m.GetParameters().First().ParameterType == parameter.GetType());

            method.Should().NotBeNull($"{methodName} should be a method of FhirClient");

            var p = parameter is null ? Enumerable.Empty<object>() : new[] { parameter };
            p = p.Concat(method.GetParameters().Skip(parameter is null ? 0 : 1).Select(param => param.HasDefaultValue ? param.DefaultValue : null));
            method.Invoke(client, p.ToArray());


            requests.Should().OnlyContain(req => req.RequestUri == expectedRequestUri);

            BaseFhirClient setupClient()
            {
                var mock = new Mock<HttpMessageHandler>();

                var response = new HttpResponseMessage
                {
                    StatusCode = HttpStatusCode.OK,
                    Content = new StringContent(@"{""resourceType"": ""Bundle"",  ""id"": ""example:""}", Encoding.UTF8, "application/json"), // not interested in the Content
                    RequestMessage = new HttpRequestMessage(HttpMethod.Get, expectedRequestUri),
                };

                mock
                 .Protected()
                         .As<IHttpResponseMessage>()
                         .Setup(m => m.SendAsync(It.IsAny<HttpRequestMessage>(), It.IsAny<CancellationToken>()))
                         .Callback<HttpRequestMessage, CancellationToken>((request, token) => requests.Add(request))
                         .ReturnsAsync(response);

                return new BaseFhirClient(
                    new(expectedRequestUri.GetLeftPart(UriPartial.Authority)), 
                    mock.Object,
                    TESTINSPECTOR,
                    new FhirClientSettings {ExplicitFhirVersion = TESTVERSION, VerifyFhirVersion = false });
            }
        }

        /// <summary>
        /// Used only for intelligence help
        /// </summary>
        private interface IHttpResponseMessage
        {
            Task<HttpResponseMessage> SendAsync(HttpRequestMessage message, CancellationToken token);
        }

        [TestMethod]
        [ExpectedException(typeof(FhirOperationException))]
        public async T.Task TestUnauthorizedWithANonFhirJsonBody()
        {
            var mock = new Mock<HttpMessageHandler>();
            var response = new HttpResponseMessage
            {
                StatusCode = HttpStatusCode.Unauthorized,
                Content = new StringContent(@"{""foo"": ""bar"",  ""id"": ""example:""}", Encoding.UTF8, "application/json"),
                RequestMessage = new HttpRequestMessage(HttpMethod.Get, "http://example.com/Patient?name=henry")
            };

            var authValue = AuthenticationHeaderValue.Parse("foo");
            response.RequestMessage.Headers.Authorization = authValue;

            mock
             .Protected()
                     .Setup<System.Threading.Tasks.Task<HttpResponseMessage>>(
                        "SendAsync",
                        ItExpr.Is<HttpRequestMessage>(h => h.RequestUri == new Uri("http://example.com/Patient?name=henry")),
                        ItExpr.IsAny<CancellationToken>())
                     .ReturnsAsync(response);

            using var client = new BaseFhirClient(new("http://example.com"), mock.Object, TESTINSPECTOR, new FhirClientSettings {ExplicitFhirVersion = TESTVERSION, VerifyFhirVersion = false });
            client.RequestHeaders.Authorization = authValue;

            var patient = await client.SearchAsync<TestPatient>(new string[] { "name=henry" });
        }

        [TestMethod]
        public async T.Task TestOperationWithEmptyBody()
        {
            var mock = new Mock<HttpMessageHandler>();
            var response = new HttpResponseMessage
            {
                StatusCode = HttpStatusCode.OK,
                Content = new StringContent(@"{""resourceType"": ""Parameters"",  ""parameter"": [ { ""name"": ""result"", ""valueString"": ""connected""}]  }", Encoding.UTF8, "application/json"),
                RequestMessage = new HttpRequestMessage(HttpMethod.Post, "http://example.com/fhir/$ping")
            };


            mock
             .Protected()
                     .Setup<Task<HttpResponseMessage>>(
                        "SendAsync",
                        ItExpr.Is<HttpRequestMessage>(h => h.RequestUri == new Uri("http://example.com/fhir/$ping")),
                        ItExpr.IsAny<CancellationToken>())
                     .ReturnsAsync(response);

            using var client = new BaseFhirClient(new("http://example.com/fhir/"), mock.Object, TESTINSPECTOR, new FhirClientSettings {ExplicitFhirVersion = TESTVERSION, VerifyFhirVersion = false });

            var parameters = await client.OperationAsync(new Uri("http://example.com/fhir/$ping")) as Parameters;

            parameters.Parameter.FirstOrDefault().Value.Should().BeOfType<FhirString>().Which.Value.Should().Be("connected");

        }

        [TestMethod]
        public async Task WillFetchFullRepresentation()
        {
            var mock = new Mock<HttpMessageHandler>();
            var patientInstanceUri = new Uri("http://example.com/fhir/Patient/3141");
            // Send back an empty body with a location on a post, to force the client (configured to need the full representation)
            // to go back out and fetch the resource.
            var postResponse = new HttpResponseMessage
            {
                StatusCode = HttpStatusCode.Created,                
                RequestMessage = new HttpRequestMessage(HttpMethod.Post, "http://example.com/fhir/Patient")
            };
            postResponse.Headers.Location = patientInstanceUri;

            mock
               .Protected()
                       .As<IHttpResponseMessage>()
                       .Setup(m => m.SendAsync(It.IsAny<HttpRequestMessage>(), It.IsAny<CancellationToken>()))
                       .ReturnsAsync(postResponse);

            var patientResponse = new HttpResponseMessage
            {
                StatusCode = HttpStatusCode.OK,
                Content = new StringContent("""{"resourceType": "Patient",  "id": "example"}""", Encoding.UTF8, ContentType.JSON_CONTENT_HEADER),
                RequestMessage = new HttpRequestMessage(HttpMethod.Get, patientInstanceUri)
            };

            mock
               .Protected()
                       .As<IHttpResponseMessage>()
                       .Setup(m => m.SendAsync(
                           It.Is<HttpRequestMessage>(m => m.Method == HttpMethod.Get && m.RequestUri == patientInstanceUri), 
                           It.IsAny<CancellationToken>()))
                       .ReturnsAsync(patientResponse);

            using var client = new BaseFhirClient(new("http://example.com/fhir/"), mock.Object, TESTINSPECTOR, new FhirClientSettings { ExplicitFhirVersion = TESTVERSION, ReturnPreference = ReturnPreference.Representation });

            var pat = await client.CreateAsync(new TestPatient { Id = "example" });
            pat.Id.Should().Be("example");
        }

        [TestMethod]
        public async Task WillThrowWhenUnexpectedResourceTypeReceived()
        {
            var handler = sendBack("Organization");
            using var client = new BaseFhirClient(new("http://example.com/fhir/"), handler, TESTINSPECTOR, new FhirClientSettings { ExplicitFhirVersion = TESTVERSION});

            var act = () => client.ReadAsync<TestPatient>("Patient/example");
            await act.Should().ThrowAsync<FhirOperationException>().WithMessage("*expected a body of type TestPatient*");
        }

        [TestMethod]
        public async Task WillReturnOperationOutcomeOnOOEndpoint()
        {
            var handler = sendBack("OperationOutcome");
            using var client = new BaseFhirClient(new("http://example.com/fhir/"), handler, TESTINSPECTOR, new FhirClientSettings { ExplicitFhirVersion = TESTVERSION });

            var oo = await client.ReadAsync<OperationOutcome>("OperationOutcome/example");
            oo.Id.Should().Be("example");
        }

        [TestMethod]
        public async Task WillReturnOperationOutcomeOnOtherEndpoint()
        {
            var handler = sendBack("OperationOutcome");
            using var client = new BaseFhirClient(new("http://example.com/fhir/"), handler, TESTINSPECTOR, new FhirClientSettings { ExplicitFhirVersion = TESTVERSION });

            var oo = await client.ReadAsync<TestPatient>("Patient/example");
            oo.Should().BeNull();
            client.LastBodyAsResource.Should().BeOfType<OperationOutcome>().Which.Id.Should().Be("example");
            client.LastResult.Outcome.Should().BeOfType<OperationOutcome>().Which.Id.Should().Be("example");
        }


        private static HttpMessageHandler sendBack(string resourceType)
        {
            var mock = new Mock<HttpMessageHandler>();
            var response = new HttpResponseMessage
            {
                StatusCode = HttpStatusCode.OK,
                RequestMessage = new HttpRequestMessage(HttpMethod.Get, $"http://example.com/fhir/{resourceType}/example"),
                Content = new StringContent($$"""{"resourceType": "{{resourceType}}",  "id": "example"}""", Encoding.UTF8, ContentType.JSON_CONTENT_HEADER),
            };

            mock
             .Protected()
                     .As<IHttpResponseMessage>()
                     .Setup(m => m.SendAsync(It.IsAny<HttpRequestMessage>(), It.IsAny<CancellationToken>()))
                     .ReturnsAsync(response);

            return mock.Object;
        }

        [TestMethod]
        public async T.Task TestCanMockFhirClient()
        {
            var mock = new Mock<BaseFhirClient>(new object[] { new Uri("http://example.org"), TESTINSPECTOR, FhirClientSettings.CreateDefault() });
            var _ = await mock.Object.ReadAsync<TestPatient>("http://example.org/fhir");
            mock.Verify(c => c.ReadAsync<TestPatient>(It.IsAny<string>(), null, null, null), Times.Once);
        }


        [TestMethod]
        public async T.Task TestCanCancelInteraction()
        {
            var mock = new Mock<HttpMessageHandler>();
            mock.Protected()
                     .Setup<T.Task<HttpResponseMessage>>(
                        "SendAsync",
                        ItExpr.IsAny<HttpRequestMessage>(), ItExpr.IsAny<CancellationToken>())
                     .Returns<HttpRequestMessage,CancellationToken>((_,ct) => blocker(ct));

            bool isBlocking = false;

            async Task<HttpResponseMessage> blocker(CancellationToken ct)
            {
                isBlocking = true;
                await T.Task.Delay(2000,ct);

                Assert.Fail("Operation was not cancelled - it should never have gotten here.");

                // Unreachable code
                return new HttpResponseMessage();
            }

            using var client = new BaseFhirClient(new("http://example.com/fhir/"), mock.Object, TESTINSPECTOR, new FhirClientSettings {ExplicitFhirVersion = TESTVERSION, VerifyFhirVersion = false });

            var cts = new CancellationTokenSource();

            // Start the task and wait until it is "blocking"
            var blockingTask = client.OperationAsync(new Uri("http://example.com/fhir/$ping"), ct: cts.Token);
            while (!isBlocking) ;

            // now cancel it.
            cts.Cancel();

            try
            {
                // trying to await it should now throw cancelled exception
                var result = await blockingTask;
                Assert.Fail("Should have been cancelled.");
            }
            catch(OperationCanceledException)
            {
                // correct!
            }
        }
    }
}
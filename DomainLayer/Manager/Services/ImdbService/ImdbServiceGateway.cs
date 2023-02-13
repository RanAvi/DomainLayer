using DomainLayer.Manager.SegregatedInterfaces;
using DomainLayer.Manager.ServiceLocators;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Net;
using System.Net.Http;
using System.Text;

namespace DomainLayer.Manager.Services.ImdbService {
    internal sealed class ImdbServiceGateway:IDisposable {

        private readonly IHttpMessageHandlerProvider _httpMessageHandlerProvider;
        private HttpClient _httpClient;
        private bool _disposed;

        public ImdbServiceGateway(IHttpMessageHandlerProvider httpMessageHandlerProvider) {
            _httpMessageHandlerProvider = httpMessageHandlerProvider;
            _httpClient = CreateHttpClient("");
        }

 

        private HttpClient CreateHttpClient(string baseUrl) {
             var httpMessageHandler = MakeHttpMessageHandler();

            if (httpMessageHandler is HttpClientHandler httpClientHandler)
            {
                httpClientHandler.PreAuthenticate = true;
                httpClientHandler.DefaultProxyCredentials = CredentialCache.DefaultCredentials;
            }

            var httpClient = new HttpClient(httpMessageHandler)
            {
                BaseAddress = new Uri(baseUrl),
            };

            return httpClient;

        }

        private HttpMessageHandler MakeHttpMessageHandler() {
            return _httpMessageHandlerProvider.CreateHttpMessageHandler();
        }
        [ExcludeFromCodeCoverage]
        private void Dispose(bool disposing) {
            if (disposing && !_disposed && _httpClient != null)
            {
                var localHttpClient = _httpClient;
                localHttpClient.Dispose();
                _httpClient = null;
                _disposed = true;
            }
        }

        public void Dispose() {
            Dispose(true);
        }
    }
}

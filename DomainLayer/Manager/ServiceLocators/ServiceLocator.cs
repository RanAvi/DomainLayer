using DomainLayer.Manager.Services.ImdbService;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace DomainLayer.Manager.ServiceLocators {
    internal sealed class ServiceLocator : ServiceLocatorBase {
        protected override HttpMessageHandler CreateHttpMessageHandlerCore() {
            return new HttpClientHandler();
        }

        protected override ImdbServiceGateway CreateImdbServiceGetwayCore() {
            return new ImdbServiceGateway(this);
        }
    }
}

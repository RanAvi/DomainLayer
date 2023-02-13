using DomainLayer.Manager.SegregatedInterfaces;
using DomainLayer.Manager.Services.ImdbService;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace DomainLayer.Manager.ServiceLocators {
     internal abstract class ServiceLocatorBase: IHttpMessageHandlerProvider {
        public HttpMessageHandler CreateHttpMessageHandler() {
            return CreateHttpMessageHandlerCore();
        }

        public ImdbServiceGateway CreateImdbServiceGateway() {
              return CreateImdbServiceGetwayCore();
        }






        protected abstract ImdbServiceGateway CreateImdbServiceGetwayCore();

        protected abstract HttpMessageHandler CreateHttpMessageHandlerCore();

    }
}

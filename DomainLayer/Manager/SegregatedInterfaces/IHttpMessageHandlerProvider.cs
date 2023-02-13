using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace DomainLayer.Manager.SegregatedInterfaces {
    internal interface IHttpMessageHandlerProvider {
        HttpMessageHandler CreateHttpMessageHandler();
    }
}

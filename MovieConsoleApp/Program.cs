using DomainLayer;
using System;
using System.Threading.Tasks;

namespace MovieConsoleApp {
    class Program {
        static  async Task   Main(string[] args) {


            DomainFacade domainFacade = new DomainFacade();
            DomainFacadeProduct domainFacadeProduct = new DomainFacadeProduct();

            var product = domainFacadeProduct.GetAllProducts();
            var create = await domainFacade.GetAllMovies();
        }
    }
}

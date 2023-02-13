using DomainLayer.ManagerProducts;
using DomainLayer.ManagerProducts.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer {
    public sealed class DomainFacadeProduct {



        public Task<Product> GetProductById(int id) {
            return ProductManager.GetProductById(id);
        }

        public Task<IEnumerable<Product>> GetAllProducts() {
            return ProductManager.GetAllProducts();
        }

        public Task<IEnumerable<Product>> GetProductsByGenre(Product  product) {
            return ProductManager.GetProductsByGenre(product);
        }

        public Task<int> CreateProduct(Product  product) {
            return ProductManager.CreateProduct(product);
        }



    }
}

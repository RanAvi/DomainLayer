using DomainLayer.ManagerProducts.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.ManagerProducts {
    internal sealed class ProductManager {
        internal static Task<IEnumerable<Product>> GetProductsByGenre(Product product) {
            throw new NotImplementedException();
        }

        internal static Task<Product> GetProductById(int id) {
            throw new NotImplementedException();
        }

        internal static Task<int> CreateProduct(Product product) {
            throw new NotImplementedException();
        }

        internal static Task<IEnumerable<Product>> GetAllProducts() {
            throw new NotImplementedException();
        }
    }
}

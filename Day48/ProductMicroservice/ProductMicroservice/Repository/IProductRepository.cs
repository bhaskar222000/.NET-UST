using ProductMicroservice.Models;
using System.Collections.Generic;

namespace ProductMicroservice.Repository
{
     interface IProductRepository
    {
        IEnumerable<Product> GetProducts();
        Product GetProductById(int ProductId);
        void InsertProduct(Product Product);
        void DeleteProduct(int ProductId);
        void UpdateProduct(Product product);
        void Save();


    }
}

using ApplicationApp.Interfaces;
using Domain.Interfaces.InterfaceProduct;
using Entities.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApplicationApp.OpenApi
{
    public class AppProduct : InterfaceProductApp
    {
        IProduct _IProduct;
        public AppProduct(IProduct IProduct)
        {
            _IProduct = IProduct;
        }

        public async Task Add(Product Objet)
        {
            await _IProduct.Add(Objet);
        }

        public async Task Delete(Product Objet)
        {
            await _IProduct.Delete(Objet);
        }

        public async Task<Product> GetEntityById(int Id)
        {
            return await _IProduct.GetEntityById(Id);
        }

        public async Task<List<Product>> List()
        {
            return await _IProduct.List();
        }

        public async Task Update(Product Objet)
        {
            await _IProduct.Update(Objet);
        }
    }
}

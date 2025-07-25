using System.Collections.Generic;
using System.Threading.Tasks;
using P3AddNewFunctionalityDotNetCore.Models.Entities;
using P3AddNewFunctionalityDotNetCore.Models.ViewModels;

namespace P3AddNewFunctionalityDotNetCore.Models.Services
{
    public interface IProductService
    {
        List<Product> GetAllProducts();
        List<ProductViewModel> GetAllProductsViewModel();
        Product GetProductById(int id);
        ProductViewModel GetProductByIdViewModel(int id);
        void UpdateProductQuantities();
        void SaveProduct(ProductViewModel product);
        void DeleteProduct(int id);
        //List<string> CheckProductModelErrors(ProductViewModel product); // Je retire ça de l'interface vu que j'ai aussi retiré l'implémentation (on n'utilise plus de liste d'erreurs manuelles sous forme de strings). 
        Task<Product> GetProduct(int id);
        Task<IList<Product>> GetProduct();
    }
}

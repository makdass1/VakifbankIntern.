using Restoran_Vakifbank.Data;

namespace Restoran_Vakifbank.Repository.IRepository
{
    public interface IProductRepository
    {
        public Task<Product> CreateAsync(Product obj);
        public Task <Product> UpdateAsync(Product obj);
        public Task <bool> DeleteAsync(int obj);
        public Task <Product> GetAsync(int id);
        public Task <IEnumerable<Product>> GetAllAsync();
    }
}

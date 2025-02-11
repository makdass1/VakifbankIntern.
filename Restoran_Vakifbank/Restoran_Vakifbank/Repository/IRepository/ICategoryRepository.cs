using Restoran_Vakifbank.Data;

namespace Restoran_Vakifbank.Repository.IRepository
{
    public interface ICategoryRepository
    {
        public Category Create(Category obj);
        public Category Update(Category obj);
        public bool Delete(int obj);
        public Category Get(int id);
        public IEnumerable<Category> GetAll();
    }
}

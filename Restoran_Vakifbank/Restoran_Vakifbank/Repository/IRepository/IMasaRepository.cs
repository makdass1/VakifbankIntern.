using Restoran_Vakifbank.Data;

namespace Restoran_Vakifbank.Repository.IRepository
{
    public interface IMasaRepository
    {
        public Task<Masa> CreateAsync(Masa obj);
        public Task <Masa> UpdateAsync(Masa obj);
        public Task <bool> DeleteAsync(int obj);
        public Task <Masa> GetAsync(int id);
        public Task <IEnumerable<Masa>> GetAllAsync();
    }
}

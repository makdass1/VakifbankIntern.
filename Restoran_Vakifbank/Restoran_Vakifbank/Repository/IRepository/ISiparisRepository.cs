using Restoran_Vakifbank.Data;

namespace Restoran_Vakifbank.Repository.IRepository
{
    public interface ISiparisRepository
    {
        public Task<Siparis> CreateAsync(Siparis obj);
        public Task<Siparis> UpdateAsync(Siparis obj);
        public Task<bool> DeleteAsync(int obj);
        public Task<Siparis> GetAsync(int id);
        public Task<IEnumerable<Siparis>> GetAllAsync();

        
        
        public   Task<Siparis?> GetByMasaNoAsync(int masaNo);
        

    }
}

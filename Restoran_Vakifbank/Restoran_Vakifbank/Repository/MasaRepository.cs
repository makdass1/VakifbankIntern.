using Microsoft.EntityFrameworkCore;
using Restoran_Vakifbank.Data;
using Restoran_Vakifbank.Repository.IRepository;

namespace Restoran_Vakifbank.Repository
{
    public class MasaRepository : IMasaRepository
    {
        private readonly ApplicationDbContext _db;
        public MasaRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task<Masa> CreateAsync(Masa obj)
        {
            await   _db.Masa.AddAsync(obj);
            await _db.SaveChangesAsync();
            return obj;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var obj = await _db.Masa.FirstOrDefaultAsync(u => u.Id == id);
            if (obj != null)
            {
                _db.Masa.Remove(obj);
                return (await _db.SaveChangesAsync()) > 0;
            }
            return false;
        }
        public async Task<Masa> GetAsync(int id)
        {
            var obj =await _db.Masa.FirstOrDefaultAsync(u => u.Id == id);
            if(obj == null)
            {

                return new Masa();
            }
            return obj;
        }
        public async Task<Masa> GetByMasaNoAsync(int masaNo)
        {
            return await _db.Masa.FirstOrDefaultAsync(m => m.Masa_no == masaNo);
        }
        public async Task<IEnumerable<Masa>> GetAllWithSiparisAsync()
        {
            return await _db.Masa.Include(m => m.Siparisler).ToListAsync();
        }
        public async Task <IEnumerable<Masa>> GetAllAsync()
        {
            return await _db.Masa.ToListAsync();
        }

        public async Task<Masa> UpdateAsync(Masa obj)
        {
            var objFromDb=await _db.Masa.FirstOrDefaultAsync(u=> u.Id==obj.Id);
            if (objFromDb != null)
            {
                
                objFromDb.Doluluk= obj.Doluluk;
                _db.Masa.Update(objFromDb);
                await _db.SaveChangesAsync();
                return objFromDb;
            }
            return obj;
        }

       
    }
}

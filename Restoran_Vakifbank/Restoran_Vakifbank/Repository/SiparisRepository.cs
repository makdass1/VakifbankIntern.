
using Microsoft.EntityFrameworkCore;
using Restoran_Vakifbank.Data;
using Restoran_Vakifbank.Repository.IRepository;

namespace Restoran_Vakifbank.Repository
{
    public class SiparisRepository : ISiparisRepository
    {
        private readonly ApplicationDbContext _db;
        public SiparisRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task<Siparis> CreateAsync(Siparis obj)
        {
            await _db.Siparis.AddAsync(obj);
            await _db.SaveChangesAsync();
            return obj;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var obj = await _db.Siparis.FirstOrDefaultAsync(u => u.Id == id);
            if (obj != null)
            {
                _db.Siparis.Remove(obj);
                return (await _db.SaveChangesAsync()) > 0;
            }
            return false;
        }
        public async Task<Siparis> GetAsync(int id)
        {
            var obj = await _db.Siparis.FirstOrDefaultAsync(u => u.Id == id);
            if (obj == null)
            {

                return new Siparis();
            }
            return obj;
        }

        public async Task<IEnumerable<Siparis>> GetAllAsync()
        {
            return await _db.Siparis.ToListAsync();
        }

        public async Task<Siparis> UpdateAsync(Siparis obj)
        {
            var objFromDb = await _db.Siparis.FirstOrDefaultAsync(u => u.Id == obj.Id);
            if (objFromDb != null)
            {

                objFromDb.Masa_no = obj.Masa_no;
                objFromDb.Siparis_tutar = obj.Siparis_tutar;
                _db.Siparis.Update(objFromDb);
                await _db.SaveChangesAsync();
                return objFromDb;
            }
            return obj;
        }

    }
}
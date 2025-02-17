using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Restoran_Vakifbank.Data
{
    public class Siparis
    {
        public int Id { get; set; }
        [Range(0, 11)]
        public int Masa_no { get; set; }
        public bool Aktif { get; set; } = true;

        public bool Odendi { get; set; } = false;
        [ForeignKey("ProductId")]
        public List<int> ProductIds { get; set; } = new List<int>();



        public decimal Siparis_tutar { get; set; }


    }
}
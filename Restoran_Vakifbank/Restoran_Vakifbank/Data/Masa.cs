using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Restoran_Vakifbank.Data
{
    public class Masa
    {
        [Key]
        public int Id { get; set; }
        [Range(0, 11)]
        public int Masa_no { get; set; }
        public decimal Toplam_Tutar { get; set; }

       
        public string Doluluk { get; set; } = "";
        
        public List<Siparis> Siparisler { get; set; } = new List<Siparis>();
    }
}
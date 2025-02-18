using System.ComponentModel.DataAnnotations;

namespace Restoran_Vakifbank.Data
{
    public class Masa
    {
        public int Id { get; set; }

        decimal Toplam_Tutar { get; set; }
        public string Doluluk { get; set; } = "";

    }
}

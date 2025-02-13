using System.ComponentModel.DataAnnotations;

namespace Restoran_Vakifbank.Data
{
    public class Category
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Plase enter name..")]
        public string Name { get; set; } = "";
    }
}

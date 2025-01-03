using System.ComponentModel.DataAnnotations.Schema;

namespace miniProiect.Models
{
    public class Partener
    {
        public int Id { get; set; }
        public string Denumire { get; set; }
        
        public string? Cui {  get; set; }

        public string? Address {  get; set; }

        public int? IdIntrari { get; set; }
        [ForeignKey("IdIntrari")]
        public IntrariParteneri? IntrariParteneri { get; set; }
    }
}

using System.ComponentModel.DataAnnotations.Schema;

namespace miniProiect.Models
{
    public class IntrariDetaliu
    {
        public int Id { get; set; }
        public float Cantitate { get; set; }
        public float Valoare { get; set; }

        public int? IdIntrariDetaliuProdus{ get; set; }

        [ForeignKey("IdIntrariDetaliuProdus")]
        public IntrariDetaliuProdus? IntrariDetaliuProdus{ get; set; }


        [ForeignKey("IntrariId")]
        public Intrari? Intrari { get; set; }
    }
}

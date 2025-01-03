using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace miniProiect.Models
{
    public class Intrari
    {
        public int Id { set; get; }
        public DateTime Date { set; get; }
        public int? IdPartner { set; get; }

        [ForeignKey("IdPartner")]
        public IntrariParteneri? IntrariParteneri{ get; set; }
        public int? IdGestiune{ set; get; }

        [ForeignKey("IdGestiune")]
        public IntrariGestiune? IntrariGestiune{ get; set; }

    }
}

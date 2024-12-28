namespace miniProiect.Models
{
    public class Produs
    {
        /// <summary>
        /// Reprezinta id-ul produsului
        /// Este unic intre alte instante de obiect si se autoincrementeaza
        /// </summary>
        public int Id { get; set; }
        public string Denumire{ get; set; }
        public float ?PretUnitar { get; set; }
    }
}

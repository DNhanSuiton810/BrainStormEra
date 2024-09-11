namespace BrainStormEra.Models
{
    public class Certificate
    {
        public string certificate_id { get; set; }
        public string user_id { get; set; }
        public DateTime certificate_date { get; set; }

        public Certificate() { }

        public Certificate(string certificate_id, string user_id, DateTime certificate_date)
        {
            this.certificate_id = certificate_id;
            this.user_id = user_id;
            this.certificate_date = certificate_date;
        }
    }
}

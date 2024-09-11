namespace BrainStormEra.Models
{
    public class Payment
    {
        public string payment_id { get; set; }
        public string user_id { get; set; }
        public string enrollment_id { get; set; }
        public string payment_description { get; set; }

        public double payment_price { get; set; }
        public string payment_status { get; set; }
        public DateTime payment_date { get; set; }
        public Payment() { }
        public Payment(string payment_id, string user_id, string enrollment_id, string payment_description, double payment_price, string payment_status, DateTime payment_date)
        {
            this.payment_id = payment_id;
            this.user_id = user_id;
            this.enrollment_id = enrollment_id;
            this.payment_description = payment_description;
            this.payment_price = payment_price;
            this.payment_status = payment_status;
            this.payment_date = payment_date;
        }
    }
}

namespace PointOfSale.Models
{
    public class VMSms
    {
        public int user_id { get; set; }
        public string api_key { get; set; }
        public string sender_id { get; set; }
        public long to { get; set;}
        public string message { get; set;}

    }
}

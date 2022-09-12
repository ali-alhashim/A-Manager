namespace A_Manager.Models
{
    public class Car_Service
    {
        public int id { get; set; }

        public DateTime created_date { get; set; }

        public DateTime last_update { get; set; }

        public string odometer { get; set; }

        public DateTime service_date { get; set; }

        public string workshop { get; set; }

        public double service_cost { get; set; }

        public string description { get; set; }
    }
}

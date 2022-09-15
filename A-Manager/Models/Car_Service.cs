using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace A_Manager.Models
{
    public class Car_Service
    {
        [Key]
        public int id { get; set; }

        [ForeignKey("id")]
        public virtual Car car { get; set; }

        public DateTime created_date { get; set; }

        public DateTime last_update { get; set; }

        public string odometer { get; set; }

        public DateTime service_date { get; set; }

        public string workshop { get; set; }

        public double service_cost { get; set; }

        public string description { get; set; }
    }
}

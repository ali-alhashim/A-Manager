using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace A_Manager.Models
{
    public class Car_Insurance
    {
        [Key]
        public int id { get; set; }

        [ForeignKey("id")]
        public virtual Car car { get; set; }

        public DateTime created_date { get; set; }

        public DateTime last_update { get; set; }

        public string policy_number { get; set; }   

        public string insurance_class { get; set; }

        public string insurance_area { get; set; }

        public double insured_value { get; set; }

        public string repair_type { get; set; }

        public Boolean insure_accessories { get; set; }

        public double excess_amount { get; set; }

        public double insurance_cost { get; set; }

        public DateTime insurance_start { get; set; }

        public DateTime insurance_end { get; set; }

    }
}

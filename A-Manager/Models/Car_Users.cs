using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace A_Manager.Models
{
    public class Car_Users
    {
        [Key]
        public int id { get; set; }


        public int carID { get; set; }
        public  Car car { get; set; }


        public int userID { get; set; }
        public  User user { get; set; }

        public DateTime? created_date { get; set; }

        public DateTime? last_update { get; set; }

        public DateTime? received_date { get; set; }
        public string? odometer_before { get; set; }

        public DateTime? handover_date { get; set; }
        public string? odometer_after { get; set; }

        public string? odometer_unit { get; set; }

        public string? authorize_type { get; set; }

        public DateTime? authorize_start_date { get; set; }
        public DateTime? authorize_end_date { get; set; }

        public string? note { get; set; }

        public string? status { get; set; }
    }
}

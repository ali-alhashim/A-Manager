using System.ComponentModel.DataAnnotations;

namespace A_Manager.Models
{
    public class User
    {
        [Key]
        public int id { get; set; }

        
        public string email { get; set; }

        
        public string password { get; set; }

        public string full_name { get; set; }

        public string local_full_name { get; set; }

        public string gender { get; set; }

        public string mobile { get; set; }

        public string telphone { get; set; }

        public string badge_number { get; set; }

        public string job_title { get; set; }

        public DateTime join_date { get; set; } 

        public string nationality { get; set; }

        public string gov_id { get; set; }

        public string brith_date { get; set; }

        public string profile_photo { get; set; }

        public Boolean is_active { get; set; }

        public Boolean is_employee { get; set; }

        public Boolean is_superuser { get; set; }
    }
}

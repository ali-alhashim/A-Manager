using System.ComponentModel.DataAnnotations;

namespace A_Manager.Models
{
    public class User
    {
        [Key]
        public int id { get; set; }

        [DataType(DataType.EmailAddress)]
        public string email { get; set; }

        [DataType(DataType.Password)]
        public string password { get; set; }

        [Display(Name = "Full Name")]
        public string full_name { get; set; }

        [DisplayFormat(ConvertEmptyStringToNull = false)]
        [Required(AllowEmptyStrings = true)]
        [Display(Name = "Local Full Name")]
        public string local_full_name { get; set; }


        public string gender { get; set; }

        [DisplayFormat(ConvertEmptyStringToNull = false)]
        [Required(AllowEmptyStrings = true)]
        public string mobile { get; set; }

        [DisplayFormat(ConvertEmptyStringToNull = false)]
        [Required(AllowEmptyStrings = true)]
        public string telphone { get; set; }

        [Display(Name = "Badge Number")]
        public string badge_number { get; set; }

        [DisplayFormat(ConvertEmptyStringToNull = false)]
        [Required(AllowEmptyStrings = true)]
        [Display(Name = "Job Title")]
        public string job_title { get; set; }

        public DateTime join_date { get; set; }

        [DisplayFormat(ConvertEmptyStringToNull = false)]
        [Required(AllowEmptyStrings = true)]
        public string nationality { get; set; }

        public string gov_id { get; set; }

        public string brith_date { get; set; }

        [DisplayFormat(ConvertEmptyStringToNull = false)]
        [Required(AllowEmptyStrings = true)]
        public string profile_photo { get; set; }

        public Boolean is_active { get; set; }

        public Boolean is_employee { get; set; }

        public Boolean is_superuser { get; set; }
    }
}

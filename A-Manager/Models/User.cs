using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace A_Manager.Models
{
    public class User
    {
        [Key]
        public int id { get; set; }

        [DataType(DataType.EmailAddress)]
        public string? email { get; set; }

        [DataType(DataType.Password)]
        public string? password { get; set; }

        [Display(Name = "Full Name")]
        public string full_name { get; set; }

        [Display(Name = "Local Full Name")]
        public string? local_full_name { get; set; }


        public string? gender { get; set; }

       
        public string? mobile { get; set; }

      
        public string? telphone { get; set; }

        [Display(Name = "Badge Number")]
        public string? badge_number { get; set; }

       
        [Display(Name = "Job Title")]
        public string? job_title { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime? join_date { get; set; }

       
        public string? nationality { get; set; }

        public string? gov_id { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime? brith_date { get; set; }


        [NotMapped]
        [DisplayName("Profile Photo")]
        public IFormFile? profile_photo { get; set; }

        [Column(TypeName = "nvarchar(max)")]
        [DisplayName("Image url")]
        public string? profile_photo_url { get; set; }

        public Boolean is_active { get; set; }

        public Boolean is_employee { get; set; }

        public Boolean is_superuser { get; set; }
    }
}

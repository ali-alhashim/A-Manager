using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace A_Manager.Models
{
    public class Car
    {
        [Key]
        public int id { get; set; }

        [Display(Name = "Serial Number")]
        public string serial_number { get; set; }

        [Display(Name = "VIN")]
        public string vehicle_identification_number { get; set; }

        public string plate_number { get; set; }

        [DisplayFormat(ConvertEmptyStringToNull = false)]
        [Required(AllowEmptyStrings = true)]
        public string door_number { get; set; }

        public string status { get; set; }

        public string color { get; set; }

        public string brand { get; set; }

        public string model { get; set; }

        public int year_of_make { get; set; }

        public int seats_number { get; set; }

        public string fuel_type { get; set; } 

        public string body_type { get; set; }

        [DisplayFormat(ConvertEmptyStringToNull = false)]
        [Required(AllowEmptyStrings = true)]
        public string front_photo { get; set; }

        [DisplayFormat(ConvertEmptyStringToNull = false)]
        [Required(AllowEmptyStrings = true)]
        public string back_photo { get;set; }

        [DisplayFormat(ConvertEmptyStringToNull = false)]
        [Required(AllowEmptyStrings = true)]
        public string right_photo { get; set; }

        [DisplayFormat(ConvertEmptyStringToNull = false)]
        [Required(AllowEmptyStrings = true)]
        public string left_photo { get; set; }

        
        public double purchase_price { get; set; }

        [Required(AllowEmptyStrings = true)]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime inspection_expiration { get; set; }

        [DisplayFormat(ConvertEmptyStringToNull = false)]
        [Required(AllowEmptyStrings = true)]
        [DataType(DataType.Date)]
        public DateTime hajri_inspection_expiration { get; set; }

        [DisplayFormat(ConvertEmptyStringToNull = false)]
        [Required(AllowEmptyStrings = true)]
        [DataType(DataType.Date)]
        public DateTime registration_license_expiration { get;set;}

        [DisplayFormat(ConvertEmptyStringToNull = false)]
        [Required(AllowEmptyStrings = true)]
        [DataType(DataType.Date)]
        public DateTime hajri_registration_license_expiration { get; set; }

        public Boolean has_gps { get; set; } 

        public Boolean has_fuel_chip { get; set; }

        [DisplayFormat(ConvertEmptyStringToNull = false)]
        [Required(AllowEmptyStrings = true)]
        public string owner_name { get; set; }

        [DisplayFormat(ConvertEmptyStringToNull = false)]
        [Required(AllowEmptyStrings = true)]
        public string owner_id { get; set; }
    }
}

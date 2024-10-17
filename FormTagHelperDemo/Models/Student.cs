using System.ComponentModel.DataAnnotations;

namespace FormTagHelperDemo.Models
{
    public class Student
    {
        public int? StudentId { get; set; }

        [Display(Name = "Full Name")]
        [Required(ErrorMessage = "Name is Required")]
        [StringLength(50)]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        public String Password { get; set; }

        [Required(ErrorMessage = "DateOfBirth Is Required")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set;}

        [Required(ErrorMessage ="Gender is Required")]
        public Gender Gender { get; set;}

        [Required(ErrorMessage ="Address is Required")]
        [StringLength(500)]
        public String Address {  get; set;}

        [Required(ErrorMessage ="Branch is Required")]
        public Branch Branch { get; set;}

        public bool TermsAndConditions {  get; set;}

        public List<String> Hobbies { get; set; } = new List<string>();

        [Required(ErrorMessage ="At least one skill is Required")]
        public List<String> Skills { get; set; } = new List<String>();

    }
}

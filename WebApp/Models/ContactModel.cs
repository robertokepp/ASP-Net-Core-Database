using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
{
    public class ContactModel
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Lastname")]
        public string Lastname { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        public ContactModel()
        {
        }

        public ContactModel(string Name, string Lastname, string Email)
        {
            this.Name = Name;
            this.Lastname = Lastname;
            this.Email = Email;
        }
    }
}

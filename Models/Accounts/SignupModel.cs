using System.ComponentModel.DataAnnotations;
namespace WebAdvert.Web.Models.Accounts
{
    public class SignupModel : PasswordModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}

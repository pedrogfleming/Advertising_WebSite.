using System.ComponentModel.DataAnnotations;

namespace WebAdvert.Web.Models.Accounts
{
    public class ChangePasswordModel : PasswordModel
    {
        [Required(ErrorMessage = "Code is required")]
        public string Code { get; set; }
        public string? Email { get; set; }
    }
}

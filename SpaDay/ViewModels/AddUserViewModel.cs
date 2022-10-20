using Microsoft.AspNetCore.SignalR;
using System.ComponentModel.DataAnnotations;

namespace SpaDay.Models
{
    public class AddUserViewModel
    {
        [Required(ErrorMessage = "Username is required!")]
        [StringLength(15, MinimumLength = 5, ErrorMessage = "Name must be between 5 and 15 characters.")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password is required!")]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "Password must be between 6 and 20 characters.")]
        public string Password { get; set; }
        


    [EmailAddress]
    public string Email { get; set; }

    }


}
}

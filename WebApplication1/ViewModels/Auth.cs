using System.ComponentModel.DataAnnotations;

namespace WebApplication1.ViewModels
{
    public class AuthLogin
    {
        //public string Test { get; set; }
        [Required]
        public string Username { get; set; }
        [Required, DataType(DataType.Password)]
        public string Password { get; set; }
    }

}
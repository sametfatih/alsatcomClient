using System.Text.Json.Serialization;

namespace alsatcomClient.Models
{
    public class LoginModel
    {
        public string UsernameOrEmail { get; set; }
        public string Password { get; set; }
    }
}


namespace Grocery.Core.Models
{
    public partial class Client : Model
    {
        public string Email { get; set; } = null;
        public string Password { get; set; } = null;
        public Client(int id, string name, string email, string password) : base(id, name)
        {
            Email = email;
            Password = password;
        }
    }
}

namespace Grocery.Core.Models
{
    public partial class Client : Model
    {
        public string Email { get; private set; }
        public string PasswordHash { get; private set; }

        public Client(int id, string name, string email, string passwordHash)
            : base(id, name)
        {
            Email = email;
            PasswordHash = passwordHash;
        }
    }
}

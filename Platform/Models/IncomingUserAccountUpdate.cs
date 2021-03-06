namespace Rokono_Control.Models
{
    public class IncomingUserAccountUpdate
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public OutgoingUserAccounts Rights {get; set;}
        public int ProjectId { get; set; }
    }
}
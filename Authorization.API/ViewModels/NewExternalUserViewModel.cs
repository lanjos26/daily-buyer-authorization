namespace Authorization.API.ViewModels
{
    public class NewExternalUserViewModel
    {
        public string Username { get; set; }
        
        public string Password { get; set; }
        
        public string FirstName { get; set; }
        
        public string LastName { get; set; }
        
        public string Email { get; set; }
        
        public int AuthenticationTypeId { get; set; }
    }
}
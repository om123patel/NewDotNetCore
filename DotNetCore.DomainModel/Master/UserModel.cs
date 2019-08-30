namespace DotNetCore.DomainModel
{
    public class UserModel : BaseDomainModel<int>
    {
        public string UserId { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
    }
}

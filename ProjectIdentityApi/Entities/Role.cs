using Microsoft.AspNetCore.Identity;

namespace ProjectIdentityApi.Entities
{
    public class Role: IdentityRole
    {
        public string Description {  get; set; }
    }
}

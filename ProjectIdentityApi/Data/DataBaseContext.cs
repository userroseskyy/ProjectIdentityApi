using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProjectIdentityApi.Entities;


namespace ProjectIdentityApi.Data
{
    public class DataBaseContext: IdentityDbContext<User,Role,string>
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options):base(options) 
        {
            
        }
       
    }
}

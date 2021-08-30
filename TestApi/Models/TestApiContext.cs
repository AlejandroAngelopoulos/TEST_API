using Microsoft.Owin.Security.OAuth;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;

namespace TestApi.Models
{
    public class TestApiContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public TestApiContext() : base("name=TestApiContext")
        {
        }
     
        public System.Data.Entity.DbSet<TestApi.Models.Product> Products { get; set; }

        public System.Data.Entity.DbSet<TestApi.Models.User> Users { get; set; }
       
    }

    public class UsersRepository : IDisposable
    {
        // SECURITY_DBEntities it is your context class
        TestApiContext context = new TestApiContext();
        //This method is used to check and validate the user credentials
        public User ValidateUser(string username, string password)
        {
            return context.Users.FirstOrDefault(user =>
            user.UserName.Equals(username, StringComparison.OrdinalIgnoreCase)
            && user.Password == password);
        }
        public void Dispose()
        {
            context.Dispose();
        }
    }

    public class MyAuthorizationServerProvider : OAuthAuthorizationServerProvider
    {

        public override async Task ValidateClientAuthentication(OAuthValidateClientAuthenticationContext context)
        {
            context.Validated();
        }
        public override async Task GrantResourceOwnerCredentials(OAuthGrantResourceOwnerCredentialsContext context)
        {
            using (UsersRepository _repo = new UsersRepository())
            {
                var user = _repo.ValidateUser(context.UserName, context.Password);
                if (user == null)
                {
                    context.SetError("invalid_grant", "Provided username and password is incorrect");
                    return;
                }
                var identity = new ClaimsIdentity(context.Options.AuthenticationType);
                identity.AddClaim(new Claim(ClaimTypes.Role, user.Role));
                identity.AddClaim(new Claim(ClaimTypes.Name, user.UserName));
                context.Validated(identity);
            }
        }

    }
}

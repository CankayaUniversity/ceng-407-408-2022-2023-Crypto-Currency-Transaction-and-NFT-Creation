using AspNetCore.Identity.MongoDbCore.Models;
using System;
using MongoDbGenericRepository.Attributes;

namespace Starry_Gold_Billfold.Models
{
    [CollectionName("Users")]
    public class ApplicationUser:MongoIdentityUser<Guid>
    {
        public ApplicationUser()
        {
        }

    }
}

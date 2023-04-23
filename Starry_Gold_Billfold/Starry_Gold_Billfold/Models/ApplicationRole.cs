using AspNetCore.Identity.MongoDbCore.Models;
using System;
using MongoDbGenericRepository.Attributes;

namespace Starry_Gold_Billfold.Models
{
    [CollectionName("Roles")]
    public class ApplicationRole: MongoIdentityRole<Guid>
    {
        public ApplicationRole()
        {
        }
    }
}

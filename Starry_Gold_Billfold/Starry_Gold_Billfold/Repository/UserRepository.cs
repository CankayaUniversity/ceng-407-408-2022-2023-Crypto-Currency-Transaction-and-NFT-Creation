using MongoRepo.Context;
using MongoRepo.Repository;
using Starry_Gold_Billfold.Database;
using Starry_Gold_Billfold.Interfaces.Repository;
using Starry_Gold_Billfold.Models;

namespace Starry_Gold_Billfold.Repository
{
    public class UserRepository : CommonRepository<ApplicationUser>, IUserRepository
    {
        public UserRepository() : base(new ApplicationDbContext(DbConnection.ConnectionString,DbConnection.DbName))
        {
        }
    }
}

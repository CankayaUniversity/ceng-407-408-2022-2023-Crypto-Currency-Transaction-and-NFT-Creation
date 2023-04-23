using MongoDB.Driver.Core.Configuration;

namespace Starry_Gold_Billfold.Database
{
    public static class DbConnection
    {
        public static string ConnectionString = "mongodb://127.0.0.1:27017/";
        public static string DbName = "CryptoDb";
    }
}

using System.Data.Entity.Migrations;

namespace GCE.DataAccess.Migrations
{
    public class Configuration: DbMigrationsConfiguration<GCEContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }
    }
}
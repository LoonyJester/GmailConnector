using System.Data.Entity;
using GCE.DataAccess.Migrations;

namespace GCE.DataAccess
{
    public class GCEDatabaseInitializer : MigrateDatabaseToLatestVersion<GCEContext, Configuration>
    {
         
    }
}
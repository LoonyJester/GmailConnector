using System.Data.Entity;
using GCE.DataAccess.DataObjects;

namespace GCE.DataAccess
{
    public class GCEContext: DbContext
    {
        public GCEContext(): base("gce_connection")
        {
            
        }

        public DbSet<Message> Messages { get; set; }
    }
}
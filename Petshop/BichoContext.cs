using System.Data.Entity;

namespace Petshop
{
    internal class BichoContext : DbContext
    {
        public BichoContext() : base("name=Petshop.Properties.Settings.ConnectionString\" connectionString")
        {


        }

        public DbSet<BichoEntity> Bichos { get; set; }
    }

}

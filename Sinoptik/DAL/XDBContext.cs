using System.Data.Entity;
using Sinoptik.Model;

namespace Sinoptik.DAL
{
    class XDBContext : DbContext
    {
        public XDBContext()
        : base("DBSinoptik") 
        {
            //this.Configuration.LazyLoadingEnabled = false;
        }


        public XDBContext(string connection) : base(connection)
        {
            this.Configuration.LazyLoadingEnabled = true;
        }


        public DbSet<XClient> Clients { get; set; }
        public  DbSet<XExam> Exams { get; set; }
        public  DbSet<XWeather> Weather { get; set; }
        public  DbSet<XSANTest> SANTest { get; set; }
        public  DbSet<XSubjectivParameters> SubjParams { get; set; }
        public  DbSet<XObjectivParameters> ObjParams { get; set; } 
        


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //здесь логика для изменений схемы (Fluent)
            
        }
    }
}

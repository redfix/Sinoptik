using System.Data.Entity;

namespace Sinoptik.Model
{
    class XDBContext : DbContext
    {
        public XDBContext()
        : base("DBSinoptik") 
        {
            //this.Configuration.LazyLoadingEnabled = false;
        }

        public  DbSet<XClient> Clients { get; set; }
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

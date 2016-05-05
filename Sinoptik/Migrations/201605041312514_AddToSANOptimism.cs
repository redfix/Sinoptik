namespace Sinoptik.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddToSANOptimism : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SANParams", "OptimismPessimism", c => c.Short());
        }
        
        public override void Down()
        {
            DropColumn("dbo.SANParams", "OptimismPessimism");
        }
    }
}

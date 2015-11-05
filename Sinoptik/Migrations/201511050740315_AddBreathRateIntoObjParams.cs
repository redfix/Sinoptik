namespace Sinoptik.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBreathRateIntoObjParams : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ObjParams", "BreathRate", c => c.Short(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.ObjParams", "BreathRate");
        }
    }
}

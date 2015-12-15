namespace Sinoptik.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NullablesInExams : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Exams", "ObjParamsId", "dbo.ObjParams");
            DropForeignKey("dbo.Exams", "SANTestId", "dbo.SANParams");
            DropForeignKey("dbo.Exams", "SubjParamsId", "dbo.SubjParams");
            DropIndex("dbo.Exams", new[] { "SubjParamsId" });
            DropIndex("dbo.Exams", new[] { "ObjParamsId" });
            DropIndex("dbo.Exams", new[] { "SANTestId" });
            AlterColumn("dbo.Exams", "SubjParamsId", c => c.Int());
            AlterColumn("dbo.Exams", "ObjParamsId", c => c.Int());
            AlterColumn("dbo.Exams", "SANTestId", c => c.Int());
            CreateIndex("dbo.Exams", "SubjParamsId");
            CreateIndex("dbo.Exams", "ObjParamsId");
            CreateIndex("dbo.Exams", "SANTestId");
            AddForeignKey("dbo.Exams", "ObjParamsId", "dbo.ObjParams", "Id");
            AddForeignKey("dbo.Exams", "SANTestId", "dbo.SANParams", "Id");
            AddForeignKey("dbo.Exams", "SubjParamsId", "dbo.SubjParams", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Exams", "SubjParamsId", "dbo.SubjParams");
            DropForeignKey("dbo.Exams", "SANTestId", "dbo.SANParams");
            DropForeignKey("dbo.Exams", "ObjParamsId", "dbo.ObjParams");
            DropIndex("dbo.Exams", new[] { "SANTestId" });
            DropIndex("dbo.Exams", new[] { "ObjParamsId" });
            DropIndex("dbo.Exams", new[] { "SubjParamsId" });
            AlterColumn("dbo.Exams", "SANTestId", c => c.Int(nullable: false));
            AlterColumn("dbo.Exams", "ObjParamsId", c => c.Int(nullable: false));
            AlterColumn("dbo.Exams", "SubjParamsId", c => c.Int(nullable: false));
            CreateIndex("dbo.Exams", "SANTestId");
            CreateIndex("dbo.Exams", "ObjParamsId");
            CreateIndex("dbo.Exams", "SubjParamsId");
            AddForeignKey("dbo.Exams", "SubjParamsId", "dbo.SubjParams", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Exams", "SANTestId", "dbo.SANParams", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Exams", "ObjParamsId", "dbo.ObjParams", "Id", cascadeDelete: true);
        }
    }
}

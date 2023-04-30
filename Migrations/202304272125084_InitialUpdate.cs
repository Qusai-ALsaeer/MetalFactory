namespace Acco.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialUpdate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tb_general", "mother_num", c => c.Int());
            AddColumn("dbo.tb_general", "motion_num", c => c.Int());
            AddColumn("dbo.tb_general", "gen_num", c => c.Int());
            DropColumn("dbo.tb_general", "mo_num");
            DropColumn("dbo.tb_general", "ser_num");
        }
        
        public override void Down()
        {
            AddColumn("dbo.tb_general", "ser_num", c => c.String(maxLength: 10));
            AddColumn("dbo.tb_general", "mo_num", c => c.Int(nullable: false));
            DropColumn("dbo.tb_general", "gen_num");
            DropColumn("dbo.tb_general", "motion_num");
            DropColumn("dbo.tb_general", "mother_num");
        }
    }
}

﻿namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_delete_aboutStatus : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Abouts", "AboutStatus");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Abouts", "AboutStatus", c => c.Boolean(nullable: false));
        }
    }
}

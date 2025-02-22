﻿namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_writer_title_add : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Writers", "WriterTitle", c => c.String(maxLength: 20));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Writers", "WriterTitle");
        }
    }
}

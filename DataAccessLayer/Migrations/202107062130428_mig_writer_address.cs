﻿namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_writer_address : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Writers", "WriterAddress", c => c.String(maxLength: 100));
            AddColumn("dbo.Writers", "WriterCountry", c => c.String(maxLength: 20));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Writers", "WriterCountry");
            DropColumn("dbo.Writers", "WriterAddress");
        }
    }
}

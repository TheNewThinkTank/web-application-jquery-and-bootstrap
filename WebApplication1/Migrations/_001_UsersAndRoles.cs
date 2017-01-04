using System;
using System.Data;
using FluentMigrator;
using FluentMigrator.Builders;

namespace WebApplication1.Migrations
{
    [Migration(1)]
    public class _001_UsersAndRoles : Migration
    {

        public override void Up()
        {
            Create.Table("users")
                .WithColumn("id").AsInt32().Identity().PrimaryKey()
                .WithColumn("username").AsString(128)
                .WithColumn("email").AsCustom("VARCHAR(256)")
                .WithColumn("password_hash").AsString(128);

            Create.Table("roles")
                .WithColumn("id").AsInt32().Identity().PrimaryKey()
                .WithColumn("name").AsString(128);

            Create.Table("role_users")
                .WithColumn("user_id").AsInt32().ForeignKey("users", "id").OnDelete(Rule.Cascade)
                .WithColumn("role_id").AsInt32().ForeignKey("roles", "id").OnDelete(Rule.Cascade);

        }
        public override void Down()
        {
            Delete.Table("role_users");
            Delete.Table("roles");
            Delete.Table("users");



        }


    }
}
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Paper.MVC.Migrations
{
    public partial class seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var sql = @"
                INSERT INTO Books VALUES ('Title 1', 'Url 1')
                INSERT INTO Books VALUES ('Title 1', 'Url 1')
                INSERT INTO Books VALUES ('Title 1', 'Url 1')
                INSERT INTO Books VALUES ('Title 1', 'Url 1')
            ";
            migrationBuilder.Sql(sql);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}

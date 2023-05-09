﻿using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Com.DanLiris.Service.Gline.Lib.Migrations
{
    public partial class CreateTransaksiOperator : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TransaksiOperator",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Active = table.Column<bool>(nullable: false),
                    CreatedAgent = table.Column<string>(maxLength: 255, nullable: false),
                    CreatedBy = table.Column<string>(maxLength: 255, nullable: false),
                    CreatedUtc = table.Column<DateTime>(nullable: false),
                    DeletedAgent = table.Column<string>(maxLength: 255, nullable: false),
                    DeletedBy = table.Column<string>(maxLength: 255, nullable: false),
                    DeletedUtc = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    LastModifiedAgent = table.Column<string>(maxLength: 255, nullable: false),
                    LastModifiedBy = table.Column<string>(maxLength: 255, nullable: false),
                    LastModifiedUtc = table.Column<DateTime>(nullable: false),
                    cycle_time = table.Column<double>(nullable: false),
                    employee_role = table.Column<string>(maxLength: 32, nullable: false),
                    id_line = table.Column<Guid>(nullable: false),
                    id_proses = table.Column<Guid>(nullable: false),
                    id_setting_ro = table.Column<Guid>(nullable: false),
                    id_shift = table.Column<Guid>(nullable: false),
                    nama = table.Column<string>(maxLength: 32, nullable: false),
                    nama_line = table.Column<int>(nullable: false),
                    nama_proses = table.Column<string>(maxLength: 255, nullable: false),
                    nama_shift = table.Column<string>(maxLength: 32, nullable: false),
                    npk = table.Column<string>(maxLength: 32, nullable: false),
                    pass = table.Column<bool>(nullable: false),
                    pass_time = table.Column<TimeSpan>(nullable: false),
                    quantity = table.Column<int>(nullable: false),
                    rono = table.Column<string>(maxLength: 50, nullable: false),
                    setting_date = table.Column<DateTime>(nullable: false),
                    setting_time = table.Column<TimeSpan>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransaksiOperator", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TransaksiOperator_Line_id_line",
                        column: x => x.id_line,
                        principalTable: "Line",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TransaksiOperator_Proses_id_proses",
                        column: x => x.id_proses,
                        principalTable: "Proses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TransaksiOperator_SettingRo_id_setting_ro",
                        column: x => x.id_setting_ro,
                        principalTable: "SettingRo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TransaksiOperator_id_line",
                table: "TransaksiOperator",
                column: "id_line");

            migrationBuilder.CreateIndex(
                name: "IX_TransaksiOperator_id_proses",
                table: "TransaksiOperator",
                column: "id_proses");

            migrationBuilder.CreateIndex(
                name: "IX_TransaksiOperator_id_setting_ro",
                table: "TransaksiOperator",
                column: "id_setting_ro");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TransaksiOperator");
        }
    }
}

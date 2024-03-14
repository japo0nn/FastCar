using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FastCarServer.Migrations
{
    /// <inheritdoc />
    public partial class UserInit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PassengerCars_Categories_CategoryId",
                table: "PassengerCars");

            migrationBuilder.DropForeignKey(
                name: "FK_PassengerCars_PassengerBodyTypes_BodyTypeId",
                table: "PassengerCars");

            migrationBuilder.DropForeignKey(
                name: "FK_PassengerCars_PassengerBrandModels_ModelId",
                table: "PassengerCars");

            migrationBuilder.DropForeignKey(
                name: "FK_PassengerCars_PassengerBrandYears_YearId",
                table: "PassengerCars");

            migrationBuilder.DropForeignKey(
                name: "FK_PassengerCars_PassengerBrands_BrandId",
                table: "PassengerCars");

            migrationBuilder.DropForeignKey(
                name: "FK_PassengerCars_PassengerGenerations_GenerationId",
                table: "PassengerCars");

            migrationBuilder.DropForeignKey(
                name: "FK_Properties_PassengerCars_PassengerCarId",
                table: "Properties");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PassengerCars",
                table: "PassengerCars");

            migrationBuilder.RenameTable(
                name: "PassengerCars",
                newName: "Cars");

            migrationBuilder.RenameColumn(
                name: "PassengerCarId",
                table: "Properties",
                newName: "CarId");

            migrationBuilder.RenameIndex(
                name: "IX_Properties_PassengerCarId",
                table: "Properties",
                newName: "IX_Properties_CarId");

            migrationBuilder.RenameIndex(
                name: "IX_PassengerCars_YearId",
                table: "Cars",
                newName: "IX_Cars_YearId");

            migrationBuilder.RenameIndex(
                name: "IX_PassengerCars_ModelId",
                table: "Cars",
                newName: "IX_Cars_ModelId");

            migrationBuilder.RenameIndex(
                name: "IX_PassengerCars_GenerationId",
                table: "Cars",
                newName: "IX_Cars_GenerationId");

            migrationBuilder.RenameIndex(
                name: "IX_PassengerCars_CategoryId",
                table: "Cars",
                newName: "IX_Cars_CategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_PassengerCars_BrandId",
                table: "Cars",
                newName: "IX_Cars_BrandId");

            migrationBuilder.RenameIndex(
                name: "IX_PassengerCars_BodyTypeId",
                table: "Cars",
                newName: "IX_Cars_BodyTypeId");

            migrationBuilder.AlterColumn<Guid>(
                name: "YearId",
                table: "Cars",
                type: "uuid",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.AlterColumn<Guid>(
                name: "ModelId",
                table: "Cars",
                type: "uuid",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.AlterColumn<Guid>(
                name: "GenerationId",
                table: "Cars",
                type: "uuid",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.AlterColumn<Guid>(
                name: "CategoryId",
                table: "Cars",
                type: "uuid",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.AlterColumn<Guid>(
                name: "BrandId",
                table: "Cars",
                type: "uuid",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.AlterColumn<Guid>(
                name: "BodyTypeId",
                table: "Cars",
                type: "uuid",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Cars",
                type: "character varying(13)",
                maxLength: 13,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "Cars",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cars",
                table: "Cars",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "IdentityUser",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    UserName = table.Column<string>(type: "text", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "text", nullable: true),
                    Email = table.Column<string>(type: "text", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "text", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    PasswordHash = table.Column<string>(type: "text", nullable: true),
                    SecurityStamp = table.Column<string>(type: "text", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true),
                    PhoneNumber = table.Column<string>(type: "text", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdentityUser", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    IdentityUserId = table.Column<string>(type: "text", nullable: true),
                    FirstName = table.Column<string>(type: "text", nullable: true),
                    LastName = table.Column<string>(type: "text", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_IdentityUser_IdentityUserId",
                        column: x => x.IdentityUserId,
                        principalTable: "IdentityUser",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cars_UserId",
                table: "Cars",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_IdentityUserId",
                table: "Users",
                column: "IdentityUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Categories_CategoryId",
                table: "Cars",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_PassengerBodyTypes_BodyTypeId",
                table: "Cars",
                column: "BodyTypeId",
                principalTable: "PassengerBodyTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_PassengerBrandModels_ModelId",
                table: "Cars",
                column: "ModelId",
                principalTable: "PassengerBrandModels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_PassengerBrandYears_YearId",
                table: "Cars",
                column: "YearId",
                principalTable: "PassengerBrandYears",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_PassengerBrands_BrandId",
                table: "Cars",
                column: "BrandId",
                principalTable: "PassengerBrands",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_PassengerGenerations_GenerationId",
                table: "Cars",
                column: "GenerationId",
                principalTable: "PassengerGenerations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Users_UserId",
                table: "Cars",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Properties_Cars_CarId",
                table: "Properties",
                column: "CarId",
                principalTable: "Cars",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Categories_CategoryId",
                table: "Cars");

            migrationBuilder.DropForeignKey(
                name: "FK_Cars_PassengerBodyTypes_BodyTypeId",
                table: "Cars");

            migrationBuilder.DropForeignKey(
                name: "FK_Cars_PassengerBrandModels_ModelId",
                table: "Cars");

            migrationBuilder.DropForeignKey(
                name: "FK_Cars_PassengerBrandYears_YearId",
                table: "Cars");

            migrationBuilder.DropForeignKey(
                name: "FK_Cars_PassengerBrands_BrandId",
                table: "Cars");

            migrationBuilder.DropForeignKey(
                name: "FK_Cars_PassengerGenerations_GenerationId",
                table: "Cars");

            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Users_UserId",
                table: "Cars");

            migrationBuilder.DropForeignKey(
                name: "FK_Properties_Cars_CarId",
                table: "Properties");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "IdentityUser");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cars",
                table: "Cars");

            migrationBuilder.DropIndex(
                name: "IX_Cars_UserId",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Cars");

            migrationBuilder.RenameTable(
                name: "Cars",
                newName: "PassengerCars");

            migrationBuilder.RenameColumn(
                name: "CarId",
                table: "Properties",
                newName: "PassengerCarId");

            migrationBuilder.RenameIndex(
                name: "IX_Properties_CarId",
                table: "Properties",
                newName: "IX_Properties_PassengerCarId");

            migrationBuilder.RenameIndex(
                name: "IX_Cars_YearId",
                table: "PassengerCars",
                newName: "IX_PassengerCars_YearId");

            migrationBuilder.RenameIndex(
                name: "IX_Cars_ModelId",
                table: "PassengerCars",
                newName: "IX_PassengerCars_ModelId");

            migrationBuilder.RenameIndex(
                name: "IX_Cars_GenerationId",
                table: "PassengerCars",
                newName: "IX_PassengerCars_GenerationId");

            migrationBuilder.RenameIndex(
                name: "IX_Cars_CategoryId",
                table: "PassengerCars",
                newName: "IX_PassengerCars_CategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Cars_BrandId",
                table: "PassengerCars",
                newName: "IX_PassengerCars_BrandId");

            migrationBuilder.RenameIndex(
                name: "IX_Cars_BodyTypeId",
                table: "PassengerCars",
                newName: "IX_PassengerCars_BodyTypeId");

            migrationBuilder.AlterColumn<Guid>(
                name: "YearId",
                table: "PassengerCars",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "ModelId",
                table: "PassengerCars",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "GenerationId",
                table: "PassengerCars",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "CategoryId",
                table: "PassengerCars",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "BrandId",
                table: "PassengerCars",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "BodyTypeId",
                table: "PassengerCars",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_PassengerCars",
                table: "PassengerCars",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PassengerCars_Categories_CategoryId",
                table: "PassengerCars",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PassengerCars_PassengerBodyTypes_BodyTypeId",
                table: "PassengerCars",
                column: "BodyTypeId",
                principalTable: "PassengerBodyTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PassengerCars_PassengerBrandModels_ModelId",
                table: "PassengerCars",
                column: "ModelId",
                principalTable: "PassengerBrandModels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PassengerCars_PassengerBrandYears_YearId",
                table: "PassengerCars",
                column: "YearId",
                principalTable: "PassengerBrandYears",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PassengerCars_PassengerBrands_BrandId",
                table: "PassengerCars",
                column: "BrandId",
                principalTable: "PassengerBrands",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PassengerCars_PassengerGenerations_GenerationId",
                table: "PassengerCars",
                column: "GenerationId",
                principalTable: "PassengerGenerations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Properties_PassengerCars_PassengerCarId",
                table: "Properties",
                column: "PassengerCarId",
                principalTable: "PassengerCars",
                principalColumn: "Id");
        }
    }
}

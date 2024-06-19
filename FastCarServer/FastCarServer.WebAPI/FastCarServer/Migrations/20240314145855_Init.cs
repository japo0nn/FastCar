using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FastCarServer.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Fields",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    FieldName = table.Column<string>(type: "text", nullable: false),
                    FieldType = table.Column<int>(type: "integer", nullable: false),
                    UnitOfMeasure = table.Column<string>(type: "text", nullable: true),
                    OptionType = table.Column<int>(type: "integer", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fields", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PassengerGenerations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PassengerGenerations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FieldOptions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Option = table.Column<string>(type: "text", nullable: false),
                    FieldId = table.Column<Guid>(type: "uuid", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FieldOptions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FieldOptions_Fields_FieldId",
                        column: x => x.FieldId,
                        principalTable: "Fields",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PassengerBodyTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    GenerationId = table.Column<Guid>(type: "uuid", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PassengerBodyTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PassengerBodyTypes_PassengerGenerations_GenerationId",
                        column: x => x.GenerationId,
                        principalTable: "PassengerGenerations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PassengerBrandYears",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Year = table.Column<int>(type: "integer", nullable: false),
                    BodyTypeId = table.Column<Guid>(type: "uuid", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PassengerBrandYears", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PassengerBrandYears_PassengerBodyTypes_BodyTypeId",
                        column: x => x.BodyTypeId,
                        principalTable: "PassengerBodyTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PassengerBrandModels",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    BrandYearId = table.Column<Guid>(type: "uuid", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PassengerBrandModels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PassengerBrandModels_PassengerBrandYears_BrandYearId",
                        column: x => x.BrandYearId,
                        principalTable: "PassengerBrandYears",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PassengerBrands",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    BrandModelId = table.Column<Guid>(type: "uuid", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PassengerBrands", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PassengerBrands_PassengerBrandModels_BrandModelId",
                        column: x => x.BrandModelId,
                        principalTable: "PassengerBrandModels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Discriminator = table.Column<string>(type: "character varying(21)", maxLength: 21, nullable: false),
                    BrandId = table.Column<Guid>(type: "uuid", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Categories_PassengerBrands_BrandId",
                        column: x => x.BrandId,
                        principalTable: "PassengerBrands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PassengerCars",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    CategoryId = table.Column<Guid>(type: "uuid", nullable: false),
                    BrandId = table.Column<Guid>(type: "uuid", nullable: false),
                    ModelId = table.Column<Guid>(type: "uuid", nullable: false),
                    YearId = table.Column<Guid>(type: "uuid", nullable: false),
                    BodyTypeId = table.Column<Guid>(type: "uuid", nullable: false),
                    GenerationId = table.Column<Guid>(type: "uuid", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PassengerCars", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PassengerCars_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PassengerCars_PassengerBodyTypes_BodyTypeId",
                        column: x => x.BodyTypeId,
                        principalTable: "PassengerBodyTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PassengerCars_PassengerBrandModels_ModelId",
                        column: x => x.ModelId,
                        principalTable: "PassengerBrandModels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PassengerCars_PassengerBrandYears_YearId",
                        column: x => x.YearId,
                        principalTable: "PassengerBrandYears",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PassengerCars_PassengerBrands_BrandId",
                        column: x => x.BrandId,
                        principalTable: "PassengerBrands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PassengerCars_PassengerGenerations_GenerationId",
                        column: x => x.GenerationId,
                        principalTable: "PassengerGenerations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Properties",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    CarFieldId = table.Column<Guid>(type: "uuid", nullable: false),
                    FieldId = table.Column<Guid>(type: "uuid", nullable: false),
                    StringValue = table.Column<string>(type: "text", nullable: true),
                    IntValue = table.Column<int>(type: "integer", nullable: true),
                    FloatValue = table.Column<float>(type: "real", nullable: true),
                    PassengerCarId = table.Column<Guid>(type: "uuid", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Properties", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Properties_Fields_FieldId",
                        column: x => x.FieldId,
                        principalTable: "Fields",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Properties_PassengerCars_PassengerCarId",
                        column: x => x.PassengerCarId,
                        principalTable: "PassengerCars",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Categories_BrandId",
                table: "Categories",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_FieldOptions_FieldId",
                table: "FieldOptions",
                column: "FieldId");

            migrationBuilder.CreateIndex(
                name: "IX_PassengerBodyTypes_GenerationId",
                table: "PassengerBodyTypes",
                column: "GenerationId");

            migrationBuilder.CreateIndex(
                name: "IX_PassengerBrandModels_BrandYearId",
                table: "PassengerBrandModels",
                column: "BrandYearId");

            migrationBuilder.CreateIndex(
                name: "IX_PassengerBrands_BrandModelId",
                table: "PassengerBrands",
                column: "BrandModelId");

            migrationBuilder.CreateIndex(
                name: "IX_PassengerBrandYears_BodyTypeId",
                table: "PassengerBrandYears",
                column: "BodyTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_PassengerCars_BodyTypeId",
                table: "PassengerCars",
                column: "BodyTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_PassengerCars_BrandId",
                table: "PassengerCars",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_PassengerCars_CategoryId",
                table: "PassengerCars",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_PassengerCars_GenerationId",
                table: "PassengerCars",
                column: "GenerationId");

            migrationBuilder.CreateIndex(
                name: "IX_PassengerCars_ModelId",
                table: "PassengerCars",
                column: "ModelId");

            migrationBuilder.CreateIndex(
                name: "IX_PassengerCars_YearId",
                table: "PassengerCars",
                column: "YearId");

            migrationBuilder.CreateIndex(
                name: "IX_Properties_FieldId",
                table: "Properties",
                column: "FieldId");

            migrationBuilder.CreateIndex(
                name: "IX_Properties_PassengerCarId",
                table: "Properties",
                column: "PassengerCarId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FieldOptions");

            migrationBuilder.DropTable(
                name: "Properties");

            migrationBuilder.DropTable(
                name: "Fields");

            migrationBuilder.DropTable(
                name: "PassengerCars");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "PassengerBrands");

            migrationBuilder.DropTable(
                name: "PassengerBrandModels");

            migrationBuilder.DropTable(
                name: "PassengerBrandYears");

            migrationBuilder.DropTable(
                name: "PassengerBodyTypes");

            migrationBuilder.DropTable(
                name: "PassengerGenerations");
        }
    }
}

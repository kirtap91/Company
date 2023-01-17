using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Company.Data.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Businesses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Businesses = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    BusinessLoc = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Businesses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DepartmentInfos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Department = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepartmentInfos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EmployeePositions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeePositions = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeePositions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BusinessDepartmentInfo",
                columns: table => new
                {
                    BusinessesId = table.Column<int>(type: "int", nullable: false),
                    DepartmentInfosId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BusinessDepartmentInfo", x => new { x.BusinessesId, x.DepartmentInfosId });
                    table.ForeignKey(
                        name: "FK_BusinessDepartmentInfo_Businesses_BusinessesId",
                        column: x => x.BusinessesId,
                        principalTable: "Businesses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BusinessDepartmentInfo_DepartmentInfos_DepartmentInfosId",
                        column: x => x.DepartmentInfosId,
                        principalTable: "DepartmentInfos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BusinessDepartments",
                columns: table => new
                {
                    BusinessId = table.Column<int>(type: "int", nullable: false),
                    DepartmentId = table.Column<int>(type: "int", nullable: false),
                    DepartmentInfoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BusinessDepartments", x => new { x.BusinessId, x.DepartmentId });
                    table.ForeignKey(
                        name: "FK_BusinessDepartments_Businesses_BusinessId",
                        column: x => x.BusinessId,
                        principalTable: "Businesses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BusinessDepartments_DepartmentInfos_DepartmentInfoId",
                        column: x => x.DepartmentInfoId,
                        principalTable: "DepartmentInfos",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "EmployeeInfos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentId = table.Column<int>(type: "int", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Salary = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    UnionMember = table.Column<bool>(type: "bit", nullable: false),
                    BusinessId = table.Column<int>(type: "int", nullable: true),
                    PositionId = table.Column<int>(type: "int", nullable: true),
                    DepartmentInfoId = table.Column<int>(type: "int", nullable: true),
                    EmployeePositionId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeInfos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeeInfos_Businesses_BusinessId",
                        column: x => x.BusinessId,
                        principalTable: "Businesses",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_EmployeeInfos_DepartmentInfos_EmployeePositionId",
                        column: x => x.EmployeePositionId,
                        principalTable: "DepartmentInfos",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_EmployeeInfos_EmployeePositions_DepartmentInfoId",
                        column: x => x.DepartmentInfoId,
                        principalTable: "EmployeePositions",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_BusinessDepartmentInfo_DepartmentInfosId",
                table: "BusinessDepartmentInfo",
                column: "DepartmentInfosId");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessDepartments_DepartmentInfoId",
                table: "BusinessDepartments",
                column: "DepartmentInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeInfos_BusinessId",
                table: "EmployeeInfos",
                column: "BusinessId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeInfos_DepartmentInfoId",
                table: "EmployeeInfos",
                column: "DepartmentInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeInfos_EmployeePositionId",
                table: "EmployeeInfos",
                column: "EmployeePositionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BusinessDepartmentInfo");

            migrationBuilder.DropTable(
                name: "BusinessDepartments");

            migrationBuilder.DropTable(
                name: "EmployeeInfos");

            migrationBuilder.DropTable(
                name: "Businesses");

            migrationBuilder.DropTable(
                name: "DepartmentInfos");

            migrationBuilder.DropTable(
                name: "EmployeePositions");
        }
    }
}

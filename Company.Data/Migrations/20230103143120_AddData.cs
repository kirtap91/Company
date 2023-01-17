using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Company.Data.Migrations
{
    public partial class AddData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Businesses",
                columns: new[] { "Id", "BusinessLoc", "Businesses" },
                values: new object[,]
                {
                    { 1, "Sweden", "Microsoft" },
                    { 2, "Sweden", "Intel" }
                });

            migrationBuilder.InsertData(
                table: "DepartmentInfos",
                columns: new[] { "Id", "Department" },
                values: new object[,]
                {
                    { 1, "Sales" },
                    { 2, "Economy" },
                    { 3, "Support" },
                    { 4, "Development" }
                });

            migrationBuilder.InsertData(
                table: "EmployeePositions",
                columns: new[] { "Id", "EmployeeId", "EmployeePositions" },
                values: new object[,]
                {
                    { 1, 3, "CEO" },
                    { 2, 4, "SalesPerson" },
                    { 3, 6, "Developer" },
                    { 4, 7, "Accountant" }
                });

            migrationBuilder.InsertData(
                table: "BusinessDepartments",
                columns: new[] { "BusinessId", "DepartmentId", "DepartmentInfoId" },
                values: new object[,]
                {
                    { 1, 2, null },
                    { 1, 4, null },
                    { 2, 1, null },
                    { 2, 2, null },
                    { 2, 3, null }
                });

            migrationBuilder.InsertData(
                table: "EmployeeInfos",
                columns: new[] { "Id", "BusinessId", "DepartmentId", "DepartmentInfoId", "EmployeePositionId", "FirstName", "LastName", "PositionId", "Salary", "UnionMember" },
                values: new object[,]
                {
                    { 1, 1, 1, null, null, "Patrik", "Gustavsson", 3, 25362m, false },
                    { 2, 1, 3, null, null, "Per", "Persson", 3, 48252m, true },
                    { 3, 1, 3, null, null, "Gustav", "Gustavsson", 2, 25000m, true },
                    { 4, 1, 2, null, null, "Karl", "Karlsson", 2, 25000m, true },
                    { 5, 2, 4, null, null, "Jenny", "Johansson", 1, 45000m, false },
                    { 6, 2, 2, null, null, "Klara", "Silverstam", 4, 36000m, false }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BusinessDepartments",
                keyColumns: new[] { "BusinessId", "DepartmentId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "BusinessDepartments",
                keyColumns: new[] { "BusinessId", "DepartmentId" },
                keyValues: new object[] { 1, 4 });

            migrationBuilder.DeleteData(
                table: "BusinessDepartments",
                keyColumns: new[] { "BusinessId", "DepartmentId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "BusinessDepartments",
                keyColumns: new[] { "BusinessId", "DepartmentId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "BusinessDepartments",
                keyColumns: new[] { "BusinessId", "DepartmentId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "DepartmentInfos",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "DepartmentInfos",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "DepartmentInfos",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "DepartmentInfos",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "EmployeeInfos",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "EmployeeInfos",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "EmployeeInfos",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "EmployeeInfos",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "EmployeeInfos",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "EmployeeInfos",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "EmployeePositions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "EmployeePositions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "EmployeePositions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "EmployeePositions",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}

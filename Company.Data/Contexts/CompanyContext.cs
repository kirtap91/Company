using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Company.Data.Entities;


namespace Company.Data.Contexts
{
    public class CompanyContext : DbContext
    {
        public DbSet<Business> Businesses => Set<Business>();
        public DbSet<BusinessDepartment> BusinessDepartments => Set<BusinessDepartment>();
        public DbSet<DepartmentInfo> DepartmentInfos => Set<DepartmentInfo>();
        public DbSet<EmployeeInfo> EmployeeInfos => Set<EmployeeInfo>();
        public DbSet<EmployeePosition> EmployeePositions => Set<EmployeePosition>();
        public CompanyContext(DbContextOptions<CompanyContext> options) : base(options)
        {

        }



        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<BusinessDepartment>().HasKey(bd => new { bd.BusinessId, bd.DepartmentId });
            SeedData(builder);
        }
        private void SeedData(ModelBuilder builder)
        {
            var employeeinfos = new List<EmployeeInfo>
            {
                new EmployeeInfo
                {
                    Id = 1,
                    FirstName = "Patrik",
                    LastName = "Gustavsson",
                    Salary = 25362,
                    UnionMember = false,
                    BusinessId = 1,
                    PositionId = 3,
                    DepartmentId = 1,


                },
                new EmployeeInfo
                {
                    Id = 2,
                    FirstName = "Per",
                    LastName = "Persson",
                    Salary = 48252,
                    UnionMember = true,
                    BusinessId = 1,
                    PositionId = 3,
                    DepartmentId = 3,


                },
                new EmployeeInfo
                {
                    Id = 3,
                    FirstName = "Gustav",
                    LastName = "Gustavsson",
                    Salary = 25000,
                    UnionMember = true,
                    BusinessId = 1,
                    PositionId = 2,
                    DepartmentId = 3,


                },
                new EmployeeInfo
                {
                    Id = 4,
                    FirstName = "Karl",
                    LastName = "Karlsson",
                    Salary = 25000,
                    UnionMember = true,
                    BusinessId = 1,
                    PositionId = 2,
                    DepartmentId = 2,


                },
                new EmployeeInfo
                {
                    Id = 5,
                    FirstName = "Jenny",
                    LastName = "Johansson",
                    Salary = 45000,
                    UnionMember = false,
                    BusinessId = 2,
                    PositionId = 1,
                    DepartmentId = 4,


                },
                new EmployeeInfo
                {
                    Id = 6,
                    FirstName = "Klara",
                    LastName = "Silverstam",
                    Salary = 36000,
                    UnionMember = false,
                    BusinessId = 2,
                    PositionId = 4,
                    DepartmentId = 2,


                }
            };
            builder.Entity<EmployeeInfo>().HasData(employeeinfos);

            var businesses = new List<Business>
            {
                new Business
                {
                    Id = 1,
                    Businesses = "Microsoft",
                    BusinessLoc = "Sweden"


                },
                new Business
                {
                    Id = 2,
                    Businesses = "Intel",
                    BusinessLoc = "Sweden"


                }

            };
            builder.Entity<Business>().HasData(businesses);

            var employeeposition = new List<EmployeePosition>
                {
                    new EmployeePosition
                    {
                        Id=1,
                        EmployeePositions = "CEO",
                        EmployeeId = 3

                    },
                    new EmployeePosition
                    {
                        Id=2,
                        EmployeePositions = "SalesPerson",
                        EmployeeId = 4

                    },
                    new EmployeePosition
                    {
                        Id=3,
                        EmployeePositions = "Developer",
                        EmployeeId = 6

                    },
                    new EmployeePosition
                    {
                        Id=4,
                        EmployeePositions = "Accountant",
                        EmployeeId = 7

                    }




                };
            builder.Entity<EmployeePosition>().HasData(employeeposition);

            var departmentinfo = new List<DepartmentInfo>
            {
                new DepartmentInfo
                    {
                        Id=1,
                        Department = "Sales",

                    },
                new DepartmentInfo
                    {
                        Id=2,
                        Department = "Economy",
                    },
                new DepartmentInfo
                    {
                        Id=3,
                        Department = "Support",

                    },
                new DepartmentInfo
                    {
                        Id=4,
                        Department = "Development",

                    }

            };
            builder.Entity<DepartmentInfo>().HasData(departmentinfo);

            var businessdepartment = new List<BusinessDepartment>
            {
                new BusinessDepartment
                {
                    BusinessId=1,
                    DepartmentId=2,
                },
                new BusinessDepartment
                {
                    BusinessId=1,
                    DepartmentId=4,
                },
                new BusinessDepartment
                {
                    BusinessId=2,
                    DepartmentId=1,
                },
                new BusinessDepartment
                {
                    BusinessId=2,
                    DepartmentId=2,
                },
                new BusinessDepartment
                {
                    BusinessId=2,
                    DepartmentId=3,
                }
            };
            builder.Entity<BusinessDepartment>().HasData(businessdepartment);
        }
    }
}



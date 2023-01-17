using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Common.DTOs
{
    public class EmployeeInfoDTO
    {
        public int DepartmentId { get; set; }

        
        public string? FirstName { get; set; }
       
        public string? LastName { get; set; }

        
        public decimal Salary { get; set; }
        public bool UnionMember { get; set; }
        public int? BusinessId { get; set; }

        public int? PositionId { get; set; }

        public int Id { get; set; }
    }
}

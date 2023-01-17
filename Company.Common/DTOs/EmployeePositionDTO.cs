using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Common.DTOs
{
    public class EmployeePositionDTO
    {
        public int Id { get; set; }

       
        public string? EmployeePositions { get; set; }
        public int EmployeeId { get; set; }
    }
}

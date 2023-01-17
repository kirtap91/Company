using Company.Data.Interfaces;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Data.Entities
{
    public class EmployeeInfo : IEntity
    {
        public int DepartmentId { get; set; }

        [MaxLength(50), Required]
        public string? FirstName { get; set; }
        [MaxLength(50), Required]
        public string? LastName { get; set; }

        [Precision(18, 2)]
        public decimal Salary { get; set; }
        public bool UnionMember { get; set; }
        public int? BusinessId { get; set; }

        public int? PositionId { get; set; }

        public int Id { get; set; }

        //public EmployeePosition? DepartmentInfo { get; set; }
        //public Business? Business { get; set; }
        //public DepartmentInfo? EmployeePosition { get; set; }


    }
}

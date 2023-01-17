using Company.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.Data.Entities;

namespace Company.Data.Entities
{
    public class BusinessDepartment : IReferenceEntity
    {
        public int BusinessId { get; set; }
        public int DepartmentId { get; set; }

        public Business? Business { get; set; }
        public DepartmentInfo? DepartmentInfo { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.Data.Interfaces;

namespace Company.Data.Entities
{
    public class DepartmentInfo : IEntity
    {
        public int Id { get; set; }
        [MaxLength(50), Required]
        public string? Department { get; set; }

        public virtual ICollection<Business>? Businesses { get; set; }
    }
}

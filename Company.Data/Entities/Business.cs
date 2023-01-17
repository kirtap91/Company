using Company.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Data.Entities
{
    public class Business : IEntity
    {
        public int Id { get; set; }
        [MaxLength(50), Required]
        public string? Businesses { get; set; }
        [MaxLength(50), Required]
        public string? BusinessLoc { get; set; }

        public virtual ICollection<DepartmentInfo>? DepartmentInfos { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Common.DTOs
{
    public class BusinessDTO
    {
        public int Id { get; set; }
        
        public string? Businesses { get; set; }
        
        public string? BusinessLoc { get; set; }
    }
}

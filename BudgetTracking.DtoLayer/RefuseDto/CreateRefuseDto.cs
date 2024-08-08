using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetTracking.DtoLayer.RefuseDto
{
    public class CreateRefuseDto
    {
        public int RefuseID { get; set; }

      
        public string RefuseReason { get; set; }
    }
}

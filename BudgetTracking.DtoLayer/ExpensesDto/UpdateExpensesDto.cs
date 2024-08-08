using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetTracking.DtoLayer.ExpensesDto
{
    public class UpdateExpensesDto
    {
        public int ExpensesID { get; set; }
       
        public string ExpensesType { get; set; }
    }
}

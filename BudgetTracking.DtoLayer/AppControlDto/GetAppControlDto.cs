using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetTracking.DtoLayer.AppControlDto
{
    public class GetAppControlDto
    {
        public int ID { get; set; }

        public bool AppControls { get; set; }
    }
}

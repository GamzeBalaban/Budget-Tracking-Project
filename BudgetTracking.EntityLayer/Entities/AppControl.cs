﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetTracking.EntityLayer.Entities
{
    public class AppControl
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public bool AppControls { get; set; }

    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetTracking.DtoLayer.BudgetAmountDto
{
    public class UpdateBudgetAmountDto
    {
        public int BudgetAmountID { get; set; }

        public int Amount { get; set; }
    }
}

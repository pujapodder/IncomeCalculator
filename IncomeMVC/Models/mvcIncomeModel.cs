using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IncomeMVC.Models
{
    public class mvcIncomeModel
    {
        public int IncomeID { get; set; }
        public string IncomeDay { get; set; }
        public decimal IncomeAmount { get; set; }
        public Nullable<int> OrderNo { get; set; }
        public string MonthYear { get; set; }
    }
}
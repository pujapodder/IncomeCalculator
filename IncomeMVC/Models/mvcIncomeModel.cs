using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IncomeMVC.Models
{
    public class mvcIncomeModel
    {
        public int IncomeID { get; set; }
        [Required(ErrorMessage = "This Feild is required")]
        public string IncomeDay { get; set; }
        [Required(ErrorMessage = "This Feild is required")]
        public decimal IncomeAmount { get; set; }
      
        public Nullable<int> OrderNo { get; set; }
        public string MonthYear { get; set; }
    }
}
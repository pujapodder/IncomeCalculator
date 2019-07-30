﻿using IncomeMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace IncomeMVC.Controllers
{
    public class IncomesController : Controller
    {
        // GET: Incomes
        public ActionResult Index()
        {
            IEnumerable<mvcIncomeModel> IncomeList;
            HttpResponseMessage response = GlobalVariables.WebApiClient.GetAsync("Incomes").Result;
            IncomeList = response.Content.ReadAsAsync<IEnumerable<mvcIncomeModel>>().Result;
            return View(IncomeList);


         
        }
    }
}
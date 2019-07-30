using IncomeMVC.Models;
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
        public ActionResult AddOrEdit(int id = 0)
        {
            if (id == 0)
                return View(new mvcIncomeModel());
            else
            {
                HttpResponseMessage response = GlobalVariables.WebApiClient.GetAsync("Incomes/" + id.ToString()).Result;
                return View(response.Content.ReadAsAsync<mvcIncomeModel>().Result);
            }

        }
        [HttpPost]
        public ActionResult AddOrEdit(mvcIncomeModel inc)
        {
            if (inc.IncomeID == 0)
            {
                HttpResponseMessage response = GlobalVariables.WebApiClient.PostAsJsonAsync("Incomes", inc).Result;
                TempData["SuccessMessage"] = "Saved Successfully";
            }
            else
            {

                HttpResponseMessage response = GlobalVariables.WebApiClient.PutAsJsonAsync("Incomes/" + inc.IncomeID, inc).Result;
                TempData["SuccessMessage"] = "Updated Successfully";
            }
            return RedirectToAction("Index");

        }

        public ActionResult Delete(int id)
        {
            HttpResponseMessage response = GlobalVariables.WebApiClient.DeleteAsync("Incomes/" + id.ToString()).Result;
            TempData["SuccessMessage"] = "Deleteded Successfully";
            return RedirectToAction("Index");
        }
    }
}
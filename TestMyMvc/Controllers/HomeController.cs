using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using BusinessLogic.Logic;
using TestMyMvc.Model;

namespace TestMyMvc.Controllers
{
    
    public class HomeController : Controller
    {
        IFizzandBuzz _fizzandBuzz;
        IFizzLogic _fizzLogic;
        IBuzzLogic _buzzLogic;
        public HomeController(IFizzandBuzz fizzandBuzz)
        {
            _fizzandBuzz = fizzandBuzz;
        }

        public HomeController(IFizzLogic fizzLogic)
        {
            _fizzLogic = fizzLogic;
        }

        public HomeController(IBuzzLogic buzzLogic)
        {
            _buzzLogic = buzzLogic;
        }




        [HttpGet]
        public ActionResult Index()
        {
            return View(new GetFizzBuzz());
        }
        


        [HttpPost]
        public ActionResult Index(GetFizzBuzz model)
        {
            if (ModelState.IsValid)
            {
                //var fizzbuzz = new FizzBuzz();

                //model.FizzBuzznum = fizzbuzz.GetFizzBuzzNum(model.Position);
                
                List<String> num = new List<String>();
                for (var i =1; i<=model.Position; i++)
                {
                    string res= i.ToString(); 
                    if (_fizzLogic.GetFizz(i) == "Fizz") { res = "Fizz"; }
                    if(_buzzLogic.GetBuzz(i) == "Buzz" ) { res = "Buzz"; }
                    if (_fizzandBuzz.GetFizzandBuzz(i) == "FizzBuzz") { res = "FizzBuzz"; }
                    num.Add(res);
                }
                model.FizzBuzznum = num;
                return RedirectToAction("FizzBuzzView", new { value = model.Position });
            }
            else
            {
                return View(model);
            }
            
        }

        [HttpGet]
        public ActionResult FizzBuzzView(int value)
        {


            var model = new GetFizzBuzz
            {
                Position = value
            };


            return View(model);
        }

    }

}

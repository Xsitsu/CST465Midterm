using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Midterm.Models;
using Newtonsoft.Json;

namespace Midterm.Controllers
{
    public class MidtermController : Controller
    {
        private QuestionBank _bank;

        public QuestionBank GetList()
        {
            if (_bank == null)
            {
                string json = System.IO.File.ReadAllText(@"JSON/Midterm.json");
                _bank = new QuestionBank();
                _bank.Questions = JsonConvert.DeserializeObject<List<Question>>(json);
            }
            return _bank;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult TakeTest()
        {
            List<TestQuestion> questions = GetList().ToTestQuestions();
            return View("TakeTest", questions);
        }

        [HttpPost]
        public IActionResult TakeTest(List<TestQuestion> questions)
        {
            if (!ModelState.IsValid)
            {
                return View("TakeTest", questions);
            }
            return View("DisplayResults", questions);
        }
    }
}
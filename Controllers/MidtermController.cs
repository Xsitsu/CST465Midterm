﻿using System;
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
        private List<TestQuestion> GetList()
        {
            string json = System.IO.File.ReadAllText(@"JSON/Midterm.json");
            QuestionBank questions = new QuestionBank();
            questions.Questions = JsonConvert.DeserializeObject<List<Question>>(json);
            return questions.ToTestQuestions();
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult TakeTest()
        {
            List<TestQuestion> questions = GetList();
            return View("TakeTest", questions);
        }

        [HttpPost]
        public IActionResult TakeTest(List<TestQuestion> questions)
        {
            if (!ModelState.IsValid)
            {

            }
            return View();
        }
    }
}
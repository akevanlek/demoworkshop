using System;
using Microsoft.AspNetCore.Mvc;
namespace workshopep28 {
    public class GradeController : Controller {
        public GradeController () {

        }

        [HttpGet]
        public string GetGrade (string scoretxt) {
            if (Int32.TryParse (scoretxt, out int score)) {
                Calculator cal = new Calculator ();
                var grade = cal.GradeCalculator (score);
                return grade;
            } else {
                return "Score Error";

            }
        }

    }

}
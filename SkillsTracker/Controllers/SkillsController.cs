using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SkillsTracker.Controllers
{
    public class SkillsController : Controller // /Controller/Action
    {
        //GET: /skills
        public IActionResult Index()
        {
            string html = "<h1>Skills Tracker</h1>" +
                "<h2>Coding Skills to Learn</h2>" +
                "<ol>" +
                    "<li>C#</li>" +
                    "<li>Java</li>" +
                    "<li>Python</li>" +
                "</ol>";
            
            return Content(html, "text/html");
        }

        //GET: /skills/form
        [HttpGet("/skills/form")]
        public IActionResult SkillsForm()
        {
            string html = "<form method='post' action='/skills/form'>" +

                            "<label for='date'> Date" +
                                "<input type='date' name='date' />" +
                            "</label>" +

                            "<label for='csharp'> C#:" +
                                "<select name='csharp'>" + 
                                    "<option value='learning basics'>Learning Basics</option>" +
                                    "<option value='making apps'>Making Apps</option>" +
                                    "<option value='master coder'>Ninja on the keyboard</option>" +
                                "</select>" +
                            "</label>" +
                            "<label for='java'> Java:" +
                                "<select name='java'>" +
                                    "<option value='learning basics'>Learning Basics</option>" +
                                    "<option value='making apps'>Making Apps</option>" +
                                    "<option value='master coder'>Ninja on the keyboard</option>" +
                                "</select>" +
                            "</label>" +
                            "<label for='python'> Python:" +
                                "<select name='python'>" +
                                    "<option value='learning basics'>Learning Basics</option>" +
                                    "<option value='making apps'>Making Apps</option>" +
                                    "<option value='master coder'>Ninja on the keyboard</option>" +
                                "</select>" +
                            "</label>" +
                            "<input type='submit' value='Submit'/>" +
                           "</form>";

            return Content(html, "text/html");
        }

        //POST: /skills/form
        [HttpPost("skills/form")]
        public IActionResult SkillsResult(string date, string csharp, string java, string python)
        {
            string html = $"<h1>{date}</h1>" +
                            "<ol>" +
                                $"<li>C#: {csharp}</li>" +
                                $"<li>Java: {java}</li>" +
                                $"<li>Python: {python}</li>" +
                            "</ol>";

            return Content(html, "text/html");
        }
    }
}

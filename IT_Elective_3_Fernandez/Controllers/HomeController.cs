using IT_Elective_3_Fernandez.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace IT_Elective_3_Fernandez.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var questions = new[]
            {
                new {
                    Question = "1. What is the fundamental difference between Server-Side Rendering (SSR/MVC) and a Decoupled Web API architecture?",
                    Answer = "B. SSR compiles HTML views on the server and sends fully rendered markup to the browser, whereas a Web API acts as a stateless data provider returning raw JSON[1]."
                },
                new {
                    Question = "2. Why do Web API controllers in ASP.NET Core inherit from ControllerBase instead of Controller?",
                    Answer = "B. ControllerBase provides essential HTTP handling and routing without carrying unnecessary HTML view rendering overhead[1][2]."
                },
                new {
                    Question = "3. Which framework attribute automatically triggers an HTTP 400 Bad Request response when incoming request payloads fail structural model validation?",
                    Answer = "C. [ApiController][1][2]"
                },
                new {
                    Question = "4. Which HTTP status code should an API return after successfully creating a new resource via a POST request, along with a Location header pointing to the new URI?",
                    Answer = "B. 201 Created[1][3]"
                },
                new {
                    Question = "5. When a DELETE request successfully removes a resource from the server and returns no content in the response body, which HTTP status code is standard?",
                    Answer = "C. 204 No Content[3]"
                },
                new {
                    Question = "6. Which endpoint URI follows RESTful resource-oriented naming best practices?",
                    Answer = "B. GET /api/courses[3]"
                },
                new {
                    Question = "7. What is the primary function of the [Route(\"api/[controller]\")] attribute in ASP.NET Core?",
                    Answer = "B. It maps incoming URI request paths to the controller class using the class name token.[1][2]"
                },
                new {
                    Question = "8. Which HTTP verb is safe and idempotent, intended exclusively for retrieving resource data without altering server state?",
                    Answer = "C. GET[1][3]"
                },
                new {
                    Question = "9. In ASP.NET Core Web API, what wrapper type allows action methods to return either a strongly typed domain object or standard HTTP status result helpers (such as Ok(), NotFound())?",
                    Answer = "ActionResult<T>"
                }
            };

            return View(questions);
        }
    }
}
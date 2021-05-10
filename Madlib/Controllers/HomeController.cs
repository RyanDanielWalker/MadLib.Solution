using Madlib.Models;
using Microsoft.AspNetCore.Mvc;

namespace Madlib.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Form()
    {
      return View();
    }

    [Route("/madlib")]
    public ActionResult Madlib()
    {
      MadlibInputs myMadlibVariable = new MadlibInputs();
      myMadlibVariable.First = "verb";
      myMadlibVariable.Second = "adverb";
      myMadlibVariable.Third = "noun";
      myMadlibVariable.Fourth = "anotherVerb";
      myMadlibVariable.Five = "anotherNoun";
      myMadlibVariable.Sixth = "verb";
      myMadlibVariable.Seventh = "verb";
      return View(myMadlibVariable);

    }
  }
}

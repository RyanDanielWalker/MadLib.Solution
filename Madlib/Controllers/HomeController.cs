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
    public ActionResult Madlib(string firstWord, string secondWord, string thirdWord, string fourthWord, string fifthWord, string sixthWord, string seventhWord)
    {
      MadlibInputs myMadlibVariable = new MadlibInputs();
      myMadlibVariable.First = firstWord;
      myMadlibVariable.Second = secondWord;
      myMadlibVariable.Third = thirdWord;
      myMadlibVariable.Fourth = fourthWord;
      myMadlibVariable.Fifth = fifthWord;
      myMadlibVariable.Sixth = sixthWord;
      myMadlibVariable.Seventh = seventhWord;
      return View(myMadlibVariable);
    }

    // [Route("/this")]


  }
}

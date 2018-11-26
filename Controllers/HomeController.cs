using Microsoft.AspNetCore.Mvc;
using Anagram.Models;

namespace Anagram.Controllers
{
  public class HomeController : Controller
  {


    [Route("/input")]
    public ActionResult Input() { return View(); }
      
    [Route("/result")]
    public ActionResult Result(string word, string word2) { 
        
      Variable myVariable = new Variable();
      myVariable.SetWord(word);
      myVariable.SetWord2(word2);
      return View(myVariable);
      }

  }
}
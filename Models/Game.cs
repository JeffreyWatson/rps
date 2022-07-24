using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace rps.models
{
  public class Game
  {
    Random rnd = new Random();
    List<string> choices = new List<string>(){
      "r", "p", "s"
    };
    public string PlayRound(string choice)
    {
      string computerChoice = ComputerAction();

      if (choice == "r" && computerChoice == "s") { return "Win"; };
      if (choice == "r" && computerChoice == "p") { return "Lose"; };
      if (choice == "r" && computerChoice == "r") { return "Tie"; };
      if (choice == "s" && computerChoice == "p") { return "Win"; };
      if (choice == "s" && computerChoice == "r") { return "Lose"; };
      if (choice == "s" && computerChoice == "s") { return "Tie"; };
      if (choice == "p" && computerChoice == "r") { return "Win"; };
      if (choice == "p" && computerChoice == "s") { return "Lose"; };
      if (choice == "p" && computerChoice == "p") { return "Tie"; };
      return "Something went wrong";
    }

    private string ComputerAction()
    {
      int num = rnd.Next(0, 2);
      return choices[num];
    }
  }
}
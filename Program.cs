// See https://aka.ms/new-console-template for more information
using System;
using System.Threading;
using rps.models;


bool playing = true;
Game rps = new Game();
int computerScore = 0;
int playerScore = 0;
string rpsLogo = @" ________  ________  ________  ___  __            ________  ________  ________  _______   ________          ________  ________  ___  ________   ________  ________  ________  ________      
|\   __  \|\   __  \|\   ____\|\  \|\  \         |\   __  \|\   __  \|\   __  \|\  ___ \ |\   __  \        |\   ____\|\   ____\|\  \|\   ____\ |\   ____\|\   __  \|\   __  \|\   ____\     
\ \  \|\  \ \  \|\  \ \  \___|\ \  \/  /|_       \ \  \|\  \ \  \|\  \ \  \|\  \ \   __/|\ \  \|\  \       \ \  \___|\ \  \___|\ \  \ \  \___|_\ \  \___|\ \  \|\  \ \  \|\  \ \  \___|_    
 \ \   _  _\ \  \\\  \ \  \    \ \   ___  \       \ \   ____\ \   __  \ \   ____\ \  \_|/_\ \   _  _\       \ \_____  \ \  \    \ \  \ \_____  \\ \_____  \ \  \\\  \ \   _  _\ \_____  \   
  \ \  \\  \\ \  \\\  \ \  \____\ \  \\ \  \       \ \  \___|\ \  \ \  \ \  \___|\ \  \_|\ \ \  \\  \|       \|____|\  \ \  \____\ \  \|____|\  \\|____|\  \ \  \\\  \ \  \\  \\|____|\  \  
   \ \__\\ _\\ \_______\ \_______\ \__\\ \__\       \ \__\    \ \__\ \__\ \__\    \ \_______\ \__\\ _\         ____\_\  \ \_______\ \__\____\_\  \ ____\_\  \ \_______\ \__\\ _\ ____\_\  \ 
    \|__|\|__|\|_______|\|_______|\|__| \|__|        \|__|     \|__|\|__|\|__|     \|_______|\|__|\|__|       |\_________\|_______|\|__|\_________\\_________\|_______|\|__|\|__|\_________\
                                                                                                              \|_________|             \|_________\|_________|                  \|_________|";
string quitGame = ("Press 'q' to quit");
string gameControls = "r for rock, p for paper, or s for scissors";


while (playing)
{
  Console.Clear();
  Console.WriteLine(rpsLogo);
  Console.WriteLine(quitGame);
  for (int i = 0; i < gameControls.Length; i++)
  {
    Console.Write(gameControls[i]);
    Thread.Sleep(50);
  }

  Console.WriteLine("");
  Console.WriteLine($"Player Score: {playerScore} & Computer Score: {computerScore}");
  string keepPlaying = Console.ReadLine();
  if (keepPlaying == "q")
  {
    Console.WriteLine("Thanks for Playing");
    playing = false;
  }
  if (keepPlaying == "r" || keepPlaying == "p" || keepPlaying == "s")
  {
    string result = rps.PlayRound(keepPlaying);
    Console.WriteLine(result);

    if (result == "Win")
    {
      playerScore++;
      newSong();
    }

    else if (result == "Lose")
    {
      computerScore++;
    }
    Thread.Sleep(1000);
  }
}

void newSong()
{
  Console.Beep(1397, 350);
  Console.Beep(1397, 350);
  Console.Beep(1319, 350);
  Console.Beep(523, 350);
  Console.Beep(1397, 350);
  Console.Beep(1397, 350);
  Console.Beep(1319, 350);
  Console.Beep(523, 350);
  Console.Beep(1175, 350);
  Console.Beep(1175, 350);
  Console.Beep(1319, 350);
  Console.Beep(1319, 350);
  Console.Beep(1397, 700);
}

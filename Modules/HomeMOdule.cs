using Nancy;
using System.Collections.Generic;
using RPS.Objects;

namespace RPS
{
	public class HomeModule : NancyModule
	{
		public HomeModule()
		{
			Get["/"] = _ =>
			{
				return View["index.cshtml"];
			};
			Post["Rock-Paper-Scissors/player1-choice"] = _ =>
			{
				string player1Name = Request.Form["player1Name"];
				string player2Name = Request.Form["player2Name"];
				RockPaperScissors newGame = new RockPaperScissors(player1Name, player2Name);
				return View["player1Input.cshtml", newGame];
			};
			Post["Rock-Paper-Scissors/player2-choice"] = _ =>
			{
				int player1Choice = int.Parse(Request.Form["choice"]);
				RockPaperScissors newGame = RockPaperScissors.GetGame();
				newGame.SetPlayer1Choice(player1Choice);
				return View["player2Input.cshtml", newGame];
			};
			Post["Rock-Paper-Scissors/result"] = _=>
			{
				int player2Choice = int.Parse(Request.Form["choice"]);
				RockPaperScissors newGame = RockPaperScissors.GetGame();
				newGame.SetPlayer2Choice(player2Choice);
				return View["result.cshtml", newGame];
			};
		}
	}
}

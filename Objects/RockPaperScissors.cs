using System.Collections.Generic;

namespace RPS.Objects
{
	public class RockPaperScissors
	{

		//Choice codes: 1 = Rock, 2 = Paper, 3 = Scissors
		private string _player1Name;
		private string _player2Name;
		private int _player1Choice;
		private int _player2Choice;
		private static Dictionary<int, RockPaperScissors> _games = new Dictionary<int, RockPaperScissors>();

		public static RockPaperScissors GetGame()
		{
			return _games[0];
		}

		public RockPaperScissors(string name1, string name2)
		{
			_player1Name = name1;
			_player2Name = name2;
			_games[0] = this;
		}

		public void SetPlayer1Choice(int choice)
		{
			_player1Choice = choice;
		}

		public void SetPlayer2Choice(int choice)
		{
			_player2Choice = choice;
		}

		public string GetPlayer1Name()
		{
			return _player1Name;
		}

		public string GetPlayer2Name()
		{
			return _player2Name;
		}

		public int GetPlayer1Choice()
		{
			return _player1Choice;
		}

		public int GetPlayer2Choice()
		{
			return _player2Choice;
		}

		public string GetWinner()
		{
			if (_player1Choice == _player2Choice)
			{
				return "Draw";
			}
			else if (_player1Choice - _player2Choice == 1)
			{
				return _player1Name + " Wins!";
			}
			else if (_player2Choice - _player1Choice == 2)
			{
				return _player1Name + " Wins!";
			}
			else
			{
				return _player2Name + " Wins!";
			}
		}
	}
}

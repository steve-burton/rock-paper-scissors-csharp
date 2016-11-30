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

		public RockPaperScissors(string name1, string name2)
		{
			_player1Name = name1;
			_player2Name = name2;
		}

		public void SetPlayer1Choice(int choice)
		{
			_player1Choice = choice;
		}

		public void SetPlayer2Choice(int choice)
		{
			_player2Choice = choice;
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

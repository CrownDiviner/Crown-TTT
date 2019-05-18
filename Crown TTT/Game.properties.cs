using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crown_TTT
{
    public partial class Game
    {
        public string Player1Icon { get { return Player1; } set {  Player1 = value; } }
        public string Player2Icon { get { return Player2; } set { Player2 = value; } }
        public string PlayerIcon { get { return Turn; } set { Turn = value; }  } 
        public string BoardPosition1 { get { return this.GameBoard[0]; } set { this.GameBoard[0] = value; } }
        public string BoardPosition2 { get { return this.GameBoard[1]; } set { this.GameBoard[1] = value; } }
        public string BoardPosition3 { get { return this.GameBoard[2]; } set { this.GameBoard[2] = value; } }
        public string BoardPosition4 { get { return this.GameBoard[3]; } set { this.GameBoard[3] = value; } }
        public string BoardPosition5 { get { return this.GameBoard[4]; } set { this.GameBoard[4] = value; } }
        public string BoardPosition6 { get { return this.GameBoard[5]; } set { this.GameBoard[5] = value; } }
        public string BoardPosition7 { get { return this.GameBoard[6]; } set { this.GameBoard[6] = value; } }
        public string BoardPosition8 { get { return this.GameBoard[7]; } set { this.GameBoard[7] = value; } }
        public string BoardPosition9 { get { return this.GameBoard[8]; } set { this.GameBoard[8] = value; } }

        public void InitializeGameComponent(String NewTurn)
        {
            Turn = NewTurn;
            PlayersTurn();
            Player1 = "X";
            Player2 = "O";
            GameBoard[0] = "";
            GameBoard[1] = "";
            GameBoard[2] = "";
            GameBoard[3] = "";
            GameBoard[4] = "";
            GameBoard[5] = "";
            GameBoard[6] = "";
            GameBoard[7] = "";
            GameBoard[8] = "";
        }

        private String[] GameBoard = new String[9];
        private string Turn;
        private string Player1;
        private string Player2;
    }
}

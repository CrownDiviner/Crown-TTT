using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Crown_TTT.Properties;
using System.Windows.Forms;
using System.IO;

namespace Crown_TTT 
{
        // Tic Tac Toe Game Verson 1.0
    public partial class Game
    {
        public Game(string CurrentTurn)
        {
            InitializeGameComponent(CurrentTurn);
        }

        public string PlayersTurn()
        {

            if (Turn == Player1)
            {
                return "Player 1";
            }
            else
            {
                return "Player 2";
            }
        }

        public Boolean CheckWin()
        { 
            //Column
            if (BoardPosition7 != "" && BoardPosition7 == BoardPosition8 && BoardPosition8 == BoardPosition9 || BoardPosition4 != "" && BoardPosition4 == BoardPosition5 && BoardPosition5 == BoardPosition6 || BoardPosition1 != "" && BoardPosition1 == BoardPosition2 && BoardPosition2 == BoardPosition3)
            {
                MessageBox.Show("Player " + Turn + " Wins");
                return true;
            }
            //Row
            else if (BoardPosition7 != "" && BoardPosition7 == BoardPosition4 && BoardPosition4 == BoardPosition1 || BoardPosition8 != "" && BoardPosition8 == BoardPosition5 && BoardPosition5 == BoardPosition2 || BoardPosition9 != "" && BoardPosition9 == BoardPosition6 && BoardPosition6 == BoardPosition3)
            {
                MessageBox.Show("Player " + Turn + " Wins");
                return true;
            }
            //Diagonal
            else if (BoardPosition7 != "" && BoardPosition7 == BoardPosition5 && BoardPosition5 == BoardPosition3 || BoardPosition9 != "" && BoardPosition9 == BoardPosition5 && BoardPosition5 == BoardPosition1)
            {
                MessageBox.Show("Player " + Turn + " Wins");
                return true;
            }
            else
            {
                return false;
            }
        }

        public void TakeTurn(int LabelName)
        {
            int BoardUpdaterSwitch = LabelName;
            if (CheckWin() != true)
            {
            switch (BoardUpdaterSwitch)
            {
                    case 1:
                        if (BoardPosition1 != "") { throw new System.ArgumentException("Pick New Spot"); }
                        BoardPosition1 = PlayerIcon; ;
                        break;
                    case 2:
                        if (BoardPosition2 != "") { throw new System.ArgumentException("Pick New Spot"); }
                        BoardPosition2 = PlayerIcon;
                        break;
                    case 3:
                        if (BoardPosition3 != "") { throw new System.ArgumentException("Pick New Spot"); }
                        BoardPosition3 = PlayerIcon;
                        break;
                    case 4:
                        if (BoardPosition4 != "") { throw new System.ArgumentException("Pick New Spot"); }
                        BoardPosition4 = PlayerIcon;
                        break;
                    case 5:
                        if (BoardPosition5 != "") { throw new System.ArgumentException("Pick New Spot"); }
                        BoardPosition5 = PlayerIcon;
                        break;
                    case 6:
                        if (BoardPosition6 != "") { throw new System.ArgumentException("Pick New Spot"); }
                        BoardPosition6 = PlayerIcon;
                        break;
                    case 7:
                        if (BoardPosition7 != "") { throw new System.ArgumentException("Pick New Spot"); }
                        BoardPosition7 = PlayerIcon;
                        break;
                    case 8:
                        if (BoardPosition8 != "") { throw new System.ArgumentException("Pick New Spot"); }
                        BoardPosition8 = PlayerIcon;
                        break;
                    case 9:
                        if (BoardPosition9 != "") { throw new System.ArgumentException("Pick New Spot"); }
                        BoardPosition9 = PlayerIcon;
                        break;
                    default:
                        throw new System.ArgumentException("Error 404: Turn not found"); 
                }
            }
        }
        public void ChangeTurn()
        {
            if (Turn == Player1)
            {
                Turn = Player2;
            }
            else
            {
                Turn = Player1;
            }
        }
    }
}

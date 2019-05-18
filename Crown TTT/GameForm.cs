using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crown_TTT
{
    public partial class GameForm : Form
    {
        // Game Creator
        Game TicTacoToe = new Game("");

        // Form
        public GameForm()
        {
            InitializeComponent();
            UpdateLabels();
        }

        // Game Intergation
        private void StartTakingTurn(int LabelName)
        {
            try
            {
                TicTacoToe.TakeTurn(LabelName);
                UpdateLabels();

                if (TicTacoToe.CheckWin() != true)
                {
                    TicTacoToe.ChangeTurn();
                }
                else
                {
                    TicTacoToe = new Game("X");
                    UpdateLabels();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void CheckLabels(int LabelName)
        {
            //for exception
        }
        private void UpdateLabels()
        {
            label1.Text = TicTacoToe.BoardPosition1;
            label2.Text = TicTacoToe.BoardPosition2;
            label3.Text = TicTacoToe.BoardPosition3;
            label4.Text = TicTacoToe.BoardPosition4;
            label5.Text = TicTacoToe.BoardPosition5;
            label6.Text = TicTacoToe.BoardPosition6;
            label7.Text = TicTacoToe.BoardPosition7;
            label8.Text = TicTacoToe.BoardPosition8;
            label9.Text = TicTacoToe.BoardPosition9;
            label10.Text = TicTacoToe.PlayersTurn();
        }
        
        // Label Click Events
        private void label1_Click_1(object sender, EventArgs e)
        {
            StartTakingTurn(1);
        }
        private void label2_Click(object sender, EventArgs e)
        {
            StartTakingTurn(2);
        }
        private void label3_Click(object sender, EventArgs e)
        {
            StartTakingTurn(3);
        }
        private void label4_Click(object sender, EventArgs e)
        {
            StartTakingTurn(4);
        }
        private void label5_Click(object sender, EventArgs e)
        {
            StartTakingTurn(5);
        }
        private void label6_Click(object sender, EventArgs e)
        {
            StartTakingTurn(6);
        }
        private void label7_Click(object sender, EventArgs e)
        {
            StartTakingTurn(7);
        }
        private void label8_Click(object sender, EventArgs e)
        {
            StartTakingTurn(8);
        }
        private void label9_Click(object sender, EventArgs e)
        {
            StartTakingTurn(9);
        }

        // Menu
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TicTacoToe = new Game("X");
            UpdateLabels();
        }
        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void firstPlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TicTacoToe = new Game(TicTacoToe.Player1Icon);
        }
        private void firstPlayerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TicTacoToe = new Game(TicTacoToe.Player2Icon);
        }
        private void charactorToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
        private void charactorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Application.Run(new GameInputDialog());
            // while  (GameInputDialog == true)
            // {
            // }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KrydsOgBolleOneScreenAI
{
    public partial class KNOSAIView : Form
    {
        //012
        //345
        //678
        string[] board = new string[9];
        string currentPlayer;
        int numbersOfX;
        int numbersOfO;
        Boolean gameOver;
        Bitmap Xpic = new Bitmap(Application.StartupPath + @"\Pics\kryds.jpg");
        Bitmap Opic = new Bitmap(Application.StartupPath + @"\Pics\bolle.jpg");

        public KNOSAIView()
        {
            InitializeComponent();
            NewGame();
        }
        private void NewGame()
        {
            currentPlayer = "X";
            numbersOfX = 0;
            numbersOfO = 0;
            gameOver = false;
            ClearBoard();

        }
        private void ClearBoard()
        {
            for (int i = 0; i < 9; i++)
            {
                board[i] = null;
            }
            pictureBox1.Image = null;
            pictureBox2.Image = null;
            pictureBox3.Image = null;
            pictureBox4.Image = null;
            pictureBox5.Image = null;
            pictureBox6.Image = null;
            pictureBox7.Image = null;
            pictureBox8.Image = null;
            pictureBox9.Image = null;
        }
        private void ChangeCurrentPlayer()
        {
            if (gameOver == false)
            {
                if (currentPlayer == "X")
                {
                    currentPlayer = "O";
                    textBoxPlayer.Text = "Spiller O har tur";
                    AIMove();
                }
                else
                {
                    currentPlayer = "X";
                    textBoxPlayer.Text = "Spiller X har tur";
                }
            }
        }
        private string MakeAMove(int place)
        {
            if (gameOver == false)
            {
                if (currentPlayer == "X")
                {
                    if (board[place] == null)
                    {
                        numbersOfX++;
                        board[place] = "X";
                        TestForWin();
                        ChangeCurrentPlayer();
                        return "X";
                    }                    
                    return "ERROR";
                }                
            }
            return "ERROR";
        }
        private void TestForWin()
        {
            Boolean b = LongTest();
            if (b == true)
            {
                gameOver = b;
                textBoxPlayer.Text = "Spiller " + currentPlayer + " har vundet";
            }
        }
        private Boolean LongTest()
        {
            if (board[0] == currentPlayer && board[1] == currentPlayer  && board[2] == currentPlayer)
            {
                return true;
            }
            else if (board[3] == currentPlayer && board[4] == currentPlayer && board[5] == currentPlayer)
            {
                return true;
            }
            else if (board[6] == currentPlayer && board[7] == currentPlayer && board[8] == currentPlayer)
            {
                return true;
            }
            else if (board[0] == currentPlayer && board[4] == currentPlayer && board[8] == currentPlayer)
            {
                return true;
            }
            else if (board[2] == currentPlayer && board[4] == currentPlayer && board[6] == currentPlayer)
            {
                return true;
            }
            else if (board[0] == currentPlayer && board[3] == currentPlayer && board[6] == currentPlayer)
            {
                return true;
            }
            else if (board[1] == currentPlayer && board[4] == currentPlayer && board[7] == currentPlayer)
            {
                return true;
            }
            else if (board[2] == currentPlayer && board[5] == currentPlayer && board[8] == currentPlayer)
            {
                return true;
            }
            else
            {
                return false;
            }
           
        }
        private void AIMove()
        {
            ChangeCurrentPlayer();
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void pictureBox2_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void pictureBox3_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void pictureBox4_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void pictureBox5_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void pictureBox6_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void pictureBox7_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void pictureBox8_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void pictureBox9_MouseClick(object sender, MouseEventArgs e)
        {

        }
    }
}

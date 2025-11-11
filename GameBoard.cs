using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TicTacToe
{
    public partial class GameBoard : Form
    {
        public string type { get; set; }
        public List<Button> buttons = new List<Button>();
        public Random rand = new Random();
        public int maxMoves = 0;

        public GameBoard(string _type)
        {
            InitializeComponent();
            type = _type;
            buttons.Add(button1);
            buttons.Add(button2);
            buttons.Add(button3);
            buttons.Add(button4);
            buttons.Add(button5);
            buttons.Add(button6);
            buttons.Add(button7);
            buttons.Add(button8);
            buttons.Add(button9);
        }

        public static bool playerMove = true, compMove = false;
        public static int playerScore, compScore = 0;
        public static string playerSymbol = "X", compSymbol = "O";

        void changeGameBackGround()
        {
            if (type != null)
            {
                switch (type)
                {
                    case "easy":
                        this.BackgroundImage = Image.FromFile(Path.Combine(Application.StartupPath, "images", "easyBack.jfif"));
                        break;
                    case "medium":
                        this.BackgroundImage = Image.FromFile(Path.Combine(Application.StartupPath, "images", "mediumBack.jpg"));
                        break;
                    case "hard":
                        this.BackgroundImage = Image.FromFile(Path.Combine(Application.StartupPath, "images", "hardBack.jpg"));
                        break;
                    case "impossible":
                        this.BackgroundImage = Image.FromFile(Path.Combine(Application.StartupPath, "images", "impossibleBack.jpg"));
                        break;
                }
            }
            else
            {
                MessageBox.Show("Player doesn't selected type of enemy !");
            }
        }

        void resetBoard()
        {
            for (int i = 0; i < buttons.Count; i++)
            {
                buttons[i].Text = "";
                buttons[i].BackColor = Color.White;
            }
            MessageBox.Show("BOARD IS SUCCESFULLY RESTARTED !");
            playerMove = true;
        }

        private void GameBoard_Load(object sender, EventArgs e)
        {
            changeGameBackGround();
        }

        private void resetBoardBTN_Click(object sender, EventArgs e)
        {
            resetBoard();
            startBoard();
        }

        private void exitBTN_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cya next time !");
            this.Close();
        }

        void startBoard()
        {
            for (int i = 0; i < buttons.Count; i++)
                buttons[i].Enabled = true;
        }

        void stopBoard()
        {
            for (int i = 0; i < buttons.Count; i++)
                buttons[i].Enabled = false;
        }

        bool checkWinner()
        {
            string[,] winCombos = new string[,]
            {
                { button1.Text, button2.Text, button3.Text },
                { button4.Text, button5.Text, button6.Text },
                { button7.Text, button8.Text, button9.Text },
                { button1.Text, button4.Text, button7.Text },
                { button2.Text, button5.Text, button8.Text },
                { button3.Text, button6.Text, button9.Text },
                { button1.Text, button5.Text, button9.Text },
                { button3.Text, button5.Text, button7.Text }
            };

            for (int i = 0; i < winCombos.GetLength(0); i++)
            {
                if (winCombos[i, 0] == playerSymbol &&
                    winCombos[i, 1] == playerSymbol &&
                    winCombos[i, 2] == playerSymbol)
                {
                    MessageBox.Show("Player has won!");
                    playerScore++;
                    playerLBL.Text = $"Player wins: {playerScore}";
                    stopBoard();
                    return true;
                }

                if (winCombos[i, 0] == compSymbol &&
                    winCombos[i, 1] == compSymbol &&
                    winCombos[i, 2] == compSymbol)
                {
                    MessageBox.Show("Computer has won!");
                    compScore++;
                    compLBL.Text = $"Computer wins: {compScore}";
                    stopBoard();
                    return true;
                }
            }

            if (buttons.All(b => b.Text != ""))
            {
                MessageBox.Show("It's a draw!");
                stopBoard();
                return true;
            }

            return false;
        }

        
        Button FindWinningMove(string symbol)
        {
            foreach (var combo in new List<Button[]> {
                new[] { button1, button2, button3 },
                new[] { button4, button5, button6 },
                new[] { button7, button8, button9 },
                new[] { button1, button4, button7 },
                new[] { button2, button5, button8 },
                new[] { button3, button6, button9 },
                new[] { button1, button5, button9 },
                new[] { button3, button5, button7 }
            })
            {
                var empty = combo.Where(b => b.Text == "").ToList();
                var same = combo.Count(b => b.Text == symbol);
                if (empty.Count == 1 && same == 2)
                    return empty[0];
            }
            return null;
        }

        void BotMove()
        {
            
            Button move = FindWinningMove(compSymbol);
            if (move == null)
                move = FindWinningMove(playerSymbol); 
            if (move == null)
            {
               
                int index;
                do
                {
                    index = rand.Next(0, 9);
                } while (buttons[index].Text != "");
                move = buttons[index];
            }

            move.Text = compSymbol;
            move.BackColor = Color.Blue;
            playerMove = true;
            compMove = false;
            maxMoves++;

            checkWinner();
        }

        void easyBot(Button btn)
        {
            if (!playerMove && !compMove) return;

            if (playerMove && btn.Text == "")
            {
                btn.Text = playerSymbol;
                btn.BackColor = Color.Red;
                playerMove = false;
                compMove = true;
                maxMoves++;
                if (checkWinner()) { playerMove = compMove = false; return; }
            }

            if (compMove)
            {
                int index;
                do { index = rand.Next(0, 9); } while (buttons[index].Text != "");
                buttons[index].Text = compSymbol;
                buttons[index].BackColor = Color.Blue;
                playerMove = true;
                compMove = false;
                checkWinner();
            }
        }

        void mediumBot(Button btn)
        {
            if (!playerMove && !compMove) return;

            if (playerMove && btn.Text == "")
            {
                btn.Text = playerSymbol;
                btn.BackColor = Color.Red;
                playerMove = false;
                compMove = true;
                maxMoves++;
                if (checkWinner()) { playerMove = compMove = false; return; }
            }

            if (compMove)
            {
                BotMove(); 
            }
        }

        void hardBot(Button btn)
        {
            if (!playerMove && !compMove)
                return;

            
            if (playerMove && btn.Text == "")
            {
                btn.Text = playerSymbol;
                btn.BackColor = Color.Red;
                playerMove = false;
                compMove = true;
                maxMoves++;

                if (checkWinner())
                {
                    playerMove = false;
                    compMove = false;
                    return;
                }
            }

            
            if (compMove)
            {
                Button move = FindWinningMove(compSymbol); 
                if (move == null)
                    move = FindWinningMove(playerSymbol); 

                if (move == null)
                {
                    
                    if (button5.Text == "")
                        move = button5;
                    else
                    {
                        
                        var corners = new List<Button> { button1, button3, button7, button9 };
                        move = corners.FirstOrDefault(b => b.Text == "");

                        
                        if (move == null)
                        {
                            var sides = new List<Button> { button2, button4, button6, button8 };
                            move = sides.FirstOrDefault(b => b.Text == "");
                        }
                    }
                }

                
                if (move != null)
                {
                    move.Text = compSymbol;
                    move.BackColor = Color.Blue;
                    playerMove = true;
                    compMove = false;
                    maxMoves++;

                    if (checkWinner())
                    {
                        playerMove = false;
                        compMove = false;
                        return;
                    }
                }
            }
        }

        void impossibleBot(Button btn)
        {
            if (!playerMove && !compMove)
                return;

            
            if (playerMove && btn.Text == "")
            {
                btn.Text = playerSymbol;
                btn.BackColor = Color.Red;
                playerMove = false;
                compMove = true;
                maxMoves++;

                if (checkWinner())
                {
                    playerMove = false;
                    compMove = false;
                    return;
                }
            }

            
            if (compMove)
            {
                for (int i = 0; i < 2; i++)
                {
                    Button move = FindWinningMove(compSymbol); 
                    if (move == null)
                        move = FindWinningMove(playerSymbol); 

                    if (move == null)
                    {
                        if (button5.Text == "")
                            move = button5;
                        else
                        {
                            var corners = new List<Button> { button1, button3, button7, button9 };
                            move = corners.FirstOrDefault(b => b.Text == "");
                            if (move == null)
                            {
                                var sides = new List<Button> { button2, button4, button6, button8 };
                                move = sides.FirstOrDefault(b => b.Text == "");
                            }
                        }
                    }

                    if (move != null)
                    {
                        move.Text = compSymbol;
                        move.BackColor = Color.Blue;
                        playerMove = true;
                        compMove = false;
                        maxMoves++;

                        if (checkWinner())
                        {
                            playerMove = false;
                            compMove = false;
                            return;
                        }
                    }
                }
            }
        }


        private void BoardBTN(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            switch (type)
            {
                case "easy":
                    easyBot(btn);
                    break;
                case "medium":
                    mediumBot(btn);
                    break;
                case "hard":
                    hardBot(btn);
                    break;
                case "impossible":
                    impossibleBot(btn);
                    break;
            }
        }
    }
}

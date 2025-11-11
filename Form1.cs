using Accessibility;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            showEnemyPIC.Visible = false;
            acceptBTN.Visible = false;
            declineBTN.Visible = false;
            showEnemyPIC.BackgroundImageLayout = ImageLayout.Stretch;
            showEnemyPIC.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        public static string typeEnemy = "";
        public static bool easyClicked, mediumClicked, hardClicked, impossibleClicked = false;


        private void Form1_Load(object sender, EventArgs e)
        {

        }




        private void easyEnemyBTN_Click(object sender, EventArgs e)
        {
            showEnemyPIC.Visible = true;
            showEnemyPIC.Image = Image.FromFile(Path.Combine(Application.StartupPath, "images", "easy.jpg"));
            acceptBTN.Visible = true;
            declineBTN.Visible = true;
            typeEnemy = "easy";
            easyClicked = true;
            mediumClicked = false;
            hardClicked = false;
            impossibleClicked = false;
            showBotStatsLBL.Text = "Friendly bot strength : 💪";
        }

        private void mediunEnemyBTN_Click(object sender, EventArgs e)
        {
            showEnemyPIC.Visible = true;
            showEnemyPIC.Image = Image.FromFile(Path.Combine(Application.StartupPath, "images", "medium.png"));
            acceptBTN.Visible = true;
            declineBTN.Visible = true;
            typeEnemy = "medium";
            showBotStatsLBL.Text = "Thinker bot strength : 💪💪";
        }

        private void hardEnemyBTN_Click(object sender, EventArgs e)
        {
            showEnemyPIC.Visible = true;
            showEnemyPIC.Image = Image.FromFile(Path.Combine(Application.StartupPath, "images", "hard.jpg"));
            acceptBTN.Visible = true;
            declineBTN.Visible = true;
            typeEnemy = "hard";
            showBotStatsLBL.Text = "Analyze bot strength : 💪💪💪";
        }

        private void impossibleEnemyBTN_Click(object sender, EventArgs e)
        {
            showEnemyPIC.Visible = true;
            showEnemyPIC.Image = Image.FromFile(Path.Combine(Application.StartupPath, "images", "impossible.png"));
            acceptBTN.Visible = true;
            declineBTN.Visible = true;
            typeEnemy = "impossible";
            showBotStatsLBL.Text = "Cheater bot strength : 💪💪💪💪";
        }

        private void acceptBTN_Click(object sender, EventArgs e)
        {
            if (typeEnemy != "")
            {
                GameBoard game = new GameBoard(typeEnemy);
                game.ShowDialog();
            }
            else
            {
                MessageBox.Show("Game can't start i can't find enemy type TRY AGAIN !");
            }
            

        }
    }
}

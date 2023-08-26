namespace TicTacToe
{
    public partial class Board : Form
    {
        private char type
        {
            get; set;
        }

        private char cpuType
        {
            get; set;
        }

        private int move
        {
            get; set;
        }

        private int playerScore
        {
            get; set;
        }

        private int cpuScore
        {
            get; set;
        }

        private bool gameRunning
        {
            get; set;
        }

        private Tile[] tiles
        {
            get; set;
        }

        private int lastPosition
        {
            get; set;
        }

        private readonly Image xImg;
        private readonly Image oImg;

        public Board()
        {
            InitializeComponent();
            tiles = new Tile[] { tlTile, tTile, trTile,
                                 lTile,  cTile, rTile,
                                 blTile, bTile, brTile };
            playerScore = 0;
            cpuScore = 0;
            move = 0;
            updateScore();
            xImg = Image.FromFile("assets/x.png");
            oImg = Image.FromFile("assets/o.png");
        }

        private void Board_Load(object sender, EventArgs e)
        {

        }

        private bool checkColumns(char type)
        {
            for (int i = 0; i < 3; i++)
                if (tiles[i].type.Equals(type) && tiles[i+3].type.Equals(type) && tiles[i+6].type.Equals(type))
                    return true;
            return false;
        }

        private bool checkRows(char type)
        {
            for (int i = 0; i < 7; i+=3)
                if (tiles[i].type.Equals(type) && tiles[i+1].type.Equals(type) && tiles[i+2].type.Equals(type))
                    return true;
            return false;
        }

        private bool checkDiags(char type)
        {
            if (tiles[0].type.Equals(type) && tiles[4].type.Equals(type) && tiles[8].type.Equals(type))
                return true;
            if (tiles[2].type.Equals(type) && tiles[4].type.Equals(type) && tiles[6].type.Equals(type))
                return true;
            return false;
        }

        private bool game()
        {
            if (checkColumns('x') || checkRows('x') || checkDiags('x'))
            {
                appointScore('x');
                return true;
            }
            if (checkColumns('o') || checkRows('o') || checkDiags('o'))
            {
                appointScore('o');
                return true;
            }
            if (move == 9)
            {
                clearBoard();
                return true;
            }
            return false;
        }

        private void appointScore(char winType)
        {
            switch(winType)
            {
                case char when winType.Equals(type):
                    playerScore++;
                    break;
                case char when winType.Equals(cpuType):
                    cpuScore++;
                    break;
            }
            clearBoard();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void updateScore()
        {
            scoreLabel.Text = "P: " + playerScore + " | C: " + cpuScore;
        }

        private void oPlayer_CheckedChanged(object sender, EventArgs e)
        {
            if (gameRunning && !type.Equals('o'))
            {
                titleLabel.Text = "You must finish the game or reset to change type.";
                oPlayer.Checked = false;
                xPlayer.Checked = true;
                return;
            }
            type = 'o';
            cpuType = 'x';
            if (!gameRunning)
                titleLabel.Text = "Click a spot to start!";
        }

        private void xPlayer_CheckedChanged(object sender, EventArgs e)
        {
            if (gameRunning && !type.Equals('x'))
            {
                titleLabel.Text = "You must finish the game or reset to change type.";
                xPlayer.Checked = false;
                oPlayer.Checked = true;
                return;
            }
            type = 'x';
            cpuType = 'o';
            if (!gameRunning)
                titleLabel.Text = "Click a spot to start!";
        }

        private void assignProp(int pos)
        {
            switch (tiles[pos].type)
            {
                case 'o':
                    tiles[pos].BackgroundImage = oImg;
                    tiles[pos].type = 'o';
                    break;
                case 'x':
                    tiles[pos].BackgroundImage = xImg;
                    tiles[pos].type = 'x';
                    break;
            }
            move++;
        }

        private async void clearBoard()
        {
            gameRunning = false;
            move = 0;
            lastPosition = -1;
            await Task.Delay(1000);
            foreach (Tile tile in tiles)
            {
                tile.BackgroundImage = null;
                tile.type = '0';
            }
            updateScore();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            playerScore = 0;
            cpuScore = 0;
            clearBoard();
        }

        private void TileClick(int pos)
        {
            if (!xPlayer.Checked && !oPlayer.Checked)
                return;
            gameRunning = true;
            titleLabel.Text = "";
            if (tiles[pos].type != '0') return;
            tiles[pos].type = type;
            assignProp(pos);
            if (game()) return;
            cpuResponse();
            game();
        }

        private void cpuResponse()
        {
            int[] badPos = new int[3] { -1, 0, 8 };
            Random rng = new();
            int pos;
            if (lastPosition == -1)
            {
                do
                {
                    pos = rng.Next(1, 9);
                    if (!tiles[pos].type.Equals(type) && !tiles[pos].type.Equals(cpuType))
                    {
                        tiles[pos].type = cpuType;
                        assignProp(pos);
                        lastPosition = pos;
                        return;
                    }
                } while (true);
            }
            if (!badPos.Contains(lastPosition))
            {
                if (!tiles[lastPosition - 1].type.Equals(type) && !tiles[lastPosition - 1].type.Equals(cpuType))
                {
                    tiles[lastPosition - 1].type = cpuType;
                    assignProp(lastPosition - 1);
                    lastPosition--;
                    return;
                }
                else if (!tiles[lastPosition + 1].type.Equals(type) && !tiles[lastPosition + 1].type.Equals(cpuType))
                {
                    tiles[lastPosition + 1].type = cpuType;
                    assignProp(lastPosition + 1);
                    lastPosition++;
                    return;
                }
            }
            if (lastPosition < 6)
            {
                if (!tiles[lastPosition + 3].type.Equals(type) && !tiles[lastPosition + 3].type.Equals(cpuType))
                {
                    tiles[lastPosition + 3].type = cpuType;
                    assignProp(lastPosition + 3);
                    lastPosition += 3;
                    return;
                }
            }
            if (lastPosition > 2)
            {
                if (!tiles[lastPosition - 3].type.Equals(type) && !tiles[lastPosition - 3].type.Equals(cpuType))
                {
                    tiles[lastPosition - 3].type = cpuType;
                    assignProp(lastPosition - 3);
                    lastPosition -= 3;
                    return;
                }
            }
            for (int i = 0; i < 9; i++)
            {
                if (!tiles[i].type.Equals(type) && !tiles[i].type.Equals(cpuType))
                {
                    tiles[i].type = cpuType;
                    assignProp(i);
                    lastPosition = i;
                    break;
                }
            }
        }

        private void tlTile_Click(object sender, EventArgs e)
        {
            TileClick(0);
        }

        private void tTile_Click(object sender, EventArgs e)
        {
            TileClick(1);
        }

        private void trTile_Click(object sender, EventArgs e)
        {
            TileClick(2);
        }

        private void lTile_Click(object sender, EventArgs e)
        {
            TileClick(3);
        }

        private void cTile_Click(object sender, EventArgs e)
        {
            TileClick(4);
        }

        private void rTile_Click(object sender, EventArgs e)
        {
            TileClick(5);
        }

        private void blTile_Click(object sender, EventArgs e)
        {
            TileClick(6);
        }

        private void bTile_Click(object sender, EventArgs e)
        {
            TileClick(7);
        }

        private void brTile_Click(object sender, EventArgs e)
        {
            TileClick(8);
        }
    }
}
namespace TicTacToe
{
    public partial class Board : Form
    {
        private int type
        {
            get; set;
        }

        private bool gameRunning
        {
            get; set;
        }

        private int[] boardTypes
        {
            get; set;
        }

        private Button[] tiles
        {
            get; set;
        }

        // 0 1 2
        // 3 4 5
        // 6 7 8

        private readonly Image xImg;
        private readonly Image oImg;

        public Board()
        {
            InitializeComponent();
            boardTypes = new int[9];
            tiles = new Button[] { boardTopLeft, boardTop, boardTopRight,
                                   boardLeft, boardCenter, boardRight,
                                   boardBottomLeft, boardBottom, boardBottomRight };
            foreach (Button tile in tiles)
            {
                tile.BackgroundImageLayout = ImageLayout.Stretch;
            }
            xImg = Image.FromFile("assets/x.png");
            oImg = Image.FromFile("assets/o.png");
        }

        private void Board_Load(object sender, EventArgs e)
        {

        }

        private void beginGame(int type) // 0 = circle, 1 = cross
        {
            gameRunning = true;
        }

        private void button_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void oPlayer_CheckedChanged(object sender, EventArgs e)
        {
            if (gameRunning && type != 0)
            {
                titleLabel.Text = "You must finish the game or reset to change type.";
                oPlayer.Checked = false;
                xPlayer.Checked = true;
                return;
            }
            type = 0;
            if (!gameRunning)
                titleLabel.Text = "Click a spot to start!";
        }

        private void xPlayer_CheckedChanged(object sender, EventArgs e)
        {
            if (gameRunning && type != 1)
            {
                titleLabel.Text = "You must finish the game or reset to change type.";
                xPlayer.Checked = false;
                oPlayer.Checked = true;
                return;
            }
            type = 1;
            if (!gameRunning)
                titleLabel.Text = "Click a spot to start!";
        }

        private void assignProp(int tile)
        {
            switch (type)
            {
                case 0:
                    tiles[tile].BackgroundImage = oImg;
                    break;
                case 1:
                    tiles[tile].BackgroundImage = xImg;
                    break;
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            foreach (Button tile in tiles)
            {
                tile.BackgroundImage = null;
            }
            gameRunning = false;
        }

        private void tileClick(int pos)
        {
            titleLabel.Text = "";
            if (!gameRunning)
                beginGame(type);
            boardTypes[pos] = type;
            assignProp(pos);
        }

        private void boardTopLeft_Click(object sender, EventArgs e)
        {
            tileClick(0);
        }

        private void boardTop_Click(object sender, EventArgs e)
        {
            tileClick(1);
        }

        private void boardTopRight_Click(object sender, EventArgs e)
        {
            tileClick(2);
        }

        private void boardLeft_Click(object sender, EventArgs e)
        {
            tileClick(3);
        }

        private void boardCenter_Click(object sender, EventArgs e)
        {
            tileClick(4);
        }

        private void boardRight_Click(object sender, EventArgs e)
        {
            tileClick(5);
        }

        private void boardBottomLeft_Click(object sender, EventArgs e)
        {
            tileClick(6);
        }

        private void boardBottom_Click(object sender, EventArgs e)
        {
            tileClick(7);
        }

        private void boardBottomRight_Click(object sender, EventArgs e)
        {
            tileClick(8);
        }
    }
}
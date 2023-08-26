namespace TicTacToe
{
    public class Tile : Button
    {
        private char _type;

        public char type
        {
            get { return _type; }
            set { _type = value; }
        }
    }
}
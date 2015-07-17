namespace Minesweeper
{
    public class Score
    {
        private string playerName;
        private int playerPoints;

        public Score(string name, int playerPoints)
        {
            this.playerName = name;
            this.playerPoints = playerPoints;
        }

        public string PlayerName
        {
            get { return this.playerName; }
            set { this.playerName = value; }
        }

        public int PlayerPoints
        {
            get { return this.playerPoints; }
            set { this.playerPoints = value; }
        }
    }
}



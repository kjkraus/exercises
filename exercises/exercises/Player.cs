namespace exercises
{
    internal class Player
    {
        private string name;
        private int score;
        private int livesLeft;

        public Player(string name)
        {
            this.name = name;
        }

        public Player(string name, int startingLives)
        {
            this.name = name;
            livesLeft = startingLives;
        }

        public string GetName()
        {
            return name;
        }

        public int GetScore()
        {
            return score;
        }

        public void AddPoints(int totalPoints)
        {
            score += totalPoints;
        }

        public void Kill()
        {
            // no negative lives
            if (livesLeft > 0)
            {
                livesLeft--;
            }
        }

        public int GetLives()
        {
            return livesLeft;
        }

        public int Score
        {
            get
            {
                return score;
            }
            set
            {
                score = value;
                if (score <= 0)
                {
                    score = 0;
                }
            }
        }
    }
}
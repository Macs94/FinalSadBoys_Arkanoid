namespace SadArkanoid.Modelo
{
    public class Score
    {
        public int idScore { get; set; }
        public int score { get; set; }
        public string username { get; set; }

        public Score()
        {
        }

        public Score(int score, string username)
        {
            this.score = score;
            this.username = username;
        }

        public Score(int idScore, int score, string username)
        {
            this.idScore = idScore;
            this.score = score;
            this.username = username;
        }
    }
}
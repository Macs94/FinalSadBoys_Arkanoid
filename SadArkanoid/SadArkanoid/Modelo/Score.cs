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
    }
}
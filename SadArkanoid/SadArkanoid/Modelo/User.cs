namespace SadArkanoid.Modelo
{
    public class User
    {
        public string username { get; set; }
        public int score { get; set; }

        public User()
        {
            username = "";
            score = 0;
        }
    }
}
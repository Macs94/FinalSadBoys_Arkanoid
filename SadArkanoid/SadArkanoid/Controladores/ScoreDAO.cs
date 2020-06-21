using System;
using System.Collections.Generic;
using System.Data;
using SadArkanoid.Modelo;

namespace SadArkanoid.Controladores
{
    public static class ScoreDAO
    {
        public static void AddScore(Score s)
        {
            string countScoresSql = String.Format("SELECT COUNT(*) FROM score WHERE username='{0}';",
                s.username);
            int countScores = ConnectionDB.ExecuteInttQuery(countScoresSql);
            
            string addScoreSql = String.Format(
                "insert into \"score\"" + 
                "(\"score\", \"username\")" +
                "values ('{0}', '{1}');",
                s.score, s.username);

            if (countScores < 10)
                ConnectionDB.ExecuteNonQuery(addScoreSql);
            else
            {
                string lowestScoreSql = String.Format("SELECT MIN (score) FROM score WHERE username='{0}';",
                    s.username);
                int lowestScore = ConnectionDB.ExecuteInttQuery(lowestScoreSql);
                
                if (s.score > lowestScore)
                {
                    string deleteLowestScore = String.Format(
                        "DELETE FROM score WHERE score = (SELECT MIN (score) FROM score WHERE username='{0}');",
                        s.username);
                    ConnectionDB.ExecuteNonQuery(deleteLowestScore);

                    ConnectionDB.ExecuteNonQuery(addScoreSql);
                }
            }
        }
        
        public static List<Score> GetTop10()
        {
            string sql = "SELECT * FROM score ORDER BY score DESC LIMIT 10;";

            DataTable dt = ConnectionDB.ExecuteQuery(sql);

            List<Score> list = new List<Score>();
            foreach (DataRow fila in dt.Rows)
            {
                Score s = new Score();
                s.idScore = Convert.ToInt32(fila[0].ToString());
                s.score = Convert.ToInt32(fila[1].ToString());
                s.username = fila[2].ToString();

                list.Add(s);
            }
            return list;
        }
    }
}
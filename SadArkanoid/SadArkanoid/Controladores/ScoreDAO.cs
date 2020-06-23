using System;
using System.Collections.Generic;
using System.Data;
using SadArkanoid.Modelo;

namespace SadArkanoid.Controladores
{
    public static class ScoreDAO
    {
        /*
        * Método: void AddScore(Score s)
        *
        * Función: agregar un puntaje a la base de datos
        *
        * Descripción: Si el usuario tiene menos de 10 puntajes guardados en la
        * base de datos, agregar puntaje 's' en la base. Si el usuario
        * tiene mas de 10 puntajes en la base y 's' es mayor que el puntaje más
        * bajo en la base, borrar dicho puntaje y agregar 's'.  
        */
        public static void AddScore(Score s)
        {
            //buscar número de puntajes almacenados para un usuario 
            string countScoresSql = String.Format("SELECT COUNT(*) FROM score WHERE username='{0}';",
                s.username);
            int countScores = ConnectionDB.ExecuteInttQuery(countScoresSql);
            
            //declaración sql para agregar puntaje a la base
            string addScoreSql = String.Format(
                "insert into \"score\"" + 
                "(\"score\", \"username\")" +
                "values ('{0}', '{1}');",
                s.score, s.username);
            
            if (countScores < 10)
                ConnectionDB.ExecuteNonQuery(addScoreSql);
            else
            {
                //buscar puntaje más bajo para un usuario
                string lowestScoreSql = String.Format("SELECT MIN (score) FROM score WHERE username='{0}';",
                    s.username);
                int lowestScore = ConnectionDB.ExecuteInttQuery(lowestScoreSql);
                
                if (s.score > lowestScore)
                {
                    //borrar puntaje más bajo para un usuario
                    string deleteLowestScore = String.Format(
                        "DELETE FROM score WHERE score = (SELECT MIN (score) FROM score WHERE username='{0}');",
                        s.username);
                    ConnectionDB.ExecuteNonQuery(deleteLowestScore);
                    
                    ConnectionDB.ExecuteNonQuery(addScoreSql);
                }
            }
        }
        
        /*
        * Método: List<Score> GetTop10()
        *
        * Función: buscar el top 10 en la base de datos
        *
        * Descripción: Este método regresa una lista de puntajes con los
        * diez puntajes más altos encontrados en la base de datos. 
        */
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
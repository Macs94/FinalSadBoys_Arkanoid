using System;
using System.Collections.Generic;
using System.Data;
using SadArkanoid.Modelo;

namespace SadArkanoid.Controladores
{
    public static class UserDAO
    {
        public static List<User> getUsers()
        {
            DataTable dt = ConnectionDB.ExecuteQuery("SELECT * FROM PUBLIC.USER");
            List<User> lista = new List<User>();

            foreach (DataRow col in dt.Rows)
            {
                var u = new User();
                u.username = col[0].ToString();
                u.score = Convert.ToInt32(col[1].ToString());
                lista.Add(u);
            } 
            return lista;
        }
        
        public static void newUser(string uname)
        {
            string sql = String.Format(
                "INSERT INTO PUBLIC.USER(username) " +
                "VALUES('{0}');",
                uname);

            ConnectionDB.ExecuteNonQuery(sql);
        }
        
        public static void updateScore(string uname, int scr)
        {
            string sql = String.Format(
                "UPDATE PUBLIC.USER set score= {0} where username='{1}';",
                scr, uname);
            
            ConnectionDB.ExecuteNonQuery(sql);
        }

        public static string checkUserName(string username)
        {
            string val = "";
            string sql = String.Format(
                "SELECT username FROM PUBLIC.USER WHERE username = '{0}';",
                username);

            val = ConnectionDB.ExecuteCheckUser(sql);
            return val;
        }
    }
}

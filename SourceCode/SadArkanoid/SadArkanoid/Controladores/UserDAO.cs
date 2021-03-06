﻿using System;

namespace SadArkanoid.Controladores
{
    public static class UserDAO
    {
        public static void NewUser(string uname)
        {
            string sql = String.Format(
                "INSERT INTO PUBLIC.USER(username) " +
                "VALUES('{0}');",
                uname);

            ConnectionDB.ExecuteNonQuery(sql);
        }

        /*
        * Método: bool CheckUserNameExists(string username)
        *
        * Función: verificar la existencia de un jugador
        *
        * Descripción: Este método regresa true si el jugador 'username'
        * existe en la base de datos, y regresa false si no existe. 
        */
        public static bool CheckUserNameExists(string username)
        {
            string sql = String.Format(
                "SELECT CASE WHEN EXISTS (SELECT * FROM public.user WHERE username = '{0}') THEN CAST(1 AS BIT) ELSE CAST(0 AS BIT) END;",
                username);
            return ConnectionDB.ExecuteCheckQuery(sql);
        }
    }
}

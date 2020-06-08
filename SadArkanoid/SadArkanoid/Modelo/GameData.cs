﻿using System.Drawing.Text;

namespace SadArkanoid.Modelo
{
    public static class GameData
    {
        public static bool fullScreen { get; set; }
        public static bool gameStart { get; set; }
        public static bool gameOver { get; set; }
        public static bool victory { get; set; }

        public static void softReset()
        {
            gameStart = false;
            gameOver = false;
            victory = false;
        }
    }
}
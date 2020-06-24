using System;

namespace SadArkanoid.Controladores
{
    public class NoScoreSavedException : Exception
    {
        public NoScoreSavedException(string message):base(message){}
    }
}
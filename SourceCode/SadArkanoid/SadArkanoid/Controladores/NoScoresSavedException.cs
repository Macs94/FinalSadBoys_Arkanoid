using System;

namespace SadArkanoid.Controladores
{
    public class NoScoresSavedException : Exception
    {
        public NoScoresSavedException(string message): base(message){}
    }
}
using System;

namespace SadArkanoid.Controladores
{
    public class MissingFontException : Exception
    {
        public MissingFontException(string message): base(message){}
    }
}
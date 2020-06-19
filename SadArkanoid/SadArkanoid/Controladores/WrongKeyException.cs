using System;

namespace SadArkanoid.Controladores
{
    public class WrongKeyException: Exception
    {
        public WrongKeyException(string message): base(message){}
    }
}
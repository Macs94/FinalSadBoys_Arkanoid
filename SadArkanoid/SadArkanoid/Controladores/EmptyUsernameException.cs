using System;

namespace SadArkanoid.Controladores
{
    public class EmptyUsernameException : Exception
    {
        public EmptyUsernameException(string message): base(message){}
    }
}
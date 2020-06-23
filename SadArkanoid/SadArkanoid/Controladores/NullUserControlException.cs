using System;

namespace SadArkanoid.Controladores
{
    public class NullUserControlException : Exception
    {
        public NullUserControlException(string message): base(message){}
    }
}
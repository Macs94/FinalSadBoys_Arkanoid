using System;

namespace SadArkanoid.Controladores
{
    public class LengthExceededException: Exception
    {
        public LengthExceededException(string message): base(message){}
    }
}
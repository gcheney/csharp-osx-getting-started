namespace Exceptions
{
    public class MyInvalidTokenException : System.ArgumentException
    {
        public MyInvalidTokenException(string msg): base(msg)
        {
        }
    }
}


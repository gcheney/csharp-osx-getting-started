namespace Exceptions
{
    public class MyMissingTokenException : System.ArgumentException
    {
        public MyMissingTokenException(string msg): base(msg)
        {
        }
    }
}


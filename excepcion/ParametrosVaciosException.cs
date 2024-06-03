namespace excepcion
{

    public class ParametrosVaciosException : Exception
    {
        public ParametrosVaciosException(string message) : base(message) { }

        public ParametrosVaciosException(string message, Exception inner) : base(message, inner) { }
    }

}

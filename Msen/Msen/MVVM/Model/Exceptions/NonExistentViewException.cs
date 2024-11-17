namespace Msen.MVVM.Model.Exceptions
{
    class NonExistentViewException : Exception
    {
        public NonExistentViewException() : base("This view does not exist.") { }
        public NonExistentViewException(string message) : base(message) { }
    }
}

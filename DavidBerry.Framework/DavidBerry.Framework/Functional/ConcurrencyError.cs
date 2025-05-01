namespace DavidBerry.Framework.Functional
{
    public class ConcurrencyError<T> : Error
    {

        public T ConflictingObject { get; private set; }


        public ConcurrencyError(string message, T conflictingObject) : base(message)
        {
            ConflictingObject = conflictingObject;
        }

    }
}
